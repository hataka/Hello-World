cd /d %~dp0
@echo off
REM ------ start build: project : paintargs01, option: Release Any CPU ------
setlocal
set TARGET=paintargs01
set EXE=%TARGET%.exe
set RES=%TARGET%.resources
set CSPROJ= %TARGET%.csproj
set SLN = %TARGET%.sln

"C:/Windows/Microsoft.NET/Framework/v3.5/Csc.exe" /noconfig /nowarn:1701,1702 /errorreport:prompt /warn:4 /define:TRACE /reference:"C:/Program Files (x86)/Reference Assemblies/Microsoft/Framework/v3.5/System.Core.dll" /reference:"C:/Program Files (x86)/Reference Assemblies/Microsoft/Framework/v3.5/System.Data.DataSetExtensions.dll" /reference:C:/Windows/Microsoft.NET/Framework/v2.0.50727/System.Data.dll /reference:C:/Windows/Microsoft.NET/Framework/v2.0.50727/System.Deployment.dll /reference:C:/Windows/Microsoft.NET/Framework/v2.0.50727/System.dll /reference:C:/Windows/Microsoft.NET/Framework/v2.0.50727/System.Drawing.dll /reference:C:/Windows/Microsoft.NET/Framework/v2.0.50727/System.Windows.Forms.dll /reference:C:/Windows/Microsoft.NET/Framework/v2.0.50727/System.Xml.dll /reference:"C:/Program Files (x86)/Reference Assemblies/Microsoft/Framework/v3.5/System.Xml.Linq.dll" /debug:pdbonly /out:paintargs01.exe /target:winexe /win32icon:F:/icons/Win95Icon/W95Icon0349.ico paintargs01.cs

endlocal
