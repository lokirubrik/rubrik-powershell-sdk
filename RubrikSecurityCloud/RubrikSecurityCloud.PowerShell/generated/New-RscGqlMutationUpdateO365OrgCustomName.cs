// New-RscGqlMutationUpdateO365OrgCustomName.cs
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
    /// Create new GraphQL Mutation updateO365OrgCustomName
    /// updateO365OrgCustomName(input: UpdateO365OrgCustomNameInput!): UpdateO365OrgCustomNameReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationUpdateO365OrgCustomName")
    ]
    public class New_RscGqlMutationUpdateO365OrgCustomName : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("updateO365OrgCustomName");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation updateO365OrgCustomName
        /// updateO365OrgCustomName(input: UpdateO365OrgCustomNameInput!): UpdateO365OrgCustomNameReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_updateO365OrgCustomName();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_updateO365OrgCustomName()
        {
            this._logger.name += " -updateO365OrgCustomName";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateO365OrgCustomNameInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateO365OrgCustomName",
                "($input: UpdateO365OrgCustomNameInput!)",
                "UpdateO365OrgCustomNameReply",
                Mutation.UpdateO365OrgCustomName_ObjectFieldSpec,
                Mutation.UpdateO365OrgCustomNameFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	orgUuid = <System.String>
	# REQUIRED
	customName = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationUpdateO365OrgCustomName
}