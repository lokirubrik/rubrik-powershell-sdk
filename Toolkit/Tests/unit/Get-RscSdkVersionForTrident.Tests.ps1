<#
.SYNOPSIS
Unit tests for Get-RscSdkVersionForTrident cmdlet
#>
BeforeAll {
    . "$PSScriptRoot\..\UnitTestInit.ps1"
    
    # Source the script to get access to helper functions
    . "$PSScriptRoot\..\..\Public\Get-RscSdkVersionForTrident.ps1"
}

Describe -Name "Get-RscSdkVersionForTrident Tests" -Fixture {

    Context "Help Documentation" {
        It -Name 'has non-empty synopsis and description' -Test {
            $help = Get-Help Get-RscSdkVersionForTrident
            $help.Synopsis | Should -Not -BeNullOrEmpty
            $help.Description | Should -Not -BeNullOrEmpty
        }
    }

    Context "Get-SdkVersionDate Helper Function" {
        
        It -Name 'parses schema version v20260119-29 correctly' -Test {
            $result = Get-SdkVersionDate -SdkVersion "v20260119-29"
            $result | Should -BeOfType [DateTime]
            $result.Year | Should -Be 2026
            $result.Month | Should -Be 1
            $result.Day | Should -Be 19
        }

        It -Name 'parses schema version v20251215-36 correctly' -Test {
            $result = Get-SdkVersionDate -SdkVersion "v20251215-36"
            $result | Should -BeOfType [DateTime]
            $result.Year | Should -Be 2025
            $result.Month | Should -Be 12
            $result.Day | Should -Be 15
        }

        It -Name 'parses SDK version 1.14.20260105 correctly' -Test {
            $result = Get-SdkVersionDate -SdkVersion "1.14.20260105"
            $result | Should -BeOfType [DateTime]
            $result.Year | Should -Be 2026
            $result.Month | Should -Be 1
            $result.Day | Should -Be 5
        }

        It -Name 'parses version with embedded date 20240812 correctly' -Test {
            $result = Get-SdkVersionDate -SdkVersion "v20240812-12"
            $result | Should -BeOfType [DateTime]
            $result.Year | Should -Be 2024
            $result.Month | Should -Be 8
            $result.Day | Should -Be 12
        }

        It -Name 'throws on invalid version without date pattern' -Test {
            { Get-SdkVersionDate -SdkVersion "1.14.0" } | Should -Throw "*Could not extract date*"
        }

        It -Name 'throws on version with invalid month' -Test {
            { Get-SdkVersionDate -SdkVersion "v20261319-29" } | Should -Throw "*Could not extract date*"
        }

        It -Name 'throws on version with year before 2020' -Test {
            { Get-SdkVersionDate -SdkVersion "v20190101-01" } | Should -Throw "*Could not extract date*"
        }
    }

    Context "Trident Version Parsing" {
        
        BeforeEach {
            # Mock Get-CompatibleSdkVersionsFromGallery to avoid network calls
            Mock Get-CompatibleSdkVersionsFromGallery { return @() }
        }

        It -Name 'parses trident-v2.5.12-88 as December 2025' -Test {
            Mock Get-RscVersion {
                return [PSCustomObject]@{
                    ServerVersion = "trident-v2.5.12-88"
                    SdkSchemaVersion = "v20251101-33"
                }
            }
            
            $result = Get-RscSdkVersionForTrident
            $result.TridentBuildDate | Should -Be "2025-11"  # Dec 2025 - 1 month = Nov 2025
        }

        It -Name 'parses trident-v2.6.03-42 as February 2026' -Test {
            Mock Get-RscVersion {
                return [PSCustomObject]@{
                    ServerVersion = "trident-v2.6.03-42"
                    SdkSchemaVersion = "v20260201-10"
                }
            }
            
            $result = Get-RscSdkVersionForTrident
            $result.TridentBuildDate | Should -Be "2026-02"  # Mar 2026 - 1 month = Feb 2026
        }

        It -Name 'handles January rollover correctly (trident-v2.6.01-10)' -Test {
            Mock Get-RscVersion {
                return [PSCustomObject]@{
                    ServerVersion = "trident-v2.6.01-10"
                    SdkSchemaVersion = "v20251201-15"
                }
            }
            
            $result = Get-RscSdkVersionForTrident
            $result.TridentBuildDate | Should -Be "2025-12"  # Jan 2026 - 1 month = Dec 2025
        }

        It -Name 'parses single digit month trident-v2.5.3-100' -Test {
            Mock Get-RscVersion {
                return [PSCustomObject]@{
                    ServerVersion = "trident-v2.5.3-100"
                    SdkSchemaVersion = "v20250201-05"
                }
            }
            
            $result = Get-RscSdkVersionForTrident
            $result.TridentBuildDate | Should -Be "2025-02"  # Mar 2025 - 1 month = Feb 2025
        }
    }

    Context "Compatibility Detection" {
        
        BeforeEach {
            Mock Get-CompatibleSdkVersionsFromGallery { return @() }
        }

        It -Name 'returns IsCompatible=true when SDK date is before Trident build date' -Test {
            Mock Get-RscVersion {
                return [PSCustomObject]@{
                    ServerVersion = "trident-v2.5.03-88"      # March 2025 -> branch cut Feb 2025
                    SdkSchemaVersion = "v20250115-29"          # Jan 15, 2025
                }
            }
            
            $result = Get-RscSdkVersionForTrident
            $result.IsCompatible | Should -Be $true
            $result.SDKBuildDate | Should -Be "2025-01-15"
            $result.TridentBuildDate | Should -Be "2025-02"
        }

        It -Name 'returns IsCompatible=true when SDK date equals Trident build date (1st of month)' -Test {
            Mock Get-RscVersion {
                return [PSCustomObject]@{
                    ServerVersion = "trident-v2.5.03-88"      # March 2025 -> branch cut Feb 2025
                    SdkSchemaVersion = "v20250201-29"          # Feb 1, 2025 (exactly on branch cut)
                }
            }
            
            $result = Get-RscSdkVersionForTrident
            $result.IsCompatible | Should -Be $true
        }

        It -Name 'returns IsCompatible=false when SDK date is after Trident build date' -Test {
            Mock Get-RscVersion {
                return [PSCustomObject]@{
                    ServerVersion = "trident-v2.5.03-88"      # March 2025 -> branch cut Feb 2025
                    SdkSchemaVersion = "v20260105-21"          # Jan 5, 2026 (way after)
                }
            }
            
            $result = Get-RscSdkVersionForTrident
            $result.IsCompatible | Should -Be $false
            $result.SDKBuildDate | Should -Be "2026-01-05"
        }

        It -Name 'returns IsCompatible=false when SDK is 1 day after branch cut' -Test {
            Mock Get-RscVersion {
                return [PSCustomObject]@{
                    ServerVersion = "trident-v2.5.03-88"      # March 2025 -> branch cut Feb 2025
                    SdkSchemaVersion = "v20250202-29"          # Feb 2, 2025 (1 day after)
                }
            }
            
            $result = Get-RscSdkVersionForTrident
            $result.IsCompatible | Should -Be $false
        }
    }

    Context "Non-Trident Environment Handling" {
        
        It -Name 'throws error for RSC-C (cloud) environment' -Test {
            Mock Get-RscVersion {
                return [PSCustomObject]@{
                    ServerVersion = "main-2026-01-15"
                    SdkSchemaVersion = "v20260105-21"
                }
            }
            
            { Get-RscSdkVersionForTrident } | Should -Throw "*only applicable for Trident*"
        }

        It -Name 'throws error for unknown server version format' -Test {
            Mock Get-RscVersion {
                return [PSCustomObject]@{
                    ServerVersion = "unknown-version-123"
                    SdkSchemaVersion = "v20260105-21"
                }
            }
            
            { Get-RscSdkVersionForTrident } | Should -Throw "*only applicable for Trident*"
        }
    }

    Context "Invalid Trident Version Format" {
        
        It -Name 'throws error for malformed Trident version' -Test {
            Mock Get-RscVersion {
                return [PSCustomObject]@{
                    ServerVersion = "trident-2025-03"  # Missing v and wrong format
                    SdkSchemaVersion = "v20250115-29"
                }
            }
            
            { Get-RscSdkVersionForTrident } | Should -Throw "*Could not parse year and month*"
        }

        It -Name 'throws error for Trident version without build number' -Test {
            Mock Get-RscVersion {
                return [PSCustomObject]@{
                    ServerVersion = "trident-v2.5.12"  # Missing build number
                    SdkSchemaVersion = "v20250115-29"
                }
            }
            
            { Get-RscSdkVersionForTrident } | Should -Throw "*Could not parse year and month*"
        }
    }

    Context "Output Object Structure" {
        
        BeforeEach {
            Mock Get-CompatibleSdkVersionsFromGallery { return @("1.12.2", "1.12.1", "1.12") }
        }

        It -Name 'returns object with all expected properties' -Test {
            Mock Get-RscVersion {
                return [PSCustomObject]@{
                    ServerVersion = "trident-v2.5.03-88"
                    SdkSchemaVersion = "v20250115-29"
                }
            }
            
            $result = Get-RscSdkVersionForTrident
            $result.PSObject.Properties.Name | Should -Contain "SDKBuildDate"
            $result.PSObject.Properties.Name | Should -Contain "TridentBuildDate"
            $result.PSObject.Properties.Name | Should -Contain "IsCompatible"
            $result.PSObject.Properties.Name | Should -Contain "Recommendation"
            $result.PSObject.Properties.Name | Should -Contain "SuggestedVersions"
        }

        It -Name 'SDKBuildDate is in yyyy-MM-dd format' -Test {
            Mock Get-RscVersion {
                return [PSCustomObject]@{
                    ServerVersion = "trident-v2.5.03-88"
                    SdkSchemaVersion = "v20250115-29"
                }
            }
            
            $result = Get-RscSdkVersionForTrident
            $result.SDKBuildDate | Should -Match "^\d{4}-\d{2}-\d{2}$"
        }

        It -Name 'TridentBuildDate is in yyyy-MM format' -Test {
            Mock Get-RscVersion {
                return [PSCustomObject]@{
                    ServerVersion = "trident-v2.5.03-88"
                    SdkSchemaVersion = "v20250115-29"
                }
            }
            
            $result = Get-RscSdkVersionForTrident
            $result.TridentBuildDate | Should -Match "^\d{4}-\d{2}$"
        }

        It -Name 'SuggestedVersions is populated when incompatible' -Test {
            Mock Get-RscVersion {
                return [PSCustomObject]@{
                    ServerVersion = "trident-v2.5.03-88"
                    SdkSchemaVersion = "v20260115-29"  # Way after branch cut
                }
            }
            
            $result = Get-RscSdkVersionForTrident
            $result.IsCompatible | Should -Be $false
            $result.SuggestedVersions | Should -Not -BeNullOrEmpty
            $result.SuggestedVersions.Count | Should -Be 3
            $result.SuggestedVersions[0] | Should -Be "1.12.2"
        }

        It -Name 'SuggestedVersions is empty when compatible' -Test {
            Mock Get-RscVersion {
                return [PSCustomObject]@{
                    ServerVersion = "trident-v2.5.03-88"
                    SdkSchemaVersion = "v20250115-29"  # Before branch cut
                }
            }
            Mock Get-CompatibleSdkVersionsFromGallery { return @() }
            
            $result = Get-RscSdkVersionForTrident
            $result.IsCompatible | Should -Be $true
            $result.SuggestedVersions | Should -BeNullOrEmpty
        }
    }

    Context "Recommendation Messages" {
        
        BeforeEach {
            Mock Get-CompatibleSdkVersionsFromGallery { return @() }
        }

        It -Name 'provides compatibility message when compatible' -Test {
            Mock Get-RscVersion {
                return [PSCustomObject]@{
                    ServerVersion = "trident-v2.5.03-88"
                    SdkSchemaVersion = "v20250115-29"
                }
            }
            
            $result = Get-RscSdkVersionForTrident
            $result.Recommendation | Should -Match "compatible"
        }

        It -Name 'provides install recommendation when incompatible' -Test {
            Mock Get-RscVersion {
                return [PSCustomObject]@{
                    ServerVersion = "trident-v2.5.03-88"
                    SdkSchemaVersion = "v20260115-29"
                }
            }
            
            $result = Get-RscSdkVersionForTrident
            $result.Recommendation | Should -Match "Install"
            $result.Recommendation | Should -Match "powershellgallery.com"
        }
    }
}

