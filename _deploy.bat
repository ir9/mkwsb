set DEPLOY=%TMP%\mkwsb
del mkwsb.zip
rmdir /s /q %DEPLOY%
mkdir %DEPLOY%

copy .\mkwsb\bin\Release\mkwsb.exe.*  %DEPLOY%
xcopy /s /i .\mkwsb\bin\Release\ja-jp %DEPLOY%\ja-jp
copy .\misc\mkwsb.txt %DEPLOY%
copy .\mkwsb.ps1      %DEPLOY%
copy .\templete.wsb   %DEPLOY%

7za.exe a -mx9 mkwsb.zip %DEPLOY%
rmdir /s /q %DEPLOY%
