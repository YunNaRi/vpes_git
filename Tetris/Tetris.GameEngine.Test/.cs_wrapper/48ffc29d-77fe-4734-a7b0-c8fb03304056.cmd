if defined CODESCROLL_TM_INSTALL_PATH (
	"%CODESCROLL_TM_INSTALL_PATH%\csc\QualityScroll.Cover.CscHooker.exe" "C:\Users\ysgo\Desktop\VPES\VPES2.3.2\svn\VPES_Study\COVER_EE\Tetris\Tetris.GameEngine.Test\Tetris.GameEngine.Test.csproj" %*
) else (
	echo Error : please SET "CODESCROLL_TM_INSTALL_PATH"
)
