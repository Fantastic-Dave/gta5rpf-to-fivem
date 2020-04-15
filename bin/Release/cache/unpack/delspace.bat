@Echo Off
CD cache\unpack
FOR /D /r %%G in ("*") DO move "%%~nxG" nospace