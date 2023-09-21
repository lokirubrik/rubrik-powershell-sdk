// New-RscGqlMutationStartCreateAwsNativeEbsVolumeSnapshotsJob.cs
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
    /// Create new GraphQL Mutation startCreateAwsNativeEbsVolumeSnapshotsJob
    /// startCreateAwsNativeEbsVolumeSnapshotsJob(input: StartCreateAwsNativeEbsVolumeSnapshotsJobInput!): BatchAsyncJobStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationStartCreateAwsNativeEbsVolumeSnapshotsJob")
    ]
    public class New_RscGqlMutationStartCreateAwsNativeEbsVolumeSnapshotsJob : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("startCreateAwsNativeEbsVolumeSnapshotsJob");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation startCreateAwsNativeEbsVolumeSnapshotsJob
        /// startCreateAwsNativeEbsVolumeSnapshotsJob(input: StartCreateAwsNativeEbsVolumeSnapshotsJobInput!): BatchAsyncJobStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_startCreateAwsNativeEbsVolumeSnapshotsJob();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_startCreateAwsNativeEbsVolumeSnapshotsJob()
        {
            this._logger.name += " -startCreateAwsNativeEbsVolumeSnapshotsJob";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartCreateAwsNativeEbsVolumeSnapshotsJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartCreateAwsNativeEbsVolumeSnapshotsJob",
                "($input: StartCreateAwsNativeEbsVolumeSnapshotsJobInput!)",
                "BatchAsyncJobStatus",
                Mutation.StartCreateAwsNativeEbsVolumeSnapshotsJob_ObjectFieldSpec,
                Mutation.StartCreateAwsNativeEbsVolumeSnapshotsJobFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	ebsVolumeIds = @(
		<System.String>
	)
	# OPTIONAL
	retentionSlaId = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationStartCreateAwsNativeEbsVolumeSnapshotsJob
}