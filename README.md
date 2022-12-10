# NewBlood.Interop.Steamworks
A modern, low-level Steamworks API binding for .NET

# Setup
1. Install the [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0).
2. Extract the contents of the `sdk` directory from the latest [Steamworks SDK](https://partner.steamgames.com/doc/sdk) into the repository's `sdk` directory.
3. Extract the latest [Game Coordinator SDK](https://partner.steamgames.com/doc/features/multiplayer/steamdatagramrelay#7) into the repository's `sdk` directory.

# Generating Updated Bindings (on Windows)
1. Install [ClangSharpPInvokeGenerator](https://www.nuget.org/packages/ClangSharpPInvokeGenerator) version 15.0.2 or higher as a global tool.
2. Clear the `sources/NewBlood.Interop.Steamworks/Generated` directory if it exists.
3. Run `generate.cmd`.

# Building for Unity (on Windows)
1. Ensure that the bindings have been generated.
2. Run `build.cmd`.
3. The `dist/com.newblood.interop.steamworks` package can now be used in Unity.
