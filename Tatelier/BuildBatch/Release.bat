@echo off

set MSBUILD_PATH="C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe"
set PLATFORM=x64
set CONFIGURATION=Release
set DIRECTORY_NAME=Tatelier

if exist "..\bin\%PLATFORM%\%DIRECTORY_NAME%" (
rmdir /q /s "..\bin\%PLATFORM%\%DIRECTORY_NAME%"
)

::MSBuild
if exist %MSBUILD_PATH% (
%MSBUILD_PATH% "%~dp0..\..\Tatelier.sln" /t:Rebuild /p:CONFIGURATION=%Configuration%;Platform="%PLATFORM%"
) else (
    echo MSBuild.exe �� ������܂���ł����B
)

::EXE�o�[�W�����擾
powershell .\output-tatelier-version.ps1 ".\..\bin\%PLATFORM%\%CONFIGURATION%\Tatelier.exe"

FOR /F %%a IN (ver.txt) DO SET VER=%%a

echo %VER%

::�t�H���_���ύX
move "..\bin\%PLATFORM%\%CONFIGURATION%" "..\bin\%PLATFORM%\%DIRECTORY_NAME%"

::ZIP�쐬
powershell .\output-release-zip.ps1 "..\bin\%PLATFORM%\%DIRECTORY_NAME%" "..\bin\%PLATFORM%\Tatelier-v%ver%-%CONFIGURATION%-%PLATFORM%.zip"

::�f�v���C�͂ЂƂ܂��蓮

    
::�ꎞ�t�@�C���폜
del ver.txt