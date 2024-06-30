@echo off

rem Generate an updated pack-callbacks.rsp
dotnet run --project sources\NewBlood.Interop.Steamworks.Generator -c Release -- generate-packing-rsp --sdk-path "%~dp0.\sdk" --out-path "%~dp0.\generation\pack-callbacks.rsp"

rem Generate an updated librarypaths.rsp
dotnet run --project sources\NewBlood.Interop.Steamworks.Generator -c Release -- generate-librarypath-rsp --sdk-path "%~dp0.\sdk" --out-path "%~dp0.\generation\librarypaths.rsp"

rem Generate unversioned interface accessors
dotnet run --project sources\NewBlood.Interop.Steamworks.Generator -c Release -- generate-accessors --sdk-path "%~dp0.\sdk" --out-path "%~dp0.\sources\NewBlood.Interop.Steamworks\Generated\accessors\Steamworks.cs"

rem Generate ISteamCallback implementations
dotnet run --project sources\NewBlood.Interop.Steamworks.Generator -c Release -- generate-callback-impls --sdk-path "%~dp0.\sdk" --out-path "%~dp0.\sources\NewBlood.Interop.Steamworks\Generated\callbacks\ISteamCallback.cs"

rem Generate Steam interface structures
dotnet run --project sources\NewBlood.Interop.Steamworks.Generator -c Release -- generate-interface-types --sdk-path "%~dp0.\sdk" --out-path "%~dp0.\sources\NewBlood.Interop.Steamworks\Generated\interfaces"

rem Generate Steam interface member info
dotnet run --project sources\NewBlood.Interop.Steamworks.Generator -c Release -- generate-members-rsp --sdk-path "%~dp0.\sdk" --out-path "%~dp0.\generation\members.rsp"

rem Generate obsoletion info
dotnet run --project sources\NewBlood.Interop.Steamworks.Generator -c Release -- generate-obsolete-rsp --sdk-path "%~dp0.\sdk" --out-path "%~dp0.\generation\obsolete.rsp"

rem Generate bindings from headers using ClangSharp
pushd generation
for /r %%f in (generate.rsp) do if exist %%f (
    pushd %%~dpf
    dotnet tool run ClangSharpPInvokeGenerator -- @generate.rsp
    popd
)
popd
