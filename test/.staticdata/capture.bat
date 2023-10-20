@echo off
chcp 65001
cd "D:\VPES_mini\nari\test"
"msbuild" "test.sln" "/t:rebuild"
chcp 949 >nul
