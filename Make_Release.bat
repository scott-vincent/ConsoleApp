dotnet publish -r win-x64 -c Release /p:PublishSingleFile=true /p:PublishTrimmed=true
del /s /q publish
mkdir publish
copy bin\Release\netcoreapp3.0\win-x64\publish\*.exe publish
copy appsettings.json publish