echo curl
for /l %%i in (1, 1, 200) do (
echo %%i/200
echo %DATE% %TIME%
rem path F:\RT\codescroll-project-uploader\
rem codescroll-project-uploader -p F:\RT\STATIC4.1.1aRT\pop -k POPS -s http://211.116.223.190
csbuild -- msbuild cube.sln /t:Rebuild
)