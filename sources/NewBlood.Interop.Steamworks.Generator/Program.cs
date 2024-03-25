using System.CommandLine;
using System.CommandLine.Invocation;
using System.Text;
using System.Text.Json;
using AsmResolver.PE;

namespace NewBlood.Interop.Steamworks.Generator;

internal static class Program
{
    private static readonly RootCommand s_RootCommand;

    private static readonly Command s_GenerateAccessorsCommand = new("generate-accessors", "Generate interface accessors");

    private static readonly Command s_GeneratePackingCommand = new("generate-packing-rsp", "Generate .rsp file containing --with-packing values for callbacks");

    private static readonly Command s_GenerateLibraryPathsCommand = new("generate-librarypath-rsp", "Generate .rsp file containing --with-librarypath values for exports");

    private static readonly Command s_GenerateCallbackImpls = new("generate-callback-impls", "Generate ISteamCallback implementations for each callback type");

    private static readonly Command s_GenerateInterfaceTypes = new("generate-interface-types", "Generate interop structures for interface types");

    private static readonly Command s_GenerateMembersCommand = new("generate-members-rsp", "Generate .rsp file containing --with-attribute values for generating interface members");

    private static readonly Command s_GenerateObsoleteRsp = new("generate-obsolete-rsp", "Generate .rsp marking deprecated functions with [Obsolete]");

    private static readonly Option<string> s_SdkPathOption = new("--sdk-path", "Steamworks SDK path") { IsRequired = true };

    private static readonly Option<string> s_OutPathOption = new("--out-path", "Output file or directory path") { IsRequired = true };

    static Program()
    {
        s_RootCommand = new RootCommand("Steamworks Binding Generation Assistant");
        Handler.SetHandler(s_GenerateAccessorsCommand, GenerateAccessors);
        Handler.SetHandler(s_GeneratePackingCommand, GeneratePacking);
        Handler.SetHandler(s_GenerateLibraryPathsCommand, GenerateLibraryPaths);
        Handler.SetHandler(s_GenerateCallbackImpls, GenerateCallbackImpls);
        Handler.SetHandler(s_GenerateInterfaceTypes, GenerateInterfaceTypes);
        Handler.SetHandler(s_GenerateMembersCommand, GenerateMembersResponseFile);
        Handler.SetHandler(s_GenerateObsoleteRsp, GenerateObsoleteRsp);
        s_RootCommand.AddCommand(s_GenerateAccessorsCommand);
        s_RootCommand.AddCommand(s_GeneratePackingCommand);
        s_RootCommand.AddCommand(s_GenerateLibraryPathsCommand);
        s_RootCommand.AddCommand(s_GenerateCallbackImpls);
        s_RootCommand.AddCommand(s_GenerateInterfaceTypes);
        s_RootCommand.AddCommand(s_GenerateMembersCommand);
        s_RootCommand.AddCommand(s_GenerateObsoleteRsp);
        s_RootCommand.AddGlobalOption(s_SdkPathOption);
        s_RootCommand.AddGlobalOption(s_OutPathOption);
    }

    private static Task Main(string[] args)
    {
        return s_RootCommand.InvokeAsync(args);
    }

    private static void GenerateObsoleteRsp(InvocationContext context)
    {
        var sdkPath = context.ParseResult.GetValueForOption(s_SdkPathOption)!;
        var outPath = context.ParseResult.GetValueForOption(s_OutPathOption)!;
        var api     = GetSteamAPI(sdkPath);

        if (Path.GetDirectoryName(outPath) is { } parentPath)
            Directory.CreateDirectory(parentPath);

        var remappings = new Dictionary<string, string>();
        using var sw   = new StreamWriter(outPath, append: false, new UTF8Encoding(false))
        {
            NewLine = "\n"
        };

        foreach (var @interface in api.Interfaces)
        {
            foreach (var method in @interface.Methods)
            {
                if (method.FlatName.EndsWith("_DEPRECATED", StringComparison.OrdinalIgnoreCase))
                {
                    remappings[method.FlatName] = method.FlatName[..^"_DEPRECATED".Length];
                }
            }
        }

        foreach (var @struct in api.Structs)
        {
            if (@struct.Methods is null)
                continue;

            foreach (var method in @struct.Methods)
            {
                if (method.FlatName.EndsWith("_DEPRECATED", StringComparison.OrdinalIgnoreCase))
                {
                    remappings[method.FlatName] = method.FlatName[..^"_DEPRECATED".Length];
                }
            }
        }

        foreach (var @enum in api.Enums)
        {
            foreach (var entry in @enum.Values)
            {
                if (entry.Name.EndsWith("_DEPRECATED", StringComparison.OrdinalIgnoreCase))
                {
                    remappings[$"{@enum.FullName ?? @enum.Name}::{entry.Name}"] = entry.Name[..^"_DEPRECATED".Length];
                }
            }
        }

        sw.Write("--remap");

        foreach (var remap in remappings.OrderBy(remap => remap.Key))
        {
            sw.WriteLine();
            sw.Write($"{remap.Key}={remap.Value}");
        }

        sw.WriteLine();
        sw.Write("--with-attribute");

        foreach (var remap in remappings.OrderBy(remap => remap.Key))
        {
            sw.WriteLine();
            sw.Write($"{remap.Key}=Obsolete");
        }
    }

    private static void GenerateMembersResponseFile(InvocationContext context)
    {
        var sdkPath = context.ParseResult.GetValueForOption(s_SdkPathOption)!;
        var outPath = context.ParseResult.GetValueForOption(s_OutPathOption)!;
        var api     = GetSteamAPI(sdkPath);

        if (Path.GetDirectoryName(outPath) is { } parentPath)
            Directory.CreateDirectory(parentPath);

        var members  = new Dictionary<string, string>();
        using var sw = new StreamWriter(outPath, append: false, new UTF8Encoding(false))
        {
            NewLine = "\n"
        };

        foreach (var @interface in api.Interfaces)
        {
            foreach (var method in @interface.Methods)
            {
                members[method.FlatName] = method.Name;
            }
        }

        foreach (var @struct in api.Structs)
        {
            if (@struct.Methods is null)
                continue;

            foreach (var method in @struct.Methods)
            {
                members[method.FlatName] = method.Name;
            }
        }

        sw.Write("--with-attribute");

        foreach (var pair in members.OrderBy(member => member.Key))
        {
            var name = pair.Value switch
            {
                "operator<"  => "IsLessThan",
                "operator==" => "IsEqualTo",
                "operator="  => "Assign",
                _            => pair.Value
            };

            // Remove _DEPRECATED from method name
            if (name.EndsWith("_DEPRECATED"))
                name = name[..^"_DEPRECATED".Length];

            sw.WriteLine();
            sw.Write($"{pair.Key}=GenerateMemberFunction(\"{name}\")");
        }
    }

    private static void GenerateInterfaceTypes(InvocationContext context)
    {
        var sdkPath = context.ParseResult.GetValueForOption(s_SdkPathOption)!;
        var outPath = context.ParseResult.GetValueForOption(s_OutPathOption)!;
        var api     = GetSteamAPI(sdkPath);
        Directory.CreateDirectory(outPath);
        
        foreach (var @interface in api.Interfaces)
        {
            var path     = Path.Combine(outPath, $"{@interface.Name}.cs");
            using var sw = new StreamWriter(path, append: false, new UTF8Encoding(false))
            {
                NewLine = "\n"
            };

            sw.WriteLine(
                $$"""
                namespace NewBlood.Interop.Steamworks;

                public unsafe ref partial struct {{@interface.Name}}
                {
                }
                """
            );
        }
    }

    private static void GenerateCallbackImpls(InvocationContext context)
    {
        var sdkPath = context.ParseResult.GetValueForOption(s_SdkPathOption)!;
        var outPath = context.ParseResult.GetValueForOption(s_OutPathOption)!;
        var api     = GetSteamAPI(sdkPath);

        if (Path.GetDirectoryName(outPath) is { } parentPath)
            Directory.CreateDirectory(parentPath);

        using var sw = new StreamWriter(outPath, false, new UTF8Encoding(false))
        {
            NewLine = "\n"
        };

        var count = 0;
        sw.WriteLine("namespace NewBlood.Interop.Steamworks;");
        sw.WriteLine();

        foreach (var callback in api.CallbackStructs.OrderBy(callback => callback.Name))
        {
            if (count > 0)
                sw.WriteLine();

            sw.WriteLine(
                $$"""
                public partial struct {{callback.Name}} : ISteamCallback
                {
                #if NET6_0_OR_GREATER
                    static
                #endif
                    int ISteamCallback.CallbackId => k_iCallback;
                }
                """
            );

            count++;
        }
    }

    private static void GenerateLibraryPaths(InvocationContext context)
    {
        var sdkPath = context.ParseResult.GetValueForOption(s_SdkPathOption)!;
        var outPath = context.ParseResult.GetValueForOption(s_OutPathOption)!;

        // Libraries to scan for exports. Only scans the 64-bit Windows DLLs.
        var libraryPaths = new Dictionary<string, string>
        {
            { Path.Combine(sdkPath, "bin", "win64", "steamdatagram_gamecoordinator.dll"), "steamdatagram_gamecoordinator" },
            { Path.Combine(sdkPath, "public", "steam", "lib", "win64", "sdkencryptedappticket64.dll"), "sdkencryptedappticket" },
            { Path.Combine(sdkPath, "redistributable_bin", "win64", "steam_api64.dll"), "steam_api" },
        };

        if (Path.GetDirectoryName(outPath) is {} parentPath)
            Directory.CreateDirectory(parentPath);

        using var sw = new StreamWriter(outPath, append: false, new UTF8Encoding(false))
        {
            NewLine = "\n"
        };

        sw.Write("--with-librarypath");
        var entries = new Dictionary<string, string>();

        foreach (var pair in libraryPaths)
        {
            var dllPath = pair.Key;
            var dllName = pair.Value;

            if (!File.Exists(dllPath))
                continue;

            var image = PEImage.FromFile(dllPath);

            if (image.Exports is null)
                continue;
            
            foreach (var export in image.Exports.Entries)
            {
                if (!export.IsByName)
                    continue;

                entries[export.Name] = dllName;
            }
        }

        foreach (var entry in entries.OrderBy(entry => entry.Key))
        {
            var key = entry.Key;

            if (key.EndsWith("_DEPRECATED"))
                key = key[..^"_DEPRECATED".Length];

            sw.WriteLine();
            sw.Write($"{key}={entry.Value}");
        }
    }

    private static void GeneratePacking(InvocationContext context)
    {
        var sdkPath = context.ParseResult.GetValueForOption(s_SdkPathOption)!;
        var outPath = context.ParseResult.GetValueForOption(s_OutPathOption)!;
        var api     = GetSteamAPI(sdkPath);

        if (Path.GetDirectoryName(outPath) is {} parentPath)
            Directory.CreateDirectory(parentPath);

        using var sw = new StreamWriter(outPath, append: false, new UTF8Encoding(false))
        {
            NewLine = "\n"
        };

        sw.Write("--with-packing");

        foreach (var callback in api.CallbackStructs.OrderBy(callback => callback.Name))
        {
            sw.WriteLine();
            sw.Write($"{callback.Name}=PrivateInteropDetails.SteamCallbackPacking");
        }
    }

    private static void GenerateAccessors(InvocationContext context)
    {
        var sdkPath = context.ParseResult.GetValueForOption(s_SdkPathOption)!;
        var outPath = context.ParseResult.GetValueForOption(s_OutPathOption)!;
        var api     = GetSteamAPI(sdkPath);

        if (Path.GetDirectoryName(outPath) is {} parentPath)
            Directory.CreateDirectory(parentPath);

        using var sw = new StreamWriter(outPath, append: false, new UTF8Encoding(false))
        {
            NewLine = "\n"
        };

        sw.WriteLine("namespace NewBlood.Interop.Steamworks;");
        sw.WriteLine();
        sw.WriteLine("public static unsafe partial class Steamworks");
        sw.WriteLine("{");

        // Generate unversioned accessor methods for Steamworks interfaces.
        //
        // These could be generated with ClangSharp because they're defined as
        // inline methods in the headers, but currently generation of bindings
        // for methods with bodies is disabled to avoid issues elsewhere.
        //
        int count = 0;

        foreach (var @interface in api.Interfaces)
        {
            if (@interface.Accessors is { Length: > 0 } accessors)
            {
                foreach (var accessor in accessors)
                {
                    if (count > 0)
                        sw.WriteLine();

                    sw.Write("    ");
                    sw.WriteLine($"public static {@interface.Name}* {accessor.Name}() => {accessor.FlatName}();");
                    sw.WriteLine();

                    sw.Write("    ");
                    sw.WriteLine($"public static {@interface.Name}* SteamAPI_{accessor.Name}() => {accessor.FlatName}();");
                    count++;
                }
            }
        }

        sw.WriteLine("}");
    }

    private static SteamAPI GetSteamAPI(string sdkPath)
    {
        var path = Path.Combine(sdkPath, "public", "steam", "steam_api.json");
        var api  = JsonSerializer.Deserialize<SteamAPI>(File.ReadAllBytes(path));
        return api ?? throw new ArgumentException("SDK contains an invalid steam_api.json file.");
    }
}
