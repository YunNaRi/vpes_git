@echo off
chcp 65001
cd "C:\Temp\poppad"
"msbuild" "/t:rebuild" "Poppad3.sln"
chcp 949 >nul
