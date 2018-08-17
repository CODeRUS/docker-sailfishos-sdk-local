@ECHO OFF

SET mypath=%~dp0
SET VBOX_INSTALL_PATH=%mypath:~0,-1%
echo %VBOX_INSTALL_PATH%
CALL "c:\SailfishOS\bin\qtcreator.exe"