// New-RscMutationCluster.cs
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
    /// Mutations for the 'Cluster' API domain.
    /// </summary>
    /// <description>
    /// New-RscMutationCluster is the cmdlet to work with operations in the {self.noun} API domain. It is a dynamic cmdlet that accepts any {self.noun} API operation as its first parameter:  {sc_names}.
    /// </description>
    /// <example>
    /// <code>New-RscMutationCluster -AddNodesToCloud [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationCluster -RegisterCloud [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationCluster -UpdateDatabaseLogReportingProperties [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationCluster -CreateFailover [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationCluster -UpdateFailover [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationCluster -DeleteFailover [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationCluster -BulkDeleteFailover [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationCluster -CreateK8s [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationCluster -RefreshK8s [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationCluster -ArchiveK8s [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationCluster -RemoveCdm [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationCluster -RecoverCloud [-Arg ..] [-Field ..]</code>
    /// </example>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationCluster",
        DefaultParameterSetName = "CreateK8s")
    ]
    public class New_RscMutationCluster : RscGqlPSCmdlet
    {
        
        /// <summary>
        /// AddNodesToCloud parameter set
        ///
        /// [GraphQL: addNodesToCloudCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "AddNodesToCloud",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Add nodes to cloud cluster.
[GraphQL: addNodesToCloudCluster]",
            Position = 0
        )]
        public SwitchParameter AddNodesToCloud { get; set; }

        
        /// <summary>
        /// RegisterCloud parameter set
        ///
        /// [GraphQL: registerCloudCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "RegisterCloud",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Register a cloud cluster.
[GraphQL: registerCloudCluster]",
            Position = 0
        )]
        public SwitchParameter RegisterCloud { get; set; }

        
        /// <summary>
        /// UpdateDatabaseLogReportingProperties parameter set
        ///
        /// [GraphQL: updateDatabaseLogReportingPropertiesForCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateDatabaseLogReportingProperties",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update the database log backup report properties

Supported in v5.3+
Update the properties for the database (SQL and Oracle) log backup delay email notification creation. The properties are logDelayThresholdInMin and logDelayNotificationFrequencyInMin.
[GraphQL: updateDatabaseLogReportingPropertiesForCluster]",
            Position = 0
        )]
        public SwitchParameter UpdateDatabaseLogReportingProperties { get; set; }

        
        /// <summary>
        /// CreateFailover parameter set
        ///
        /// [GraphQL: createFailoverCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreateFailover",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a failover cluster

Supported in v5.2+
Create a failover cluster.
[GraphQL: createFailoverCluster]",
            Position = 0
        )]
        public SwitchParameter CreateFailover { get; set; }

        
        /// <summary>
        /// UpdateFailover parameter set
        ///
        /// [GraphQL: updateFailoverCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateFailover",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update a failover cluster

Supported in v5.2+
Update failover cluster with specified properties.
[GraphQL: updateFailoverCluster]",
            Position = 0
        )]
        public SwitchParameter UpdateFailover { get; set; }

        
        /// <summary>
        /// DeleteFailover parameter set
        ///
        /// [GraphQL: deleteFailoverCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteFailover",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete a failover cluster

Supported in v5.2+
Delete a failover cluster.
[GraphQL: deleteFailoverCluster]",
            Position = 0
        )]
        public SwitchParameter DeleteFailover { get; set; }

        
        /// <summary>
        /// BulkDeleteFailover parameter set
        ///
        /// [GraphQL: bulkDeleteFailoverCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "BulkDeleteFailover",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete the provided failover clusters

Supported in v5.3+
Delete the provided failover clusters.
[GraphQL: bulkDeleteFailoverCluster]",
            Position = 0
        )]
        public SwitchParameter BulkDeleteFailover { get; set; }

        
        /// <summary>
        /// CreateK8s parameter set
        ///
        /// [GraphQL: createK8sCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreateK8s",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Add a Kubernetes cluster.
[GraphQL: createK8sCluster]",
            Position = 0
        )]
        public SwitchParameter CreateK8s { get; set; }

        
        /// <summary>
        /// RefreshK8s parameter set
        ///
        /// [GraphQL: refreshK8sCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "RefreshK8s",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Refresh resources of a Kubernetes cluster.
[GraphQL: refreshK8sCluster]",
            Position = 0
        )]
        public SwitchParameter RefreshK8s { get; set; }

        
        /// <summary>
        /// ArchiveK8s parameter set
        ///
        /// [GraphQL: archiveK8sCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "ArchiveK8s",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Archive a Kubernetes cluster.
[GraphQL: archiveK8sCluster]",
            Position = 0
        )]
        public SwitchParameter ArchiveK8s { get; set; }

        
        /// <summary>
        /// RemoveCdm parameter set
        ///
        /// [GraphQL: removeCdmCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "RemoveCdm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: removeCdmCluster]",
            Position = 0
        )]
        public SwitchParameter RemoveCdm { get; set; }

        
        /// <summary>
        /// RecoverCloud parameter set
        ///
        /// [GraphQL: recoverCloudCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "RecoverCloud",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Recover a Rubrik Cloud Cluster.
[GraphQL: recoverCloudCluster]",
            Position = 0
        )]
        public SwitchParameter RecoverCloud { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(Op)
                {
                    case "AddNodesToCloud":
                        this.ProcessRecord_AddNodesToCloud();
                        break;
                    case "RegisterCloud":
                        this.ProcessRecord_RegisterCloud();
                        break;
                    case "UpdateDatabaseLogReportingProperties":
                        this.ProcessRecord_UpdateDatabaseLogReportingProperties();
                        break;
                    case "CreateFailover":
                        this.ProcessRecord_CreateFailover();
                        break;
                    case "UpdateFailover":
                        this.ProcessRecord_UpdateFailover();
                        break;
                    case "DeleteFailover":
                        this.ProcessRecord_DeleteFailover();
                        break;
                    case "BulkDeleteFailover":
                        this.ProcessRecord_BulkDeleteFailover();
                        break;
                    case "CreateK8s":
                        this.ProcessRecord_CreateK8s();
                        break;
                    case "RefreshK8s":
                        this.ProcessRecord_RefreshK8s();
                        break;
                    case "ArchiveK8s":
                        this.ProcessRecord_ArchiveK8s();
                        break;
                    case "RemoveCdm":
                        this.ProcessRecord_RemoveCdm();
                        break;
                    case "RecoverCloud":
                        this.ProcessRecord_RecoverCloud();
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
        // addNodesToCloudCluster.
        internal void ProcessRecord_AddNodesToCloud()
        {
            this._logger.name += " -AddNodesToCloud";
            // Create new graphql operation addNodesToCloudCluster
            InitMutationAddNodesToCloudCluster();
        }

        // This parameter set invokes a single graphql operation:
        // registerCloudCluster.
        internal void ProcessRecord_RegisterCloud()
        {
            this._logger.name += " -RegisterCloud";
            // Create new graphql operation registerCloudCluster
            InitMutationRegisterCloudCluster();
        }

        // This parameter set invokes a single graphql operation:
        // updateDatabaseLogReportingPropertiesForCluster.
        internal void ProcessRecord_UpdateDatabaseLogReportingProperties()
        {
            this._logger.name += " -UpdateDatabaseLogReportingProperties";
            // Create new graphql operation updateDatabaseLogReportingPropertiesForCluster
            InitMutationUpdateDatabaseLogReportingPropertiesForCluster();
        }

        // This parameter set invokes a single graphql operation:
        // createFailoverCluster.
        internal void ProcessRecord_CreateFailover()
        {
            this._logger.name += " -CreateFailover";
            // Create new graphql operation createFailoverCluster
            InitMutationCreateFailoverCluster();
        }

        // This parameter set invokes a single graphql operation:
        // updateFailoverCluster.
        internal void ProcessRecord_UpdateFailover()
        {
            this._logger.name += " -UpdateFailover";
            // Create new graphql operation updateFailoverCluster
            InitMutationUpdateFailoverCluster();
        }

        // This parameter set invokes a single graphql operation:
        // deleteFailoverCluster.
        internal void ProcessRecord_DeleteFailover()
        {
            this._logger.name += " -DeleteFailover";
            // Create new graphql operation deleteFailoverCluster
            InitMutationDeleteFailoverCluster();
        }

        // This parameter set invokes a single graphql operation:
        // bulkDeleteFailoverCluster.
        internal void ProcessRecord_BulkDeleteFailover()
        {
            this._logger.name += " -BulkDeleteFailover";
            // Create new graphql operation bulkDeleteFailoverCluster
            InitMutationBulkDeleteFailoverCluster();
        }

        // This parameter set invokes a single graphql operation:
        // createK8sCluster.
        internal void ProcessRecord_CreateK8s()
        {
            this._logger.name += " -CreateK8s";
            // Create new graphql operation createK8sCluster
            InitMutationCreateK8sCluster();
        }

        // This parameter set invokes a single graphql operation:
        // refreshK8sCluster.
        internal void ProcessRecord_RefreshK8s()
        {
            this._logger.name += " -RefreshK8s";
            // Create new graphql operation refreshK8sCluster
            InitMutationRefreshK8sCluster();
        }

        // This parameter set invokes a single graphql operation:
        // archiveK8sCluster.
        internal void ProcessRecord_ArchiveK8s()
        {
            this._logger.name += " -ArchiveK8s";
            // Create new graphql operation archiveK8sCluster
            InitMutationArchiveK8sCluster();
        }

        // This parameter set invokes a single graphql operation:
        // removeCdmCluster.
        internal void ProcessRecord_RemoveCdm()
        {
            this._logger.name += " -RemoveCdm";
            // Create new graphql operation removeCdmCluster
            InitMutationRemoveCdmCluster();
        }

        // This parameter set invokes a single graphql operation:
        // recoverCloudCluster.
        internal void ProcessRecord_RecoverCloud()
        {
            this._logger.name += " -RecoverCloud";
            // Create new graphql operation recoverCloudCluster
            InitMutationRecoverCloudCluster();
        }


        // Create new GraphQL Mutation:
        // addNodesToCloudCluster(input: AddNodesToCloudClusterInput!): CcProvisionJobReply!
        internal void InitMutationAddNodesToCloudCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddNodesToCloudClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddNodesToCloudCluster",
                "($input: AddNodesToCloudClusterInput!)",
                "CcProvisionJobReply",
                Mutation.AddNodesToCloudCluster_ObjectFieldSpec,
                Mutation.AddNodesToCloudClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	numberOfNodes = <System.Int32>
	# OPTIONAL
	shouldKeepResourcesOnFailure = <System.Boolean>
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	vendor = <CcpVendorType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CcpVendorType]) for enum values.
	# REQUIRED
	clusterUuid = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // registerCloudCluster(input: RegisterCloudClusterInput!): RegisterCloudClusterReply!
        internal void InitMutationRegisterCloudCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RegisterCloudClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRegisterCloudCluster",
                "($input: RegisterCloudClusterInput!)",
                "RegisterCloudClusterReply",
                Mutation.RegisterCloudCluster_ObjectFieldSpec,
                Mutation.RegisterCloudClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	clusterUuid = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateDatabaseLogReportingPropertiesForCluster(input: UpdateDatabaseLogReportingPropertiesForClusterInput!): DbLogReportProperties!
        internal void InitMutationUpdateDatabaseLogReportingPropertiesForCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateDatabaseLogReportingPropertiesForClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateDatabaseLogReportingPropertiesForCluster",
                "($input: UpdateDatabaseLogReportingPropertiesForClusterInput!)",
                "DbLogReportProperties",
                Mutation.UpdateDatabaseLogReportingPropertiesForCluster_ObjectFieldSpec,
                Mutation.UpdateDatabaseLogReportingPropertiesForClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	properties = @{
		# OPTIONAL
		enableDelayNotification = <System.Boolean>
		# OPTIONAL
		logDelayThresholdInMin = <System.Int64>
		# OPTIONAL
		logDelayNotificationFrequencyInMin = <System.Int64>
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createFailoverCluster(input: CreateFailoverClusterInput!): CreateFailoverClusterReply!
        internal void InitMutationCreateFailoverCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateFailoverClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateFailoverCluster",
                "($input: CreateFailoverClusterInput!)",
                "CreateFailoverClusterReply",
                Mutation.CreateFailoverCluster_ObjectFieldSpec,
                Mutation.CreateFailoverClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	config = @{
		# OPTIONAL
		configuredSlaDomainId = <System.String>
		# REQUIRED
		hostIds = @(
			<System.String>
		)
		# REQUIRED
		name = <System.String>
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateFailoverCluster(input: UpdateFailoverClusterInput!): UpdateFailoverClusterReply!
        internal void InitMutationUpdateFailoverCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateFailoverClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateFailoverCluster",
                "($input: UpdateFailoverClusterInput!)",
                "UpdateFailoverClusterReply",
                Mutation.UpdateFailoverCluster_ObjectFieldSpec,
                Mutation.UpdateFailoverClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	updateProperties = @{
		# OPTIONAL
		configuredSlaDomainId = <System.String>
		# REQUIRED
		hostIds = @(
			<System.String>
		)
		# REQUIRED
		name = <System.String>
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteFailoverCluster(input: DeleteFailoverClusterInput!): ResponseSuccess!
        internal void InitMutationDeleteFailoverCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteFailoverClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteFailoverCluster",
                "($input: DeleteFailoverClusterInput!)",
                "ResponseSuccess",
                Mutation.DeleteFailoverCluster_ObjectFieldSpec,
                Mutation.DeleteFailoverClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	preserveSnapshots = <System.Boolean>
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // bulkDeleteFailoverCluster(input: BulkDeleteFailoverClusterInput!): ResponseSuccess!
        internal void InitMutationBulkDeleteFailoverCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkDeleteFailoverClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkDeleteFailoverCluster",
                "($input: BulkDeleteFailoverClusterInput!)",
                "ResponseSuccess",
                Mutation.BulkDeleteFailoverCluster_ObjectFieldSpec,
                Mutation.BulkDeleteFailoverClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	preserveSnapshots = <System.Boolean>
	# REQUIRED
	ids = @(
		<System.String>
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // createK8sCluster(input: CreateK8sClusterInput!): CreateK8sClusterReply!
        internal void InitMutationCreateK8sCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateK8sClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateK8sCluster",
                "($input: CreateK8sClusterInput!)",
                "CreateK8sClusterReply",
                Mutation.CreateK8sCluster_ObjectFieldSpec,
                Mutation.CreateK8sClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	cdmClusterId = <System.String>
	# REQUIRED
	hostList = @(
		<System.String>
	)
	# REQUIRED
	name = <System.String>
	# REQUIRED
	port = <System.Int32>
	# REQUIRED
	rbsPortRanges = @(
		@{
			# OPTIONAL
			portMin = <System.Int32>
			# OPTIONAL
			portMax = <System.Int32>
		}
	)
	# OPTIONAL
	userDrivenPortRanges = @(
		@{
			# OPTIONAL
			portMin = <System.Int32>
			# OPTIONAL
			portMax = <System.Int32>
		}
	)
	# REQUIRED
	type = <K8sClusterProtoType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.K8sClusterProtoType]) for enum values.
	# OPTIONAL
	proxyUrl = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // refreshK8sCluster(input: RefreshK8sClusterInput!): CreateOnDemandJobReply!
        internal void InitMutationRefreshK8sCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshK8sClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshK8sCluster",
                "($input: RefreshK8sClusterInput!)",
                "CreateOnDemandJobReply",
                Mutation.RefreshK8sCluster_ObjectFieldSpec,
                Mutation.RefreshK8sClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	k8sClusterId = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // archiveK8sCluster(input: ArchiveK8sClusterInput!): ArchiveK8sClusterReply!
        internal void InitMutationArchiveK8sCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ArchiveK8sClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationArchiveK8sCluster",
                "($input: ArchiveK8sClusterInput!)",
                "ArchiveK8sClusterReply",
                Mutation.ArchiveK8sCluster_ObjectFieldSpec,
                Mutation.ArchiveK8sClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterId = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // removeCdmCluster(clusterUUID: UUID!, isForce: Boolean!, expireInDays: Long): Boolean!
        internal void InitMutationRemoveCdmCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUUID", "UUID!"),
                Tuple.Create("isForce", "Boolean!"),
                Tuple.Create("expireInDays", "Long"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRemoveCdmCluster",
                "($clusterUUID: UUID!,$isForce: Boolean!,$expireInDays: Long)",
                "System.Boolean",
                Mutation.RemoveCdmCluster_ObjectFieldSpec,
                Mutation.RemoveCdmClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.clusterUUID = <System.String>
# REQUIRED
$inputs.Var.isForce = <System.Boolean>
# OPTIONAL
$inputs.Var.expireInDays = <System.Int64>"
            );
        }

        // Create new GraphQL Mutation:
        // recoverCloudCluster(input: RecoverCloudClusterInput!): CcProvisionJobReply!
        internal void InitMutationRecoverCloudCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RecoverCloudClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRecoverCloudCluster",
                "($input: RecoverCloudClusterInput!)",
                "CcProvisionJobReply",
                Mutation.RecoverCloudCluster_ObjectFieldSpec,
                Mutation.RecoverCloudClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	adminPassword = <System.String>
	# OPTIONAL
	userEmail = <System.String>
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	clusterUuid = <System.String>
	# OPTIONAL
	azureEsResourceGroup = <System.String>
	# OPTIONAL
	azureVmConfig = @{
		# OPTIONAL
		resourceGroup = <System.String>
		# OPTIONAL
		cdmVersion = <System.String>
		# OPTIONAL
		location = <System.String>
		# OPTIONAL
		nodeSizeGb = <System.Int32>
		# OPTIONAL
		networkResourceGroup = <System.String>
		# OPTIONAL
		vnetResourceGroup = <System.String>
		# OPTIONAL
		networkSecurityGroup = <System.String>
		# OPTIONAL
		networkSecurityResourceGroup = <System.String>
		# OPTIONAL
		vnet = <System.String>
		# OPTIONAL
		subnet = <System.String>
		# OPTIONAL
		tags = <System.String>
		# OPTIONAL
		vmImage = <System.String>
		# OPTIONAL
		cdmProduct = <System.String>
		# OPTIONAL
		vmType = <VmType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VmType]) for enum values.
		# OPTIONAL
		instanceType = <AzureInstanceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureInstanceType]) for enum values.
	}
	# OPTIONAL
	awsVmConfig = @{
		# OPTIONAL
		cdmVersion = <System.String>
		# OPTIONAL
		nodeSizeGb = <System.Int32>
		# OPTIONAL
		subnet = <System.String>
		# OPTIONAL
		tags = <System.String>
		# OPTIONAL
		imageId = <System.String>
		# OPTIONAL
		instanceProfileName = <System.String>
		# OPTIONAL
		cdmProduct = <System.String>
		# OPTIONAL
		vmType = <VmType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VmType]) for enum values.
		# OPTIONAL
		securityGroups = @(
			<System.String>
		)
		# OPTIONAL
		instanceType = <AwsInstanceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsInstanceType]) for enum values.
	}
	# OPTIONAL
	awsRegion = <System.String>
	# REQUIRED
	shouldDisableAwsApiTermination = <System.Boolean>
	# REQUIRED
	shouldKeepClusterOnFailure = <System.Boolean>
	# OPTIONAL
	ntpServers = @(
		<System.String>
	)
}"
            );
        }


    } // class New_RscMutationCluster
}