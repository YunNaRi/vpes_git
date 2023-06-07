@echo off
chcp 65001
cd "D:\VPES_GIT\vpes_git\PopPad3_vs2015"
"msbuild" "vs2015_poppad.sln" "/t:rebuild"
chcp 949 >nul
