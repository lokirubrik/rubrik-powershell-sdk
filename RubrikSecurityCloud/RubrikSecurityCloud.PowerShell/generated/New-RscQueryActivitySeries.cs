// New-RscQueryActivitySeries.cs
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
    /// Queries for the 'Activity series' API domain.
    /// </summary>
    /// <description>
    /// New-RscQueryActivitySeries is a master cmdlet for ActivitySeries work that can invoke any of the following subcommands: ActivitySeries, List.
    /// </description>
    /// <example>
    /// <code>New-RscQueryActivitySeries -ActivitySeries [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryActivitySeries -List [-Arg ..] [-Field ..]</code>
    /// </example>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscQueryActivitySeries",
        DefaultParameterSetName = "ActivitySeries")
    ]
    public class New_RscQueryActivitySeries : RscGqlPSCmdlet
    {
        
        /// <summary>
        /// ActivitySeries parameter set
        ///
        /// [GraphQL: activitySeries]
        /// </summary>
        [Parameter(
            ParameterSetName = "ActivitySeries",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieve an activity series.
[GraphQL: activitySeries]",
            Position = 0
        )]
        public SwitchParameter ActivitySeries { get; set; }

        
        /// <summary>
        /// List parameter set
        ///
        /// [GraphQL: activitySeriesConnection]
        /// </summary>
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: activitySeriesConnection]",
            Position = 0
        )]
        public SwitchParameter List { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(Op)
                {
                    case "ActivitySeries":
                        this.ProcessRecord_ActivitySeries();
                        break;
                    case "List":
                        this.ProcessRecord_List();
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
        // activitySeries.
        internal void ProcessRecord_ActivitySeries()
        {
            this._logger.name += " -ActivitySeries";
            // Create new graphql operation activitySeries
            InitQueryActivitySeries();
        }

        // This parameter set invokes a single graphql operation:
        // activitySeriesConnection.
        internal void ProcessRecord_List()
        {
            this._logger.name += " -List";
            // Create new graphql operation activitySeriesConnection
            InitQueryActivitySeriesConnection();
        }


        // Create new GraphQL Query:
        // activitySeries(input: ActivitySeriesInput!): ActivitySeries!
        internal void InitQueryActivitySeries()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ActivitySeriesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryActivitySeries",
                "($input: ActivitySeriesInput!)",
                "ActivitySeries",
                Query.ActivitySeries_ObjectFieldSpec,
                Query.ActivitySeriesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	activitySeriesId = <System.String>
	# OPTIONAL
	clusterUuid = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // activitySeriesConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortOrder: SortOrder
        //     sortBy: ActivitySeriesSortField
        //     filters: ActivitySeriesFilter
        //   ): ActivitySeriesConnection!
        internal void InitQueryActivitySeriesConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "ActivitySeriesSortField"),
                Tuple.Create("filters", "ActivitySeriesFilter"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryActivitySeriesConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: ActivitySeriesSortField,$filters: ActivitySeriesFilter)",
                "ActivitySeriesConnection",
                Query.ActivitySeriesConnection_ObjectFieldSpec,
                Query.ActivitySeriesConnectionFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.sortBy = <ActivitySeriesSortField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivitySeriesSortField]) for enum values.
# OPTIONAL
$inputs.Var.filters = @{
	# OPTIONAL
	lastActivityStatus = @(
		<EventStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventStatus]) for enum values.
	)
	# OPTIONAL
	lastActivityType = @(
		<EventType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventType]) for enum values.
	)
	# OPTIONAL
	severity = @(
		<EventSeverity> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventSeverity]) for enum values.
	)
	# OPTIONAL
	objectName = <System.String>
	# OPTIONAL
	objectType = @(
		<EventObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventObjectType]) for enum values.
	)
	# OPTIONAL
	startTimeGt = <DateTime>
	# OPTIONAL
	startTimeLt = <DateTime>
	# OPTIONAL
	lastUpdatedTimeGt = <DateTime>
	# OPTIONAL
	lastUpdatedTimeLt = <DateTime>
	# OPTIONAL
	clusterId = @(
		<System.String>
	)
	# OPTIONAL
	clusterType = @(
		<EventClusterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventClusterType]) for enum values.
	)
	# OPTIONAL
	objectFid = @(
		<System.String>
	)
	# OPTIONAL
	ancestorId = <System.String>
	# OPTIONAL
	searchTerm = <System.String>
	# OPTIONAL
	orgIds = @(
		<System.String>
	)
}"
            );
        }


    } // class New_RscQueryActivitySeries
}