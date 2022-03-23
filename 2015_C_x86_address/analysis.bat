call "C:\\Program Files (x86)\\Microsoft Visual Studio 14.0\\Common7\\Tools\\VsDevCmd.bat"
cd %~dp0
call csbuild -- msbuild address_manager.sln /t:rebuild