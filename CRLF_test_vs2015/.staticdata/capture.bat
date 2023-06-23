@echo off
chcp 65001
cd "C:\Program Files\Suresoft\QualityScroll VPES 3.2.2\vpes\STATIC_WORKSPACE\Auto_test_static_c"
"msbuild" "CRLF_test_vs2015.sln" "/t:rebuild"
chcp 949 >nul
