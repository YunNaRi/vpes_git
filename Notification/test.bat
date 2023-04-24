echo curl
for /l %%i in (1, 1, 500) do (
echo %%i/500
echo %DATE% %TIME%
mvn_cover package com.codescroll.acp:static-maven-plugin:1.0-SNAPSHOT:static -Dkey=MAVEN -Dserver=211.116.223.195 -DskipTests
)