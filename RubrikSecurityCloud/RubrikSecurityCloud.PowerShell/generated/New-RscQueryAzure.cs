// New-RscQueryAzure.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using GraphQL;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.PowerShell.Private;

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Queries for the 'Azure' API domain.
    /// </summary>
    /// <description>
    /// New-RscQueryAzure is the cmdlet to work with operations in the {self.noun} API domain. It is a dynamic cmdlet that accepts any {self.noun} API operation as its first parameter:  {sc_names}.
    /// </description>
    /// <example>
    /// <code>New-RscQueryAzure -NativeRoot [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -NativeSubscription [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -NativeSubscriptions [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -NativeResourceGroup [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -NativeResourceGroups [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -NativeVirtualMachine [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -NativeVirtualMachines [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -NativeManagedDisk [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -NativeManagedDisks [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -AllNativeVirtualNetworks [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -AllNativeSubnetsByRegionFromAzure [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -AllNativeSecurityGroupsByRegionFromAzure [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -AllDiskEncryptionSetsByRegion [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -AllNativeAvailabilitySetsByRegionFromAzure [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -AllNativeExportCompatibleVmSizesByRegionFromAzure [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -AllNativeExportCompatibleDiskTypesByRegionFromAzure [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -AllNativeVirtualMachineSizes [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -IsNativeManagedDiskSnapshotRestorable [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -IsStorageAccountNameAvailable [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -AllNativeStorageAccountsFromAzure [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -SqlDatabase [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -SqlDatabases [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -SqlDatabaseServer [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -SqlDatabaseServers [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -SqlManagedInstanceDatabase [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -SqlManagedInstanceDatabases [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -SqlManagedInstanceServer [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -SqlManagedInstanceServers [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -SqlDatabaseDbPointInTimeRestoreWindowFromAzure [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -ValidateNativeSqlDatabaseDbNameForExport [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -ValidateNativeSqlManagedInstanceDbNameForExport [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -AllSqlDatabaseServerElasticPools [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -IsNativeSqlDatabaseSnapshotPersistent [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -AllKeyVaultsByRegion [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -AllEncryptionKeys [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -CloudAccountTenant [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -CloudAccountTenantWithExoConfigs [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -AllCloudAccountTenants [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -CloudAccountSubscriptionWithFeatures [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -AllCloudAccountSubscriptionsByFeature [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -AllSubscriptionWithExocomputeMappings [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -AllResourceGroupsFrom [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -DoesNativeResourceGroupExist [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -AllNativeResourceGroupsInfoIfExist [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -AllCloudAccountMissingPermissions [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -CloudAccountPermissionConfig [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -AllExocomputeConfigsInAccount [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -AllCloudAccountSubnetsByRegion [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -ValidateCloudAccountExocomputeConfigurations [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -AllArmTemplatesByFeature [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -CheckPersistentStorageSubscriptionCanUnmap [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -Subscriptions [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -Regions [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -ResourceGroups [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -VNets [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -Subnets [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -StorageAccounts [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -AllHostedRegions [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -AllResourceGroups [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -AllVnets [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -AllSubnets [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -AllCdmVersions [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -AllRegions [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -AllNsgs [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -AllStorageAccounts [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -AllManagedIdentities [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -AdDirectories [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -AdDirectory [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -AdObjectsByType [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzure -SearchAdSnapshot [-Arg ..] [-Field ..]</code>
    /// </example>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscQueryAzure",
        DefaultParameterSetName = "VNets")
    ]
    public class New_RscQueryAzure : RscGqlPSCmdlet
    {
        
        /// <summary>
        /// NativeRoot parameter set
        ///
        /// [GraphQL: azureNativeRoot]
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeRoot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Root of Azure native hierarchy.
[GraphQL: azureNativeRoot]",
            Position = 0
        )]
        public SwitchParameter NativeRoot { get; set; }

        
        /// <summary>
        /// NativeSubscription parameter set
        ///
        /// [GraphQL: azureNativeSubscription]
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeSubscription",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves an Azure Native Subscription. Refers to the logical entity that provides entitlement to deploy and consume Azure resources.
[GraphQL: azureNativeSubscription]",
            Position = 0
        )]
        public SwitchParameter NativeSubscription { get; set; }

        
        /// <summary>
        /// NativeSubscriptions parameter set
        ///
        /// [GraphQL: azureNativeSubscriptions]
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeSubscriptions",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a paginated list of all Azure Native Subscriptions.
[GraphQL: azureNativeSubscriptions]",
            Position = 0
        )]
        public SwitchParameter NativeSubscriptions { get; set; }

        
        /// <summary>
        /// NativeResourceGroup parameter set
        ///
        /// [GraphQL: azureNativeResourceGroup]
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeResourceGroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves an Azure Native Resource Group. Refers to a collection of resources in which multiple Azure services can reside.
[GraphQL: azureNativeResourceGroup]",
            Position = 0
        )]
        public SwitchParameter NativeResourceGroup { get; set; }

        
        /// <summary>
        /// NativeResourceGroups parameter set
        ///
        /// [GraphQL: azureNativeResourceGroups]
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeResourceGroups",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a paginated list of all Azure Native Resource Groups.
[GraphQL: azureNativeResourceGroups]",
            Position = 0
        )]
        public SwitchParameter NativeResourceGroups { get; set; }

        
        /// <summary>
        /// NativeVirtualMachine parameter set
        ///
        /// [GraphQL: azureNativeVirtualMachine]
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeVirtualMachine",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves an Azure Virtual Machine that refers to the Azure infrastructure as a service (IaaS) used to deploy persistent VMs. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/.
[GraphQL: azureNativeVirtualMachine]",
            Position = 0
        )]
        public SwitchParameter NativeVirtualMachine { get; set; }

        
        /// <summary>
        /// NativeVirtualMachines parameter set
        ///
        /// [GraphQL: azureNativeVirtualMachines]
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeVirtualMachines",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a paginated list of all Azure Virtual Machines (VMs).
[GraphQL: azureNativeVirtualMachines]",
            Position = 0
        )]
        public SwitchParameter NativeVirtualMachines { get; set; }

        
        /// <summary>
        /// NativeManagedDisk parameter set
        ///
        /// [GraphQL: azureNativeManagedDisk]
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeManagedDisk",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves an Azure Native Managed Disk that refers to the block storage designed to be used with Azure Virtual Machines. Some examples are: ultra disks, premium solid-state drives (SSD), standard SSDs, and standard hard disk drives (HDD). For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/managed-disks-overview.
[GraphQL: azureNativeManagedDisk]",
            Position = 0
        )]
        public SwitchParameter NativeManagedDisk { get; set; }

        
        /// <summary>
        /// NativeManagedDisks parameter set
        ///
        /// [GraphQL: azureNativeManagedDisks]
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeManagedDisks",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a paginated list of all Azure Native Managed Disks.
[GraphQL: azureNativeManagedDisks]",
            Position = 0
        )]
        public SwitchParameter NativeManagedDisks { get; set; }

        
        /// <summary>
        /// AllNativeVirtualNetworks parameter set
        ///
        /// [GraphQL: allAzureNativeVirtualNetworks]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllNativeVirtualNetworks",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves all virtual networks (VNets) in the protected subscriptions. VNet enables secure communication with other VNets, the internet, and on-premise networks. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/virtual-networks-overview.
[GraphQL: allAzureNativeVirtualNetworks]",
            Position = 0
        )]
        public SwitchParameter AllNativeVirtualNetworks { get; set; }

        
        /// <summary>
        /// AllNativeSubnetsByRegionFromAzure parameter set
        ///
        /// [GraphQL: allAzureNativeSubnetsByRegionFromAzure]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllNativeSubnetsByRegionFromAzure",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves all subnets in the specified region and subscription. Subnets allow you to choose IP address range of your choice. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/network-overview#virtual-network-and-subnets.
[GraphQL: allAzureNativeSubnetsByRegionFromAzure]",
            Position = 0
        )]
        public SwitchParameter AllNativeSubnetsByRegionFromAzure { get; set; }

        
        /// <summary>
        /// AllNativeSecurityGroupsByRegionFromAzure parameter set
        ///
        /// [GraphQL: allAzureNativeSecurityGroupsByRegionFromAzure]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllNativeSecurityGroupsByRegionFromAzure",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves all security groups in the specified region and subscription. Security groups enable you to configure network security as a natural extension of an application's structure, allowing you to group virtual machines and define network security policies based on those groups. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/application-security-groups.
[GraphQL: allAzureNativeSecurityGroupsByRegionFromAzure]",
            Position = 0
        )]
        public SwitchParameter AllNativeSecurityGroupsByRegionFromAzure { get; set; }

        
        /// <summary>
        /// AllDiskEncryptionSetsByRegion parameter set
        ///
        /// [GraphQL: allAzureDiskEncryptionSetsByRegion]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllDiskEncryptionSetsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all Azure Disk Encryption Sets in a region.
[GraphQL: allAzureDiskEncryptionSetsByRegion]",
            Position = 0
        )]
        public SwitchParameter AllDiskEncryptionSetsByRegion { get; set; }

        
        /// <summary>
        /// AllNativeAvailabilitySetsByRegionFromAzure parameter set
        ///
        /// [GraphQL: allAzureNativeAvailabilitySetsByRegionFromAzure]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllNativeAvailabilitySetsByRegionFromAzure",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves all availability sets in the specified region, resource group, and subscription. An availability set is a logical grouping of VMs to facilitate redundancy and availability. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/availability-set-overview.
[GraphQL: allAzureNativeAvailabilitySetsByRegionFromAzure]",
            Position = 0
        )]
        public SwitchParameter AllNativeAvailabilitySetsByRegionFromAzure { get; set; }

        
        /// <summary>
        /// AllNativeExportCompatibleVmSizesByRegionFromAzure parameter set
        ///
        /// [GraphQL: allAzureNativeExportCompatibleVmSizesByRegionFromAzure]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllNativeExportCompatibleVmSizesByRegionFromAzure",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves all supported virtual machine (VM) sizes when exporting a particular snapshot. Not all VM sizes are supported in all the regions. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/sizes.
[GraphQL: allAzureNativeExportCompatibleVmSizesByRegionFromAzure]",
            Position = 0
        )]
        public SwitchParameter AllNativeExportCompatibleVmSizesByRegionFromAzure { get; set; }

        
        /// <summary>
        /// AllNativeExportCompatibleDiskTypesByRegionFromAzure parameter set
        ///
        /// [GraphQL: allAzureNativeExportCompatibleDiskTypesByRegionFromAzure]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllNativeExportCompatibleDiskTypesByRegionFromAzure",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves all supported disk types when exporting a specific snapshot. Not all disk types are supported in all the regions. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/disks-types.
[GraphQL: allAzureNativeExportCompatibleDiskTypesByRegionFromAzure]",
            Position = 0
        )]
        public SwitchParameter AllNativeExportCompatibleDiskTypesByRegionFromAzure { get; set; }

        
        /// <summary>
        /// AllNativeVirtualMachineSizes parameter set
        ///
        /// [GraphQL: allAzureNativeVirtualMachineSizes]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllNativeVirtualMachineSizes",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves all virtual machine (VM) sizes in the subscriptions protected by Rubrik that have been configured for protection. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/sizes.
[GraphQL: allAzureNativeVirtualMachineSizes]",
            Position = 0
        )]
        public SwitchParameter AllNativeVirtualMachineSizes { get; set; }

        
        /// <summary>
        /// IsNativeManagedDiskSnapshotRestorable parameter set
        ///
        /// [GraphQL: isAzureNativeManagedDiskSnapshotRestorable]
        /// </summary>
        [Parameter(
            ParameterSetName = "IsNativeManagedDiskSnapshotRestorable",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Specifies whether the Managed Disk snapshot is restorable or not. A managed disk is restorable when the restore settings of the Managed Disk are configured on the Azure portal and on the Rubrik platform. When the value is true, the managed disk snapshot is restorable.
[GraphQL: isAzureNativeManagedDiskSnapshotRestorable]",
            Position = 0
        )]
        public SwitchParameter IsNativeManagedDiskSnapshotRestorable { get; set; }

        
        /// <summary>
        /// IsStorageAccountNameAvailable parameter set
        ///
        /// [GraphQL: isAzureStorageAccountNameAvailable]
        /// </summary>
        [Parameter(
            ParameterSetName = "IsStorageAccountNameAvailable",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Specifies whether the given storage account name is valid and available in Azure to be assigned to a new storage account. When the value is true, the specified account name is available in Azure.
[GraphQL: isAzureStorageAccountNameAvailable]",
            Position = 0
        )]
        public SwitchParameter IsStorageAccountNameAvailable { get; set; }

        
        /// <summary>
        /// AllNativeStorageAccountsFromAzure parameter set
        ///
        /// [GraphQL: allAzureNativeStorageAccountsFromAzure]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllNativeStorageAccountsFromAzure",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves list of all storage Accounts in a subscription.
[GraphQL: allAzureNativeStorageAccountsFromAzure]",
            Position = 0
        )]
        public SwitchParameter AllNativeStorageAccountsFromAzure { get; set; }

        
        /// <summary>
        /// SqlDatabase parameter set
        ///
        /// [GraphQL: azureSqlDatabase]
        /// </summary>
        [Parameter(
            ParameterSetName = "SqlDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves an Azure SQL Database. Refers to the fully managed SQL database built for the cloud. For more information, see https://azure.microsoft.com/en-us/products/azure-sql/database/.
[GraphQL: azureSqlDatabase]",
            Position = 0
        )]
        public SwitchParameter SqlDatabase { get; set; }

        
        /// <summary>
        /// SqlDatabases parameter set
        ///
        /// [GraphQL: azureSqlDatabases]
        /// </summary>
        [Parameter(
            ParameterSetName = "SqlDatabases",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a paginated list of all Azure SQL Databases.
[GraphQL: azureSqlDatabases]",
            Position = 0
        )]
        public SwitchParameter SqlDatabases { get; set; }

        
        /// <summary>
        /// SqlDatabaseServer parameter set
        ///
        /// [GraphQL: azureSqlDatabaseServer]
        /// </summary>
        [Parameter(
            ParameterSetName = "SqlDatabaseServer",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves an Azure SQL Database Server. Refers to the server that contains the Azure SQL Databases. For more information, see https://docs.microsoft.com/en-us/azure/azure-sql/database/logical-servers.
[GraphQL: azureSqlDatabaseServer]",
            Position = 0
        )]
        public SwitchParameter SqlDatabaseServer { get; set; }

        
        /// <summary>
        /// SqlDatabaseServers parameter set
        ///
        /// [GraphQL: azureSqlDatabaseServers]
        /// </summary>
        [Parameter(
            ParameterSetName = "SqlDatabaseServers",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a paginated list of all Azure SQL Database Servers.
[GraphQL: azureSqlDatabaseServers]",
            Position = 0
        )]
        public SwitchParameter SqlDatabaseServers { get; set; }

        
        /// <summary>
        /// SqlManagedInstanceDatabase parameter set
        ///
        /// [GraphQL: azureSqlManagedInstanceDatabase]
        /// </summary>
        [Parameter(
            ParameterSetName = "SqlManagedInstanceDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves an Azure SQL Managed Instance Database. Refers to the database engine compatible with the latest SQL Server (Enterprise Edition) database engine. For more information, see https://docs.microsoft.com/en-us/azure/azure-sql/managed-instance/sql-managed-instance-paas-overview.
[GraphQL: azureSqlManagedInstanceDatabase]",
            Position = 0
        )]
        public SwitchParameter SqlManagedInstanceDatabase { get; set; }

        
        /// <summary>
        /// SqlManagedInstanceDatabases parameter set
        ///
        /// [GraphQL: azureSqlManagedInstanceDatabases]
        /// </summary>
        [Parameter(
            ParameterSetName = "SqlManagedInstanceDatabases",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a paginated list of all Azure SQL Managed Instance Databases.
[GraphQL: azureSqlManagedInstanceDatabases]",
            Position = 0
        )]
        public SwitchParameter SqlManagedInstanceDatabases { get; set; }

        
        /// <summary>
        /// SqlManagedInstanceServer parameter set
        ///
        /// [GraphQL: azureSqlManagedInstanceServer]
        /// </summary>
        [Parameter(
            ParameterSetName = "SqlManagedInstanceServer",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves an Azure SQL Managed Instance Server. Refers to the server the Azure SQL Managed Instance Database is a part of.
[GraphQL: azureSqlManagedInstanceServer]",
            Position = 0
        )]
        public SwitchParameter SqlManagedInstanceServer { get; set; }

        
        /// <summary>
        /// SqlManagedInstanceServers parameter set
        ///
        /// [GraphQL: azureSqlManagedInstanceServers]
        /// </summary>
        [Parameter(
            ParameterSetName = "SqlManagedInstanceServers",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a paginated list of all Azure SQL Managed Instance Servers.
[GraphQL: azureSqlManagedInstanceServers]",
            Position = 0
        )]
        public SwitchParameter SqlManagedInstanceServers { get; set; }

        
        /// <summary>
        /// SqlDatabaseDbPointInTimeRestoreWindowFromAzure parameter set
        ///
        /// [GraphQL: azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure]
        /// </summary>
        [Parameter(
            ParameterSetName = "SqlDatabaseDbPointInTimeRestoreWindowFromAzure",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Point-in-Time (PiT) restore window of the Azure SQL Database instance in the Azure native account. Refers to the range of time within which the database is available to be restored to a particular point in time. For more information, see https://azure.microsoft.com/en-in/blog/azure-sql-database-point-in-time-restore/.
[GraphQL: azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure]",
            Position = 0
        )]
        public SwitchParameter SqlDatabaseDbPointInTimeRestoreWindowFromAzure { get; set; }

        
        /// <summary>
        /// SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure parameter set
        ///
        /// [GraphQL: azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure]
        /// </summary>
        [Parameter(
            ParameterSetName = "SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Point-in-Time (PiT) restore window of the Azure SQL Managed Instance database in the Azure native account. Refers to the range of time within which the database is available to be restored to a particular point in time. For more information, see https://docs.microsoft.com/en-us/azure/azure-sql/managed-instance/point-in-time-restore?tabs=azure-portal.
[GraphQL: azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure]",
            Position = 0
        )]
        public SwitchParameter SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure { get; set; }

        
        /// <summary>
        /// ValidateNativeSqlDatabaseDbNameForExport parameter set
        ///
        /// [GraphQL: validateAzureNativeSqlDatabaseDbNameForExport]
        /// </summary>
        [Parameter(
            ParameterSetName = "ValidateNativeSqlDatabaseDbNameForExport",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Validates the name used for an Sql Database during an export operation. Returns true if the database name is valid. Returns false, with an error message, if the database name validation fails. Returns false, without an error message for all other failures.
[GraphQL: validateAzureNativeSqlDatabaseDbNameForExport]",
            Position = 0
        )]
        public SwitchParameter ValidateNativeSqlDatabaseDbNameForExport { get; set; }

        
        /// <summary>
        /// ValidateNativeSqlManagedInstanceDbNameForExport parameter set
        ///
        /// [GraphQL: validateAzureNativeSqlManagedInstanceDbNameForExport]
        /// </summary>
        [Parameter(
            ParameterSetName = "ValidateNativeSqlManagedInstanceDbNameForExport",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Validates the name used for an Managed Instance Database during an export operation. Returns true if the database name is valid. Returns false, with an error message, if the database name validation fails. Returns false, without an error message for all other failures.
[GraphQL: validateAzureNativeSqlManagedInstanceDbNameForExport]",
            Position = 0
        )]
        public SwitchParameter ValidateNativeSqlManagedInstanceDbNameForExport { get; set; }

        
        /// <summary>
        /// AllSqlDatabaseServerElasticPools parameter set
        ///
        /// [GraphQL: allAzureSqlDatabaseServerElasticPools]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllSqlDatabaseServerElasticPools",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves the list of elastic pools available for a SQL Database Server.For more information, see https://docs.microsoft.com/en-us/azure/azure-sql/database/elastic-pool-overview.
[GraphQL: allAzureSqlDatabaseServerElasticPools]",
            Position = 0
        )]
        public SwitchParameter AllSqlDatabaseServerElasticPools { get; set; }

        
        /// <summary>
        /// IsNativeSqlDatabaseSnapshotPersistent parameter set
        ///
        /// [GraphQL: isAzureNativeSqlDatabaseSnapshotPersistent]
        /// </summary>
        [Parameter(
            ParameterSetName = "IsNativeSqlDatabaseSnapshotPersistent",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Checks if an Azure SQL Database Snapshot or an Azure SQL Managed Instance Database Snapshot is a persistent snapshot.
[GraphQL: isAzureNativeSqlDatabaseSnapshotPersistent]",
            Position = 0
        )]
        public SwitchParameter IsNativeSqlDatabaseSnapshotPersistent { get; set; }

        
        /// <summary>
        /// AllKeyVaultsByRegion parameter set
        ///
        /// [GraphQL: allAzureKeyVaultsByRegion]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllKeyVaultsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all Azure Key Vaults in a region.
[GraphQL: allAzureKeyVaultsByRegion]",
            Position = 0
        )]
        public SwitchParameter AllKeyVaultsByRegion { get; set; }

        
        /// <summary>
        /// AllEncryptionKeys parameter set
        ///
        /// [GraphQL: allAzureEncryptionKeys]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllEncryptionKeys",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all Encryption Keys in an Azure Key Vault.
[GraphQL: allAzureEncryptionKeys]",
            Position = 0
        )]
        public SwitchParameter AllEncryptionKeys { get; set; }

        
        /// <summary>
        /// CloudAccountTenant parameter set
        ///
        /// [GraphQL: azureCloudAccountTenant]
        /// </summary>
        [Parameter(
            ParameterSetName = "CloudAccountTenant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves the details of the Azure tenant and all the subscriptions of the tenant, for a feature.
[GraphQL: azureCloudAccountTenant]",
            Position = 0
        )]
        public SwitchParameter CloudAccountTenant { get; set; }

        
        /// <summary>
        /// CloudAccountTenantWithExoConfigs parameter set
        ///
        /// [GraphQL: azureCloudAccountTenantWithExoConfigs]
        /// </summary>
        [Parameter(
            ParameterSetName = "CloudAccountTenantWithExoConfigs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves details about the Azure cloud account tenant including the Exocompute configurations for the tenant subscriptions, for a specified feature.
[GraphQL: azureCloudAccountTenantWithExoConfigs]",
            Position = 0
        )]
        public SwitchParameter CloudAccountTenantWithExoConfigs { get; set; }

        
        /// <summary>
        /// AllCloudAccountTenants parameter set
        ///
        /// [GraphQL: allAzureCloudAccountTenants]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllCloudAccountTenants",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list of all the Azure tenants and tenant subscriptions for features. The list can be filtered by feature status, subscription native ID, and subscription name.
[GraphQL: allAzureCloudAccountTenants]",
            Position = 0
        )]
        public SwitchParameter AllCloudAccountTenants { get; set; }

        
        /// <summary>
        /// CloudAccountSubscriptionWithFeatures parameter set
        ///
        /// [GraphQL: azureCloudAccountSubscriptionWithFeatures]
        /// </summary>
        [Parameter(
            ParameterSetName = "CloudAccountSubscriptionWithFeatures",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves the details of the Azure cloud account.
[GraphQL: azureCloudAccountSubscriptionWithFeatures]",
            Position = 0
        )]
        public SwitchParameter CloudAccountSubscriptionWithFeatures { get; set; }

        
        /// <summary>
        /// AllCloudAccountSubscriptionsByFeature parameter set
        ///
        /// [GraphQL: allAzureCloudAccountSubscriptionsByFeature]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllCloudAccountSubscriptionsByFeature",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list of all Azure Subscriptions with feature details such as feature, status, and regions.
[GraphQL: allAzureCloudAccountSubscriptionsByFeature]",
            Position = 0
        )]
        public SwitchParameter AllCloudAccountSubscriptionsByFeature { get; set; }

        
        /// <summary>
        /// AllSubscriptionWithExocomputeMappings parameter set
        ///
        /// [GraphQL: allAzureSubscriptionWithExocomputeMappings]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllSubscriptionWithExocomputeMappings",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list of all Azure subscriptions with Exocompute subscription mapping.
[GraphQL: allAzureSubscriptionWithExocomputeMappings]",
            Position = 0
        )]
        public SwitchParameter AllSubscriptionWithExocomputeMappings { get; set; }

        
        /// <summary>
        /// AllResourceGroupsFrom parameter set
        ///
        /// [GraphQL: allResourceGroupsFromAzure]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllResourceGroupsFrom",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list og all resource groups in the specified account.
[GraphQL: allResourceGroupsFromAzure]",
            Position = 0
        )]
        public SwitchParameter AllResourceGroupsFrom { get; set; }

        
        /// <summary>
        /// DoesNativeResourceGroupExist parameter set
        ///
        /// [GraphQL: doesAzureNativeResourceGroupExist]
        /// </summary>
        [Parameter(
            ParameterSetName = "DoesNativeResourceGroupExist",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Checks if a resource group with the specified name exists in the specified account.
[GraphQL: doesAzureNativeResourceGroupExist]",
            Position = 0
        )]
        public SwitchParameter DoesNativeResourceGroupExist { get; set; }

        
        /// <summary>
        /// AllNativeResourceGroupsInfoIfExist parameter set
        ///
        /// [GraphQL: allAzureNativeResourceGroupsInfoIfExist]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllNativeResourceGroupsInfoIfExist",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list of resource groups with the specified names which exist in the specified account.
[GraphQL: allAzureNativeResourceGroupsInfoIfExist]",
            Position = 0
        )]
        public SwitchParameter AllNativeResourceGroupsInfoIfExist { get; set; }

        
        /// <summary>
        /// AllCloudAccountMissingPermissions parameter set
        ///
        /// [GraphQL: allAzureCloudAccountMissingPermissions]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllCloudAccountMissingPermissions",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list of all the missing permissions on Azure subscriptions that are a part of the Azure Cloud Account.
[GraphQL: allAzureCloudAccountMissingPermissions]",
            Position = 0
        )]
        public SwitchParameter AllCloudAccountMissingPermissions { get; set; }

        
        /// <summary>
        /// CloudAccountPermissionConfig parameter set
        ///
        /// [GraphQL: azureCloudAccountPermissionConfig]
        /// </summary>
        [Parameter(
            ParameterSetName = "CloudAccountPermissionConfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves the configuration consisting of role permissions and feature policy version required for Azure subscription setup. Features refer to the Polaris features that the customer wants to be enabled on the cloud account.
[GraphQL: azureCloudAccountPermissionConfig]",
            Position = 0
        )]
        public SwitchParameter CloudAccountPermissionConfig { get; set; }

        
        /// <summary>
        /// AllExocomputeConfigsInAccount parameter set
        ///
        /// [GraphQL: allAzureExocomputeConfigsInAccount]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllExocomputeConfigsInAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list of Azure Exocompute configurations filtered by a cloud account ID or a search query.
[GraphQL: allAzureExocomputeConfigsInAccount]",
            Position = 0
        )]
        public SwitchParameter AllExocomputeConfigsInAccount { get; set; }

        
        /// <summary>
        /// AllCloudAccountSubnetsByRegion parameter set
        ///
        /// [GraphQL: allAzureCloudAccountSubnetsByRegion]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllCloudAccountSubnetsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves all subnets in the specified region and subscription. Subnets allow you to choose IP address range of your choice. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/network-overview#virtual-network-and-subnets.
[GraphQL: allAzureCloudAccountSubnetsByRegion]",
            Position = 0
        )]
        public SwitchParameter AllCloudAccountSubnetsByRegion { get; set; }

        
        /// <summary>
        /// ValidateCloudAccountExocomputeConfigurations parameter set
        ///
        /// [GraphQL: validateAzureCloudAccountExocomputeConfigurations]
        /// </summary>
        [Parameter(
            ParameterSetName = "ValidateCloudAccountExocomputeConfigurations",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Validates if Azure subnets are correctly configured for running Azure Kubernetes Service (AKS) Clusters. When correctly configured, the Azure subnets allow the required region-specific outbound connectivity and do not overlap with Azure restricted IP Address Space.
[GraphQL: validateAzureCloudAccountExocomputeConfigurations]",
            Position = 0
        )]
        public SwitchParameter ValidateCloudAccountExocomputeConfigurations { get; set; }

        
        /// <summary>
        /// AllArmTemplatesByFeature parameter set
        ///
        /// [GraphQL: allAzureArmTemplatesByFeature]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllArmTemplatesByFeature",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieve ARM templates for role definition and role assignment.
[GraphQL: allAzureArmTemplatesByFeature]",
            Position = 0
        )]
        public SwitchParameter AllArmTemplatesByFeature { get; set; }

        
        /// <summary>
        /// CheckPersistentStorageSubscriptionCanUnmap parameter set
        ///
        /// [GraphQL: checkAzurePersistentStorageSubscriptionCanUnmap]
        /// </summary>
        [Parameter(
            ParameterSetName = "CheckPersistentStorageSubscriptionCanUnmap",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Checks if we can unmap the archival location from the subscription.
[GraphQL: checkAzurePersistentStorageSubscriptionCanUnmap]",
            Position = 0
        )]
        public SwitchParameter CheckPersistentStorageSubscriptionCanUnmap { get; set; }

        
        /// <summary>
        /// Subscriptions parameter set
        ///
        /// [GraphQL: azureSubscriptions]
        /// </summary>
        [Parameter(
            ParameterSetName = "Subscriptions",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Gets the subscriptions for the given Azure tenant.
[GraphQL: azureSubscriptions]",
            Position = 0
        )]
        public SwitchParameter Subscriptions { get; set; }

        
        /// <summary>
        /// Regions parameter set
        ///
        /// [GraphQL: azureRegions]
        /// </summary>
        [Parameter(
            ParameterSetName = "Regions",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Gets the Azure regions for the given subscription.
[GraphQL: azureRegions]",
            Position = 0
        )]
        public SwitchParameter Regions { get; set; }

        
        /// <summary>
        /// ResourceGroups parameter set
        ///
        /// [GraphQL: azureResourceGroups]
        /// </summary>
        [Parameter(
            ParameterSetName = "ResourceGroups",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Gets the Azure resource groups for the given subscription.
[GraphQL: azureResourceGroups]",
            Position = 0
        )]
        public SwitchParameter ResourceGroups { get; set; }

        
        /// <summary>
        /// VNets parameter set
        ///
        /// [GraphQL: azureVNets]
        /// </summary>
        [Parameter(
            ParameterSetName = "VNets",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Gets the VNets for the given subscription.
[GraphQL: azureVNets]",
            Position = 0
        )]
        public SwitchParameter VNets { get; set; }

        
        /// <summary>
        /// Subnets parameter set
        ///
        /// [GraphQL: azureSubnets]
        /// </summary>
        [Parameter(
            ParameterSetName = "Subnets",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Gets the subnets for the given subscription.
[GraphQL: azureSubnets]",
            Position = 0
        )]
        public SwitchParameter Subnets { get; set; }

        
        /// <summary>
        /// StorageAccounts parameter set
        ///
        /// [GraphQL: azureStorageAccounts]
        /// </summary>
        [Parameter(
            ParameterSetName = "StorageAccounts",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Gets the storage accounts for the given subscription.
[GraphQL: azureStorageAccounts]",
            Position = 0
        )]
        public SwitchParameter StorageAccounts { get; set; }

        
        /// <summary>
        /// AllHostedRegions parameter set
        ///
        /// [GraphQL: allHostedAzureRegions]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllHostedRegions",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Lists all Azure regions supported by the Rubrik-Hosted SaaS protection.
[GraphQL: allHostedAzureRegions]",
            Position = 0
        )]
        public SwitchParameter AllHostedRegions { get; set; }

        
        /// <summary>
        /// AllResourceGroups parameter set
        ///
        /// [GraphQL: allAzureResourceGroups]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllResourceGroups",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get resource groups for a service principal in Azure.
[GraphQL: allAzureResourceGroups]",
            Position = 0
        )]
        public SwitchParameter AllResourceGroups { get; set; }

        
        /// <summary>
        /// AllVnets parameter set
        ///
        /// [GraphQL: allAzureVnets]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllVnets",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get VNets for a given account in Azure.
[GraphQL: allAzureVnets]",
            Position = 0
        )]
        public SwitchParameter AllVnets { get; set; }

        
        /// <summary>
        /// AllSubnets parameter set
        ///
        /// [GraphQL: allAzureSubnets]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllSubnets",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get subnets for a given account in Azure.
[GraphQL: allAzureSubnets]",
            Position = 0
        )]
        public SwitchParameter AllSubnets { get; set; }

        
        /// <summary>
        /// AllCdmVersions parameter set
        ///
        /// [GraphQL: allAzureCdmVersions]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllCdmVersions",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get all Rubrik CDM versions in the Azure marketplace.
[GraphQL: allAzureCdmVersions]",
            Position = 0
        )]
        public SwitchParameter AllCdmVersions { get; set; }

        
        /// <summary>
        /// AllRegions parameter set
        ///
        /// [GraphQL: allAzureRegions]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllRegions",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get all available regions for Azure.
[GraphQL: allAzureRegions]",
            Position = 0
        )]
        public SwitchParameter AllRegions { get; set; }

        
        /// <summary>
        /// AllNsgs parameter set
        ///
        /// [GraphQL: allAzureNsgs]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllNsgs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get all available network security groups for Azure.
[GraphQL: allAzureNsgs]",
            Position = 0
        )]
        public SwitchParameter AllNsgs { get; set; }

        
        /// <summary>
        /// AllStorageAccounts parameter set
        ///
        /// [GraphQL: allAzureStorageAccounts]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllStorageAccounts",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List all storage accounts from Azure.
[GraphQL: allAzureStorageAccounts]",
            Position = 0
        )]
        public SwitchParameter AllStorageAccounts { get; set; }

        
        /// <summary>
        /// AllManagedIdentities parameter set
        ///
        /// [GraphQL: allAzureManagedIdentities]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllManagedIdentities",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List all managed identities for Azure resources.
[GraphQL: allAzureManagedIdentities]",
            Position = 0
        )]
        public SwitchParameter AllManagedIdentities { get; set; }

        
        /// <summary>
        /// AdDirectories parameter set
        ///
        /// [GraphQL: azureAdDirectories]
        /// </summary>
        [Parameter(
            ParameterSetName = "AdDirectories",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Lists all Azure AD directories for the account.
[GraphQL: azureAdDirectories]",
            Position = 0
        )]
        public SwitchParameter AdDirectories { get; set; }

        
        /// <summary>
        /// AdDirectory parameter set
        ///
        /// [GraphQL: azureAdDirectory]
        /// </summary>
        [Parameter(
            ParameterSetName = "AdDirectory",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details of the Azure AD corresponding to the workload ID.
[GraphQL: azureAdDirectory]",
            Position = 0
        )]
        public SwitchParameter AdDirectory { get; set; }

        
        /// <summary>
        /// AdObjectsByType parameter set
        ///
        /// [GraphQL: azureAdObjectsByType]
        /// </summary>
        [Parameter(
            ParameterSetName = "AdObjectsByType",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details of the Azure AD objects corresponding to the type.
[GraphQL: azureAdObjectsByType]",
            Position = 0
        )]
        public SwitchParameter AdObjectsByType { get; set; }

        
        /// <summary>
        /// SearchAdSnapshot parameter set
        ///
        /// [GraphQL: searchAzureAdSnapshot]
        /// </summary>
        [Parameter(
            ParameterSetName = "SearchAdSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Search for azureAdObjects in a snapshot.
[GraphQL: searchAzureAdSnapshot]",
            Position = 0
        )]
        public SwitchParameter SearchAdSnapshot { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(Op)
                {
                    case "NativeRoot":
                        this.ProcessRecord_NativeRoot();
                        break;
                    case "NativeSubscription":
                        this.ProcessRecord_NativeSubscription();
                        break;
                    case "NativeSubscriptions":
                        this.ProcessRecord_NativeSubscriptions();
                        break;
                    case "NativeResourceGroup":
                        this.ProcessRecord_NativeResourceGroup();
                        break;
                    case "NativeResourceGroups":
                        this.ProcessRecord_NativeResourceGroups();
                        break;
                    case "NativeVirtualMachine":
                        this.ProcessRecord_NativeVirtualMachine();
                        break;
                    case "NativeVirtualMachines":
                        this.ProcessRecord_NativeVirtualMachines();
                        break;
                    case "NativeManagedDisk":
                        this.ProcessRecord_NativeManagedDisk();
                        break;
                    case "NativeManagedDisks":
                        this.ProcessRecord_NativeManagedDisks();
                        break;
                    case "AllNativeVirtualNetworks":
                        this.ProcessRecord_AllNativeVirtualNetworks();
                        break;
                    case "AllNativeSubnetsByRegionFromAzure":
                        this.ProcessRecord_AllNativeSubnetsByRegionFromAzure();
                        break;
                    case "AllNativeSecurityGroupsByRegionFromAzure":
                        this.ProcessRecord_AllNativeSecurityGroupsByRegionFromAzure();
                        break;
                    case "AllDiskEncryptionSetsByRegion":
                        this.ProcessRecord_AllDiskEncryptionSetsByRegion();
                        break;
                    case "AllNativeAvailabilitySetsByRegionFromAzure":
                        this.ProcessRecord_AllNativeAvailabilitySetsByRegionFromAzure();
                        break;
                    case "AllNativeExportCompatibleVmSizesByRegionFromAzure":
                        this.ProcessRecord_AllNativeExportCompatibleVmSizesByRegionFromAzure();
                        break;
                    case "AllNativeExportCompatibleDiskTypesByRegionFromAzure":
                        this.ProcessRecord_AllNativeExportCompatibleDiskTypesByRegionFromAzure();
                        break;
                    case "AllNativeVirtualMachineSizes":
                        this.ProcessRecord_AllNativeVirtualMachineSizes();
                        break;
                    case "IsNativeManagedDiskSnapshotRestorable":
                        this.ProcessRecord_IsNativeManagedDiskSnapshotRestorable();
                        break;
                    case "IsStorageAccountNameAvailable":
                        this.ProcessRecord_IsStorageAccountNameAvailable();
                        break;
                    case "AllNativeStorageAccountsFromAzure":
                        this.ProcessRecord_AllNativeStorageAccountsFromAzure();
                        break;
                    case "SqlDatabase":
                        this.ProcessRecord_SqlDatabase();
                        break;
                    case "SqlDatabases":
                        this.ProcessRecord_SqlDatabases();
                        break;
                    case "SqlDatabaseServer":
                        this.ProcessRecord_SqlDatabaseServer();
                        break;
                    case "SqlDatabaseServers":
                        this.ProcessRecord_SqlDatabaseServers();
                        break;
                    case "SqlManagedInstanceDatabase":
                        this.ProcessRecord_SqlManagedInstanceDatabase();
                        break;
                    case "SqlManagedInstanceDatabases":
                        this.ProcessRecord_SqlManagedInstanceDatabases();
                        break;
                    case "SqlManagedInstanceServer":
                        this.ProcessRecord_SqlManagedInstanceServer();
                        break;
                    case "SqlManagedInstanceServers":
                        this.ProcessRecord_SqlManagedInstanceServers();
                        break;
                    case "SqlDatabaseDbPointInTimeRestoreWindowFromAzure":
                        this.ProcessRecord_SqlDatabaseDbPointInTimeRestoreWindowFromAzure();
                        break;
                    case "SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure":
                        this.ProcessRecord_SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure();
                        break;
                    case "ValidateNativeSqlDatabaseDbNameForExport":
                        this.ProcessRecord_ValidateNativeSqlDatabaseDbNameForExport();
                        break;
                    case "ValidateNativeSqlManagedInstanceDbNameForExport":
                        this.ProcessRecord_ValidateNativeSqlManagedInstanceDbNameForExport();
                        break;
                    case "AllSqlDatabaseServerElasticPools":
                        this.ProcessRecord_AllSqlDatabaseServerElasticPools();
                        break;
                    case "IsNativeSqlDatabaseSnapshotPersistent":
                        this.ProcessRecord_IsNativeSqlDatabaseSnapshotPersistent();
                        break;
                    case "AllKeyVaultsByRegion":
                        this.ProcessRecord_AllKeyVaultsByRegion();
                        break;
                    case "AllEncryptionKeys":
                        this.ProcessRecord_AllEncryptionKeys();
                        break;
                    case "CloudAccountTenant":
                        this.ProcessRecord_CloudAccountTenant();
                        break;
                    case "CloudAccountTenantWithExoConfigs":
                        this.ProcessRecord_CloudAccountTenantWithExoConfigs();
                        break;
                    case "AllCloudAccountTenants":
                        this.ProcessRecord_AllCloudAccountTenants();
                        break;
                    case "CloudAccountSubscriptionWithFeatures":
                        this.ProcessRecord_CloudAccountSubscriptionWithFeatures();
                        break;
                    case "AllCloudAccountSubscriptionsByFeature":
                        this.ProcessRecord_AllCloudAccountSubscriptionsByFeature();
                        break;
                    case "AllSubscriptionWithExocomputeMappings":
                        this.ProcessRecord_AllSubscriptionWithExocomputeMappings();
                        break;
                    case "AllResourceGroupsFrom":
                        this.ProcessRecord_AllResourceGroupsFrom();
                        break;
                    case "DoesNativeResourceGroupExist":
                        this.ProcessRecord_DoesNativeResourceGroupExist();
                        break;
                    case "AllNativeResourceGroupsInfoIfExist":
                        this.ProcessRecord_AllNativeResourceGroupsInfoIfExist();
                        break;
                    case "AllCloudAccountMissingPermissions":
                        this.ProcessRecord_AllCloudAccountMissingPermissions();
                        break;
                    case "CloudAccountPermissionConfig":
                        this.ProcessRecord_CloudAccountPermissionConfig();
                        break;
                    case "AllExocomputeConfigsInAccount":
                        this.ProcessRecord_AllExocomputeConfigsInAccount();
                        break;
                    case "AllCloudAccountSubnetsByRegion":
                        this.ProcessRecord_AllCloudAccountSubnetsByRegion();
                        break;
                    case "ValidateCloudAccountExocomputeConfigurations":
                        this.ProcessRecord_ValidateCloudAccountExocomputeConfigurations();
                        break;
                    case "AllArmTemplatesByFeature":
                        this.ProcessRecord_AllArmTemplatesByFeature();
                        break;
                    case "CheckPersistentStorageSubscriptionCanUnmap":
                        this.ProcessRecord_CheckPersistentStorageSubscriptionCanUnmap();
                        break;
                    case "Subscriptions":
                        this.ProcessRecord_Subscriptions();
                        break;
                    case "Regions":
                        this.ProcessRecord_Regions();
                        break;
                    case "ResourceGroups":
                        this.ProcessRecord_ResourceGroups();
                        break;
                    case "VNets":
                        this.ProcessRecord_VNets();
                        break;
                    case "Subnets":
                        this.ProcessRecord_Subnets();
                        break;
                    case "StorageAccounts":
                        this.ProcessRecord_StorageAccounts();
                        break;
                    case "AllHostedRegions":
                        this.ProcessRecord_AllHostedRegions();
                        break;
                    case "AllResourceGroups":
                        this.ProcessRecord_AllResourceGroups();
                        break;
                    case "AllVnets":
                        this.ProcessRecord_AllVnets();
                        break;
                    case "AllSubnets":
                        this.ProcessRecord_AllSubnets();
                        break;
                    case "AllCdmVersions":
                        this.ProcessRecord_AllCdmVersions();
                        break;
                    case "AllRegions":
                        this.ProcessRecord_AllRegions();
                        break;
                    case "AllNsgs":
                        this.ProcessRecord_AllNsgs();
                        break;
                    case "AllStorageAccounts":
                        this.ProcessRecord_AllStorageAccounts();
                        break;
                    case "AllManagedIdentities":
                        this.ProcessRecord_AllManagedIdentities();
                        break;
                    case "AdDirectories":
                        this.ProcessRecord_AdDirectories();
                        break;
                    case "AdDirectory":
                        this.ProcessRecord_AdDirectory();
                        break;
                    case "AdObjectsByType":
                        this.ProcessRecord_AdObjectsByType();
                        break;
                    case "SearchAdSnapshot":
                        this.ProcessRecord_SearchAdSnapshot();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + Op);
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
        }
#pragma warning restore 1591

        // This parameter set invokes a single graphql operation:
        // azureNativeRoot.
        internal void ProcessRecord_NativeRoot()
        {
            this._logger.name += " -NativeRoot";
            // Create new graphql operation azureNativeRoot
            InitQueryAzureNativeRoot();
        }

        // This parameter set invokes a single graphql operation:
        // azureNativeSubscription.
        internal void ProcessRecord_NativeSubscription()
        {
            this._logger.name += " -NativeSubscription";
            // Create new graphql operation azureNativeSubscription
            InitQueryAzureNativeSubscription();
        }

        // This parameter set invokes a single graphql operation:
        // azureNativeSubscriptions.
        internal void ProcessRecord_NativeSubscriptions()
        {
            this._logger.name += " -NativeSubscriptions";
            // Create new graphql operation azureNativeSubscriptions
            InitQueryAzureNativeSubscriptions();
        }

        // This parameter set invokes a single graphql operation:
        // azureNativeResourceGroup.
        internal void ProcessRecord_NativeResourceGroup()
        {
            this._logger.name += " -NativeResourceGroup";
            // Create new graphql operation azureNativeResourceGroup
            InitQueryAzureNativeResourceGroup();
        }

        // This parameter set invokes a single graphql operation:
        // azureNativeResourceGroups.
        internal void ProcessRecord_NativeResourceGroups()
        {
            this._logger.name += " -NativeResourceGroups";
            // Create new graphql operation azureNativeResourceGroups
            InitQueryAzureNativeResourceGroups();
        }

        // This parameter set invokes a single graphql operation:
        // azureNativeVirtualMachine.
        internal void ProcessRecord_NativeVirtualMachine()
        {
            this._logger.name += " -NativeVirtualMachine";
            // Create new graphql operation azureNativeVirtualMachine
            InitQueryAzureNativeVirtualMachine();
        }

        // This parameter set invokes a single graphql operation:
        // azureNativeVirtualMachines.
        internal void ProcessRecord_NativeVirtualMachines()
        {
            this._logger.name += " -NativeVirtualMachines";
            // Create new graphql operation azureNativeVirtualMachines
            InitQueryAzureNativeVirtualMachines();
        }

        // This parameter set invokes a single graphql operation:
        // azureNativeManagedDisk.
        internal void ProcessRecord_NativeManagedDisk()
        {
            this._logger.name += " -NativeManagedDisk";
            // Create new graphql operation azureNativeManagedDisk
            InitQueryAzureNativeManagedDisk();
        }

        // This parameter set invokes a single graphql operation:
        // azureNativeManagedDisks.
        internal void ProcessRecord_NativeManagedDisks()
        {
            this._logger.name += " -NativeManagedDisks";
            // Create new graphql operation azureNativeManagedDisks
            InitQueryAzureNativeManagedDisks();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeVirtualNetworks.
        internal void ProcessRecord_AllNativeVirtualNetworks()
        {
            this._logger.name += " -AllNativeVirtualNetworks";
            // Create new graphql operation allAzureNativeVirtualNetworks
            InitQueryAllAzureNativeVirtualNetworks();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeSubnetsByRegionFromAzure.
        internal void ProcessRecord_AllNativeSubnetsByRegionFromAzure()
        {
            this._logger.name += " -AllNativeSubnetsByRegionFromAzure";
            // Create new graphql operation allAzureNativeSubnetsByRegionFromAzure
            InitQueryAllAzureNativeSubnetsByRegionFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeSecurityGroupsByRegionFromAzure.
        internal void ProcessRecord_AllNativeSecurityGroupsByRegionFromAzure()
        {
            this._logger.name += " -AllNativeSecurityGroupsByRegionFromAzure";
            // Create new graphql operation allAzureNativeSecurityGroupsByRegionFromAzure
            InitQueryAllAzureNativeSecurityGroupsByRegionFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureDiskEncryptionSetsByRegion.
        internal void ProcessRecord_AllDiskEncryptionSetsByRegion()
        {
            this._logger.name += " -AllDiskEncryptionSetsByRegion";
            // Create new graphql operation allAzureDiskEncryptionSetsByRegion
            InitQueryAllAzureDiskEncryptionSetsByRegion();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeAvailabilitySetsByRegionFromAzure.
        internal void ProcessRecord_AllNativeAvailabilitySetsByRegionFromAzure()
        {
            this._logger.name += " -AllNativeAvailabilitySetsByRegionFromAzure";
            // Create new graphql operation allAzureNativeAvailabilitySetsByRegionFromAzure
            InitQueryAllAzureNativeAvailabilitySetsByRegionFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeExportCompatibleVmSizesByRegionFromAzure.
        internal void ProcessRecord_AllNativeExportCompatibleVmSizesByRegionFromAzure()
        {
            this._logger.name += " -AllNativeExportCompatibleVmSizesByRegionFromAzure";
            // Create new graphql operation allAzureNativeExportCompatibleVmSizesByRegionFromAzure
            InitQueryAllAzureNativeExportCompatibleVmSizesByRegionFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeExportCompatibleDiskTypesByRegionFromAzure.
        internal void ProcessRecord_AllNativeExportCompatibleDiskTypesByRegionFromAzure()
        {
            this._logger.name += " -AllNativeExportCompatibleDiskTypesByRegionFromAzure";
            // Create new graphql operation allAzureNativeExportCompatibleDiskTypesByRegionFromAzure
            InitQueryAllAzureNativeExportCompatibleDiskTypesByRegionFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeVirtualMachineSizes.
        internal void ProcessRecord_AllNativeVirtualMachineSizes()
        {
            this._logger.name += " -AllNativeVirtualMachineSizes";
            // Create new graphql operation allAzureNativeVirtualMachineSizes
            InitQueryAllAzureNativeVirtualMachineSizes();
        }

        // This parameter set invokes a single graphql operation:
        // isAzureNativeManagedDiskSnapshotRestorable.
        internal void ProcessRecord_IsNativeManagedDiskSnapshotRestorable()
        {
            this._logger.name += " -IsNativeManagedDiskSnapshotRestorable";
            // Create new graphql operation isAzureNativeManagedDiskSnapshotRestorable
            InitQueryIsAzureNativeManagedDiskSnapshotRestorable();
        }

        // This parameter set invokes a single graphql operation:
        // isAzureStorageAccountNameAvailable.
        internal void ProcessRecord_IsStorageAccountNameAvailable()
        {
            this._logger.name += " -IsStorageAccountNameAvailable";
            // Create new graphql operation isAzureStorageAccountNameAvailable
            InitQueryIsAzureStorageAccountNameAvailable();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeStorageAccountsFromAzure.
        internal void ProcessRecord_AllNativeStorageAccountsFromAzure()
        {
            this._logger.name += " -AllNativeStorageAccountsFromAzure";
            // Create new graphql operation allAzureNativeStorageAccountsFromAzure
            InitQueryAllAzureNativeStorageAccountsFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlDatabase.
        internal void ProcessRecord_SqlDatabase()
        {
            this._logger.name += " -SqlDatabase";
            // Create new graphql operation azureSqlDatabase
            InitQueryAzureSqlDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlDatabases.
        internal void ProcessRecord_SqlDatabases()
        {
            this._logger.name += " -SqlDatabases";
            // Create new graphql operation azureSqlDatabases
            InitQueryAzureSqlDatabases();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlDatabaseServer.
        internal void ProcessRecord_SqlDatabaseServer()
        {
            this._logger.name += " -SqlDatabaseServer";
            // Create new graphql operation azureSqlDatabaseServer
            InitQueryAzureSqlDatabaseServer();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlDatabaseServers.
        internal void ProcessRecord_SqlDatabaseServers()
        {
            this._logger.name += " -SqlDatabaseServers";
            // Create new graphql operation azureSqlDatabaseServers
            InitQueryAzureSqlDatabaseServers();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlManagedInstanceDatabase.
        internal void ProcessRecord_SqlManagedInstanceDatabase()
        {
            this._logger.name += " -SqlManagedInstanceDatabase";
            // Create new graphql operation azureSqlManagedInstanceDatabase
            InitQueryAzureSqlManagedInstanceDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlManagedInstanceDatabases.
        internal void ProcessRecord_SqlManagedInstanceDatabases()
        {
            this._logger.name += " -SqlManagedInstanceDatabases";
            // Create new graphql operation azureSqlManagedInstanceDatabases
            InitQueryAzureSqlManagedInstanceDatabases();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlManagedInstanceServer.
        internal void ProcessRecord_SqlManagedInstanceServer()
        {
            this._logger.name += " -SqlManagedInstanceServer";
            // Create new graphql operation azureSqlManagedInstanceServer
            InitQueryAzureSqlManagedInstanceServer();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlManagedInstanceServers.
        internal void ProcessRecord_SqlManagedInstanceServers()
        {
            this._logger.name += " -SqlManagedInstanceServers";
            // Create new graphql operation azureSqlManagedInstanceServers
            InitQueryAzureSqlManagedInstanceServers();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure.
        internal void ProcessRecord_SqlDatabaseDbPointInTimeRestoreWindowFromAzure()
        {
            this._logger.name += " -SqlDatabaseDbPointInTimeRestoreWindowFromAzure";
            // Create new graphql operation azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure
            InitQueryAzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure.
        internal void ProcessRecord_SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure()
        {
            this._logger.name += " -SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure";
            // Create new graphql operation azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure
            InitQueryAzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // validateAzureNativeSqlDatabaseDbNameForExport.
        internal void ProcessRecord_ValidateNativeSqlDatabaseDbNameForExport()
        {
            this._logger.name += " -ValidateNativeSqlDatabaseDbNameForExport";
            // Create new graphql operation validateAzureNativeSqlDatabaseDbNameForExport
            InitQueryValidateAzureNativeSqlDatabaseDbNameForExport();
        }

        // This parameter set invokes a single graphql operation:
        // validateAzureNativeSqlManagedInstanceDbNameForExport.
        internal void ProcessRecord_ValidateNativeSqlManagedInstanceDbNameForExport()
        {
            this._logger.name += " -ValidateNativeSqlManagedInstanceDbNameForExport";
            // Create new graphql operation validateAzureNativeSqlManagedInstanceDbNameForExport
            InitQueryValidateAzureNativeSqlManagedInstanceDbNameForExport();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureSqlDatabaseServerElasticPools.
        internal void ProcessRecord_AllSqlDatabaseServerElasticPools()
        {
            this._logger.name += " -AllSqlDatabaseServerElasticPools";
            // Create new graphql operation allAzureSqlDatabaseServerElasticPools
            InitQueryAllAzureSqlDatabaseServerElasticPools();
        }

        // This parameter set invokes a single graphql operation:
        // isAzureNativeSqlDatabaseSnapshotPersistent.
        internal void ProcessRecord_IsNativeSqlDatabaseSnapshotPersistent()
        {
            this._logger.name += " -IsNativeSqlDatabaseSnapshotPersistent";
            // Create new graphql operation isAzureNativeSqlDatabaseSnapshotPersistent
            InitQueryIsAzureNativeSqlDatabaseSnapshotPersistent();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureKeyVaultsByRegion.
        internal void ProcessRecord_AllKeyVaultsByRegion()
        {
            this._logger.name += " -AllKeyVaultsByRegion";
            // Create new graphql operation allAzureKeyVaultsByRegion
            InitQueryAllAzureKeyVaultsByRegion();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureEncryptionKeys.
        internal void ProcessRecord_AllEncryptionKeys()
        {
            this._logger.name += " -AllEncryptionKeys";
            // Create new graphql operation allAzureEncryptionKeys
            InitQueryAllAzureEncryptionKeys();
        }

        // This parameter set invokes a single graphql operation:
        // azureCloudAccountTenant.
        internal void ProcessRecord_CloudAccountTenant()
        {
            this._logger.name += " -CloudAccountTenant";
            // Create new graphql operation azureCloudAccountTenant
            InitQueryAzureCloudAccountTenant();
        }

        // This parameter set invokes a single graphql operation:
        // azureCloudAccountTenantWithExoConfigs.
        internal void ProcessRecord_CloudAccountTenantWithExoConfigs()
        {
            this._logger.name += " -CloudAccountTenantWithExoConfigs";
            // Create new graphql operation azureCloudAccountTenantWithExoConfigs
            InitQueryAzureCloudAccountTenantWithExoConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureCloudAccountTenants.
        internal void ProcessRecord_AllCloudAccountTenants()
        {
            this._logger.name += " -AllCloudAccountTenants";
            // Create new graphql operation allAzureCloudAccountTenants
            InitQueryAllAzureCloudAccountTenants();
        }

        // This parameter set invokes a single graphql operation:
        // azureCloudAccountSubscriptionWithFeatures.
        internal void ProcessRecord_CloudAccountSubscriptionWithFeatures()
        {
            this._logger.name += " -CloudAccountSubscriptionWithFeatures";
            // Create new graphql operation azureCloudAccountSubscriptionWithFeatures
            InitQueryAzureCloudAccountSubscriptionWithFeatures();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureCloudAccountSubscriptionsByFeature.
        internal void ProcessRecord_AllCloudAccountSubscriptionsByFeature()
        {
            this._logger.name += " -AllCloudAccountSubscriptionsByFeature";
            // Create new graphql operation allAzureCloudAccountSubscriptionsByFeature
            InitQueryAllAzureCloudAccountSubscriptionsByFeature();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureSubscriptionWithExocomputeMappings.
        internal void ProcessRecord_AllSubscriptionWithExocomputeMappings()
        {
            this._logger.name += " -AllSubscriptionWithExocomputeMappings";
            // Create new graphql operation allAzureSubscriptionWithExocomputeMappings
            InitQueryAllAzureSubscriptionWithExocomputeMappings();
        }

        // This parameter set invokes a single graphql operation:
        // allResourceGroupsFromAzure.
        internal void ProcessRecord_AllResourceGroupsFrom()
        {
            this._logger.name += " -AllResourceGroupsFrom";
            // Create new graphql operation allResourceGroupsFromAzure
            InitQueryAllResourceGroupsFromAzure();
        }

        // This parameter set invokes a single graphql operation:
        // doesAzureNativeResourceGroupExist.
        internal void ProcessRecord_DoesNativeResourceGroupExist()
        {
            this._logger.name += " -DoesNativeResourceGroupExist";
            // Create new graphql operation doesAzureNativeResourceGroupExist
            InitQueryDoesAzureNativeResourceGroupExist();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNativeResourceGroupsInfoIfExist.
        internal void ProcessRecord_AllNativeResourceGroupsInfoIfExist()
        {
            this._logger.name += " -AllNativeResourceGroupsInfoIfExist";
            // Create new graphql operation allAzureNativeResourceGroupsInfoIfExist
            InitQueryAllAzureNativeResourceGroupsInfoIfExist();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureCloudAccountMissingPermissions.
        internal void ProcessRecord_AllCloudAccountMissingPermissions()
        {
            this._logger.name += " -AllCloudAccountMissingPermissions";
            // Create new graphql operation allAzureCloudAccountMissingPermissions
            InitQueryAllAzureCloudAccountMissingPermissions();
        }

        // This parameter set invokes a single graphql operation:
        // azureCloudAccountPermissionConfig.
        internal void ProcessRecord_CloudAccountPermissionConfig()
        {
            this._logger.name += " -CloudAccountPermissionConfig";
            // Create new graphql operation azureCloudAccountPermissionConfig
            InitQueryAzureCloudAccountPermissionConfig();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureExocomputeConfigsInAccount.
        internal void ProcessRecord_AllExocomputeConfigsInAccount()
        {
            this._logger.name += " -AllExocomputeConfigsInAccount";
            // Create new graphql operation allAzureExocomputeConfigsInAccount
            InitQueryAllAzureExocomputeConfigsInAccount();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureCloudAccountSubnetsByRegion.
        internal void ProcessRecord_AllCloudAccountSubnetsByRegion()
        {
            this._logger.name += " -AllCloudAccountSubnetsByRegion";
            // Create new graphql operation allAzureCloudAccountSubnetsByRegion
            InitQueryAllAzureCloudAccountSubnetsByRegion();
        }

        // This parameter set invokes a single graphql operation:
        // validateAzureCloudAccountExocomputeConfigurations.
        internal void ProcessRecord_ValidateCloudAccountExocomputeConfigurations()
        {
            this._logger.name += " -ValidateCloudAccountExocomputeConfigurations";
            // Create new graphql operation validateAzureCloudAccountExocomputeConfigurations
            InitQueryValidateAzureCloudAccountExocomputeConfigurations();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureArmTemplatesByFeature.
        internal void ProcessRecord_AllArmTemplatesByFeature()
        {
            this._logger.name += " -AllArmTemplatesByFeature";
            // Create new graphql operation allAzureArmTemplatesByFeature
            InitQueryAllAzureArmTemplatesByFeature();
        }

        // This parameter set invokes a single graphql operation:
        // checkAzurePersistentStorageSubscriptionCanUnmap.
        internal void ProcessRecord_CheckPersistentStorageSubscriptionCanUnmap()
        {
            this._logger.name += " -CheckPersistentStorageSubscriptionCanUnmap";
            // Create new graphql operation checkAzurePersistentStorageSubscriptionCanUnmap
            InitQueryCheckAzurePersistentStorageSubscriptionCanUnmap();
        }

        // This parameter set invokes a single graphql operation:
        // azureSubscriptions.
        internal void ProcessRecord_Subscriptions()
        {
            this._logger.name += " -Subscriptions";
            // Create new graphql operation azureSubscriptions
            InitQueryAzureSubscriptions();
        }

        // This parameter set invokes a single graphql operation:
        // azureRegions.
        internal void ProcessRecord_Regions()
        {
            this._logger.name += " -Regions";
            // Create new graphql operation azureRegions
            InitQueryAzureRegions();
        }

        // This parameter set invokes a single graphql operation:
        // azureResourceGroups.
        internal void ProcessRecord_ResourceGroups()
        {
            this._logger.name += " -ResourceGroups";
            // Create new graphql operation azureResourceGroups
            InitQueryAzureResourceGroups();
        }

        // This parameter set invokes a single graphql operation:
        // azureVNets.
        internal void ProcessRecord_VNets()
        {
            this._logger.name += " -VNets";
            // Create new graphql operation azureVNets
            InitQueryAzureVnets();
        }

        // This parameter set invokes a single graphql operation:
        // azureSubnets.
        internal void ProcessRecord_Subnets()
        {
            this._logger.name += " -Subnets";
            // Create new graphql operation azureSubnets
            InitQueryAzureSubnets();
        }

        // This parameter set invokes a single graphql operation:
        // azureStorageAccounts.
        internal void ProcessRecord_StorageAccounts()
        {
            this._logger.name += " -StorageAccounts";
            // Create new graphql operation azureStorageAccounts
            InitQueryAzureStorageAccounts();
        }

        // This parameter set invokes a single graphql operation:
        // allHostedAzureRegions.
        internal void ProcessRecord_AllHostedRegions()
        {
            this._logger.name += " -AllHostedRegions";
            // Create new graphql operation allHostedAzureRegions
            InitQueryAllHostedAzureRegions();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureResourceGroups.
        internal void ProcessRecord_AllResourceGroups()
        {
            this._logger.name += " -AllResourceGroups";
            // Create new graphql operation allAzureResourceGroups
            InitQueryAllAzureResourceGroups();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureVnets.
        internal void ProcessRecord_AllVnets()
        {
            this._logger.name += " -AllVnets";
            // Create new graphql operation allAzureVnets
            InitQueryAllAzureVnets();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureSubnets.
        internal void ProcessRecord_AllSubnets()
        {
            this._logger.name += " -AllSubnets";
            // Create new graphql operation allAzureSubnets
            InitQueryAllAzureSubnets();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureCdmVersions.
        internal void ProcessRecord_AllCdmVersions()
        {
            this._logger.name += " -AllCdmVersions";
            // Create new graphql operation allAzureCdmVersions
            InitQueryAllAzureCdmVersions();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureRegions.
        internal void ProcessRecord_AllRegions()
        {
            this._logger.name += " -AllRegions";
            // Create new graphql operation allAzureRegions
            InitQueryAllAzureRegions();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureNsgs.
        internal void ProcessRecord_AllNsgs()
        {
            this._logger.name += " -AllNsgs";
            // Create new graphql operation allAzureNsgs
            InitQueryAllAzureNsgs();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureStorageAccounts.
        internal void ProcessRecord_AllStorageAccounts()
        {
            this._logger.name += " -AllStorageAccounts";
            // Create new graphql operation allAzureStorageAccounts
            InitQueryAllAzureStorageAccounts();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureManagedIdentities.
        internal void ProcessRecord_AllManagedIdentities()
        {
            this._logger.name += " -AllManagedIdentities";
            // Create new graphql operation allAzureManagedIdentities
            InitQueryAllAzureManagedIdentities();
        }

        // This parameter set invokes a single graphql operation:
        // azureAdDirectories.
        internal void ProcessRecord_AdDirectories()
        {
            this._logger.name += " -AdDirectories";
            // Create new graphql operation azureAdDirectories
            InitQueryAzureAdDirectories();
        }

        // This parameter set invokes a single graphql operation:
        // azureAdDirectory.
        internal void ProcessRecord_AdDirectory()
        {
            this._logger.name += " -AdDirectory";
            // Create new graphql operation azureAdDirectory
            InitQueryAzureAdDirectory();
        }

        // This parameter set invokes a single graphql operation:
        // azureAdObjectsByType.
        internal void ProcessRecord_AdObjectsByType()
        {
            this._logger.name += " -AdObjectsByType";
            // Create new graphql operation azureAdObjectsByType
            InitQueryAzureAdObjectsByType();
        }

        // This parameter set invokes a single graphql operation:
        // searchAzureAdSnapshot.
        internal void ProcessRecord_SearchAdSnapshot()
        {
            this._logger.name += " -SearchAdSnapshot";
            // Create new graphql operation searchAzureAdSnapshot
            InitQuerySearchAzureAdSnapshot();
        }


        // Create new GraphQL Query:
        // azureNativeRoot: AzureNativeRoot!
        internal void InitQueryAzureNativeRoot()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeRoot",
                "",
                "AzureNativeRoot",
                Query.AzureNativeRoot_ObjectFieldSpec,
                Query.AzureNativeRootFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // azureNativeSubscription(azureSubscriptionRubrikId: UUID!): AzureNativeSubscription!
        internal void InitQueryAzureNativeSubscription()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeSubscription",
                "($azureSubscriptionRubrikId: UUID!)",
                "AzureNativeSubscription",
                Query.AzureNativeSubscription_ObjectFieldSpec,
                Query.AzureNativeSubscriptionFieldSpec,
                @"# REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // azureNativeSubscriptions(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AzureNativeSubscriptionSortFields
        //     sortOrder: SortOrder
        //     subscriptionFilters: AzureNativeSubscriptionFilters
        //     authorizedOperationFilter: Operation
        //     workloadHierarchy: WorkloadLevelHierarchy
        //     azureNativeProtectionFeature: AzureNativeProtectionFeature
        //   ): AzureNativeSubscriptionConnection!
        internal void InitQueryAzureNativeSubscriptions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AzureNativeSubscriptionSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("subscriptionFilters", "AzureNativeSubscriptionFilters"),
                Tuple.Create("authorizedOperationFilter", "Operation"),
                Tuple.Create("workloadHierarchy", "WorkloadLevelHierarchy"),
                Tuple.Create("azureNativeProtectionFeature", "AzureNativeProtectionFeature"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeSubscriptions",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureNativeSubscriptionSortFields,$sortOrder: SortOrder,$subscriptionFilters: AzureNativeSubscriptionFilters,$authorizedOperationFilter: Operation,$workloadHierarchy: WorkloadLevelHierarchy,$azureNativeProtectionFeature: AzureNativeProtectionFeature)",
                "AzureNativeSubscriptionConnection",
                Query.AzureNativeSubscriptions_ObjectFieldSpec,
                Query.AzureNativeSubscriptionsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AzureNativeSubscriptionSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeSubscriptionSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.subscriptionFilters = @{
	# OPTIONAL
	nameSubstringFilter = @{
		# REQUIRED
		nameSubstring = <System.String>
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			<System.String>
		)
	}
}
# OPTIONAL
$inputs.Var.authorizedOperationFilter = <Operation> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
# OPTIONAL
$inputs.Var.workloadHierarchy = <WorkloadLevelHierarchy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
# OPTIONAL
$inputs.Var.azureNativeProtectionFeature = <AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // azureNativeResourceGroup(resourceGroupId: UUID!): AzureNativeResourceGroup!
        internal void InitQueryAzureNativeResourceGroup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("resourceGroupId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeResourceGroup",
                "($resourceGroupId: UUID!)",
                "AzureNativeResourceGroup",
                Query.AzureNativeResourceGroup_ObjectFieldSpec,
                Query.AzureNativeResourceGroupFieldSpec,
                @"# REQUIRED
$inputs.Var.resourceGroupId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // azureNativeResourceGroups(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AzureNativeCommonResourceGroupSortFields
        //     sortOrder: SortOrder
        //     commonResourceGroupFilters: AzureNativeCommonResourceGroupFilters
        //     protectedObjectTypes: [WorkloadLevelHierarchy!]
        //     azureNativeProtectionFeatures: [AzureNativeProtectionFeature!]
        //   ): AzureNativeResourceGroupConnection!
        internal void InitQueryAzureNativeResourceGroups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AzureNativeCommonResourceGroupSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("commonResourceGroupFilters", "AzureNativeCommonResourceGroupFilters"),
                Tuple.Create("protectedObjectTypes", "[WorkloadLevelHierarchy!]"),
                Tuple.Create("azureNativeProtectionFeatures", "[AzureNativeProtectionFeature!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeResourceGroups",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureNativeCommonResourceGroupSortFields,$sortOrder: SortOrder,$commonResourceGroupFilters: AzureNativeCommonResourceGroupFilters,$protectedObjectTypes: [WorkloadLevelHierarchy!],$azureNativeProtectionFeatures: [AzureNativeProtectionFeature!])",
                "AzureNativeResourceGroupConnection",
                Query.AzureNativeResourceGroups_ObjectFieldSpec,
                Query.AzureNativeResourceGroupsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AzureNativeCommonResourceGroupSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeCommonResourceGroupSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.commonResourceGroupFilters = @{
	# OPTIONAL
	nameSubstringFilter = @{
		# REQUIRED
		nameSubstring = <System.String>
	}
	# OPTIONAL
	subscriptionFilter = @{
		# REQUIRED
		subscriptionIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	regionFilter = @{
		# REQUIRED
		regions = @(
			<AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
		)
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			<System.String>
		)
	}
}
# OPTIONAL
$inputs.Var.protectedObjectTypes = @(
	<WorkloadLevelHierarchy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
)
# OPTIONAL
$inputs.Var.azureNativeProtectionFeatures = @(
	<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
)"
            );
        }

        // Create new GraphQL Query:
        // azureNativeVirtualMachine(azureVirtualMachineRubrikId: UUID!): AzureNativeVirtualMachine!
        internal void InitQueryAzureNativeVirtualMachine()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureVirtualMachineRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeVirtualMachine",
                "($azureVirtualMachineRubrikId: UUID!)",
                "AzureNativeVirtualMachine",
                Query.AzureNativeVirtualMachine_ObjectFieldSpec,
                Query.AzureNativeVirtualMachineFieldSpec,
                @"# REQUIRED
$inputs.Var.azureVirtualMachineRubrikId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // azureNativeVirtualMachines(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AzureNativeVirtualMachineSortFields
        //     sortOrder: SortOrder
        //     descendantTypeFilter: [HierarchyObjectTypeEnum!]
        //     virtualMachineFilters: AzureNativeVirtualMachineFilters
        //   ): AzureNativeVirtualMachineConnection!
        internal void InitQueryAzureNativeVirtualMachines()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AzureNativeVirtualMachineSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("descendantTypeFilter", "[HierarchyObjectTypeEnum!]"),
                Tuple.Create("virtualMachineFilters", "AzureNativeVirtualMachineFilters"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeVirtualMachines",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureNativeVirtualMachineSortFields,$sortOrder: SortOrder,$descendantTypeFilter: [HierarchyObjectTypeEnum!],$virtualMachineFilters: AzureNativeVirtualMachineFilters)",
                "AzureNativeVirtualMachineConnection",
                Query.AzureNativeVirtualMachines_ObjectFieldSpec,
                Query.AzureNativeVirtualMachinesFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AzureNativeVirtualMachineSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeVirtualMachineSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.descendantTypeFilter = @(
	<HierarchyObjectTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
)
# OPTIONAL
$inputs.Var.virtualMachineFilters = @{
	# OPTIONAL
	nameSubstringFilter = @{
		# REQUIRED
		nameSubstring = <System.String>
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	resourceGroupFilter = @{
		# REQUIRED
		resourceGroupNames = @(
			<System.String>
		)
	}
	# OPTIONAL
	subscriptionFilter = @{
		# REQUIRED
		subscriptionIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	regionFilter = @{
		# REQUIRED
		regions = @(
			<AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
		)
	}
	# OPTIONAL
	vmSizeFilter = @{
		# REQUIRED
		vmSizes = @(
			<System.String>
		)
	}
	# OPTIONAL
	vnetFilter = @{
		# REQUIRED
		vnetNames = @(
			<System.String>
		)
	}
	# OPTIONAL
	relicFilter = @{
		# REQUIRED
		relic = <System.Boolean>
	}
	# OPTIONAL
	tagFilter = @{
		# REQUIRED
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
	}
	# OPTIONAL
	exocomputeConnectedFilter = @{
		# REQUIRED
		isConnected = <System.Boolean>
	}
	# OPTIONAL
	fileIndexingFilter = @{
		# REQUIRED
		statuses = @(
			<AzureNativeFileIndexingStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeFileIndexingStatus]) for enum values.
		)
	}
	# OPTIONAL
	appProtectionStatusFilter = @{
		# REQUIRED
		isProtectionSetup = <System.Boolean>
	}
	# OPTIONAL
	rbsStatusFilter = @{
		# REQUIRED
		status = <CloudInstanceRbsConnectionStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudInstanceRbsConnectionStatus]) for enum values.
	}
}"
            );
        }

        // Create new GraphQL Query:
        // azureNativeManagedDisk(azureManagedDiskRubrikId: UUID!): AzureNativeManagedDisk!
        internal void InitQueryAzureNativeManagedDisk()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureManagedDiskRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeManagedDisk",
                "($azureManagedDiskRubrikId: UUID!)",
                "AzureNativeManagedDisk",
                Query.AzureNativeManagedDisk_ObjectFieldSpec,
                Query.AzureNativeManagedDiskFieldSpec,
                @"# REQUIRED
$inputs.Var.azureManagedDiskRubrikId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // azureNativeManagedDisks(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AzureNativeDiskSortFields
        //     sortOrder: SortOrder
        //     diskFilters: AzureNativeDiskFilters
        //   ): AzureNativeManagedDiskConnection!
        internal void InitQueryAzureNativeManagedDisks()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AzureNativeDiskSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("diskFilters", "AzureNativeDiskFilters"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeManagedDisks",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureNativeDiskSortFields,$sortOrder: SortOrder,$diskFilters: AzureNativeDiskFilters)",
                "AzureNativeManagedDiskConnection",
                Query.AzureNativeManagedDisks_ObjectFieldSpec,
                Query.AzureNativeManagedDisksFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AzureNativeDiskSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeDiskSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.diskFilters = @{
	# OPTIONAL
	nameSubstringFilter = @{
		# REQUIRED
		nameSubstring = <System.String>
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	resourceGroupFilter = @{
		# REQUIRED
		resourceGroupNames = @(
			<System.String>
		)
	}
	# OPTIONAL
	subscriptionFilter = @{
		# REQUIRED
		subscriptionIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	regionFilter = @{
		# REQUIRED
		regions = @(
			<AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
		)
	}
	# OPTIONAL
	diskTypeFilter = @{
		# REQUIRED
		diskTypes = @(
			<System.String>
		)
	}
	# OPTIONAL
	attachedVmFilter = @{
		# REQUIRED
		virtualMachineIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	relicFilter = @{
		# REQUIRED
		relic = <System.Boolean>
	}
	# OPTIONAL
	tagFilter = @{
		# REQUIRED
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
	}
	# OPTIONAL
	exocomputeConnectedFilter = @{
		# REQUIRED
		isConnected = <System.Boolean>
	}
	# OPTIONAL
	fileIndexingFilter = @{
		# REQUIRED
		statuses = @(
			<AzureNativeFileIndexingStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeFileIndexingStatus]) for enum values.
		)
	}
}"
            );
        }

        // Create new GraphQL Query:
        // allAzureNativeVirtualNetworks(azureSubscriptionRubrikId: UUID): [AzureNativeVirtualNetwork!]!
        internal void InitQueryAllAzureNativeVirtualNetworks()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNativeVirtualNetworks",
                "($azureSubscriptionRubrikId: UUID)",
                "List<AzureNativeVirtualNetwork>",
                Query.AllAzureNativeVirtualNetworks_ObjectFieldSpec,
                Query.AllAzureNativeVirtualNetworksFieldSpec,
                @"# OPTIONAL
$inputs.Var.azureSubscriptionRubrikId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // allAzureNativeSubnetsByRegionFromAzure(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!): [AzureNativeSubnet!]!
        internal void InitQueryAllAzureNativeSubnetsByRegionFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("region", "AzureNativeRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNativeSubnetsByRegionFromAzure",
                "($azureSubscriptionRubrikId: UUID!,$region: AzureNativeRegion!)",
                "List<AzureNativeSubnet>",
                Query.AllAzureNativeSubnetsByRegionFromAzure_ObjectFieldSpec,
                Query.AllAzureNativeSubnetsByRegionFromAzureFieldSpec,
                @"# REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allAzureNativeSecurityGroupsByRegionFromAzure(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!): [AzureNativeSecurityGroup!]!
        internal void InitQueryAllAzureNativeSecurityGroupsByRegionFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("region", "AzureNativeRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNativeSecurityGroupsByRegionFromAzure",
                "($azureSubscriptionRubrikId: UUID!,$region: AzureNativeRegion!)",
                "List<AzureNativeSecurityGroup>",
                Query.AllAzureNativeSecurityGroupsByRegionFromAzure_ObjectFieldSpec,
                Query.AllAzureNativeSecurityGroupsByRegionFromAzureFieldSpec,
                @"# REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allAzureDiskEncryptionSetsByRegion(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!): [AzureNativeDiskEncryptionSet!]!
        internal void InitQueryAllAzureDiskEncryptionSetsByRegion()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("region", "AzureNativeRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureDiskEncryptionSetsByRegion",
                "($azureSubscriptionRubrikId: UUID!,$region: AzureNativeRegion!)",
                "List<AzureNativeDiskEncryptionSet>",
                Query.AllAzureDiskEncryptionSetsByRegion_ObjectFieldSpec,
                Query.AllAzureDiskEncryptionSetsByRegionFieldSpec,
                @"# REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allAzureNativeAvailabilitySetsByRegionFromAzure(azureSubscriptionRubrikId: UUID!, resourceGroupName: String!, region: AzureNativeRegion!): [AzureNativeAvailabilitySet!]!
        internal void InitQueryAllAzureNativeAvailabilitySetsByRegionFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("region", "AzureNativeRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNativeAvailabilitySetsByRegionFromAzure",
                "($azureSubscriptionRubrikId: UUID!,$resourceGroupName: String!,$region: AzureNativeRegion!)",
                "List<AzureNativeAvailabilitySet>",
                Query.AllAzureNativeAvailabilitySetsByRegionFromAzure_ObjectFieldSpec,
                Query.AllAzureNativeAvailabilitySetsByRegionFromAzureFieldSpec,
                @"# REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>
# REQUIRED
$inputs.Var.resourceGroupName = <System.String>
# REQUIRED
$inputs.Var.region = <AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allAzureNativeExportCompatibleVmSizesByRegionFromAzure(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!, vmSnapshotId: UUID!): [AzureNativeExportCompatibleVmSizes!]!
        internal void InitQueryAllAzureNativeExportCompatibleVmSizesByRegionFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("region", "AzureNativeRegion!"),
                Tuple.Create("vmSnapshotId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNativeExportCompatibleVmSizesByRegionFromAzure",
                "($azureSubscriptionRubrikId: UUID!,$region: AzureNativeRegion!,$vmSnapshotId: UUID!)",
                "List<AzureNativeExportCompatibleVmSizes>",
                Query.AllAzureNativeExportCompatibleVmSizesByRegionFromAzure_ObjectFieldSpec,
                Query.AllAzureNativeExportCompatibleVmSizesByRegionFromAzureFieldSpec,
                @"# REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
# REQUIRED
$inputs.Var.vmSnapshotId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // allAzureNativeExportCompatibleDiskTypesByRegionFromAzure(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!): [AzureNativeExportCompatibleDiskTypes!]!
        internal void InitQueryAllAzureNativeExportCompatibleDiskTypesByRegionFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("region", "AzureNativeRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNativeExportCompatibleDiskTypesByRegionFromAzure",
                "($azureSubscriptionRubrikId: UUID!,$region: AzureNativeRegion!)",
                "List<AzureNativeExportCompatibleDiskTypes>",
                Query.AllAzureNativeExportCompatibleDiskTypesByRegionFromAzure_ObjectFieldSpec,
                Query.AllAzureNativeExportCompatibleDiskTypesByRegionFromAzureFieldSpec,
                @"# REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allAzureNativeVirtualMachineSizes(azureSubscriptionRubrikId: UUID): [String!]!
        internal void InitQueryAllAzureNativeVirtualMachineSizes()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNativeVirtualMachineSizes",
                "($azureSubscriptionRubrikId: UUID)",
                "List<System.String>",
                Query.AllAzureNativeVirtualMachineSizes_ObjectFieldSpec,
                Query.AllAzureNativeVirtualMachineSizesFieldSpec,
                @"# OPTIONAL
$inputs.Var.azureSubscriptionRubrikId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // isAzureNativeManagedDiskSnapshotRestorable(azureSubscriptionRubrikId: UUID!, diskSnapshotId: UUID!): Boolean!
        internal void InitQueryIsAzureNativeManagedDiskSnapshotRestorable()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("diskSnapshotId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsAzureNativeManagedDiskSnapshotRestorable",
                "($azureSubscriptionRubrikId: UUID!,$diskSnapshotId: UUID!)",
                "System.Boolean",
                Query.IsAzureNativeManagedDiskSnapshotRestorable_ObjectFieldSpec,
                Query.IsAzureNativeManagedDiskSnapshotRestorableFieldSpec,
                @"# REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>
# REQUIRED
$inputs.Var.diskSnapshotId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // isAzureStorageAccountNameAvailable(azureSubscriptionRubrikId: UUID!, storageAccountName: String!): Boolean!
        internal void InitQueryIsAzureStorageAccountNameAvailable()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("storageAccountName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsAzureStorageAccountNameAvailable",
                "($azureSubscriptionRubrikId: UUID!,$storageAccountName: String!)",
                "System.Boolean",
                Query.IsAzureStorageAccountNameAvailable_ObjectFieldSpec,
                Query.IsAzureStorageAccountNameAvailableFieldSpec,
                @"# REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>
# REQUIRED
$inputs.Var.storageAccountName = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // allAzureNativeStorageAccountsFromAzure(azureSubscriptionRubrikId: UUID!): [AzureNativeStorageAccount!]!
        internal void InitQueryAllAzureNativeStorageAccountsFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNativeStorageAccountsFromAzure",
                "($azureSubscriptionRubrikId: UUID!)",
                "List<AzureNativeStorageAccount>",
                Query.AllAzureNativeStorageAccountsFromAzure_ObjectFieldSpec,
                Query.AllAzureNativeStorageAccountsFromAzureFieldSpec,
                @"# REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // azureSqlDatabase(azureSqlDatabaseRubrikId: UUID!): AzureSqlDatabaseDb!
        internal void InitQueryAzureSqlDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlDatabaseRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlDatabase",
                "($azureSqlDatabaseRubrikId: UUID!)",
                "AzureSqlDatabaseDb",
                Query.AzureSqlDatabase_ObjectFieldSpec,
                Query.AzureSqlDatabaseFieldSpec,
                @"# REQUIRED
$inputs.Var.azureSqlDatabaseRubrikId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // azureSqlDatabases(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AzureSqlDatabaseSortFields
        //     sortOrder: SortOrder
        //     azureSqlDatabaseFilters: AzureSqlDatabaseFilters
        //   ): AzureSqlDatabaseDbConnection!
        internal void InitQueryAzureSqlDatabases()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AzureSqlDatabaseSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("azureSqlDatabaseFilters", "AzureSqlDatabaseFilters"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlDatabases",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureSqlDatabaseSortFields,$sortOrder: SortOrder,$azureSqlDatabaseFilters: AzureSqlDatabaseFilters)",
                "AzureSqlDatabaseDbConnection",
                Query.AzureSqlDatabases_ObjectFieldSpec,
                Query.AzureSqlDatabasesFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AzureSqlDatabaseSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlDatabaseSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.azureSqlDatabaseFilters = @{
	# OPTIONAL
	nameSubstringFilter = @{
		# REQUIRED
		nameSubstring = <System.String>
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	resourceGroupFilter = @{
		# REQUIRED
		resourceGroupNames = @(
			<System.String>
		)
	}
	# OPTIONAL
	subscriptionFilter = @{
		# REQUIRED
		subscriptionIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	regionFilter = @{
		# REQUIRED
		regions = @(
			<AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
		)
	}
	# OPTIONAL
	relicFilter = @{
		# REQUIRED
		relic = <System.Boolean>
	}
	# OPTIONAL
	tagFilter = @{
		# REQUIRED
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
	}
	# OPTIONAL
	serverFilter = @{
		# REQUIRED
		serverNames = @(
			<System.String>
		)
	}
}"
            );
        }

        // Create new GraphQL Query:
        // azureSqlDatabaseServer(azureSqlDatabaseServerRubrikId: UUID!): AzureSqlDatabaseServer!
        internal void InitQueryAzureSqlDatabaseServer()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlDatabaseServerRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlDatabaseServer",
                "($azureSqlDatabaseServerRubrikId: UUID!)",
                "AzureSqlDatabaseServer",
                Query.AzureSqlDatabaseServer_ObjectFieldSpec,
                Query.AzureSqlDatabaseServerFieldSpec,
                @"# REQUIRED
$inputs.Var.azureSqlDatabaseServerRubrikId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // azureSqlDatabaseServers(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AzureSqlDatabaseServerSortFields
        //     sortOrder: SortOrder
        //     azureSqlDatabaseServerFilters: AzureSqlDatabaseServerFilters
        //   ): AzureSqlDatabaseServerConnection!
        internal void InitQueryAzureSqlDatabaseServers()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AzureSqlDatabaseServerSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("azureSqlDatabaseServerFilters", "AzureSqlDatabaseServerFilters"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlDatabaseServers",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureSqlDatabaseServerSortFields,$sortOrder: SortOrder,$azureSqlDatabaseServerFilters: AzureSqlDatabaseServerFilters)",
                "AzureSqlDatabaseServerConnection",
                Query.AzureSqlDatabaseServers_ObjectFieldSpec,
                Query.AzureSqlDatabaseServersFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AzureSqlDatabaseServerSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlDatabaseServerSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.azureSqlDatabaseServerFilters = @{
	# OPTIONAL
	nameSubstringFilter = @{
		# REQUIRED
		nameSubstring = <System.String>
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	resourceGroupFilter = @{
		# REQUIRED
		resourceGroupNames = @(
			<System.String>
		)
	}
	# OPTIONAL
	subscriptionFilter = @{
		# REQUIRED
		subscriptionIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	regionFilter = @{
		# REQUIRED
		regions = @(
			<AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
		)
	}
}"
            );
        }

        // Create new GraphQL Query:
        // azureSqlManagedInstanceDatabase(azureSqlManagedInstanceDatabaseRubrikId: UUID!): AzureSqlManagedInstanceDatabase!
        internal void InitQueryAzureSqlManagedInstanceDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlManagedInstanceDatabaseRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlManagedInstanceDatabase",
                "($azureSqlManagedInstanceDatabaseRubrikId: UUID!)",
                "AzureSqlManagedInstanceDatabase",
                Query.AzureSqlManagedInstanceDatabase_ObjectFieldSpec,
                Query.AzureSqlManagedInstanceDatabaseFieldSpec,
                @"# REQUIRED
$inputs.Var.azureSqlManagedInstanceDatabaseRubrikId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // azureSqlManagedInstanceDatabases(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AzureSqlManagedInstanceDatabaseSortFields
        //     sortOrder: SortOrder
        //     azureSqlManagedInstanceDatabaseFilters: AzureSqlManagedInstanceDatabaseFilters
        //   ): AzureSqlManagedInstanceDatabaseConnection!
        internal void InitQueryAzureSqlManagedInstanceDatabases()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AzureSqlManagedInstanceDatabaseSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("azureSqlManagedInstanceDatabaseFilters", "AzureSqlManagedInstanceDatabaseFilters"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlManagedInstanceDatabases",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureSqlManagedInstanceDatabaseSortFields,$sortOrder: SortOrder,$azureSqlManagedInstanceDatabaseFilters: AzureSqlManagedInstanceDatabaseFilters)",
                "AzureSqlManagedInstanceDatabaseConnection",
                Query.AzureSqlManagedInstanceDatabases_ObjectFieldSpec,
                Query.AzureSqlManagedInstanceDatabasesFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AzureSqlManagedInstanceDatabaseSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlManagedInstanceDatabaseSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.azureSqlManagedInstanceDatabaseFilters = @{
	# OPTIONAL
	nameSubstringFilter = @{
		# REQUIRED
		nameSubstring = <System.String>
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	resourceGroupFilter = @{
		# REQUIRED
		resourceGroupNames = @(
			<System.String>
		)
	}
	# OPTIONAL
	subscriptionFilter = @{
		# REQUIRED
		subscriptionIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	regionFilter = @{
		# REQUIRED
		regions = @(
			<AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
		)
	}
	# OPTIONAL
	relicFilter = @{
		# REQUIRED
		relic = <System.Boolean>
	}
	# OPTIONAL
	serverFilter = @{
		# REQUIRED
		serverNames = @(
			<System.String>
		)
	}
}"
            );
        }

        // Create new GraphQL Query:
        // azureSqlManagedInstanceServer(azureSqlManagedInstanceServerRubrikId: UUID!): AzureSqlManagedInstanceServer!
        internal void InitQueryAzureSqlManagedInstanceServer()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlManagedInstanceServerRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlManagedInstanceServer",
                "($azureSqlManagedInstanceServerRubrikId: UUID!)",
                "AzureSqlManagedInstanceServer",
                Query.AzureSqlManagedInstanceServer_ObjectFieldSpec,
                Query.AzureSqlManagedInstanceServerFieldSpec,
                @"# REQUIRED
$inputs.Var.azureSqlManagedInstanceServerRubrikId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // azureSqlManagedInstanceServers(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AzureSqlManagedInstanceServerSortFields
        //     sortOrder: SortOrder
        //     azureSqlManagedInstanceServerFilters: AzureSqlManagedInstanceServerFilters
        //   ): AzureSqlManagedInstanceServerConnection!
        internal void InitQueryAzureSqlManagedInstanceServers()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AzureSqlManagedInstanceServerSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("azureSqlManagedInstanceServerFilters", "AzureSqlManagedInstanceServerFilters"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlManagedInstanceServers",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureSqlManagedInstanceServerSortFields,$sortOrder: SortOrder,$azureSqlManagedInstanceServerFilters: AzureSqlManagedInstanceServerFilters)",
                "AzureSqlManagedInstanceServerConnection",
                Query.AzureSqlManagedInstanceServers_ObjectFieldSpec,
                Query.AzureSqlManagedInstanceServersFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AzureSqlManagedInstanceServerSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlManagedInstanceServerSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.azureSqlManagedInstanceServerFilters = @{
	# OPTIONAL
	nameSubstringFilter = @{
		# REQUIRED
		nameSubstring = <System.String>
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	resourceGroupFilter = @{
		# REQUIRED
		resourceGroupNames = @(
			<System.String>
		)
	}
	# OPTIONAL
	subscriptionFilter = @{
		# REQUIRED
		subscriptionIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	regionFilter = @{
		# REQUIRED
		regions = @(
			<AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
		)
	}
	# OPTIONAL
	tagFilter = @{
		# REQUIRED
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
	}
}"
            );
        }

        // Create new GraphQL Query:
        // azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure(
        //     subscriptionId: UUID!
        //     resourceGroupName: String!
        //     azureSqlDatabaseServerName: String!
        //     azureSqlDatabaseName: String!
        //   ): AzureNativeSqlDatabasePointInTimeRestoreWindow!
        internal void InitQueryAzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("azureSqlDatabaseServerName", "String!"),
                Tuple.Create("azureSqlDatabaseName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure",
                "($subscriptionId: UUID!,$resourceGroupName: String!,$azureSqlDatabaseServerName: String!,$azureSqlDatabaseName: String!)",
                "AzureNativeSqlDatabasePointInTimeRestoreWindow",
                Query.AzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure_ObjectFieldSpec,
                Query.AzureSqlDatabaseDbPointInTimeRestoreWindowFromAzureFieldSpec,
                @"# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.resourceGroupName = <System.String>
# REQUIRED
$inputs.Var.azureSqlDatabaseServerName = <System.String>
# REQUIRED
$inputs.Var.azureSqlDatabaseName = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure(
        //     subscriptionId: UUID!
        //     resourceGroupName: String!
        //     azureSqlManagedInstanceName: String!
        //     azureSqlDatabaseName: String!
        //   ): AzureNativeSqlDatabasePointInTimeRestoreWindow!
        internal void InitQueryAzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("azureSqlManagedInstanceName", "String!"),
                Tuple.Create("azureSqlDatabaseName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure",
                "($subscriptionId: UUID!,$resourceGroupName: String!,$azureSqlManagedInstanceName: String!,$azureSqlDatabaseName: String!)",
                "AzureNativeSqlDatabasePointInTimeRestoreWindow",
                Query.AzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure_ObjectFieldSpec,
                Query.AzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzureFieldSpec,
                @"# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.resourceGroupName = <System.String>
# REQUIRED
$inputs.Var.azureSqlManagedInstanceName = <System.String>
# REQUIRED
$inputs.Var.azureSqlDatabaseName = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // validateAzureNativeSqlDatabaseDbNameForExport(azureSqlDatabaseName: String!, azureSqlDatabaseServerRubrikId: UUID!): ValidateAzureNativeSqlDatabaseDbNameForExportReply!
        internal void InitQueryValidateAzureNativeSqlDatabaseDbNameForExport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlDatabaseName", "String!"),
                Tuple.Create("azureSqlDatabaseServerRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryValidateAzureNativeSqlDatabaseDbNameForExport",
                "($azureSqlDatabaseName: String!,$azureSqlDatabaseServerRubrikId: UUID!)",
                "ValidateAzureNativeSqlDatabaseDbNameForExportReply",
                Query.ValidateAzureNativeSqlDatabaseDbNameForExport_ObjectFieldSpec,
                Query.ValidateAzureNativeSqlDatabaseDbNameForExportFieldSpec,
                @"# REQUIRED
$inputs.Var.azureSqlDatabaseName = <System.String>
# REQUIRED
$inputs.Var.azureSqlDatabaseServerRubrikId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // validateAzureNativeSqlManagedInstanceDbNameForExport(azureSqlDatabaseName: String!, azureSqlManagedInstanceServerRubrikId: UUID!): ValidateAzureNativeSqlManagedInstanceDbNameForExportReply!
        internal void InitQueryValidateAzureNativeSqlManagedInstanceDbNameForExport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlDatabaseName", "String!"),
                Tuple.Create("azureSqlManagedInstanceServerRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryValidateAzureNativeSqlManagedInstanceDbNameForExport",
                "($azureSqlDatabaseName: String!,$azureSqlManagedInstanceServerRubrikId: UUID!)",
                "ValidateAzureNativeSqlManagedInstanceDbNameForExportReply",
                Query.ValidateAzureNativeSqlManagedInstanceDbNameForExport_ObjectFieldSpec,
                Query.ValidateAzureNativeSqlManagedInstanceDbNameForExportFieldSpec,
                @"# REQUIRED
$inputs.Var.azureSqlDatabaseName = <System.String>
# REQUIRED
$inputs.Var.azureSqlManagedInstanceServerRubrikId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // allAzureSqlDatabaseServerElasticPools(
        //     subscriptionId: UUID!
        //     resourceGroupName: String!
        //     azureSqlDatabaseServerName: String!
        //     azureSqlDatabaseServerRubrikId: UUID!
        //   ): [AzureSqlDatabaseServerElasticPool!]!
        internal void InitQueryAllAzureSqlDatabaseServerElasticPools()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("azureSqlDatabaseServerName", "String!"),
                Tuple.Create("azureSqlDatabaseServerRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureSqlDatabaseServerElasticPools",
                "($subscriptionId: UUID!,$resourceGroupName: String!,$azureSqlDatabaseServerName: String!,$azureSqlDatabaseServerRubrikId: UUID!)",
                "List<AzureSqlDatabaseServerElasticPool>",
                Query.AllAzureSqlDatabaseServerElasticPools_ObjectFieldSpec,
                Query.AllAzureSqlDatabaseServerElasticPoolsFieldSpec,
                @"# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.resourceGroupName = <System.String>
# REQUIRED
$inputs.Var.azureSqlDatabaseServerName = <System.String>
# REQUIRED
$inputs.Var.azureSqlDatabaseServerRubrikId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // isAzureNativeSqlDatabaseSnapshotPersistent(snapshotId: UUID!): Boolean!
        internal void InitQueryIsAzureNativeSqlDatabaseSnapshotPersistent()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snapshotId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsAzureNativeSqlDatabaseSnapshotPersistent",
                "($snapshotId: UUID!)",
                "System.Boolean",
                Query.IsAzureNativeSqlDatabaseSnapshotPersistent_ObjectFieldSpec,
                Query.IsAzureNativeSqlDatabaseSnapshotPersistentFieldSpec,
                @"# REQUIRED
$inputs.Var.snapshotId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // allAzureKeyVaultsByRegion(azureKeyVaultsInput: AzureKeyVaultsInput!): [AzureKeyVault!]!
        internal void InitQueryAllAzureKeyVaultsByRegion()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureKeyVaultsInput", "AzureKeyVaultsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureKeyVaultsByRegion",
                "($azureKeyVaultsInput: AzureKeyVaultsInput!)",
                "List<AzureKeyVault>",
                Query.AllAzureKeyVaultsByRegion_ObjectFieldSpec,
                Query.AllAzureKeyVaultsByRegionFieldSpec,
                @"# REQUIRED
$inputs.Var.azureKeyVaultsInput = @{
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	region = <AzureRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
	# OPTIONAL
	userAssignedManagedIdentityPrincipalId = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // allAzureEncryptionKeys(azureEncryptionKeysInput: AzureEncryptionKeysInput!): [AzureEncryptionKey!]!
        internal void InitQueryAllAzureEncryptionKeys()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureEncryptionKeysInput", "AzureEncryptionKeysInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureEncryptionKeys",
                "($azureEncryptionKeysInput: AzureEncryptionKeysInput!)",
                "List<AzureEncryptionKey>",
                Query.AllAzureEncryptionKeys_ObjectFieldSpec,
                Query.AllAzureEncryptionKeysFieldSpec,
                @"# REQUIRED
$inputs.Var.azureEncryptionKeysInput = @{
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	keyVaultName = <System.String>
	# REQUIRED
	resourceGroupName = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // azureCloudAccountTenant(
        //     tenantId: UUID!
        //     feature: CloudAccountFeature!
        //     subscriptionStatusFilters: [CloudAccountStatus!]!
        //     subscriptionSearchText: String!
        //     subscriptionIdsFilter: [UUID!]
        //   ): AzureCloudAccountTenant!
        internal void InitQueryAzureCloudAccountTenant()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("subscriptionStatusFilters", "[CloudAccountStatus!]!"),
                Tuple.Create("subscriptionSearchText", "String!"),
                Tuple.Create("subscriptionIdsFilter", "[UUID!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureCloudAccountTenant",
                "($tenantId: UUID!,$feature: CloudAccountFeature!,$subscriptionStatusFilters: [CloudAccountStatus!]!,$subscriptionSearchText: String!,$subscriptionIdsFilter: [UUID!])",
                "AzureCloudAccountTenant",
                Query.AzureCloudAccountTenant_ObjectFieldSpec,
                Query.AzureCloudAccountTenantFieldSpec,
                @"# REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$inputs.Var.subscriptionStatusFilters = @(
	<CloudAccountStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountStatus]) for enum values.
)
# REQUIRED
$inputs.Var.subscriptionSearchText = <System.String>
# OPTIONAL
$inputs.Var.subscriptionIdsFilter = @(
	<System.String>
)"
            );
        }

        // Create new GraphQL Query:
        // azureCloudAccountTenantWithExoConfigs(
        //     tenantId: UUID!
        //     feature: CloudAccountFeature!
        //     subscriptionStatusFilters: [CloudAccountStatus!]!
        //     subscriptionSearchText: String!
        //     subscriptionIdsFilter: [UUID!]
        //   ): AzureCloudAccountTenantWithExoConfigs!
        internal void InitQueryAzureCloudAccountTenantWithExoConfigs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("subscriptionStatusFilters", "[CloudAccountStatus!]!"),
                Tuple.Create("subscriptionSearchText", "String!"),
                Tuple.Create("subscriptionIdsFilter", "[UUID!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureCloudAccountTenantWithExoConfigs",
                "($tenantId: UUID!,$feature: CloudAccountFeature!,$subscriptionStatusFilters: [CloudAccountStatus!]!,$subscriptionSearchText: String!,$subscriptionIdsFilter: [UUID!])",
                "AzureCloudAccountTenantWithExoConfigs",
                Query.AzureCloudAccountTenantWithExoConfigs_ObjectFieldSpec,
                Query.AzureCloudAccountTenantWithExoConfigsFieldSpec,
                @"# REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$inputs.Var.subscriptionStatusFilters = @(
	<CloudAccountStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountStatus]) for enum values.
)
# REQUIRED
$inputs.Var.subscriptionSearchText = <System.String>
# OPTIONAL
$inputs.Var.subscriptionIdsFilter = @(
	<System.String>
)"
            );
        }

        // Create new GraphQL Query:
        // allAzureCloudAccountTenants(features: [CloudAccountFeature!], feature: CloudAccountFeature!, includeSubscriptionDetails: Boolean!): [AzureCloudAccountTenant!]!
        internal void InitQueryAllAzureCloudAccountTenants()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("features", "[CloudAccountFeature!]"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("includeSubscriptionDetails", "Boolean!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureCloudAccountTenants",
                "($features: [CloudAccountFeature!],$feature: CloudAccountFeature!,$includeSubscriptionDetails: Boolean!)",
                "List<AzureCloudAccountTenant>",
                Query.AllAzureCloudAccountTenants_ObjectFieldSpec,
                Query.AllAzureCloudAccountTenantsFieldSpec,
                @"# OPTIONAL
$inputs.Var.features = @(
	<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
)
# REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$inputs.Var.includeSubscriptionDetails = <System.Boolean>"
            );
        }

        // Create new GraphQL Query:
        // azureCloudAccountSubscriptionWithFeatures(cloudAccountId: UUID!): AzureCloudAccountSubscriptionWithFeatures!
        internal void InitQueryAzureCloudAccountSubscriptionWithFeatures()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureCloudAccountSubscriptionWithFeatures",
                "($cloudAccountId: UUID!)",
                "AzureCloudAccountSubscriptionWithFeatures",
                Query.AzureCloudAccountSubscriptionWithFeatures_ObjectFieldSpec,
                Query.AzureCloudAccountSubscriptionWithFeaturesFieldSpec,
                @"# REQUIRED
$inputs.Var.cloudAccountId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // allAzureCloudAccountSubscriptionsByFeature(feature: CloudAccountFeature!, subscriptionStatusFilters: [CloudAccountStatus!]!): [AzureSubscriptionWithFeaturesType!]!
        internal void InitQueryAllAzureCloudAccountSubscriptionsByFeature()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("subscriptionStatusFilters", "[CloudAccountStatus!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureCloudAccountSubscriptionsByFeature",
                "($feature: CloudAccountFeature!,$subscriptionStatusFilters: [CloudAccountStatus!]!)",
                "List<AzureSubscriptionWithFeaturesType>",
                Query.AllAzureCloudAccountSubscriptionsByFeature_ObjectFieldSpec,
                Query.AllAzureCloudAccountSubscriptionsByFeatureFieldSpec,
                @"# REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$inputs.Var.subscriptionStatusFilters = @(
	<CloudAccountStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountStatus]) for enum values.
)"
            );
        }

        // Create new GraphQL Query:
        // allAzureSubscriptionWithExocomputeMappings(features: [CloudAccountFeature!], exocomputeSubscriptionIdsFilter: [UUID!]): [AzureSubscriptionWithExocomputeMapping!]!
        internal void InitQueryAllAzureSubscriptionWithExocomputeMappings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("features", "[CloudAccountFeature!]"),
                Tuple.Create("exocomputeSubscriptionIdsFilter", "[UUID!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureSubscriptionWithExocomputeMappings",
                "($features: [CloudAccountFeature!],$exocomputeSubscriptionIdsFilter: [UUID!])",
                "List<AzureSubscriptionWithExocomputeMapping>",
                Query.AllAzureSubscriptionWithExocomputeMappings_ObjectFieldSpec,
                Query.AllAzureSubscriptionWithExocomputeMappingsFieldSpec,
                @"# OPTIONAL
$inputs.Var.features = @(
	<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
)
# OPTIONAL
$inputs.Var.exocomputeSubscriptionIdsFilter = @(
	<System.String>
)"
            );
        }

        // Create new GraphQL Query:
        // allResourceGroupsFromAzure(cloudAccountId: UUID!, azureSubscriptionNativeId: UUID!, feature: CloudAccountFeature!): [AzureResourceGroup!]!
        internal void InitQueryAllResourceGroupsFromAzure()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
                Tuple.Create("azureSubscriptionNativeId", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllResourceGroupsFromAzure",
                "($cloudAccountId: UUID!,$azureSubscriptionNativeId: UUID!,$feature: CloudAccountFeature!)",
                "List<AzureResourceGroup>",
                Query.AllResourceGroupsFromAzure_ObjectFieldSpec,
                Query.AllResourceGroupsFromAzureFieldSpec,
                @"# REQUIRED
$inputs.Var.cloudAccountId = <System.String>
# REQUIRED
$inputs.Var.azureSubscriptionNativeId = <System.String>
# REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // doesAzureNativeResourceGroupExist(
        //     cloudAccountId: UUID!
        //     azureSubscriptionNativeId: UUID!
        //     resourceGroupName: String!
        //     feature: CloudAccountFeature!
        //   ): Boolean!
        internal void InitQueryDoesAzureNativeResourceGroupExist()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
                Tuple.Create("azureSubscriptionNativeId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDoesAzureNativeResourceGroupExist",
                "($cloudAccountId: UUID!,$azureSubscriptionNativeId: UUID!,$resourceGroupName: String!,$feature: CloudAccountFeature!)",
                "System.Boolean",
                Query.DoesAzureNativeResourceGroupExist_ObjectFieldSpec,
                Query.DoesAzureNativeResourceGroupExistFieldSpec,
                @"# REQUIRED
$inputs.Var.cloudAccountId = <System.String>
# REQUIRED
$inputs.Var.azureSubscriptionNativeId = <System.String>
# REQUIRED
$inputs.Var.resourceGroupName = <System.String>
# REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allAzureNativeResourceGroupsInfoIfExist(input: AzureGetResourceGroupsInfoIfExistInput!): [AzureResourceGroupInfo!]!
        internal void InitQueryAllAzureNativeResourceGroupsInfoIfExist()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AzureGetResourceGroupsInfoIfExistInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNativeResourceGroupsInfoIfExist",
                "($input: AzureGetResourceGroupsInfoIfExistInput!)",
                "List<AzureResourceGroupInfo>",
                Query.AllAzureNativeResourceGroupsInfoIfExist_ObjectFieldSpec,
                Query.AllAzureNativeResourceGroupsInfoIfExistFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	sessionId = <System.String>
	# REQUIRED
	resourceGroupInputs = @(
		@{
			# REQUIRED
			subscriptionNativeId = <System.String>
			# REQUIRED
			resourceGroupName = <System.String>
		}
	)
}"
            );
        }

        // Create new GraphQL Query:
        // allAzureCloudAccountMissingPermissions(sessionId: String!, subscriptionIds: [UUID!]!, cloudAccountAction: CloudAccountAction!): [AzureSubscriptionMissingPermissions!]!
        internal void InitQueryAllAzureCloudAccountMissingPermissions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("sessionId", "String!"),
                Tuple.Create("subscriptionIds", "[UUID!]!"),
                Tuple.Create("cloudAccountAction", "CloudAccountAction!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureCloudAccountMissingPermissions",
                "($sessionId: String!,$subscriptionIds: [UUID!]!,$cloudAccountAction: CloudAccountAction!)",
                "List<AzureSubscriptionMissingPermissions>",
                Query.AllAzureCloudAccountMissingPermissions_ObjectFieldSpec,
                Query.AllAzureCloudAccountMissingPermissionsFieldSpec,
                @"# REQUIRED
$inputs.Var.sessionId = <System.String>
# REQUIRED
$inputs.Var.subscriptionIds = @(
	<System.String>
)
# REQUIRED
$inputs.Var.cloudAccountAction = <CloudAccountAction> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountAction]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // azureCloudAccountPermissionConfig(feature: CloudAccountFeature!): AzureCloudAccountPermissionConfigResponse!
        internal void InitQueryAzureCloudAccountPermissionConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("feature", "CloudAccountFeature!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureCloudAccountPermissionConfig",
                "($feature: CloudAccountFeature!)",
                "AzureCloudAccountPermissionConfigResponse",
                Query.AzureCloudAccountPermissionConfig_ObjectFieldSpec,
                Query.AzureCloudAccountPermissionConfigFieldSpec,
                @"# REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allAzureExocomputeConfigsInAccount(azureExocomputeSearchQuery: String, cloudAccountIDs: [UUID!]): [AzureExocomputeConfigsInAccount!]!
        internal void InitQueryAllAzureExocomputeConfigsInAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureExocomputeSearchQuery", "String"),
                Tuple.Create("cloudAccountIDs", "[UUID!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureExocomputeConfigsInAccount",
                "($azureExocomputeSearchQuery: String,$cloudAccountIDs: [UUID!])",
                "List<AzureExocomputeConfigsInAccount>",
                Query.AllAzureExocomputeConfigsInAccount_ObjectFieldSpec,
                Query.AllAzureExocomputeConfigsInAccountFieldSpec,
                @"# OPTIONAL
$inputs.Var.azureExocomputeSearchQuery = <System.String>
# OPTIONAL
$inputs.Var.cloudAccountIDs = @(
	<System.String>
)"
            );
        }

        // Create new GraphQL Query:
        // allAzureCloudAccountSubnetsByRegion(cloudAccountId: UUID!, region: AzureCloudAccountRegion!): [AzureNativeSubnet!]!
        internal void InitQueryAllAzureCloudAccountSubnetsByRegion()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
                Tuple.Create("region", "AzureCloudAccountRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureCloudAccountSubnetsByRegion",
                "($cloudAccountId: UUID!,$region: AzureCloudAccountRegion!)",
                "List<AzureNativeSubnet>",
                Query.AllAzureCloudAccountSubnetsByRegion_ObjectFieldSpec,
                Query.AllAzureCloudAccountSubnetsByRegionFieldSpec,
                @"# REQUIRED
$inputs.Var.cloudAccountId = <System.String>
# REQUIRED
$inputs.Var.region = <AzureCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // validateAzureCloudAccountExocomputeConfigurations(input: ValidateAzureCloudAccountExocomputeConfigurationsInput!): ValidateAzureSubnetsForCloudAccountExocomputeReply!
        internal void InitQueryValidateAzureCloudAccountExocomputeConfigurations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ValidateAzureCloudAccountExocomputeConfigurationsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryValidateAzureCloudAccountExocomputeConfigurations",
                "($input: ValidateAzureCloudAccountExocomputeConfigurationsInput!)",
                "ValidateAzureSubnetsForCloudAccountExocomputeReply",
                Query.ValidateAzureCloudAccountExocomputeConfigurations_ObjectFieldSpec,
                Query.ValidateAzureCloudAccountExocomputeConfigurationsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	azureExocomputeRegionConfigs = @(
		@{
			# REQUIRED
			region = <AzureCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
			# REQUIRED
			subnetNativeId = <System.String>
			# REQUIRED
			isRscManaged = <System.Boolean>
			# OPTIONAL
			podSubnetNativeId = <System.String>
		}
	)
}"
            );
        }

        // Create new GraphQL Query:
        // allAzureArmTemplatesByFeature(input: AzureArmTemplatesByFeatureInput!): [AzureArmTemplateByFeature!]!
        internal void InitQueryAllAzureArmTemplatesByFeature()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AzureArmTemplatesByFeatureInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureArmTemplatesByFeature",
                "($input: AzureArmTemplatesByFeatureInput!)",
                "List<AzureArmTemplateByFeature>",
                Query.AllAzureArmTemplatesByFeature_ObjectFieldSpec,
                Query.AllAzureArmTemplatesByFeatureFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	customerTenantDomainName = <System.String>
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# REQUIRED
	operationType = <CloudAccountOperation> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountOperation]) for enum values.
	# REQUIRED
	cloudType = <AzureCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
	# OPTIONAL
	featuresToInclude = @(
		@{
			# OPTIONAL
			permissionsGroups = @(
				<PermissionsGroup> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
			)
			# REQUIRED
			featureType = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
		}
	)
}"
            );
        }

        // Create new GraphQL Query:
        // checkAzurePersistentStorageSubscriptionCanUnmap(cloudAccountId: UUID!, feature: CloudAccountFeature!, unmappingValidationType: UnmappingValidationType!): CheckAzurePersistentStorageSubscriptionCanUnmapReply!
        internal void InitQueryCheckAzurePersistentStorageSubscriptionCanUnmap()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("unmappingValidationType", "UnmappingValidationType!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCheckAzurePersistentStorageSubscriptionCanUnmap",
                "($cloudAccountId: UUID!,$feature: CloudAccountFeature!,$unmappingValidationType: UnmappingValidationType!)",
                "CheckAzurePersistentStorageSubscriptionCanUnmapReply",
                Query.CheckAzurePersistentStorageSubscriptionCanUnmap_ObjectFieldSpec,
                Query.CheckAzurePersistentStorageSubscriptionCanUnmapFieldSpec,
                @"# REQUIRED
$inputs.Var.cloudAccountId = <System.String>
# REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$inputs.Var.unmappingValidationType = <UnmappingValidationType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmappingValidationType]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // azureSubscriptions(tenantId: String!): AzureSubscriptionConnection!
        internal void InitQueryAzureSubscriptions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSubscriptions",
                "($tenantId: String!)",
                "AzureSubscriptionConnection",
                Query.AzureSubscriptions_ObjectFieldSpec,
                Query.AzureSubscriptionsFieldSpec,
                @"# REQUIRED
$inputs.Var.tenantId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // azureRegions(tenantId: String!, subscriptionId: UUID!): RegionConnection!
        internal void InitQueryAzureRegions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureRegions",
                "($tenantId: String!,$subscriptionId: UUID!)",
                "RegionConnection",
                Query.AzureRegions_ObjectFieldSpec,
                Query.AzureRegionsFieldSpec,
                @"# REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // azureResourceGroups(tenantId: String!, subscriptionId: UUID!): ResourceGroupConnection!
        internal void InitQueryAzureResourceGroups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureResourceGroups",
                "($tenantId: String!,$subscriptionId: UUID!)",
                "ResourceGroupConnection",
                Query.AzureResourceGroups_ObjectFieldSpec,
                Query.AzureResourceGroupsFieldSpec,
                @"# REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // azureVNets(tenantId: String!, subscriptionId: UUID!, regionName: String!): VnetConnection!
        internal void InitQueryAzureVnets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("regionName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureVnets",
                "($tenantId: String!,$subscriptionId: UUID!,$regionName: String!)",
                "VnetConnection",
                Query.AzureVnets_ObjectFieldSpec,
                Query.AzureVnetsFieldSpec,
                @"# REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.regionName = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // azureSubnets(tenantId: String!, subscriptionId: UUID!, vNetId: String!): SubnetConnection!
        internal void InitQueryAzureSubnets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("vNetId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSubnets",
                "($tenantId: String!,$subscriptionId: UUID!,$vNetId: String!)",
                "SubnetConnection",
                Query.AzureSubnets_ObjectFieldSpec,
                Query.AzureSubnetsFieldSpec,
                @"# REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.vNetId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // azureStorageAccounts(tenantId: String!, subscriptionId: UUID!, regionName: String!): StorageAccountConnection!
        internal void InitQueryAzureStorageAccounts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("regionName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureStorageAccounts",
                "($tenantId: String!,$subscriptionId: UUID!,$regionName: String!)",
                "StorageAccountConnection",
                Query.AzureStorageAccounts_ObjectFieldSpec,
                Query.AzureStorageAccountsFieldSpec,
                @"# REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.regionName = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // allHostedAzureRegions: AzureRegionsResp!
        internal void InitQueryAllHostedAzureRegions()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllHostedAzureRegions",
                "",
                "AzureRegionsResp",
                Query.AllHostedAzureRegions_ObjectFieldSpec,
                Query.AllHostedAzureRegionsFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // allAzureResourceGroups(cloudAccountId: String!, azureRegion: String!): [String!]!
        internal void InitQueryAllAzureResourceGroups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "String!"),
                Tuple.Create("azureRegion", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureResourceGroups",
                "($cloudAccountId: String!,$azureRegion: String!)",
                "List<System.String>",
                Query.AllAzureResourceGroups_ObjectFieldSpec,
                Query.AllAzureResourceGroupsFieldSpec,
                @"# REQUIRED
$inputs.Var.cloudAccountId = <System.String>
# REQUIRED
$inputs.Var.azureRegion = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // allAzureVnets(vnetRequest: AzureVnetReq!): [String!]!
        internal void InitQueryAllAzureVnets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("vnetRequest", "AzureVnetReq!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureVnets",
                "($vnetRequest: AzureVnetReq!)",
                "List<System.String>",
                Query.AllAzureVnets_ObjectFieldSpec,
                Query.AllAzureVnetsFieldSpec,
                @"# REQUIRED
$inputs.Var.vnetRequest = @{
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	resourceGroup = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // allAzureSubnets(subnetRequest: AzureSubnetReq!): [String!]!
        internal void InitQueryAllAzureSubnets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("subnetRequest", "AzureSubnetReq!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureSubnets",
                "($subnetRequest: AzureSubnetReq!)",
                "List<System.String>",
                Query.AllAzureSubnets_ObjectFieldSpec,
                Query.AllAzureSubnetsFieldSpec,
                @"# REQUIRED
$inputs.Var.subnetRequest = @{
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	resourceGroup = <System.String>
	# OPTIONAL
	vnetName = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // allAzureCdmVersions(cdmVersionRequest: AzureCdmVersionReq!): [AzureCdmVersion!]!
        internal void InitQueryAllAzureCdmVersions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cdmVersionRequest", "AzureCdmVersionReq!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureCdmVersions",
                "($cdmVersionRequest: AzureCdmVersionReq!)",
                "List<AzureCdmVersion>",
                Query.AllAzureCdmVersions_ObjectFieldSpec,
                Query.AllAzureCdmVersionsFieldSpec,
                @"# REQUIRED
$inputs.Var.cdmVersionRequest = @{
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	location = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // allAzureRegions(cloudAccountId: String!): [AzureCloudAccountRegion!]!
        internal void InitQueryAllAzureRegions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureRegions",
                "($cloudAccountId: String!)",
                "List<AzureCloudAccountRegion>",
                Query.AllAzureRegions_ObjectFieldSpec,
                Query.AllAzureRegionsFieldSpec,
                @"# REQUIRED
$inputs.Var.cloudAccountId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // allAzureNsgs(nsgRequest: AzureNsgRequest!): [String!]!
        internal void InitQueryAllAzureNsgs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("nsgRequest", "AzureNsgRequest!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNsgs",
                "($nsgRequest: AzureNsgRequest!)",
                "List<System.String>",
                Query.AllAzureNsgs_ObjectFieldSpec,
                Query.AllAzureNsgsFieldSpec,
                @"# REQUIRED
$inputs.Var.nsgRequest = @{
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	resourceGroup = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // allAzureStorageAccounts(storageAccountsRequest: AzureStorageAccountsReq!): [String!]!
        internal void InitQueryAllAzureStorageAccounts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("storageAccountsRequest", "AzureStorageAccountsReq!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureStorageAccounts",
                "($storageAccountsRequest: AzureStorageAccountsReq!)",
                "List<System.String>",
                Query.AllAzureStorageAccounts_ObjectFieldSpec,
                Query.AllAzureStorageAccountsFieldSpec,
                @"# REQUIRED
$inputs.Var.storageAccountsRequest = @{
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	resourceGroup = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // allAzureManagedIdentities(managedIdentitiesRequest: AzureManagedIdentitiesRequest!): [AzureManagedIdentity!]!
        internal void InitQueryAllAzureManagedIdentities()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("managedIdentitiesRequest", "AzureManagedIdentitiesRequest!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureManagedIdentities",
                "($managedIdentitiesRequest: AzureManagedIdentitiesRequest!)",
                "List<AzureManagedIdentity>",
                Query.AllAzureManagedIdentities_ObjectFieldSpec,
                Query.AllAzureManagedIdentitiesFieldSpec,
                @"# REQUIRED
$inputs.Var.managedIdentitiesRequest = @{
	# REQUIRED
	cloudAccountId = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // azureAdDirectories(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): AzureAdDirectoryConnection!
        internal void InitQueryAzureAdDirectories()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureAdDirectories",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "AzureAdDirectoryConnection",
                Query.AzureAdDirectories_ObjectFieldSpec,
                Query.AzureAdDirectoriesFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)"
            );
        }

        // Create new GraphQL Query:
        // azureAdDirectory(workloadFid: UUID!): AzureAdDirectory!
        internal void InitQueryAzureAdDirectory()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("workloadFid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureAdDirectory",
                "($workloadFid: UUID!)",
                "AzureAdDirectory",
                Query.AzureAdDirectory_ObjectFieldSpec,
                Query.AzureAdDirectoryFieldSpec,
                @"# REQUIRED
$inputs.Var.workloadFid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // azureAdObjectsByType(
        //     first: Int
        //     after: String
        //     sortByOption: [AzureAdObjectSearchType!]
        //     sortOrder: SortOrder
        //     input: AzureAdObjectTypeInput!
        //   ): AzureAdObjectConnection!
        internal void InitQueryAzureAdObjectsByType()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortByOption", "[AzureAdObjectSearchType!]"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("input", "AzureAdObjectTypeInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureAdObjectsByType",
                "($first: Int,$after: String,$sortByOption: [AzureAdObjectSearchType!],$sortOrder: SortOrder,$input: AzureAdObjectTypeInput!)",
                "AzureAdObjectConnection",
                Query.AzureAdObjectsByType_ObjectFieldSpec,
                Query.AzureAdObjectsByTypeFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortByOption = @(
	<AzureAdObjectSearchType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdObjectSearchType]) for enum values.
)
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snapshotId = <System.String>
	# REQUIRED
	azureAdObjectType = <AzureAdObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdObjectType]) for enum values.
}"
            );
        }

        // Create new GraphQL Query:
        // searchAzureAdSnapshot(first: Int, after: String, input: SearchAzureAdSnapshotInput!): AzureAdObjectConnection!
        internal void InitQuerySearchAzureAdSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("input", "SearchAzureAdSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySearchAzureAdSnapshot",
                "($first: Int,$after: String,$input: SearchAzureAdSnapshotInput!)",
                "AzureAdObjectConnection",
                Query.SearchAzureAdSnapshot_ObjectFieldSpec,
                Query.SearchAzureAdSnapshotFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snapshotId = <System.String>
	# REQUIRED
	azureAdSearchKeyword = <System.String>
	# REQUIRED
	azureAdObjectType = <AzureAdObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdObjectType]) for enum values.
	# REQUIRED
	azureAdSearchKeywordType = <AzureAdObjectSearchType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdObjectSearchType]) for enum values.
}"
            );
        }


    } // class New_RscQueryAzure
}