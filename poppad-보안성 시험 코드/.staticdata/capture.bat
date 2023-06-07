@echo off
chcp 65001
cd "D:\VPES_GIT\vpes_git\poppad-보안성 시험 코드"
"msbuild" "PopPad3.sln/t:rebuild"
chcp 949 >nul
