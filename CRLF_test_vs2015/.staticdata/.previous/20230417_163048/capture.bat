@echo off
chcp 65001
cd "D:\VPES_GIT\vpes_git\CRLF_test_vs2015"
"msbuild" "CRLF_test_vs2015.sln" "/t:rebuild"
chcp 949 >nul
