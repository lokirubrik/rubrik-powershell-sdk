// New-RscGqlQueryO365OrgSummaries.cs
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
    /// Create new GraphQL Query o365OrgSummaries
    /// o365OrgSummaries: GetImplicitlyAuthorizedObjectSummariesResponse!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryO365OrgSummaries")
    ]
    public class New_RscGqlQueryO365OrgSummaries : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("o365OrgSummaries");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query o365OrgSummaries
        /// o365OrgSummaries: GetImplicitlyAuthorizedObjectSummariesResponse!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_o365OrgSummaries();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_o365OrgSummaries()
        {
            this._logger.name += " -o365OrgSummaries";
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365OrgSummaries",
                "",
                "GetImplicitlyAuthorizedObjectSummariesResponse",
                Query.O365OrgSummaries_ObjectFieldSpec,
                Query.O365OrgSummariesFieldSpec,
                @""
            );
        }

    } // class New-RscGqlQueryO365OrgSummaries
}