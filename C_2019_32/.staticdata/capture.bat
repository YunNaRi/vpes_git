@echo off
chcp 65001
cd "D:\샘플\test_git\C_2019_32"
"msbuild" "VS2019_CPP_3.sln" "/t:rebuild"
chcp 949 >nul
