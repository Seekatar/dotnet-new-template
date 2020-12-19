# Sample .NET Template

## File Template

Install the sample template

```PowerShell
cd working/templates/extensions
dotnet new -i ./
```

Uninstall the sample template by using `dotnet new -u` and finding the command to uninstall it.

```PowerShell
dotnet new -u | sls 'dotnet new.*working\\templates\\extensions'
```

## Project Template

Install the sample template

```PowerShell
cd working/templates/consoleasync
ri bin,obj -r
dotnet new -i ./
```

Uninstall the sample template by using `dotnet new -u` and finding the command to uninstall it.

```PowerShell
dotnet new -u | sls 'dotnet new.*working\\templates\\console'
```

## Packing

```PowerShell
cd working # above the two template folders
dotnet new console -n templatepack -o .
```

Edit the csproj per [tutorial](https://docs.microsoft.com/en-us/dotnet/core/tutorials/cli-templates-create-template-pack) to create a nupkg and don't compile the code, but include it in the nupkg.

Build it and register it

```PowerShell
cd working
dotnet pack
# pack will output fqdn of nupkg
dotnet new -i C:\code\dotnet-new-template\working\bin\Debug\AdatumCorporation.Utility.Templates.1.0.0.nupkg
```

Uninstall it

```PowerShell
dotnet new -u | sls 'dotnet new.*AdatumCorp'
```

https://weblog.west-wind.com/posts/2020/Oct/05/Creating-a-dotnet-new-Project-Template
