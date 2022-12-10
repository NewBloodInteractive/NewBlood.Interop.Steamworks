@echo off
set BUILD_ARGS=-f netstandard2.1 -c Release -p:GenerateDependencyFile=false -p:DebugType=None
set PACKAGE_DIR=%CD%\dist\com.newblood.interop.steamworks

rem Build NewBlood.Interop.Steamworks for Unix
dotnet build sources\NewBlood.Interop.Steamworks %BUILD_ARGS%
copy /b /v /y "sources\NewBlood.Interop.Steamworks\bin\Release\netstandard2.1\NewBlood.Interop.Steamworks.dll" "%PACKAGE_DIR%\Managed\Unix\"

rem Build NewBlood.Interop.Steamworks for Windows
dotnet build sources\NewBlood.Interop.Steamworks %BUILD_ARGS% -p:BuildForWindows=true
copy /b /v /y "sources\NewBlood.Interop.Steamworks\bin\Release\netstandard2.1\NewBlood.Interop.Steamworks.dll" "%PACKAGE_DIR%\Managed\Windows\"

rem Copy native Steamworks API libraries
copy /b /v /y sdk\redistributable_bin\steam_api.dll "%PACKAGE_DIR%\Native\x86\steam_api.dll"
copy /b /v /y sdk\redistributable_bin\win64\steam_api64.dll "%PACKAGE_DIR%\Native\x64\steam_api.dll"
copy /b /v /y sdk\redistributable_bin\osx\libsteam_api.dylib "%PACKAGE_DIR%\Native\libsteam_api.dylib"
rem copy /b /v /y sdk\redistributable_bin\linux32\libsteam_api.so "%PACKAGE_DIR%\Native\x86\libsteam_api.so"
copy /b /v /y sdk\redistributable_bin\linux64\libsteam_api.so "%PACKAGE_DIR%\Native\x64\libsteam_api.so"

rem Copy native Steamworks encrypted app ticket libraries
copy /b /v /y sdk\public\steam\lib\win32\sdkencryptedappticket.dll "%PACKAGE_DIR%\Native\x86\sdkencryptedappticket.dll"
copy /b /v /y sdk\public\steam\lib\win64\sdkencryptedappticket64.dll "%PACKAGE_DIR%\Native\x64\sdkencryptedappticket.dll"
copy /b /v /y sdk\public\steam\lib\osx\libsdkencryptedappticket.dylib "%PACKAGE_DIR%\Native\libsdkencryptedappticket.dylib"
rem copy /b /v /y sdk\public\steam\lib\linux32\libsdkencryptedappticket.so "%PACKAGE_DIR%\Native\x86\libsdkencryptedappticket.so"
copy /b /v /y sdk\public\steam\lib\linux64\libsdkencryptedappticket.so "%PACKAGE_DIR%\Native\x64\libsdkencryptedappticket.so"

rem Copy native Game Coordinator SDK libraries
copy /b /v /y sdk\bin\win64\steamdatagram_gamecoordinator.dll "%PACKAGE_DIR%\Native\x64\steamdatagram_gamecoordinator.dll"
copy /b /v /y sdk\bin\ubuntu12_64\libsteamdatagram_gamecoordinator.so "%PACKAGE_DIR%\Native\x64\libsteamdatagram_gamecoordinator.so"
