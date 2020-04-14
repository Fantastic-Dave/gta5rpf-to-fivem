@echo off
FOR /f "delims=" %%G IN ('dir /ad /b') DO (
   setlocal enabledelayedexpansion   
   pushd "%%~dpG"
   SET fname=%%~nxG
   SET fname=!fname: =!
   rename "%%~nxG" "!fname!"
   popd
   endlocal
)