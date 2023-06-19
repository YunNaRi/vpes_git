@echo off
chcp 65001
cd "C:\Program Files\Suresoft\QualityScroll VPES 3.2.2\vpes\STATIC_WORKSPACE\Auto_test_static_c\miro_vs2015"
"msbuild" "vs2015_miro.sln" "/t:rebuild"
chcp 949 >nul
