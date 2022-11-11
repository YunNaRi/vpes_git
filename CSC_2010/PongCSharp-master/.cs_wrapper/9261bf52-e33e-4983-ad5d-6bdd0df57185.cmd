if defined CODESCROLL_TM_INSTALL_PATH (
	"%CODESCROLL_TM_INSTALL_PATH%\csc\QualityScroll.Cover.CscHooker.exe" "D:\COVER\Sample Code(EE)\sample\CSC_2010\PongCSharp-master\pong.csproj" %*
) else (
	echo Error : please SET "CODESCROLL_TM_INSTALL_PATH"
)
