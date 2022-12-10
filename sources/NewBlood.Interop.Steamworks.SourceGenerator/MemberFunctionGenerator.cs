using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace NewBlood.Interop.Steamworks.SourceGenerator;

[Generator]
public sealed class MemberFunctionGenerator : IIncrementalGenerator
{
    private static Encoding Encoding { get; } = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var symbols = context.SyntaxProvider.ForAttributeWithMetadataName(
            "NewBlood.Interop.Steamworks.GenerateMemberFunctionAttribute",
            static (syntax,  token) => syntax is MethodDeclarationSyntax,
            static (context, token) =>
            {
                var symbol = (IMethodSymbol)context.TargetSymbol;
                var method = new MethodRecord(symbol);
                var owner  = new TypeRecord(((IPointerTypeSymbol)symbol.Parameters[0].Type).PointedAtType);
                var name   = context.Attributes[0].ConstructorArguments[0].Value!.ToString();
                return new MemberFunctionRecord(name, owner, method);
            });

        context.RegisterSourceOutput(symbols, static (context, member) =>
        {
            var builder = new StringBuilder();
            builder.AppendLine("// <auto-generated/>");
            builder.AppendLine("#pragma warning disable");
            builder.AppendLine();
            builder.AppendLine("namespace NewBlood.Interop.Steamworks;");
            builder.AppendLine();
            builder.AppendLine($"partial struct {member.ThisType.Name}");
            builder.AppendLine("{");

            if (member.Method.IsObsolete)
                builder.AppendLine("    [global::System.ObsoleteAttribute]");

            builder.Append("    public unsafe ");
            builder.Append(member.Method.ReturnType.FullName);
            builder.Append(' ');
            builder.Append(member.Name);
            builder.Append('(');

            for (int i = 1; i < member.Method.Parameters.Length; i++)
            {
                if (i > 1)
                    builder.Append(", ");

                builder.Append(member.Method.Parameters[i].Type.FullName);
                builder.Append(' ');
                builder.Append(member.Method.Parameters[i].Name);
            }

            builder.AppendLine(")");
            builder.AppendLine("    {");

            builder.AppendLine($"        fixed ({member.ThisType.FullName}* {member.Method.Parameters[0].Name} = &this)");
            builder.AppendLine("        {");
            builder.Append("            ");

            if (member.Method.ReturnType.FullName != "void")
                builder.Append("return ");

            builder.Append(member.Method.ContainingType.FullName);
            builder.Append('.');
            builder.Append(member.Method.Name);
            builder.Append("(");
            builder.Append(member.Method.Parameters[0].Name);

            for (int i = 1; i < member.Method.Parameters.Length; i++)
            {
                builder.Append(", ");
                builder.Append(member.Method.Parameters[i].Name);
            }

            builder.AppendLine(");");
            builder.AppendLine("        }");
            builder.AppendLine("    }");
            builder.AppendLine("}");

            context.AddSource($"{member.Method.Name}.g.cs", SourceText.From(builder.ToString(), Encoding));
        });
    }
}
