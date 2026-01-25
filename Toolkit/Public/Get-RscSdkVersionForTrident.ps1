#Requires -Version 3
function Get-RscSdkVersionForTrident {
    <#
    .SYNOPSIS
    Check SDK version compatibility for Trident (RSC-P) environments.

    .DESCRIPTION
    This cmdlet validates that the PowerShell SDK version is compatible with a Trident (RSC-P)
    environment. It compares the SDK schema date with the approximate RSC-C branch cut date
    that the Trident release was based on.

    RSC-P (Trident) releases are cut from RSC-C branches with approximately a 1-month lag
    for testing and qualification. This cmdlet helps ensure you're using a compatible SDK version.

    The SDK schema version (e.g., v20260119-29) contains the RSC-C release date embedded in it,
    which is used to determine compatibility.

    .EXAMPLE
    Get-RscSdkVersionForTrident

    Checks if the current SDK version is compatible with the connected Trident environment.

    .NOTES
    - Only works when connected to a Trident (RSC-P) environment
    - SDK versions newer than the Trident branch cut date may have compatibility issues
    - Recommended to keep SDK within 3 months of the server version for safety
    - Find available SDK versions at: https://www.powershellgallery.com/packages/RubrikSecurityCloud
    #>

    Param()

    Process {
        # Step 1: Get version information and validate Trident environment
        $versionInfo = Get-RscVersion

        $serverVersion = $versionInfo.ServerVersion
        $sdkVersion = $versionInfo.SdkSchemaVersion

        # Validate this is a Trident environment
        if ($serverVersion -notmatch "trident") {
            throw "This cmdlet is only applicable for Trident (RSC-P) environments. " +
                  "Server version '$serverVersion' does not contain 'trident'. " +
                  "For RSC-C (cloud) environments, use Get-RscVersion to check version compatibility."
        }

        # Step 2: Extract year and month from Trident version, go back 1 month for branch cut date
        # Expected format: trident-v{decade}.{year}.{month}-{build}
        # Example: trident-v2.5.12-88 means 2025 (2.5), December (12), build 88 (discarded)
        if ($serverVersion -match "trident-v(\d)\.(\d)\.(\d{1,2})-\d+") {
            $decade = [int]$Matches[1]
            $yearDigit = [int]$Matches[2]
            $tridentYear = 2000 + ($decade * 10) + $yearDigit  # 2.5 -> 2025, 2.6 -> 2026
            $tridentMonth = [int]$Matches[3]
        }
        else {
            throw "Could not parse year and month from Trident version: $serverVersion. " +
                  "Expected format: trident-v{decade}.{year}.{month}-{build} (e.g., trident-v2.5.12-88)"
        }

        # Go back one month for the approximate branch cut date
        $branchCutMonth = $tridentMonth - 1
        $branchCutYear = $tridentYear
        if ($branchCutMonth -lt 1) {
            $branchCutMonth = 12
            $branchCutYear = $branchCutYear - 1
        }

        # Create approximate branch cut date (use day 1 for comparison, display as month/year only)
        $approxBranchCutDate = [DateTime]::new($branchCutYear, $branchCutMonth, 1)
        $tridentBuildDateStr = $approxBranchCutDate.ToString("yyyy-MM")

        # Step 3: Parse SDK version to get its date from the schema version string
        # The SdkSchemaVersion (e.g., v20260119-29) contains the date embedded in it
        $sdkVersionDate = Get-SdkVersionDate -SdkVersion $sdkVersion
        $sdkBuildDateStr = $sdkVersionDate.ToString("yyyy-MM-dd")

        # Step 4: Compare dates and provide recommendations
        # For comparison, SDK date should be within the branch cut month or earlier
        $result = [PSCustomObject]@{
            SDKBuildDate      = $sdkBuildDateStr
            TridentBuildDate  = $tridentBuildDateStr
            IsCompatible      = $true
            Recommendation    = $null
            SuggestedVersions = @()
        }

        # Compare: SDK date should be on or before the 1st of the branch cut month
        if ($sdkVersionDate -gt $approxBranchCutDate) {
            $result.IsCompatible = $false

            Write-Warning ("SDK build date ($sdkBuildDateStr) is NEWER than " +
                "the Trident build date ($tridentBuildDateStr).")
            Write-Warning "This SDK may contain features/APIs not available in this Trident environment."

            # Fetch compatible versions from PowerShell Gallery
            $suggestedVersions = Get-CompatibleSdkVersionsFromGallery -MaxDate $approxBranchCutDate -TopN 3
            $result.SuggestedVersions = $suggestedVersions

            $result.Recommendation = "Install an SDK version released on or before $tridentBuildDateStr. " +
                "Find available versions at: https://www.powershellgallery.com/packages/RubrikSecurityCloud"

            Write-Host "`nRecommendation:" -ForegroundColor Yellow
            Write-Host "  Install an SDK version with schema date on or before $tridentBuildDateStr" -ForegroundColor Cyan

            if ($suggestedVersions.Count -gt 0) {
                Write-Host "  Recommended version: $($suggestedVersions[0])" -ForegroundColor Green
                if ($suggestedVersions.Count -gt 1) {
                    Write-Host "  Other compatible versions: $($suggestedVersions[1..($suggestedVersions.Count-1)] -join ', ')" -ForegroundColor Cyan
                }
            }
            else {
                Write-Host "  Find available versions: https://www.powershellgallery.com/packages/RubrikSecurityCloud" -ForegroundColor Cyan
            }
        }
        else {
            $result.Recommendation = "SDK version is compatible with this Trident environment."
            Write-Host "SDK version is compatible with this Trident environment." -ForegroundColor Green
        }

        return $result
    }
}

# Helper function to extract date from SDK schema version string
# The SdkSchemaVersion (e.g., v20260119-29) contains the date in YYYYMMDD format
function Get-SdkVersionDate {
    param(
        [Parameter(Mandatory = $true)]
        [string]$SdkVersion
    )

    # Pattern: 8-digit date in format YYYYMMDD
    # Examples: "v20260119-29" -> 20260119, "1.14.20260105" -> 20260105
    if ($SdkVersion -match "(\d{4})(\d{2})(\d{2})") {
        $year = [int]$Matches[1]
        $month = [int]$Matches[2]
        $day = [int]$Matches[3]

        # Validate it's a reasonable date (year between 2020 and 2100)
        if ($year -ge 2020 -and $year -le 2100 -and $month -ge 1 -and $month -le 12 -and $day -ge 1 -and $day -le 31) {
            try {
                return [DateTime]::new($year, $month, $day)
            }
            catch {
                # Fall through to error
            }
        }
    }

    throw "Could not extract date from SDK version: $SdkVersion. " +
          "Expected format containing YYYYMMDD pattern (e.g., v20260119-29)."
}

# Helper function to fetch compatible SDK versions from PowerShell Gallery
function Get-CompatibleSdkVersionsFromGallery {
    param(
        [Parameter(Mandatory = $true)]
        [DateTime]$MaxDate,

        [Parameter(Mandatory = $false)]
        [int]$TopN = 3
    )

    $compatibleVersions = @()

    try {
        # Query PowerShell Gallery API for RubrikSecurityCloud versions (ordered by Published date)
        $apiUrl = "https://www.powershellgallery.com/api/v2/FindPackagesById()?id='RubrikSecurityCloud'&`$orderby=Published%20desc&`$top=50"
        $response = Invoke-WebRequest -Uri $apiUrl -UseBasicParsing -TimeoutSec 30

        # Parse XML response
        [xml]$xml = $response.Content

        # Get all entries
        $entries = $xml.feed.entry

        foreach ($entry in $entries) {
            $version = $entry.properties.Version
            $description = $entry.properties.Description

            # Extract schema version from description (e.g., "GraphQL schema version: v20260105-21")
            if ($description -match "GraphQL schema version:\s*(v?\d{8}-\d+)") {
                $schemaVersion = $Matches[1]

                # Extract date from schema version
                try {
                    $schemaDate = Get-SdkVersionDate -SdkVersion $schemaVersion

                    # Check if this version is compatible (schema date <= MaxDate)
                    if ($schemaDate -le $MaxDate) {
                        $compatibleVersions += [PSCustomObject]@{
                            Version = $version
                            SchemaDate = $schemaDate.ToString("yyyy-MM-dd")
                        }

                        # Stop if we have enough versions
                        if ($compatibleVersions.Count -ge $TopN) {
                            break
                        }
                    }
                }
                catch {
                    # Skip versions where we can't parse the date
                    continue
                }
            }
        }
    }
    catch {
        # If API call fails, return empty array (graceful degradation)
        Write-Warning "Could not fetch versions from PowerShell Gallery: $($_.Exception.Message)"
    }

    return $compatibleVersions.Version
}

