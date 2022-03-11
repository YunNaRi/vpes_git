@echo off
chcp 65001
cd "D:\VPES_mini\nari\visual_studio_c_cpp"
"msbuild" "STATIC_C_CPP_EXAMPLE.sln" "/t:rebuild"
chcp 949 >nul
