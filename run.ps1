param (
    [ValidateSet('pack','install-pack','uninstall-pack','rebuild-pack','use-pack')]
    [string[]] $Task,
    [switch] $PesterPassThru,
    [string] $Name
)

foreach ($t in $Task) {

    try {
    $prevPref = $ErrorActionPreference
    $ErrorActionPreference = "Stop"

    switch ($t) {
        'pack' {
            Push-Location (Join-Path $PSScriptRoot 'working')
            dotnet pack
        }
        'install-pack' {
            dotnet new -i "$PSScriptRoot\working\bin\Debug\AdatumCorporation.Utility.Templates.1.0.0.nupkg"
        }
        'uninstall-pack' {
            dotnet new -u AdatumCorporation.Utility.Templates
        }
        'rebuild-pack' {
            # dotnet new -u AdatumCorporation.Utility.Templates
            Push-Location (Join-Path $PSScriptRoot 'working')
            dotnet pack
            dotnet new -i "$PSScriptRoot\working\bin\Debug\AdatumCorporation.Utility.Templates.1.0.0.nupkg"
        }
        'use-pack' {
            Push-Location (Join-Path $PSScriptRoot 'test')
            if (!$Name) {
                throw "Name required for use-pack"
            }
            if (Test-Path "$PSScriptRoot/test/$Name") {
                throw "Folder $PSScriptRoot/test/$Name already exists"
            }
            dotnet new consoleasync -o $Name
        }
       Default {}
    }

    } finally {
        Pop-Location
        $ErrorActionPreference = $prevPref
    }
}