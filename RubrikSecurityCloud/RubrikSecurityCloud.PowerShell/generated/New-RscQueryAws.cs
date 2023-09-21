// New-RscQueryAws.cs
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
    /// Queries for the 'AWS' API domain.
    /// </summary>
    /// <description>
    /// New-RscQueryAws is a master cmdlet for Aws work that can invoke any of the following subcommands: NativeRoot, NativeAccount, NativeEc2Instance, NativeEbsVolume, NativeS3Bucket, NativeAccounts, NativeEc2InstancesByName, NativeEc2Instances, NativeEbsVolumesByName, NativeEbsVolumes, AllVpcsByRegion, AllVpcs, IsNativeEbsVolumeSnapshotRestorable, AllAvailabilityZonesByRegion, AllKmsEncryptionKeysByRegion, IsS3BucketNameAvailable, AllS3Buckets, AllS3BucketsDetails, NativeRdsInstance, NativeRdsInstances, NativeRdsPointInTimeRestoreWindow, RdsInstanceDetails, IsNativeRdsInstanceLaunchConfigurationValid, AllOptionGroupsByRegion, AllDbParameterGroupsByRegion, AllDbSubnetGroupsByRegion, ValidateNativeRdsInstanceNameForExport, ValidateNativeRdsClusterNameForExport, NativeRdsExportDefaults, AllEc2KeyPairsByRegion, AmiTypeForNativeArchivedSnapshotExport, AllSupportedRdsDatabaseInstanceClasses, ComputeSettings, AllComputeSettings, AllCloudAccountsWithFeatures, CloudAccountWithFeatures, CloudAccountListVpcs, CloudAccountListSubnets, CloudAccountListSecurityGroups, AllExocomputeConfigs, AllCloudAccountConfigs, TrustPolicy, AllPermissionPolicies, ArtifactsToDelete, AllRegions, AllCdmVersions, AllInstanceProfileNames.
    /// </description>
    /// <example>
    /// <code>New-RscQueryAws -NativeRoot [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -NativeAccount [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -NativeEc2Instance [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -NativeEbsVolume [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -NativeS3Bucket [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -NativeAccounts [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -NativeEc2InstancesByName [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -NativeEc2Instances [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -NativeEbsVolumesByName [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -NativeEbsVolumes [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -AllVpcsByRegion [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -AllVpcs [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -IsNativeEbsVolumeSnapshotRestorable [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -AllAvailabilityZonesByRegion [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -AllKmsEncryptionKeysByRegion [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -IsS3BucketNameAvailable [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -AllS3Buckets [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -AllS3BucketsDetails [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -NativeRdsInstance [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -NativeRdsInstances [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -NativeRdsPointInTimeRestoreWindow [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -RdsInstanceDetails [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -IsNativeRdsInstanceLaunchConfigurationValid [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -AllOptionGroupsByRegion [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -AllDbParameterGroupsByRegion [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -AllDbSubnetGroupsByRegion [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -ValidateNativeRdsInstanceNameForExport [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -ValidateNativeRdsClusterNameForExport [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -NativeRdsExportDefaults [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -AllEc2KeyPairsByRegion [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -AmiTypeForNativeArchivedSnapshotExport [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -AllSupportedRdsDatabaseInstanceClasses [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -ComputeSettings [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -AllComputeSettings [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -AllCloudAccountsWithFeatures [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -CloudAccountWithFeatures [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -CloudAccountListVpcs [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -CloudAccountListSubnets [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -CloudAccountListSecurityGroups [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -AllExocomputeConfigs [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -AllCloudAccountConfigs [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -TrustPolicy [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -AllPermissionPolicies [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -ArtifactsToDelete [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -AllRegions [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -AllCdmVersions [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAws -AllInstanceProfileNames [-Arg ..] [-Field ..]</code>
    /// </example>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscQueryAws",
        DefaultParameterSetName = "AllVpcs")
    ]
    public class New_RscQueryAws : RscGqlPSCmdlet
    {
        
        /// <summary>
        /// NativeRoot parameter set
        ///
        /// [GraphQL: awsNativeRoot]
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeRoot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Root of AWS native hierarchy.
[GraphQL: awsNativeRoot]",
            Position = 0
        )]
        public SwitchParameter NativeRoot { get; set; }

        
        /// <summary>
        /// NativeAccount parameter set
        ///
        /// [GraphQL: awsNativeAccount]
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Refers to the AWS Native account that serves as a container for all your AWS resources. The AWS Native account contains information about the metadata related to the AWS Native resources.
[GraphQL: awsNativeAccount]",
            Position = 0
        )]
        public SwitchParameter NativeAccount { get; set; }

        
        /// <summary>
        /// NativeEc2Instance parameter set
        ///
        /// [GraphQL: awsNativeEc2Instance]
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeEc2Instance",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Refers to Amazon Elastic Compute Cloud (EC2) Instance represented by a specific ID. For more information, see https://aws.amazon.com/ec2/.
[GraphQL: awsNativeEc2Instance]",
            Position = 0
        )]
        public SwitchParameter NativeEc2Instance { get; set; }

        
        /// <summary>
        /// NativeEbsVolume parameter set
        ///
        /// [GraphQL: awsNativeEbsVolume]
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeEbsVolume",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Refers to the Amazon Elastic Block Store (EBS) Volume represented by a specific ID. For more information, see https://aws.amazon.com/ebs/.
[GraphQL: awsNativeEbsVolume]",
            Position = 0
        )]
        public SwitchParameter NativeEbsVolume { get; set; }

        
        /// <summary>
        /// NativeS3Bucket parameter set
        ///
        /// [GraphQL: awsNativeS3Bucket]
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeS3Bucket",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Represents the Amazon S3 Bucket with a specific ID. For more information, see https://aws.amazon.com/s3/.
[GraphQL: awsNativeS3Bucket]",
            Position = 0
        )]
        public SwitchParameter NativeS3Bucket { get; set; }

        
        /// <summary>
        /// NativeAccounts parameter set
        ///
        /// [GraphQL: awsNativeAccounts]
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeAccounts",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of all AWS Native accounts.
[GraphQL: awsNativeAccounts]",
            Position = 0
        )]
        public SwitchParameter NativeAccounts { get; set; }

        
        /// <summary>
        /// NativeEc2InstancesByName parameter set
        ///
        /// [GraphQL: awsNativeEc2InstancesByName]
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeEc2InstancesByName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of all AWS EC2 Instances by name or substring of name.
[GraphQL: awsNativeEc2InstancesByName]",
            Position = 0
        )]
        public SwitchParameter NativeEc2InstancesByName { get; set; }

        
        /// <summary>
        /// NativeEc2Instances parameter set
        ///
        /// [GraphQL: awsNativeEc2Instances]
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeEc2Instances",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of all AWS EC2 Instances.
[GraphQL: awsNativeEc2Instances]",
            Position = 0
        )]
        public SwitchParameter NativeEc2Instances { get; set; }

        
        /// <summary>
        /// NativeEbsVolumesByName parameter set
        ///
        /// [GraphQL: awsNativeEbsVolumesByName]
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeEbsVolumesByName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of all AWS EBS Volumes by name or substring of name.
[GraphQL: awsNativeEbsVolumesByName]",
            Position = 0
        )]
        public SwitchParameter NativeEbsVolumesByName { get; set; }

        
        /// <summary>
        /// NativeEbsVolumes parameter set
        ///
        /// [GraphQL: awsNativeEbsVolumes]
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeEbsVolumes",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of all AWS EBS Volumes.
[GraphQL: awsNativeEbsVolumes]",
            Position = 0
        )]
        public SwitchParameter NativeEbsVolumes { get; set; }

        
        /// <summary>
        /// AllVpcsByRegion parameter set
        ///
        /// [GraphQL: allVpcsByRegionFromAws]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllVpcsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all Virtual Private Clouds (VPCs) in the AWS Native account, classified by region.
[GraphQL: allVpcsByRegionFromAws]",
            Position = 0
        )]
        public SwitchParameter AllVpcsByRegion { get; set; }

        
        /// <summary>
        /// AllVpcs parameter set
        ///
        /// [GraphQL: allVpcsFromAws]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllVpcs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all Virtual Private Clouds (VPCs) in the AWS Native account.
[GraphQL: allVpcsFromAws]",
            Position = 0
        )]
        public SwitchParameter AllVpcs { get; set; }

        
        /// <summary>
        /// IsNativeEbsVolumeSnapshotRestorable parameter set
        ///
        /// [GraphQL: isAwsNativeEbsVolumeSnapshotRestorable]
        /// </summary>
        [Parameter(
            ParameterSetName = "IsNativeEbsVolumeSnapshotRestorable",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Specified whether an EBS volume is restorable. For an EBS Volume to be restorable, the volume should be able to replace where attached.
[GraphQL: isAwsNativeEbsVolumeSnapshotRestorable]",
            Position = 0
        )]
        public SwitchParameter IsNativeEbsVolumeSnapshotRestorable { get; set; }

        
        /// <summary>
        /// AllAvailabilityZonesByRegion parameter set
        ///
        /// [GraphQL: allAvailabilityZonesByRegionFromAws]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllAvailabilityZonesByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of Availability Zones (AZs) in the specified region on the specified AWS Native account.
[GraphQL: allAvailabilityZonesByRegionFromAws]",
            Position = 0
        )]
        public SwitchParameter AllAvailabilityZonesByRegion { get; set; }

        
        /// <summary>
        /// AllKmsEncryptionKeysByRegion parameter set
        ///
        /// [GraphQL: allKmsEncryptionKeysByRegionFromAws]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllKmsEncryptionKeysByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of encryption keys in the specified region on the specified AWS Native account. All the encrytion keys listed are managed by AWS Key Management System (KMS). For more information, see https://aws.amazon.com/kms/.
[GraphQL: allKmsEncryptionKeysByRegionFromAws]",
            Position = 0
        )]
        public SwitchParameter AllKmsEncryptionKeysByRegion { get; set; }

        
        /// <summary>
        /// IsS3BucketNameAvailable parameter set
        ///
        /// [GraphQL: isAwsS3BucketNameAvailable]
        /// </summary>
        [Parameter(
            ParameterSetName = "IsS3BucketNameAvailable",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Specifies whether an S3 bucket name is available for use in AWS or not. When true, the bucket name is available for use.
[GraphQL: isAwsS3BucketNameAvailable]",
            Position = 0
        )]
        public SwitchParameter IsS3BucketNameAvailable { get; set; }

        
        /// <summary>
        /// AllS3Buckets parameter set
        ///
        /// [GraphQL: allS3BucketsFromAws]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllS3Buckets",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all S3 bucket names across regions for the AWS Native account.
[GraphQL: allS3BucketsFromAws]",
            Position = 0
        )]
        public SwitchParameter AllS3Buckets { get; set; }

        
        /// <summary>
        /// AllS3BucketsDetails parameter set
        ///
        /// [GraphQL: allS3BucketsDetailsFromAws]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllS3BucketsDetails",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all S3 bucket details across regions for the AWS Native account.
[GraphQL: allS3BucketsDetailsFromAws]",
            Position = 0
        )]
        public SwitchParameter AllS3BucketsDetails { get; set; }

        
        /// <summary>
        /// NativeRdsInstance parameter set
        ///
        /// [GraphQL: awsNativeRdsInstance]
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeRdsInstance",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Refers to AWS Relational Database Service (RDS) represented by a specific ID. For more information, see https://aws.amazon.com/rds/.
[GraphQL: awsNativeRdsInstance]",
            Position = 0
        )]
        public SwitchParameter NativeRdsInstance { get; set; }

        
        /// <summary>
        /// NativeRdsInstances parameter set
        ///
        /// [GraphQL: awsNativeRdsInstances]
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeRdsInstances",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of AWS RDS Instances on AWS Native account.
[GraphQL: awsNativeRdsInstances]",
            Position = 0
        )]
        public SwitchParameter NativeRdsInstances { get; set; }

        
        /// <summary>
        /// NativeRdsPointInTimeRestoreWindow parameter set
        ///
        /// [GraphQL: awsNativeRdsPointInTimeRestoreWindow]
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeRdsPointInTimeRestoreWindow",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Point-in-Time (PiT) restore window of the RDS Instance in the AWS Native account. Refers to the range of time within which the database is available to be restored to a particular point in time. For more information,see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PIT.html.
[GraphQL: awsNativeRdsPointInTimeRestoreWindow]",
            Position = 0
        )]
        public SwitchParameter NativeRdsPointInTimeRestoreWindow { get; set; }

        
        /// <summary>
        /// RdsInstanceDetails parameter set
        ///
        /// [GraphQL: rdsInstanceDetailsFromAws]
        /// </summary>
        [Parameter(
            ParameterSetName = "RdsInstanceDetails",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details of the RDS Instance in the AWS Native account.
[GraphQL: rdsInstanceDetailsFromAws]",
            Position = 0
        )]
        public SwitchParameter RdsInstanceDetails { get; set; }

        
        /// <summary>
        /// IsNativeRdsInstanceLaunchConfigurationValid parameter set
        ///
        /// [GraphQL: isAwsNativeRdsInstanceLaunchConfigurationValid]
        /// </summary>
        [Parameter(
            ParameterSetName = "IsNativeRdsInstanceLaunchConfigurationValid",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Specifies whether the given DbInstance class, storage type, multi-az capability, encryption capability, iops value are supported for the given dbEngine, dbEngineVersion in the specified availability zone. When true, the specification is valid for a RDS Instance and can be used to create a new Instance.
[GraphQL: isAwsNativeRdsInstanceLaunchConfigurationValid]",
            Position = 0
        )]
        public SwitchParameter IsNativeRdsInstanceLaunchConfigurationValid { get; set; }

        
        /// <summary>
        /// AllOptionGroupsByRegion parameter set
        ///
        /// [GraphQL: allOptionGroupsByRegionFromAws]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllOptionGroupsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all RDS option groups in a given region. Refers to settings of how a particular option works for an RDS Instance. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_WorkingWithOptionGroups.html.
[GraphQL: allOptionGroupsByRegionFromAws]",
            Position = 0
        )]
        public SwitchParameter AllOptionGroupsByRegion { get; set; }

        
        /// <summary>
        /// AllDbParameterGroupsByRegion parameter set
        ///
        /// [GraphQL: allDbParameterGroupsByRegionFromAws]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllDbParameterGroupsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all DB parameter groups in a given region. Refers to container for engine configuration that applies to one or more DB Instances. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_WorkingWithOptionGroups.html.
[GraphQL: allDbParameterGroupsByRegionFromAws]",
            Position = 0
        )]
        public SwitchParameter AllDbParameterGroupsByRegion { get; set; }

        
        /// <summary>
        /// AllDbSubnetGroupsByRegion parameter set
        ///
        /// [GraphQL: allDbSubnetGroupsByRegionFromAws]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllDbSubnetGroupsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"All DB subnet groups in a given region. Refers to logical isolation of RDS on a network. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_VPC.WorkingWithRDSInstanceinaVPC.html.
[GraphQL: allDbSubnetGroupsByRegionFromAws]",
            Position = 0
        )]
        public SwitchParameter AllDbSubnetGroupsByRegion { get; set; }

        
        /// <summary>
        /// ValidateNativeRdsInstanceNameForExport parameter set
        ///
        /// [GraphQL: validateAwsNativeRdsInstanceNameForExport]
        /// </summary>
        [Parameter(
            ParameterSetName = "ValidateNativeRdsInstanceNameForExport",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Validates the name used for an RDS Instance during an export operation. Returns true if the RDS Instance name is valid. Returns false, with an error message, if the RDS Instance name validation fails. Returns false, without an error message for all other failures.
[GraphQL: validateAwsNativeRdsInstanceNameForExport]",
            Position = 0
        )]
        public SwitchParameter ValidateNativeRdsInstanceNameForExport { get; set; }

        
        /// <summary>
        /// ValidateNativeRdsClusterNameForExport parameter set
        ///
        /// [GraphQL: validateAwsNativeRdsClusterNameForExport]
        /// </summary>
        [Parameter(
            ParameterSetName = "ValidateNativeRdsClusterNameForExport",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Validates the name used for an RDS cluster during an export operation. Returns true if the RDS cluster name is valid. Returns false, with an error message, if the RDS cluster name validation fails. Returns false, without an error message for all other failures.
[GraphQL: validateAwsNativeRdsClusterNameForExport]",
            Position = 0
        )]
        public SwitchParameter ValidateNativeRdsClusterNameForExport { get; set; }

        
        /// <summary>
        /// NativeRdsExportDefaults parameter set
        ///
        /// [GraphQL: awsNativeRdsExportDefaults]
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeRdsExportDefaults",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Refers to the default values for the export operation of the RDS DB Instance in the AWS Native account.
[GraphQL: awsNativeRdsExportDefaults]",
            Position = 0
        )]
        public SwitchParameter NativeRdsExportDefaults { get; set; }

        
        /// <summary>
        /// AllEc2KeyPairsByRegion parameter set
        ///
        /// [GraphQL: allEc2KeyPairsByRegionFromAws]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllEc2KeyPairsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all key pairs for a given region. A key pair, consisting of a public key and a private key, is a set of security credentials that you use to prove your identity when connecting to an EC2 instance. For more information, see https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html.
[GraphQL: allEc2KeyPairsByRegionFromAws]",
            Position = 0
        )]
        public SwitchParameter AllEc2KeyPairsByRegion { get; set; }

        
        /// <summary>
        /// AmiTypeForNativeArchivedSnapshotExport parameter set
        ///
        /// [GraphQL: amiTypeForAwsNativeArchivedSnapshotExport]
        /// </summary>
        [Parameter(
            ParameterSetName = "AmiTypeForNativeArchivedSnapshotExport",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Amazon Machine Image (AMI) type for export of an archived EC2 Instance snapshot. For more information, see https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instances-and-amis.html.
[GraphQL: amiTypeForAwsNativeArchivedSnapshotExport]",
            Position = 0
        )]
        public SwitchParameter AmiTypeForNativeArchivedSnapshotExport { get; set; }

        
        /// <summary>
        /// AllSupportedRdsDatabaseInstanceClasses parameter set
        ///
        /// [GraphQL: allSupportedAwsRdsDatabaseInstanceClasses]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllSupportedRdsDatabaseInstanceClasses",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all the database instance classes supported by AWS RDS database for the provided DB engine and engine version. DB engine version is a optional argument, it can be ignored if we want to retrieve all the supported instance class for a DB engine irrespective of DB engine version.
[GraphQL: allSupportedAwsRdsDatabaseInstanceClasses]",
            Position = 0
        )]
        public SwitchParameter AllSupportedRdsDatabaseInstanceClasses { get; set; }

        
        /// <summary>
        /// ComputeSettings parameter set
        ///
        /// [GraphQL: awsComputeSettings]
        /// </summary>
        [Parameter(
            ParameterSetName = "ComputeSettings",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieve aws compute settings.
[GraphQL: awsComputeSettings]",
            Position = 0
        )]
        public SwitchParameter ComputeSettings { get; set; }

        
        /// <summary>
        /// AllComputeSettings parameter set
        ///
        /// [GraphQL: allAwsComputeSettings]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllComputeSettings",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List all aws compute settings.
[GraphQL: allAwsComputeSettings]",
            Position = 0
        )]
        public SwitchParameter AllComputeSettings { get; set; }

        
        /// <summary>
        /// AllCloudAccountsWithFeatures parameter set
        ///
        /// [GraphQL: allAwsCloudAccountsWithFeatures]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllCloudAccountsWithFeatures",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of active AWS cloud accounts and the features for the accounts. A cloud account is an AWS account added to the Rubrik platform.
[GraphQL: allAwsCloudAccountsWithFeatures]",
            Position = 0
        )]
        public SwitchParameter AllCloudAccountsWithFeatures { get; set; }

        
        /// <summary>
        /// CloudAccountWithFeatures parameter set
        ///
        /// [GraphQL: awsCloudAccountWithFeatures]
        /// </summary>
        [Parameter(
            ParameterSetName = "CloudAccountWithFeatures",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of AWS cloud accounts and the features for each account, classified by ID.
[GraphQL: awsCloudAccountWithFeatures]",
            Position = 0
        )]
        public SwitchParameter CloudAccountWithFeatures { get; set; }

        
        /// <summary>
        /// CloudAccountListVpcs parameter set
        ///
        /// [GraphQL: awsCloudAccountListVpcs]
        /// </summary>
        [Parameter(
            ParameterSetName = "CloudAccountListVpcs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list of virtual private clouds (VPCs) in the specific cloud account.
[GraphQL: awsCloudAccountListVpcs]",
            Position = 0
        )]
        public SwitchParameter CloudAccountListVpcs { get; set; }

        
        /// <summary>
        /// CloudAccountListSubnets parameter set
        ///
        /// [GraphQL: awsCloudAccountListSubnets]
        /// </summary>
        [Parameter(
            ParameterSetName = "CloudAccountListSubnets",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list of subnets in the specified cloud account and virtual private cloud (VPC).
[GraphQL: awsCloudAccountListSubnets]",
            Position = 0
        )]
        public SwitchParameter CloudAccountListSubnets { get; set; }

        
        /// <summary>
        /// CloudAccountListSecurityGroups parameter set
        ///
        /// [GraphQL: awsCloudAccountListSecurityGroups]
        /// </summary>
        [Parameter(
            ParameterSetName = "CloudAccountListSecurityGroups",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list of security groups in the specified cloud account and virtual private cloud (VPC).
[GraphQL: awsCloudAccountListSecurityGroups]",
            Position = 0
        )]
        public SwitchParameter CloudAccountListSecurityGroups { get; set; }

        
        /// <summary>
        /// AllExocomputeConfigs parameter set
        ///
        /// [GraphQL: allAwsExocomputeConfigs]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllExocomputeConfigs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all AWS exocompute configurations filtered by a cloud account ID or a cloud account name prefix.
[GraphQL: allAwsExocomputeConfigs]",
            Position = 0
        )]
        public SwitchParameter AllExocomputeConfigs { get; set; }

        
        /// <summary>
        /// AllCloudAccountConfigs parameter set
        ///
        /// [GraphQL: allAwsCloudAccountConfigs]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllCloudAccountConfigs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of all AWS cloud account configurations with the given search query.
[GraphQL: allAwsCloudAccountConfigs]",
            Position = 0
        )]
        public SwitchParameter AllCloudAccountConfigs { get; set; }

        
        /// <summary>
        /// TrustPolicy parameter set
        ///
        /// [GraphQL: awsTrustPolicy]
        /// </summary>
        [Parameter(
            ParameterSetName = "TrustPolicy",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves the AWS trust policy that will be attached with each role (cross-account, exocompute, etc.) in the customer's environment.
[GraphQL: awsTrustPolicy]",
            Position = 0
        )]
        public SwitchParameter TrustPolicy { get; set; }

        
        /// <summary>
        /// AllPermissionPolicies parameter set
        ///
        /// [GraphQL: allAwsPermissionPolicies]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllPermissionPolicies",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves the permissions policy for all the input features along with any AWS-managed policy ARNs which need to be attached to the roles. Each policy document can be used to create an AWS-managed policy which then needs to be attached to corresponding role.
[GraphQL: allAwsPermissionPolicies]",
            Position = 0
        )]
        public SwitchParameter AllPermissionPolicies { get; set; }

        
        /// <summary>
        /// ArtifactsToDelete parameter set
        ///
        /// [GraphQL: awsArtifactsToDelete]
        /// </summary>
        [Parameter(
            ParameterSetName = "ArtifactsToDelete",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves the AWS artifacts that need to be deleted when an account is being deleted.
[GraphQL: awsArtifactsToDelete]",
            Position = 0
        )]
        public SwitchParameter ArtifactsToDelete { get; set; }

        
        /// <summary>
        /// AllRegions parameter set
        ///
        /// [GraphQL: allAwsRegions]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllRegions",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"All valid AWS regions for this cloud account.
[GraphQL: allAwsRegions]",
            Position = 0
        )]
        public SwitchParameter AllRegions { get; set; }

        
        /// <summary>
        /// AllCdmVersions parameter set
        ///
        /// [GraphQL: allAwsCdmVersions]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllCdmVersions",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get all Rubrik CDM versions in the AWS marketplace.
[GraphQL: allAwsCdmVersions]",
            Position = 0
        )]
        public SwitchParameter AllCdmVersions { get; set; }

        
        /// <summary>
        /// AllInstanceProfileNames parameter set
        ///
        /// [GraphQL: allAwsInstanceProfileNames]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllInstanceProfileNames",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"All Rubrik CC-ES instance profiles in the AWS account.
[GraphQL: allAwsInstanceProfileNames]",
            Position = 0
        )]
        public SwitchParameter AllInstanceProfileNames { get; set; }


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
                    case "NativeAccount":
                        this.ProcessRecord_NativeAccount();
                        break;
                    case "NativeEc2Instance":
                        this.ProcessRecord_NativeEc2Instance();
                        break;
                    case "NativeEbsVolume":
                        this.ProcessRecord_NativeEbsVolume();
                        break;
                    case "NativeS3Bucket":
                        this.ProcessRecord_NativeS3Bucket();
                        break;
                    case "NativeAccounts":
                        this.ProcessRecord_NativeAccounts();
                        break;
                    case "NativeEc2InstancesByName":
                        this.ProcessRecord_NativeEc2InstancesByName();
                        break;
                    case "NativeEc2Instances":
                        this.ProcessRecord_NativeEc2Instances();
                        break;
                    case "NativeEbsVolumesByName":
                        this.ProcessRecord_NativeEbsVolumesByName();
                        break;
                    case "NativeEbsVolumes":
                        this.ProcessRecord_NativeEbsVolumes();
                        break;
                    case "AllVpcsByRegion":
                        this.ProcessRecord_AllVpcsByRegion();
                        break;
                    case "AllVpcs":
                        this.ProcessRecord_AllVpcs();
                        break;
                    case "IsNativeEbsVolumeSnapshotRestorable":
                        this.ProcessRecord_IsNativeEbsVolumeSnapshotRestorable();
                        break;
                    case "AllAvailabilityZonesByRegion":
                        this.ProcessRecord_AllAvailabilityZonesByRegion();
                        break;
                    case "AllKmsEncryptionKeysByRegion":
                        this.ProcessRecord_AllKmsEncryptionKeysByRegion();
                        break;
                    case "IsS3BucketNameAvailable":
                        this.ProcessRecord_IsS3BucketNameAvailable();
                        break;
                    case "AllS3Buckets":
                        this.ProcessRecord_AllS3Buckets();
                        break;
                    case "AllS3BucketsDetails":
                        this.ProcessRecord_AllS3BucketsDetails();
                        break;
                    case "NativeRdsInstance":
                        this.ProcessRecord_NativeRdsInstance();
                        break;
                    case "NativeRdsInstances":
                        this.ProcessRecord_NativeRdsInstances();
                        break;
                    case "NativeRdsPointInTimeRestoreWindow":
                        this.ProcessRecord_NativeRdsPointInTimeRestoreWindow();
                        break;
                    case "RdsInstanceDetails":
                        this.ProcessRecord_RdsInstanceDetails();
                        break;
                    case "IsNativeRdsInstanceLaunchConfigurationValid":
                        this.ProcessRecord_IsNativeRdsInstanceLaunchConfigurationValid();
                        break;
                    case "AllOptionGroupsByRegion":
                        this.ProcessRecord_AllOptionGroupsByRegion();
                        break;
                    case "AllDbParameterGroupsByRegion":
                        this.ProcessRecord_AllDbParameterGroupsByRegion();
                        break;
                    case "AllDbSubnetGroupsByRegion":
                        this.ProcessRecord_AllDbSubnetGroupsByRegion();
                        break;
                    case "ValidateNativeRdsInstanceNameForExport":
                        this.ProcessRecord_ValidateNativeRdsInstanceNameForExport();
                        break;
                    case "ValidateNativeRdsClusterNameForExport":
                        this.ProcessRecord_ValidateNativeRdsClusterNameForExport();
                        break;
                    case "NativeRdsExportDefaults":
                        this.ProcessRecord_NativeRdsExportDefaults();
                        break;
                    case "AllEc2KeyPairsByRegion":
                        this.ProcessRecord_AllEc2KeyPairsByRegion();
                        break;
                    case "AmiTypeForNativeArchivedSnapshotExport":
                        this.ProcessRecord_AmiTypeForNativeArchivedSnapshotExport();
                        break;
                    case "AllSupportedRdsDatabaseInstanceClasses":
                        this.ProcessRecord_AllSupportedRdsDatabaseInstanceClasses();
                        break;
                    case "ComputeSettings":
                        this.ProcessRecord_ComputeSettings();
                        break;
                    case "AllComputeSettings":
                        this.ProcessRecord_AllComputeSettings();
                        break;
                    case "AllCloudAccountsWithFeatures":
                        this.ProcessRecord_AllCloudAccountsWithFeatures();
                        break;
                    case "CloudAccountWithFeatures":
                        this.ProcessRecord_CloudAccountWithFeatures();
                        break;
                    case "CloudAccountListVpcs":
                        this.ProcessRecord_CloudAccountListVpcs();
                        break;
                    case "CloudAccountListSubnets":
                        this.ProcessRecord_CloudAccountListSubnets();
                        break;
                    case "CloudAccountListSecurityGroups":
                        this.ProcessRecord_CloudAccountListSecurityGroups();
                        break;
                    case "AllExocomputeConfigs":
                        this.ProcessRecord_AllExocomputeConfigs();
                        break;
                    case "AllCloudAccountConfigs":
                        this.ProcessRecord_AllCloudAccountConfigs();
                        break;
                    case "TrustPolicy":
                        this.ProcessRecord_TrustPolicy();
                        break;
                    case "AllPermissionPolicies":
                        this.ProcessRecord_AllPermissionPolicies();
                        break;
                    case "ArtifactsToDelete":
                        this.ProcessRecord_ArtifactsToDelete();
                        break;
                    case "AllRegions":
                        this.ProcessRecord_AllRegions();
                        break;
                    case "AllCdmVersions":
                        this.ProcessRecord_AllCdmVersions();
                        break;
                    case "AllInstanceProfileNames":
                        this.ProcessRecord_AllInstanceProfileNames();
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
        // awsNativeRoot.
        internal void ProcessRecord_NativeRoot()
        {
            this._logger.name += " -NativeRoot";
            // Create new graphql operation awsNativeRoot
            InitQueryAwsNativeRoot();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeAccount.
        internal void ProcessRecord_NativeAccount()
        {
            this._logger.name += " -NativeAccount";
            // Create new graphql operation awsNativeAccount
            InitQueryAwsNativeAccount();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeEc2Instance.
        internal void ProcessRecord_NativeEc2Instance()
        {
            this._logger.name += " -NativeEc2Instance";
            // Create new graphql operation awsNativeEc2Instance
            InitQueryAwsNativeEc2Instance();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeEbsVolume.
        internal void ProcessRecord_NativeEbsVolume()
        {
            this._logger.name += " -NativeEbsVolume";
            // Create new graphql operation awsNativeEbsVolume
            InitQueryAwsNativeEbsVolume();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeS3Bucket.
        internal void ProcessRecord_NativeS3Bucket()
        {
            this._logger.name += " -NativeS3Bucket";
            // Create new graphql operation awsNativeS3Bucket
            InitQueryAwsNativeS3Bucket();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeAccounts.
        internal void ProcessRecord_NativeAccounts()
        {
            this._logger.name += " -NativeAccounts";
            // Create new graphql operation awsNativeAccounts
            InitQueryAwsNativeAccounts();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeEc2InstancesByName.
        internal void ProcessRecord_NativeEc2InstancesByName()
        {
            this._logger.name += " -NativeEc2InstancesByName";
            // Create new graphql operation awsNativeEc2InstancesByName
            InitQueryAwsNativeEc2InstancesByName();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeEc2Instances.
        internal void ProcessRecord_NativeEc2Instances()
        {
            this._logger.name += " -NativeEc2Instances";
            // Create new graphql operation awsNativeEc2Instances
            InitQueryAwsNativeEc2Instances();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeEbsVolumesByName.
        internal void ProcessRecord_NativeEbsVolumesByName()
        {
            this._logger.name += " -NativeEbsVolumesByName";
            // Create new graphql operation awsNativeEbsVolumesByName
            InitQueryAwsNativeEbsVolumesByName();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeEbsVolumes.
        internal void ProcessRecord_NativeEbsVolumes()
        {
            this._logger.name += " -NativeEbsVolumes";
            // Create new graphql operation awsNativeEbsVolumes
            InitQueryAwsNativeEbsVolumes();
        }

        // This parameter set invokes a single graphql operation:
        // allVpcsByRegionFromAws.
        internal void ProcessRecord_AllVpcsByRegion()
        {
            this._logger.name += " -AllVpcsByRegion";
            // Create new graphql operation allVpcsByRegionFromAws
            InitQueryAllVpcsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allVpcsFromAws.
        internal void ProcessRecord_AllVpcs()
        {
            this._logger.name += " -AllVpcs";
            // Create new graphql operation allVpcsFromAws
            InitQueryAllVpcsFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // isAwsNativeEbsVolumeSnapshotRestorable.
        internal void ProcessRecord_IsNativeEbsVolumeSnapshotRestorable()
        {
            this._logger.name += " -IsNativeEbsVolumeSnapshotRestorable";
            // Create new graphql operation isAwsNativeEbsVolumeSnapshotRestorable
            InitQueryIsAwsNativeEbsVolumeSnapshotRestorable();
        }

        // This parameter set invokes a single graphql operation:
        // allAvailabilityZonesByRegionFromAws.
        internal void ProcessRecord_AllAvailabilityZonesByRegion()
        {
            this._logger.name += " -AllAvailabilityZonesByRegion";
            // Create new graphql operation allAvailabilityZonesByRegionFromAws
            InitQueryAllAvailabilityZonesByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allKmsEncryptionKeysByRegionFromAws.
        internal void ProcessRecord_AllKmsEncryptionKeysByRegion()
        {
            this._logger.name += " -AllKmsEncryptionKeysByRegion";
            // Create new graphql operation allKmsEncryptionKeysByRegionFromAws
            InitQueryAllKmsEncryptionKeysByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // isAwsS3BucketNameAvailable.
        internal void ProcessRecord_IsS3BucketNameAvailable()
        {
            this._logger.name += " -IsS3BucketNameAvailable";
            // Create new graphql operation isAwsS3BucketNameAvailable
            InitQueryIsAwsS3BucketNameAvailable();
        }

        // This parameter set invokes a single graphql operation:
        // allS3BucketsFromAws.
        internal void ProcessRecord_AllS3Buckets()
        {
            this._logger.name += " -AllS3Buckets";
            // Create new graphql operation allS3BucketsFromAws
            InitQueryAllS3BucketsFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allS3BucketsDetailsFromAws.
        internal void ProcessRecord_AllS3BucketsDetails()
        {
            this._logger.name += " -AllS3BucketsDetails";
            // Create new graphql operation allS3BucketsDetailsFromAws
            InitQueryAllS3BucketsDetailsFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeRdsInstance.
        internal void ProcessRecord_NativeRdsInstance()
        {
            this._logger.name += " -NativeRdsInstance";
            // Create new graphql operation awsNativeRdsInstance
            InitQueryAwsNativeRdsInstance();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeRdsInstances.
        internal void ProcessRecord_NativeRdsInstances()
        {
            this._logger.name += " -NativeRdsInstances";
            // Create new graphql operation awsNativeRdsInstances
            InitQueryAwsNativeRdsInstances();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeRdsPointInTimeRestoreWindow.
        internal void ProcessRecord_NativeRdsPointInTimeRestoreWindow()
        {
            this._logger.name += " -NativeRdsPointInTimeRestoreWindow";
            // Create new graphql operation awsNativeRdsPointInTimeRestoreWindow
            InitQueryAwsNativeRdsPointInTimeRestoreWindow();
        }

        // This parameter set invokes a single graphql operation:
        // rdsInstanceDetailsFromAws.
        internal void ProcessRecord_RdsInstanceDetails()
        {
            this._logger.name += " -RdsInstanceDetails";
            // Create new graphql operation rdsInstanceDetailsFromAws
            InitQueryRdsInstanceDetailsFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // isAwsNativeRdsInstanceLaunchConfigurationValid.
        internal void ProcessRecord_IsNativeRdsInstanceLaunchConfigurationValid()
        {
            this._logger.name += " -IsNativeRdsInstanceLaunchConfigurationValid";
            // Create new graphql operation isAwsNativeRdsInstanceLaunchConfigurationValid
            InitQueryIsAwsNativeRdsInstanceLaunchConfigurationValid();
        }

        // This parameter set invokes a single graphql operation:
        // allOptionGroupsByRegionFromAws.
        internal void ProcessRecord_AllOptionGroupsByRegion()
        {
            this._logger.name += " -AllOptionGroupsByRegion";
            // Create new graphql operation allOptionGroupsByRegionFromAws
            InitQueryAllOptionGroupsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allDbParameterGroupsByRegionFromAws.
        internal void ProcessRecord_AllDbParameterGroupsByRegion()
        {
            this._logger.name += " -AllDbParameterGroupsByRegion";
            // Create new graphql operation allDbParameterGroupsByRegionFromAws
            InitQueryAllDbParameterGroupsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allDbSubnetGroupsByRegionFromAws.
        internal void ProcessRecord_AllDbSubnetGroupsByRegion()
        {
            this._logger.name += " -AllDbSubnetGroupsByRegion";
            // Create new graphql operation allDbSubnetGroupsByRegionFromAws
            InitQueryAllDbSubnetGroupsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // validateAwsNativeRdsInstanceNameForExport.
        internal void ProcessRecord_ValidateNativeRdsInstanceNameForExport()
        {
            this._logger.name += " -ValidateNativeRdsInstanceNameForExport";
            // Create new graphql operation validateAwsNativeRdsInstanceNameForExport
            InitQueryValidateAwsNativeRdsInstanceNameForExport();
        }

        // This parameter set invokes a single graphql operation:
        // validateAwsNativeRdsClusterNameForExport.
        internal void ProcessRecord_ValidateNativeRdsClusterNameForExport()
        {
            this._logger.name += " -ValidateNativeRdsClusterNameForExport";
            // Create new graphql operation validateAwsNativeRdsClusterNameForExport
            InitQueryValidateAwsNativeRdsClusterNameForExport();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeRdsExportDefaults.
        internal void ProcessRecord_NativeRdsExportDefaults()
        {
            this._logger.name += " -NativeRdsExportDefaults";
            // Create new graphql operation awsNativeRdsExportDefaults
            InitQueryAwsNativeRdsExportDefaults();
        }

        // This parameter set invokes a single graphql operation:
        // allEc2KeyPairsByRegionFromAws.
        internal void ProcessRecord_AllEc2KeyPairsByRegion()
        {
            this._logger.name += " -AllEc2KeyPairsByRegion";
            // Create new graphql operation allEc2KeyPairsByRegionFromAws
            InitQueryAllEc2KeyPairsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // amiTypeForAwsNativeArchivedSnapshotExport.
        internal void ProcessRecord_AmiTypeForNativeArchivedSnapshotExport()
        {
            this._logger.name += " -AmiTypeForNativeArchivedSnapshotExport";
            // Create new graphql operation amiTypeForAwsNativeArchivedSnapshotExport
            InitQueryAmiTypeForAwsNativeArchivedSnapshotExport();
        }

        // This parameter set invokes a single graphql operation:
        // allSupportedAwsRdsDatabaseInstanceClasses.
        internal void ProcessRecord_AllSupportedRdsDatabaseInstanceClasses()
        {
            this._logger.name += " -AllSupportedRdsDatabaseInstanceClasses";
            // Create new graphql operation allSupportedAwsRdsDatabaseInstanceClasses
            InitQueryAllSupportedAwsRdsDatabaseInstanceClasses();
        }

        // This parameter set invokes a single graphql operation:
        // awsComputeSettings.
        internal void ProcessRecord_ComputeSettings()
        {
            this._logger.name += " -ComputeSettings";
            // Create new graphql operation awsComputeSettings
            InitQueryAwsComputeSettings();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsComputeSettings.
        internal void ProcessRecord_AllComputeSettings()
        {
            this._logger.name += " -AllComputeSettings";
            // Create new graphql operation allAwsComputeSettings
            InitQueryAllAwsComputeSettings();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsCloudAccountsWithFeatures.
        internal void ProcessRecord_AllCloudAccountsWithFeatures()
        {
            this._logger.name += " -AllCloudAccountsWithFeatures";
            // Create new graphql operation allAwsCloudAccountsWithFeatures
            InitQueryAllAwsCloudAccountsWithFeatures();
        }

        // This parameter set invokes a single graphql operation:
        // awsCloudAccountWithFeatures.
        internal void ProcessRecord_CloudAccountWithFeatures()
        {
            this._logger.name += " -CloudAccountWithFeatures";
            // Create new graphql operation awsCloudAccountWithFeatures
            InitQueryAwsCloudAccountWithFeatures();
        }

        // This parameter set invokes a single graphql operation:
        // awsCloudAccountListVpcs.
        internal void ProcessRecord_CloudAccountListVpcs()
        {
            this._logger.name += " -CloudAccountListVpcs";
            // Create new graphql operation awsCloudAccountListVpcs
            InitQueryAwsCloudAccountListVpcs();
        }

        // This parameter set invokes a single graphql operation:
        // awsCloudAccountListSubnets.
        internal void ProcessRecord_CloudAccountListSubnets()
        {
            this._logger.name += " -CloudAccountListSubnets";
            // Create new graphql operation awsCloudAccountListSubnets
            InitQueryAwsCloudAccountListSubnets();
        }

        // This parameter set invokes a single graphql operation:
        // awsCloudAccountListSecurityGroups.
        internal void ProcessRecord_CloudAccountListSecurityGroups()
        {
            this._logger.name += " -CloudAccountListSecurityGroups";
            // Create new graphql operation awsCloudAccountListSecurityGroups
            InitQueryAwsCloudAccountListSecurityGroups();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsExocomputeConfigs.
        internal void ProcessRecord_AllExocomputeConfigs()
        {
            this._logger.name += " -AllExocomputeConfigs";
            // Create new graphql operation allAwsExocomputeConfigs
            InitQueryAllAwsExocomputeConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsCloudAccountConfigs.
        internal void ProcessRecord_AllCloudAccountConfigs()
        {
            this._logger.name += " -AllCloudAccountConfigs";
            // Create new graphql operation allAwsCloudAccountConfigs
            InitQueryAllAwsCloudAccountConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // awsTrustPolicy.
        internal void ProcessRecord_TrustPolicy()
        {
            this._logger.name += " -TrustPolicy";
            // Create new graphql operation awsTrustPolicy
            InitQueryAwsTrustPolicy();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsPermissionPolicies.
        internal void ProcessRecord_AllPermissionPolicies()
        {
            this._logger.name += " -AllPermissionPolicies";
            // Create new graphql operation allAwsPermissionPolicies
            InitQueryAllAwsPermissionPolicies();
        }

        // This parameter set invokes a single graphql operation:
        // awsArtifactsToDelete.
        internal void ProcessRecord_ArtifactsToDelete()
        {
            this._logger.name += " -ArtifactsToDelete";
            // Create new graphql operation awsArtifactsToDelete
            InitQueryAwsArtifactsToDelete();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsRegions.
        internal void ProcessRecord_AllRegions()
        {
            this._logger.name += " -AllRegions";
            // Create new graphql operation allAwsRegions
            InitQueryAllAwsRegions();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsCdmVersions.
        internal void ProcessRecord_AllCdmVersions()
        {
            this._logger.name += " -AllCdmVersions";
            // Create new graphql operation allAwsCdmVersions
            InitQueryAllAwsCdmVersions();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsInstanceProfileNames.
        internal void ProcessRecord_AllInstanceProfileNames()
        {
            this._logger.name += " -AllInstanceProfileNames";
            // Create new graphql operation allAwsInstanceProfileNames
            InitQueryAllAwsInstanceProfileNames();
        }


        // Create new GraphQL Query:
        // awsNativeRoot: AwsNativeRoot!
        internal void InitQueryAwsNativeRoot()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeRoot",
                "",
                "AwsNativeRoot",
                Query.AwsNativeRoot_ObjectFieldSpec,
                Query.AwsNativeRootFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // awsNativeAccount(awsNativeAccountRubrikId: UUID!, awsNativeProtectionFeature: AwsNativeProtectionFeature!): AwsNativeAccount!
        internal void InitQueryAwsNativeAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsNativeAccountRubrikId", "UUID!"),
                Tuple.Create("awsNativeProtectionFeature", "AwsNativeProtectionFeature!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeAccount",
                "($awsNativeAccountRubrikId: UUID!,$awsNativeProtectionFeature: AwsNativeProtectionFeature!)",
                "AwsNativeAccount",
                Query.AwsNativeAccount_ObjectFieldSpec,
                Query.AwsNativeAccountFieldSpec,
                @"# REQUIRED
$inputs.Var.awsNativeAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.awsNativeProtectionFeature = <AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // awsNativeEc2Instance(ec2InstanceRubrikId: UUID!): AwsNativeEc2Instance!
        internal void InitQueryAwsNativeEc2Instance()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("ec2InstanceRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeEc2Instance",
                "($ec2InstanceRubrikId: UUID!)",
                "AwsNativeEc2Instance",
                Query.AwsNativeEc2Instance_ObjectFieldSpec,
                Query.AwsNativeEc2InstanceFieldSpec,
                @"# REQUIRED
$inputs.Var.ec2InstanceRubrikId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // awsNativeEbsVolume(ebsVolumeRubrikId: UUID!): AwsNativeEbsVolume!
        internal void InitQueryAwsNativeEbsVolume()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("ebsVolumeRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeEbsVolume",
                "($ebsVolumeRubrikId: UUID!)",
                "AwsNativeEbsVolume",
                Query.AwsNativeEbsVolume_ObjectFieldSpec,
                Query.AwsNativeEbsVolumeFieldSpec,
                @"# REQUIRED
$inputs.Var.ebsVolumeRubrikId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // awsNativeS3Bucket(s3BucketRubrikId: UUID!): AwsNativeS3Bucket!
        internal void InitQueryAwsNativeS3Bucket()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("s3BucketRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeS3Bucket",
                "($s3BucketRubrikId: UUID!)",
                "AwsNativeS3Bucket",
                Query.AwsNativeS3Bucket_ObjectFieldSpec,
                Query.AwsNativeS3BucketFieldSpec,
                @"# REQUIRED
$inputs.Var.s3BucketRubrikId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // awsNativeAccounts(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AwsNativeAccountSortFields
        //     sortOrder: SortOrder
        //     accountFilters: AwsNativeAccountFilters
        //     authorizedOperationFilter: Operation
        //     awsNativeProtectionFeature: AwsNativeProtectionFeature!
        //   ): AwsNativeAccountConnection!
        internal void InitQueryAwsNativeAccounts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AwsNativeAccountSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("accountFilters", "AwsNativeAccountFilters"),
                Tuple.Create("authorizedOperationFilter", "Operation"),
                Tuple.Create("awsNativeProtectionFeature", "AwsNativeProtectionFeature!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeAccounts",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AwsNativeAccountSortFields,$sortOrder: SortOrder,$accountFilters: AwsNativeAccountFilters,$authorizedOperationFilter: Operation,$awsNativeProtectionFeature: AwsNativeProtectionFeature!)",
                "AwsNativeAccountConnection",
                Query.AwsNativeAccounts_ObjectFieldSpec,
                Query.AwsNativeAccountsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AwsNativeAccountSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeAccountSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.accountFilters = @{
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
	cloudTypeFilter = @{
		# REQUIRED
		cloudTypes = @(
			<AwsCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
		)
	}
}
# OPTIONAL
$inputs.Var.authorizedOperationFilter = <Operation> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
# REQUIRED
$inputs.Var.awsNativeProtectionFeature = <AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // awsNativeEc2InstancesByName(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AwsNativeEc2InstanceSortFields
        //     sortOrder: SortOrder
        //     ec2InstanceName: String!
        //   ): AwsNativeEc2InstanceConnection!
        internal void InitQueryAwsNativeEc2InstancesByName()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AwsNativeEc2InstanceSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("ec2InstanceName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeEc2InstancesByName",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AwsNativeEc2InstanceSortFields,$sortOrder: SortOrder,$ec2InstanceName: String!)",
                "AwsNativeEc2InstanceConnection",
                Query.AwsNativeEc2InstancesByName_ObjectFieldSpec,
                Query.AwsNativeEc2InstancesByNameFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AwsNativeEc2InstanceSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEc2InstanceSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# REQUIRED
$inputs.Var.ec2InstanceName = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // awsNativeEc2Instances(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AwsNativeEc2InstanceSortFields
        //     sortOrder: SortOrder
        //     descendantTypeFilter: [HierarchyObjectTypeEnum!]
        //     ec2InstanceFilters: AwsNativeEc2InstanceFilters
        //   ): AwsNativeEc2InstanceConnection!
        internal void InitQueryAwsNativeEc2Instances()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AwsNativeEc2InstanceSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("descendantTypeFilter", "[HierarchyObjectTypeEnum!]"),
                Tuple.Create("ec2InstanceFilters", "AwsNativeEc2InstanceFilters"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeEc2Instances",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AwsNativeEc2InstanceSortFields,$sortOrder: SortOrder,$descendantTypeFilter: [HierarchyObjectTypeEnum!],$ec2InstanceFilters: AwsNativeEc2InstanceFilters)",
                "AwsNativeEc2InstanceConnection",
                Query.AwsNativeEc2Instances_ObjectFieldSpec,
                Query.AwsNativeEc2InstancesFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AwsNativeEc2InstanceSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEc2InstanceSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.descendantTypeFilter = @(
	<HierarchyObjectTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
)
# OPTIONAL
$inputs.Var.ec2InstanceFilters = @{
	# OPTIONAL
	nameOrIdSubstringFilter = @{
		# REQUIRED
		nameOrIdSubstring = <System.String>
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	accountFilter = @{
		# REQUIRED
		accountIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	fileRecoveryStatusFilter = @{
		# REQUIRED
		statuses = @(
			<AwsNativeFileRecoveryStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeFileRecoveryStatus]) for enum values.
		)
	}
	# OPTIONAL
	regionFilter = @{
		# REQUIRED
		regions = @(
			<AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
		)
	}
	# OPTIONAL
	typeFilter = @{
		# REQUIRED
		ec2InstanceTypes = @(
			<AwsNativeEc2InstanceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEc2InstanceType]) for enum values.
		)
	}
	# OPTIONAL
	vpcFilter = @{
		# REQUIRED
		vpcIds = @(
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
	appProtectionStatusFilter = @{
		# REQUIRED
		isProtectionSetup = <System.Boolean>
	}
	# OPTIONAL
	rbsStatusFilter = @{
		# REQUIRED
		status = <CloudInstanceRbsConnectionStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudInstanceRbsConnectionStatus]) for enum values.
	}
	# OPTIONAL
	orgFilter = @{
		# REQUIRED
		orgIds = @(
			<System.String>
		)
	}
}"
            );
        }

        // Create new GraphQL Query:
        // awsNativeEbsVolumesByName(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AwsNativeEbsVolumeSortFields
        //     sortOrder: SortOrder
        //     ebsVolumeName: String!
        //   ): AwsNativeEbsVolumeConnection!
        internal void InitQueryAwsNativeEbsVolumesByName()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AwsNativeEbsVolumeSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("ebsVolumeName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeEbsVolumesByName",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AwsNativeEbsVolumeSortFields,$sortOrder: SortOrder,$ebsVolumeName: String!)",
                "AwsNativeEbsVolumeConnection",
                Query.AwsNativeEbsVolumesByName_ObjectFieldSpec,
                Query.AwsNativeEbsVolumesByNameFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AwsNativeEbsVolumeSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEbsVolumeSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# REQUIRED
$inputs.Var.ebsVolumeName = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // awsNativeEbsVolumes(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AwsNativeEbsVolumeSortFields
        //     sortOrder: SortOrder
        //     ebsVolumeFilters: AwsNativeEbsVolumeFilters
        //   ): AwsNativeEbsVolumeConnection!
        internal void InitQueryAwsNativeEbsVolumes()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AwsNativeEbsVolumeSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("ebsVolumeFilters", "AwsNativeEbsVolumeFilters"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeEbsVolumes",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AwsNativeEbsVolumeSortFields,$sortOrder: SortOrder,$ebsVolumeFilters: AwsNativeEbsVolumeFilters)",
                "AwsNativeEbsVolumeConnection",
                Query.AwsNativeEbsVolumes_ObjectFieldSpec,
                Query.AwsNativeEbsVolumesFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AwsNativeEbsVolumeSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEbsVolumeSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.ebsVolumeFilters = @{
	# OPTIONAL
	nameOrIdSubstringFilter = @{
		# REQUIRED
		nameOrIdSubstring = <System.String>
	}
	# OPTIONAL
	fileRecoveryStatusFilter = @{
		# REQUIRED
		statuses = @(
			<AwsNativeFileRecoveryStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeFileRecoveryStatus]) for enum values.
		)
	}
	# OPTIONAL
	typeFilter = @{
		# REQUIRED
		ebsVolumeTypes = @(
			<AwsNativeEbsVolumeType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEbsVolumeType]) for enum values.
		)
	}
	# OPTIONAL
	attachedInstanceFilter = @{
		# REQUIRED
		ec2InstanceIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	accountFilter = @{
		# REQUIRED
		accountIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	regionFilter = @{
		# REQUIRED
		regions = @(
			<AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
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
	orgFilter = @{
		# REQUIRED
		orgIds = @(
			<System.String>
		)
	}
}"
            );
        }

        // Create new GraphQL Query:
        // allVpcsByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!): [AwsVpc!]!
        internal void InitQueryAllVpcsByRegionFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllVpcsByRegionFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!)",
                "List<AwsVpc>",
                Query.AllVpcsByRegionFromAws_ObjectFieldSpec,
                Query.AllVpcsByRegionFromAwsFieldSpec,
                @"# REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allVpcsFromAws(awsAccountRubrikId: UUID): [AwsVpc!]!
        internal void InitQueryAllVpcsFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllVpcsFromAws",
                "($awsAccountRubrikId: UUID)",
                "List<AwsVpc>",
                Query.AllVpcsFromAws_ObjectFieldSpec,
                Query.AllVpcsFromAwsFieldSpec,
                @"# OPTIONAL
$inputs.Var.awsAccountRubrikId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // isAwsNativeEbsVolumeSnapshotRestorable(snapshotId: String!): IsVolumeSnapshotRestorableReply!
        internal void InitQueryIsAwsNativeEbsVolumeSnapshotRestorable()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snapshotId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsAwsNativeEbsVolumeSnapshotRestorable",
                "($snapshotId: String!)",
                "IsVolumeSnapshotRestorableReply",
                Query.IsAwsNativeEbsVolumeSnapshotRestorable_ObjectFieldSpec,
                Query.IsAwsNativeEbsVolumeSnapshotRestorableFieldSpec,
                @"# REQUIRED
$inputs.Var.snapshotId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // allAvailabilityZonesByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!): [String!]!
        internal void InitQueryAllAvailabilityZonesByRegionFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAvailabilityZonesByRegionFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!)",
                "List<System.String>",
                Query.AllAvailabilityZonesByRegionFromAws_ObjectFieldSpec,
                Query.AllAvailabilityZonesByRegionFromAwsFieldSpec,
                @"# REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allKmsEncryptionKeysByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!): [KmsEncryptionKey!]!
        internal void InitQueryAllKmsEncryptionKeysByRegionFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllKmsEncryptionKeysByRegionFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!)",
                "List<KmsEncryptionKey>",
                Query.AllKmsEncryptionKeysByRegionFromAws_ObjectFieldSpec,
                Query.AllKmsEncryptionKeysByRegionFromAwsFieldSpec,
                @"# REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // isAwsS3BucketNameAvailable(bucketName: String!, awsAccountRubrikId: UUID!): Boolean!
        internal void InitQueryIsAwsS3BucketNameAvailable()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("bucketName", "String!"),
                Tuple.Create("awsAccountRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsAwsS3BucketNameAvailable",
                "($bucketName: String!,$awsAccountRubrikId: UUID!)",
                "System.Boolean",
                Query.IsAwsS3BucketNameAvailable_ObjectFieldSpec,
                Query.IsAwsS3BucketNameAvailableFieldSpec,
                @"# REQUIRED
$inputs.Var.bucketName = <System.String>
# REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // allS3BucketsFromAws(awsAccountRubrikId: UUID!): [String!]!
        internal void InitQueryAllS3BucketsFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllS3BucketsFromAws",
                "($awsAccountRubrikId: UUID!)",
                "List<System.String>",
                Query.AllS3BucketsFromAws_ObjectFieldSpec,
                Query.AllS3BucketsFromAwsFieldSpec,
                @"# REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // allS3BucketsDetailsFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion): [S3BucketDetails!]!
        internal void InitQueryAllS3BucketsDetailsFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllS3BucketsDetailsFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion)",
                "List<S3BucketDetails>",
                Query.AllS3BucketsDetailsFromAws_ObjectFieldSpec,
                Query.AllS3BucketsDetailsFromAwsFieldSpec,
                @"# REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# OPTIONAL
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // awsNativeRdsInstance(rdsInstanceRubrikId: UUID!): AwsNativeRdsInstance!
        internal void InitQueryAwsNativeRdsInstance()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("rdsInstanceRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeRdsInstance",
                "($rdsInstanceRubrikId: UUID!)",
                "AwsNativeRdsInstance",
                Query.AwsNativeRdsInstance_ObjectFieldSpec,
                Query.AwsNativeRdsInstanceFieldSpec,
                @"# REQUIRED
$inputs.Var.rdsInstanceRubrikId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // awsNativeRdsInstances(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AwsNativeRdsInstanceSortFields
        //     sortOrder: SortOrder
        //     rdsInstanceFilters: AwsNativeRdsInstanceFilters
        //   ): AwsNativeRdsInstanceConnection!
        internal void InitQueryAwsNativeRdsInstances()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AwsNativeRdsInstanceSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("rdsInstanceFilters", "AwsNativeRdsInstanceFilters"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeRdsInstances",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AwsNativeRdsInstanceSortFields,$sortOrder: SortOrder,$rdsInstanceFilters: AwsNativeRdsInstanceFilters)",
                "AwsNativeRdsInstanceConnection",
                Query.AwsNativeRdsInstances_ObjectFieldSpec,
                Query.AwsNativeRdsInstancesFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AwsNativeRdsInstanceSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsInstanceSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.rdsInstanceFilters = @{
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
	accountFilter = @{
		# REQUIRED
		accountIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	vpcFilter = @{
		# REQUIRED
		vpcIds = @(
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
	regionFilter = @{
		# REQUIRED
		regions = @(
			<AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
		)
	}
	# OPTIONAL
	dbEngineFilter = @{
		# REQUIRED
		dbEngines = @(
			<AwsNativeRdsDbEngine> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbEngine]) for enum values.
		)
	}
	# OPTIONAL
	dbInstanceClassFilter = @{
		# REQUIRED
		dbInstanceClasses = @(
			<AwsNativeRdsDbInstanceClass> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbInstanceClass]) for enum values.
		)
	}
	# OPTIONAL
	orgFilter = @{
		# REQUIRED
		orgIds = @(
			<System.String>
		)
	}
}"
            );
        }

        // Create new GraphQL Query:
        // awsNativeRdsPointInTimeRestoreWindow(
        //     awsAccountRubrikId: UUID!
        //     region: AwsNativeRegion!
        //     rdsInstanceName: String!
        //     rdsDatabaseRubrikId: UUID
        //   ): AwsNativeRdsPointInTimeRestoreWindow!
        internal void InitQueryAwsNativeRdsPointInTimeRestoreWindow()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("rdsInstanceName", "String!"),
                Tuple.Create("rdsDatabaseRubrikId", "UUID"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeRdsPointInTimeRestoreWindow",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$rdsInstanceName: String!,$rdsDatabaseRubrikId: UUID)",
                "AwsNativeRdsPointInTimeRestoreWindow",
                Query.AwsNativeRdsPointInTimeRestoreWindow_ObjectFieldSpec,
                Query.AwsNativeRdsPointInTimeRestoreWindowFieldSpec,
                @"# REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$inputs.Var.rdsInstanceName = <System.String>
# OPTIONAL
$inputs.Var.rdsDatabaseRubrikId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // rdsInstanceDetailsFromAws(
        //     awsAccountRubrikId: UUID!
        //     region: AwsNativeRegion!
        //     rdsInstanceName: String!
        //     rdsDatabaseRubrikId: UUID
        //   ): RdsInstanceDetailsFromAws!
        internal void InitQueryRdsInstanceDetailsFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("rdsInstanceName", "String!"),
                Tuple.Create("rdsDatabaseRubrikId", "UUID"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryRdsInstanceDetailsFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$rdsInstanceName: String!,$rdsDatabaseRubrikId: UUID)",
                "RdsInstanceDetailsFromAws",
                Query.RdsInstanceDetailsFromAws_ObjectFieldSpec,
                Query.RdsInstanceDetailsFromAwsFieldSpec,
                @"# REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$inputs.Var.rdsInstanceName = <System.String>
# OPTIONAL
$inputs.Var.rdsDatabaseRubrikId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // isAwsNativeRdsInstanceLaunchConfigurationValid(
        //     awsAccountRubrikId: UUID!
        //     region: AwsNativeRegion!
        //     dbEngine: AwsNativeRdsDbEngine!
        //     dbEngineVersion: String!
        //     dbClass: AwsNativeRdsDbInstanceClass!
        //     databaseInstanceClass: String
        //     primaryAz: String
        //     storageType: AwsNativeRdsStorageType
        //     isMultiAz: Boolean!
        //     kmsKeyId: String
        //     iops: Int
        //   ): Boolean!
        internal void InitQueryIsAwsNativeRdsInstanceLaunchConfigurationValid()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("dbEngine", "AwsNativeRdsDbEngine!"),
                Tuple.Create("dbEngineVersion", "String!"),
                Tuple.Create("dbClass", "AwsNativeRdsDbInstanceClass!"),
                Tuple.Create("databaseInstanceClass", "String"),
                Tuple.Create("primaryAz", "String"),
                Tuple.Create("storageType", "AwsNativeRdsStorageType"),
                Tuple.Create("isMultiAz", "Boolean!"),
                Tuple.Create("kmsKeyId", "String"),
                Tuple.Create("iops", "Int"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsAwsNativeRdsInstanceLaunchConfigurationValid",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$dbEngine: AwsNativeRdsDbEngine!,$dbEngineVersion: String!,$dbClass: AwsNativeRdsDbInstanceClass!,$databaseInstanceClass: String,$primaryAz: String,$storageType: AwsNativeRdsStorageType,$isMultiAz: Boolean!,$kmsKeyId: String,$iops: Int)",
                "System.Boolean",
                Query.IsAwsNativeRdsInstanceLaunchConfigurationValid_ObjectFieldSpec,
                Query.IsAwsNativeRdsInstanceLaunchConfigurationValidFieldSpec,
                @"# REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$inputs.Var.dbEngine = <AwsNativeRdsDbEngine> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbEngine]) for enum values.
# REQUIRED
$inputs.Var.dbEngineVersion = <System.String>
# REQUIRED
$inputs.Var.dbClass = <AwsNativeRdsDbInstanceClass> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbInstanceClass]) for enum values.
# OPTIONAL
$inputs.Var.databaseInstanceClass = <System.String>
# OPTIONAL
$inputs.Var.primaryAz = <System.String>
# OPTIONAL
$inputs.Var.storageType = <AwsNativeRdsStorageType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsStorageType]) for enum values.
# REQUIRED
$inputs.Var.isMultiAz = <System.Boolean>
# OPTIONAL
$inputs.Var.kmsKeyId = <System.String>
# OPTIONAL
$inputs.Var.iops = <System.Int32>"
            );
        }

        // Create new GraphQL Query:
        // allOptionGroupsByRegionFromAws(
        //     awsAccountRubrikId: UUID!
        //     region: AwsNativeRegion!
        //     dbEngine: AwsNativeRdsDbEngine!
        //     dbEngineVersion: String!
        //     majorEngineVersion: String!
        //   ): [OptionGroup!]!
        internal void InitQueryAllOptionGroupsByRegionFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("dbEngine", "AwsNativeRdsDbEngine!"),
                Tuple.Create("dbEngineVersion", "String!"),
                Tuple.Create("majorEngineVersion", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllOptionGroupsByRegionFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$dbEngine: AwsNativeRdsDbEngine!,$dbEngineVersion: String!,$majorEngineVersion: String!)",
                "List<OptionGroup>",
                Query.AllOptionGroupsByRegionFromAws_ObjectFieldSpec,
                Query.AllOptionGroupsByRegionFromAwsFieldSpec,
                @"# REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$inputs.Var.dbEngine = <AwsNativeRdsDbEngine> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbEngine]) for enum values.
# REQUIRED
$inputs.Var.dbEngineVersion = <System.String>
# REQUIRED
$inputs.Var.majorEngineVersion = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // allDbParameterGroupsByRegionFromAws(
        //     awsAccountRubrikId: UUID!
        //     region: AwsNativeRegion!
        //     dbEngine: AwsNativeRdsDbEngine!
        //     dbEngineVersion: String!
        //     rdsType: AwsNativeRdsType
        //   ): [DbParameterGroup!]!
        internal void InitQueryAllDbParameterGroupsByRegionFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("dbEngine", "AwsNativeRdsDbEngine!"),
                Tuple.Create("dbEngineVersion", "String!"),
                Tuple.Create("rdsType", "AwsNativeRdsType"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllDbParameterGroupsByRegionFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$dbEngine: AwsNativeRdsDbEngine!,$dbEngineVersion: String!,$rdsType: AwsNativeRdsType)",
                "List<DbParameterGroup>",
                Query.AllDbParameterGroupsByRegionFromAws_ObjectFieldSpec,
                Query.AllDbParameterGroupsByRegionFromAwsFieldSpec,
                @"# REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$inputs.Var.dbEngine = <AwsNativeRdsDbEngine> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbEngine]) for enum values.
# REQUIRED
$inputs.Var.dbEngineVersion = <System.String>
# OPTIONAL
$inputs.Var.rdsType = <AwsNativeRdsType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsType]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allDbSubnetGroupsByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!): [SubnetGroup!]!
        internal void InitQueryAllDbSubnetGroupsByRegionFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllDbSubnetGroupsByRegionFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!)",
                "List<SubnetGroup>",
                Query.AllDbSubnetGroupsByRegionFromAws_ObjectFieldSpec,
                Query.AllDbSubnetGroupsByRegionFromAwsFieldSpec,
                @"# REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // validateAwsNativeRdsInstanceNameForExport(awsAccountRubrikId: UUID!, region: AwsNativeRegion!, rdsInstanceName: String!): ValidateAwsNativeRdsInstanceNameForExportReply!
        internal void InitQueryValidateAwsNativeRdsInstanceNameForExport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("rdsInstanceName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryValidateAwsNativeRdsInstanceNameForExport",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$rdsInstanceName: String!)",
                "ValidateAwsNativeRdsInstanceNameForExportReply",
                Query.ValidateAwsNativeRdsInstanceNameForExport_ObjectFieldSpec,
                Query.ValidateAwsNativeRdsInstanceNameForExportFieldSpec,
                @"# REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$inputs.Var.rdsInstanceName = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // validateAwsNativeRdsClusterNameForExport(awsAccountRubrikId: UUID!, region: AwsNativeRegion!, rdsClusterName: String!): ValidateAwsNativeRdsClusterNameForExportReply!
        internal void InitQueryValidateAwsNativeRdsClusterNameForExport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("rdsClusterName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryValidateAwsNativeRdsClusterNameForExport",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$rdsClusterName: String!)",
                "ValidateAwsNativeRdsClusterNameForExportReply",
                Query.ValidateAwsNativeRdsClusterNameForExport_ObjectFieldSpec,
                Query.ValidateAwsNativeRdsClusterNameForExportFieldSpec,
                @"# REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$inputs.Var.rdsClusterName = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // awsNativeRdsExportDefaults(rdsInstanceRubrikId: UUID!, snapshotId: String, isPointInTime: Boolean!): RdsInstanceExportDefaults!
        internal void InitQueryAwsNativeRdsExportDefaults()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("rdsInstanceRubrikId", "UUID!"),
                Tuple.Create("snapshotId", "String"),
                Tuple.Create("isPointInTime", "Boolean!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeRdsExportDefaults",
                "($rdsInstanceRubrikId: UUID!,$snapshotId: String,$isPointInTime: Boolean!)",
                "RdsInstanceExportDefaults",
                Query.AwsNativeRdsExportDefaults_ObjectFieldSpec,
                Query.AwsNativeRdsExportDefaultsFieldSpec,
                @"# REQUIRED
$inputs.Var.rdsInstanceRubrikId = <System.String>
# OPTIONAL
$inputs.Var.snapshotId = <System.String>
# REQUIRED
$inputs.Var.isPointInTime = <System.Boolean>"
            );
        }

        // Create new GraphQL Query:
        // allEc2KeyPairsByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!): [String!]!
        internal void InitQueryAllEc2KeyPairsByRegionFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllEc2KeyPairsByRegionFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!)",
                "List<System.String>",
                Query.AllEc2KeyPairsByRegionFromAws_ObjectFieldSpec,
                Query.AllEc2KeyPairsByRegionFromAwsFieldSpec,
                @"# REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // amiTypeForAwsNativeArchivedSnapshotExport(input: AmiTypeForAwsNativeArchivedSnapshotExportInput!): AmiTypeForAwsNativeArchivedSnapshotExportReply!
        internal void InitQueryAmiTypeForAwsNativeArchivedSnapshotExport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AmiTypeForAwsNativeArchivedSnapshotExportInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAmiTypeForAwsNativeArchivedSnapshotExport",
                "($input: AmiTypeForAwsNativeArchivedSnapshotExportInput!)",
                "AmiTypeForAwsNativeArchivedSnapshotExportReply",
                Query.AmiTypeForAwsNativeArchivedSnapshotExport_ObjectFieldSpec,
                Query.AmiTypeForAwsNativeArchivedSnapshotExportFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snapshotId = <System.String>
	# REQUIRED
	destinationRegionId = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
	# REQUIRED
	destinationAwsAccountRubrikId = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // allSupportedAwsRdsDatabaseInstanceClasses(
        //     awsAccountRubrikId: UUID!
        //     region: AwsNativeRegion!
        //     dbEngine: AwsNativeRdsDbEngine!
        //     dbEngineVersion: String
        //   ): [String!]!
        internal void InitQueryAllSupportedAwsRdsDatabaseInstanceClasses()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("dbEngine", "AwsNativeRdsDbEngine!"),
                Tuple.Create("dbEngineVersion", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllSupportedAwsRdsDatabaseInstanceClasses",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$dbEngine: AwsNativeRdsDbEngine!,$dbEngineVersion: String)",
                "List<System.String>",
                Query.AllSupportedAwsRdsDatabaseInstanceClasses_ObjectFieldSpec,
                Query.AllSupportedAwsRdsDatabaseInstanceClassesFieldSpec,
                @"# REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$inputs.Var.dbEngine = <AwsNativeRdsDbEngine> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbEngine]) for enum values.
# OPTIONAL
$inputs.Var.dbEngineVersion = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // awsComputeSettings(computeSettingId: UUID!): AwsComputeSettings!
        internal void InitQueryAwsComputeSettings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("computeSettingId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsComputeSettings",
                "($computeSettingId: UUID!)",
                "AwsComputeSettings",
                Query.AwsComputeSettings_ObjectFieldSpec,
                Query.AwsComputeSettingsFieldSpec,
                @"# REQUIRED
$inputs.Var.computeSettingId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // allAwsComputeSettings(
        //     sortBy: AwsCloudComputeSettingQuerySortByField
        //     sortOrder: SortOrder
        //     filter: [AwsCloudComputeSettingFilterInput!]
        //     contextFilter: ContextFilterTypeEnum
        //   ): [AwsComputeSettings!]!
        internal void InitQueryAllAwsComputeSettings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("sortBy", "AwsCloudComputeSettingQuerySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[AwsCloudComputeSettingFilterInput!]"),
                Tuple.Create("contextFilter", "ContextFilterTypeEnum"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAwsComputeSettings",
                "($sortBy: AwsCloudComputeSettingQuerySortByField,$sortOrder: SortOrder,$filter: [AwsCloudComputeSettingFilterInput!],$contextFilter: ContextFilterTypeEnum)",
                "List<AwsComputeSettings>",
                Query.AllAwsComputeSettings_ObjectFieldSpec,
                Query.AllAwsComputeSettingsFieldSpec,
                @"# OPTIONAL
$inputs.Var.sortBy = <AwsCloudComputeSettingQuerySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudComputeSettingQuerySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <AwsCloudComputeSettingFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudComputeSettingFilterField]) for enum values.
		# OPTIONAL
		text = <System.String>
}
)
# OPTIONAL
$inputs.Var.contextFilter = <ContextFilterTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ContextFilterTypeEnum]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allAwsCloudAccountsWithFeatures(awsCloudAccountsArg: AwsCloudAccountsWithFeaturesInput!): [AwsCloudAccountWithFeatures!]!
        internal void InitQueryAllAwsCloudAccountsWithFeatures()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsCloudAccountsArg", "AwsCloudAccountsWithFeaturesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAwsCloudAccountsWithFeatures",
                "($awsCloudAccountsArg: AwsCloudAccountsWithFeaturesInput!)",
                "List<AwsCloudAccountWithFeatures>",
                Query.AllAwsCloudAccountsWithFeatures_ObjectFieldSpec,
                Query.AllAwsCloudAccountsWithFeaturesFieldSpec,
                @"# REQUIRED
$inputs.Var.awsCloudAccountsArg = @{
	# REQUIRED
	feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	# REQUIRED
	statusFilters = @(
		<CloudAccountStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountStatus]) for enum values.
	)
	# OPTIONAL
	awsAdminAccountFilter = <System.String>
	# OPTIONAL
	columnSearchFilter = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // awsCloudAccountWithFeatures(cloudAccountId: UUID!, awsCloudAccountArg: AwsCloudAccountWithFeaturesInput!): AwsCloudAccountWithFeatures!
        internal void InitQueryAwsCloudAccountWithFeatures()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
                Tuple.Create("awsCloudAccountArg", "AwsCloudAccountWithFeaturesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsCloudAccountWithFeatures",
                "($cloudAccountId: UUID!,$awsCloudAccountArg: AwsCloudAccountWithFeaturesInput!)",
                "AwsCloudAccountWithFeatures",
                Query.AwsCloudAccountWithFeatures_ObjectFieldSpec,
                Query.AwsCloudAccountWithFeaturesFieldSpec,
                @"# REQUIRED
$inputs.Var.cloudAccountId = <System.String>
# REQUIRED
$inputs.Var.awsCloudAccountArg = @{
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Query:
        // awsCloudAccountListVpcs(cloudAccountUuid: UUID!, feature: CloudAccountFeature!, region: AwsRegion!): AwsCloudAccountListVpcResponse!
        internal void InitQueryAwsCloudAccountListVpcs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountUuid", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("region", "AwsRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsCloudAccountListVpcs",
                "($cloudAccountUuid: UUID!,$feature: CloudAccountFeature!,$region: AwsRegion!)",
                "AwsCloudAccountListVpcResponse",
                Query.AwsCloudAccountListVpcs_ObjectFieldSpec,
                Query.AwsCloudAccountListVpcsFieldSpec,
                @"# REQUIRED
$inputs.Var.cloudAccountUuid = <System.String>
# REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$inputs.Var.region = <AwsRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // awsCloudAccountListSubnets(
        //     cloudAccountUuid: UUID!
        //     feature: CloudAccountFeature!
        //     region: AwsRegion!
        //     vpcID: String!
        //   ): AwsCloudAccountListSubnetsResponse!
        internal void InitQueryAwsCloudAccountListSubnets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountUuid", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("region", "AwsRegion!"),
                Tuple.Create("vpcID", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsCloudAccountListSubnets",
                "($cloudAccountUuid: UUID!,$feature: CloudAccountFeature!,$region: AwsRegion!,$vpcID: String!)",
                "AwsCloudAccountListSubnetsResponse",
                Query.AwsCloudAccountListSubnets_ObjectFieldSpec,
                Query.AwsCloudAccountListSubnetsFieldSpec,
                @"# REQUIRED
$inputs.Var.cloudAccountUuid = <System.String>
# REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$inputs.Var.region = <AwsRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
# REQUIRED
$inputs.Var.vpcID = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // awsCloudAccountListSecurityGroups(
        //     cloudAccountUuid: UUID!
        //     feature: CloudAccountFeature!
        //     region: AwsRegion!
        //     vpcID: String!
        //   ): AwsCloudAccountListSecurityGroupsResponse!
        internal void InitQueryAwsCloudAccountListSecurityGroups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountUuid", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("region", "AwsRegion!"),
                Tuple.Create("vpcID", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsCloudAccountListSecurityGroups",
                "($cloudAccountUuid: UUID!,$feature: CloudAccountFeature!,$region: AwsRegion!,$vpcID: String!)",
                "AwsCloudAccountListSecurityGroupsResponse",
                Query.AwsCloudAccountListSecurityGroups_ObjectFieldSpec,
                Query.AwsCloudAccountListSecurityGroupsFieldSpec,
                @"# REQUIRED
$inputs.Var.cloudAccountUuid = <System.String>
# REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$inputs.Var.region = <AwsRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
# REQUIRED
$inputs.Var.vpcID = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // allAwsExocomputeConfigs(awsNativeAccountIdOrNamePrefix: String!): [AwsExocomputeConfig!]!
        internal void InitQueryAllAwsExocomputeConfigs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsNativeAccountIdOrNamePrefix", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAwsExocomputeConfigs",
                "($awsNativeAccountIdOrNamePrefix: String!)",
                "List<AwsExocomputeConfig>",
                Query.AllAwsExocomputeConfigs_ObjectFieldSpec,
                Query.AllAwsExocomputeConfigsFieldSpec,
                @"# REQUIRED
$inputs.Var.awsNativeAccountIdOrNamePrefix = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // allAwsCloudAccountConfigs(awsCloudAccountsArg: AwsCloudAccountConfigsInput!): [AwsFeatureConfig!]!
        internal void InitQueryAllAwsCloudAccountConfigs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsCloudAccountsArg", "AwsCloudAccountConfigsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAwsCloudAccountConfigs",
                "($awsCloudAccountsArg: AwsCloudAccountConfigsInput!)",
                "List<AwsFeatureConfig>",
                Query.AllAwsCloudAccountConfigs_ObjectFieldSpec,
                Query.AllAwsCloudAccountConfigsFieldSpec,
                @"# REQUIRED
$inputs.Var.awsCloudAccountsArg = @{
	# REQUIRED
	feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	# REQUIRED
	statusFilters = @(
		<CloudAccountStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountStatus]) for enum values.
	)
	# OPTIONAL
	awsAdminAccountFilter = <System.String>
	# OPTIONAL
	columnSearchFilter = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // awsTrustPolicy(input: AwsTrustPolicyInput!): AwsTrustPolicy!
        internal void InitQueryAwsTrustPolicy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AwsTrustPolicyInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsTrustPolicy",
                "($input: AwsTrustPolicyInput!)",
                "AwsTrustPolicy",
                Query.AwsTrustPolicy_ObjectFieldSpec,
                Query.AwsTrustPolicyFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	cloudType = <AwsCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# REQUIRED
	awsNativeAccounts = @(
		@{
			# OPTIONAL
			externalId = <System.String>
			# REQUIRED
			id = <System.String>
		}
	)
}"
            );
        }

        // Create new GraphQL Query:
        // allAwsPermissionPolicies(input: AwsGetPermissionPoliciesInput!): [PermissionPolicy!]!
        internal void InitQueryAllAwsPermissionPolicies()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AwsGetPermissionPoliciesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAwsPermissionPolicies",
                "($input: AwsGetPermissionPoliciesInput!)",
                "List<PermissionPolicy>",
                Query.AllAwsPermissionPolicies_ObjectFieldSpec,
                Query.AllAwsPermissionPoliciesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	cloudType = <AwsCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# OPTIONAL
	featureSpecificDetails = @{
		# OPTIONAL
		ec2RecoveryRolePath = <System.String>
	}
}"
            );
        }

        // Create new GraphQL Query:
        // awsArtifactsToDelete(input: AwsArtifactsToDeleteInput!): AwsArtifactsToDelete!
        internal void InitQueryAwsArtifactsToDelete()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AwsArtifactsToDeleteInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsArtifactsToDelete",
                "($input: AwsArtifactsToDeleteInput!)",
                "AwsArtifactsToDelete",
                Query.AwsArtifactsToDelete_ObjectFieldSpec,
                Query.AwsArtifactsToDeleteFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	awsNativeId = <System.String>
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Query:
        // allAwsRegions(cloudAccountId: String!): [AwsCloudAccountRegion!]!
        internal void InitQueryAllAwsRegions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAwsRegions",
                "($cloudAccountId: String!)",
                "List<AwsCloudAccountRegion>",
                Query.AllAwsRegions_ObjectFieldSpec,
                Query.AllAwsRegionsFieldSpec,
                @"# REQUIRED
$inputs.Var.cloudAccountId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // allAwsCdmVersions(input: AwsCdmVersionRequest!): [AwsCdmVersion!]!
        internal void InitQueryAllAwsCdmVersions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AwsCdmVersionRequest!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAwsCdmVersions",
                "($input: AwsCdmVersionRequest!)",
                "List<AwsCdmVersion>",
                Query.AllAwsCdmVersions_ObjectFieldSpec,
                Query.AllAwsCdmVersionsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	region = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // allAwsInstanceProfileNames(cloudAccountId: String!, region: String!): [String!]!
        internal void InitQueryAllAwsInstanceProfileNames()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "String!"),
                Tuple.Create("region", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAwsInstanceProfileNames",
                "($cloudAccountId: String!,$region: String!)",
                "List<System.String>",
                Query.AllAwsInstanceProfileNames_ObjectFieldSpec,
                Query.AllAwsInstanceProfileNamesFieldSpec,
                @"# REQUIRED
$inputs.Var.cloudAccountId = <System.String>
# REQUIRED
$inputs.Var.region = <System.String>"
            );
        }


    } // class New_RscQueryAws
}