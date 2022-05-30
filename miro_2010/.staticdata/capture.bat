@echo off
chcp 65001
cd "D:\VPES_GIT\vpes_git\miro_2010"
"msbuild" "miro.sln" "/t:rebuild"
chcp 949 >nul
