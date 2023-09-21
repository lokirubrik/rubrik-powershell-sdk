// New-RscMutationVsphere.cs
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
    /// Mutations for the 'vSphere' API domain.
    /// </summary>
    /// <description>
    /// New-RscMutationVsphere is the cmdlet to work with operations in the {self.noun} API domain. It is a dynamic cmdlet that accepts any {self.noun} API operation as its first parameter:  {sc_names}.
    /// </description>
    /// <example>
    /// <code>New-RscMutationVsphere -OnDemandSnapshot [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationVsphere -BulkOnDemandSnapshot [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationVsphere -DeleteLiveMount [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationVsphere -ExportSnapshotToStandaloneHostV2 [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationVsphere -DownloadVirtualMachineFiles [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationVsphere -CreateAdvancedTag [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationVsphere -DeleteAdvancedTag [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationVsphere -UpdateAdvancedTag [-Arg ..] [-Field ..]</code>
    /// </example>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationVsphere",
        DefaultParameterSetName = "DeleteLiveMount")
    ]
    public class New_RscMutationVsphere : RscGqlPSCmdlet
    {
        
        /// <summary>
        /// OnDemandSnapshot parameter set
        ///
        /// [GraphQL: vsphereOnDemandSnapshot]
        /// </summary>
        [Parameter(
            ParameterSetName = "OnDemandSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vsphereOnDemandSnapshot]",
            Position = 0
        )]
        public SwitchParameter OnDemandSnapshot { get; set; }

        
        /// <summary>
        /// BulkOnDemandSnapshot parameter set
        ///
        /// [GraphQL: vsphereBulkOnDemandSnapshot]
        /// </summary>
        [Parameter(
            ParameterSetName = "BulkOnDemandSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Trigger a bulk on demand snapshot.
[GraphQL: vsphereBulkOnDemandSnapshot]",
            Position = 0
        )]
        public SwitchParameter BulkOnDemandSnapshot { get; set; }

        
        /// <summary>
        /// DeleteLiveMount parameter set
        ///
        /// [GraphQL: deleteVsphereLiveMount]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete a Live Mount VM

Supported in v5.0+
Create a request to delete a Live Mount virtual machine.
[GraphQL: deleteVsphereLiveMount]",
            Position = 0
        )]
        public SwitchParameter DeleteLiveMount { get; set; }

        
        /// <summary>
        /// ExportSnapshotToStandaloneHostV2 parameter set
        ///
        /// [GraphQL: vsphereExportSnapshotToStandaloneHostV2]
        /// </summary>
        [Parameter(
            ParameterSetName = "ExportSnapshotToStandaloneHostV2",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Export snapshot of a virtual machine to standalone ESXi server.
[GraphQL: vsphereExportSnapshotToStandaloneHostV2]",
            Position = 0
        )]
        public SwitchParameter ExportSnapshotToStandaloneHostV2 { get; set; }

        
        /// <summary>
        /// DownloadVirtualMachineFiles parameter set
        ///
        /// [GraphQL: downloadVsphereVirtualMachineFiles]
        /// </summary>
        [Parameter(
            ParameterSetName = "DownloadVirtualMachineFiles",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Download Virtual Machine files from a snapshot

Supported in v9.0+
Start an asynchronous job to download multiple Virtual Machine files, such as .vmdk, .vmx, and .nvram files, from the specified Virtual Machine snapshot.
[GraphQL: downloadVsphereVirtualMachineFiles]",
            Position = 0
        )]
        public SwitchParameter DownloadVirtualMachineFiles { get; set; }

        
        /// <summary>
        /// CreateAdvancedTag parameter set
        ///
        /// [GraphQL: createVsphereAdvancedTag]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreateAdvancedTag",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a multi-tag filter for vSphere tags

Supported in v7.0+
Create a filter consisting of vSphere tags joined with logical operators.
[GraphQL: createVsphereAdvancedTag]",
            Position = 0
        )]
        public SwitchParameter CreateAdvancedTag { get; set; }

        
        /// <summary>
        /// DeleteAdvancedTag parameter set
        ///
        /// [GraphQL: deleteVsphereAdvancedTag]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteAdvancedTag",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Remove the multi-tag filter

Supported in v7.0+
Remove the multi-tag filter.
[GraphQL: deleteVsphereAdvancedTag]",
            Position = 0
        )]
        public SwitchParameter DeleteAdvancedTag { get; set; }

        
        /// <summary>
        /// UpdateAdvancedTag parameter set
        ///
        /// [GraphQL: updateVsphereAdvancedTag]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateAdvancedTag",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update the multi-tag filter

Supported in v7.0+
Updates the name, condition, and description of the specified multi-tag filter.
[GraphQL: updateVsphereAdvancedTag]",
            Position = 0
        )]
        public SwitchParameter UpdateAdvancedTag { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(Op)
                {
                    case "OnDemandSnapshot":
                        this.ProcessRecord_OnDemandSnapshot();
                        break;
                    case "BulkOnDemandSnapshot":
                        this.ProcessRecord_BulkOnDemandSnapshot();
                        break;
                    case "DeleteLiveMount":
                        this.ProcessRecord_DeleteLiveMount();
                        break;
                    case "ExportSnapshotToStandaloneHostV2":
                        this.ProcessRecord_ExportSnapshotToStandaloneHostV2();
                        break;
                    case "DownloadVirtualMachineFiles":
                        this.ProcessRecord_DownloadVirtualMachineFiles();
                        break;
                    case "CreateAdvancedTag":
                        this.ProcessRecord_CreateAdvancedTag();
                        break;
                    case "DeleteAdvancedTag":
                        this.ProcessRecord_DeleteAdvancedTag();
                        break;
                    case "UpdateAdvancedTag":
                        this.ProcessRecord_UpdateAdvancedTag();
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
        // vsphereOnDemandSnapshot.
        internal void ProcessRecord_OnDemandSnapshot()
        {
            this._logger.name += " -OnDemandSnapshot";
            // Create new graphql operation vsphereOnDemandSnapshot
            InitMutationVsphereOnDemandSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereBulkOnDemandSnapshot.
        internal void ProcessRecord_BulkOnDemandSnapshot()
        {
            this._logger.name += " -BulkOnDemandSnapshot";
            // Create new graphql operation vsphereBulkOnDemandSnapshot
            InitMutationVsphereBulkOnDemandSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // deleteVsphereLiveMount.
        internal void ProcessRecord_DeleteLiveMount()
        {
            this._logger.name += " -DeleteLiveMount";
            // Create new graphql operation deleteVsphereLiveMount
            InitMutationDeleteVsphereLiveMount();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereExportSnapshotToStandaloneHostV2.
        internal void ProcessRecord_ExportSnapshotToStandaloneHostV2()
        {
            this._logger.name += " -ExportSnapshotToStandaloneHostV2";
            // Create new graphql operation vsphereExportSnapshotToStandaloneHostV2
            InitMutationVsphereExportSnapshotToStandaloneHostV2();
        }

        // This parameter set invokes a single graphql operation:
        // downloadVsphereVirtualMachineFiles.
        internal void ProcessRecord_DownloadVirtualMachineFiles()
        {
            this._logger.name += " -DownloadVirtualMachineFiles";
            // Create new graphql operation downloadVsphereVirtualMachineFiles
            InitMutationDownloadVsphereVirtualMachineFiles();
        }

        // This parameter set invokes a single graphql operation:
        // createVsphereAdvancedTag.
        internal void ProcessRecord_CreateAdvancedTag()
        {
            this._logger.name += " -CreateAdvancedTag";
            // Create new graphql operation createVsphereAdvancedTag
            InitMutationCreateVsphereAdvancedTag();
        }

        // This parameter set invokes a single graphql operation:
        // deleteVsphereAdvancedTag.
        internal void ProcessRecord_DeleteAdvancedTag()
        {
            this._logger.name += " -DeleteAdvancedTag";
            // Create new graphql operation deleteVsphereAdvancedTag
            InitMutationDeleteVsphereAdvancedTag();
        }

        // This parameter set invokes a single graphql operation:
        // updateVsphereAdvancedTag.
        internal void ProcessRecord_UpdateAdvancedTag()
        {
            this._logger.name += " -UpdateAdvancedTag";
            // Create new graphql operation updateVsphereAdvancedTag
            InitMutationUpdateVsphereAdvancedTag();
        }


        // Create new GraphQL Mutation:
        // vsphereOnDemandSnapshot(input: VsphereOnDemandSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationVsphereOnDemandSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereOnDemandSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereOnDemandSnapshot",
                "($input: VsphereOnDemandSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.VsphereOnDemandSnapshot_ObjectFieldSpec,
                Mutation.VsphereOnDemandSnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	config = @{
		# OPTIONAL
		slaId = <System.String>
	}
	# REQUIRED
	id = <System.String>
	# OPTIONAL
	userNote = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // vsphereBulkOnDemandSnapshot(input: VsphereBulkOnDemandSnapshotInput!): BatchAsyncRequestStatus!
        internal void InitMutationVsphereBulkOnDemandSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereBulkOnDemandSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereBulkOnDemandSnapshot",
                "($input: VsphereBulkOnDemandSnapshotInput!)",
                "BatchAsyncRequestStatus",
                Mutation.VsphereBulkOnDemandSnapshot_ObjectFieldSpec,
                Mutation.VsphereBulkOnDemandSnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		slaId = <System.String>
		# REQUIRED
		vms = @(
			<System.String>
		)
	}
	# OPTIONAL
	userNote = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteVsphereLiveMount(input: DeleteVsphereLiveMountInput!): AsyncRequestStatus!
        internal void InitMutationDeleteVsphereLiveMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteVsphereLiveMountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteVsphereLiveMount",
                "($input: DeleteVsphereLiveMountInput!)",
                "AsyncRequestStatus",
                Mutation.DeleteVsphereLiveMount_ObjectFieldSpec,
                Mutation.DeleteVsphereLiveMountFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	force = <System.Boolean>
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // vsphereExportSnapshotToStandaloneHostV2(input: VsphereExportSnapshotToStandaloneHostV2Input!): AsyncRequestStatus!
        internal void InitMutationVsphereExportSnapshotToStandaloneHostV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereExportSnapshotToStandaloneHostV2Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereExportSnapshotToStandaloneHostV2",
                "($input: VsphereExportSnapshotToStandaloneHostV2Input!)",
                "AsyncRequestStatus",
                Mutation.VsphereExportSnapshotToStandaloneHostV2_ObjectFieldSpec,
                Mutation.VsphereExportSnapshotToStandaloneHostV2FieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		mountExportSnapshotJobCommonOptions = @{
			# OPTIONAL
			disableNetwork = <System.Boolean>
			# OPTIONAL
			keepMacAddresses = <System.Boolean>
			# OPTIONAL
			powerOn = <System.Boolean>
			# OPTIONAL
			removeNetworkDevices = <System.Boolean>
			# OPTIONAL
			vmName = <System.String>
		}
		# REQUIRED
		datastoreName = <System.String>
		# REQUIRED
		hostIpAddress = <System.String>
		# REQUIRED
		hostPassword = <System.String>
		# REQUIRED
		hostUsername = <System.String>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadVsphereVirtualMachineFiles(input: DownloadVsphereVirtualMachineFilesInput!): AsyncRequestStatus!
        internal void InitMutationDownloadVsphereVirtualMachineFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadVsphereVirtualMachineFilesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadVsphereVirtualMachineFiles",
                "($input: DownloadVsphereVirtualMachineFilesInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadVsphereVirtualMachineFiles_ObjectFieldSpec,
                Mutation.DownloadVsphereVirtualMachineFilesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		fileNamesToDownload = @(
			<System.String>
		)
		# REQUIRED
		vmId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // createVsphereAdvancedTag(input: CreateVsphereAdvancedTagInput!): CreateVsphereAdvancedTagReply!
        internal void InitMutationCreateVsphereAdvancedTag()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateVsphereAdvancedTagInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateVsphereAdvancedTag",
                "($input: CreateVsphereAdvancedTagInput!)",
                "CreateVsphereAdvancedTagReply",
                Mutation.CreateVsphereAdvancedTag_ObjectFieldSpec,
                Mutation.CreateVsphereAdvancedTagFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	filterInfo = @{
		# OPTIONAL
		description = <System.String>
		# REQUIRED
		condition = <System.String>
		# REQUIRED
		name = <System.String>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteVsphereAdvancedTag(input: DeleteVsphereAdvancedTagInput!): RequestSuccess!
        internal void InitMutationDeleteVsphereAdvancedTag()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteVsphereAdvancedTagInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteVsphereAdvancedTag",
                "($input: DeleteVsphereAdvancedTagInput!)",
                "RequestSuccess",
                Mutation.DeleteVsphereAdvancedTag_ObjectFieldSpec,
                Mutation.DeleteVsphereAdvancedTagFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	filterId = <System.String>
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateVsphereAdvancedTag(input: UpdateVsphereAdvancedTagInput!): UpdateVsphereAdvancedTagReply!
        internal void InitMutationUpdateVsphereAdvancedTag()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateVsphereAdvancedTagInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateVsphereAdvancedTag",
                "($input: UpdateVsphereAdvancedTagInput!)",
                "UpdateVsphereAdvancedTagReply",
                Mutation.UpdateVsphereAdvancedTag_ObjectFieldSpec,
                Mutation.UpdateVsphereAdvancedTagFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	filterId = <System.String>
	# REQUIRED
	filterInfo = @{
		# OPTIONAL
		description = <System.String>
		# REQUIRED
		condition = <System.String>
		# REQUIRED
		name = <System.String>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }


    } // class New_RscMutationVsphere
}