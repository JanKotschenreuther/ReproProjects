dotnet publish .\adv-dbupdater-ui.csproj `
    -o C:\Publish\adv-dbupdater-ui `
    -c Release `
    -f net8.0-windows10.0.19041.0 `
    -p:WindowsAppSDKSelfContained=true `
    -p:WindowsPackageType=None `
    -p:RuntimeIdentifierOverride=win10-x64 `
    -p:ErrorOnDuplicatePublishOutputFiles=true `
    -p:Version=1.0.8
