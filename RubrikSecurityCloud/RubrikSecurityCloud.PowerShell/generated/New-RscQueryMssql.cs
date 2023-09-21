// New-RscQueryMssql.cs
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
    /// Queries for the 'MSSQL' API domain.
    /// </summary>
    /// <description>
    /// New-RscQueryMssql is the cmdlet to work with operations in the {self.noun} API domain. It is a dynamic cmdlet that accepts any {self.noun} API operation as its first parameter:  {sc_names}.
    /// </description>
    /// <example>
    /// <code>New-RscQueryMssql -TopLevelDescendants [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryMssql -Databases [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryMssql -AvailabilityGroup [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryMssql -Instance [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryMssql -Database [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryMssql -RecoverableRanges [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryMssql -DatabaseMissedSnapshots [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryMssql -CompatibleInstances [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryMssql -DatabaseMissedRecoverableRanges [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryMssql -AllDatabaseRestoreFiles [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryMssql -DatabaseLiveMounts [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryMssql -DefaultProperties [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryMssql -DatabaseRestoreEstimate [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryMssql -CdmLogShippingTargets [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryMssql -CdmLogShippingTarget [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryMssql -LogShippingTargets [-Arg ..] [-Field ..]</code>
    /// </example>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscQueryMssql",
        DefaultParameterSetName = "Instance")
    ]
    public class New_RscQueryMssql : RscGqlPSCmdlet
    {
        
        /// <summary>
        /// TopLevelDescendants parameter set
        ///
        /// [GraphQL: mssqlTopLevelDescendants]
        /// </summary>
        [Parameter(
            ParameterSetName = "TopLevelDescendants",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of the highest-level Microsoft SQL Objects accessible by the current user.
[GraphQL: mssqlTopLevelDescendants]",
            Position = 0
        )]
        public SwitchParameter TopLevelDescendants { get; set; }

        
        /// <summary>
        /// Databases parameter set
        ///
        /// [GraphQL: mssqlDatabases]
        /// </summary>
        [Parameter(
            ParameterSetName = "Databases",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of Microsoft SQL Databases.
[GraphQL: mssqlDatabases]",
            Position = 0
        )]
        public SwitchParameter Databases { get; set; }

        
        /// <summary>
        /// AvailabilityGroup parameter set
        ///
        /// [GraphQL: mssqlAvailabilityGroup]
        /// </summary>
        [Parameter(
            ParameterSetName = "AvailabilityGroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"A Microsoft SQL Availability Group.
[GraphQL: mssqlAvailabilityGroup]",
            Position = 0
        )]
        public SwitchParameter AvailabilityGroup { get; set; }

        
        /// <summary>
        /// Instance parameter set
        ///
        /// [GraphQL: mssqlInstance]
        /// </summary>
        [Parameter(
            ParameterSetName = "Instance",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"A Microsoft SQL Instance.
[GraphQL: mssqlInstance]",
            Position = 0
        )]
        public SwitchParameter Instance { get; set; }

        
        /// <summary>
        /// Database parameter set
        ///
        /// [GraphQL: mssqlDatabase]
        /// </summary>
        [Parameter(
            ParameterSetName = "Database",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"A Microsoft SQL Database.
[GraphQL: mssqlDatabase]",
            Position = 0
        )]
        public SwitchParameter Database { get; set; }

        
        /// <summary>
        /// RecoverableRanges parameter set
        ///
        /// [GraphQL: mssqlRecoverableRanges]
        /// </summary>
        [Parameter(
            ParameterSetName = "RecoverableRanges",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of recoverable ranges for a Microsoft SQL Database.
[GraphQL: mssqlRecoverableRanges]",
            Position = 0
        )]
        public SwitchParameter RecoverableRanges { get; set; }

        
        /// <summary>
        /// DatabaseMissedSnapshots parameter set
        ///
        /// [GraphQL: mssqlDatabaseMissedSnapshots]
        /// </summary>
        [Parameter(
            ParameterSetName = "DatabaseMissedSnapshots",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of missed snapshots for a Microsoft SQL Database.
[GraphQL: mssqlDatabaseMissedSnapshots]",
            Position = 0
        )]
        public SwitchParameter DatabaseMissedSnapshots { get; set; }

        
        /// <summary>
        /// CompatibleInstances parameter set
        ///
        /// [GraphQL: mssqlCompatibleInstances]
        /// </summary>
        [Parameter(
            ParameterSetName = "CompatibleInstances",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns all compatible instances for export for the specified recovery time.
[GraphQL: mssqlCompatibleInstances]",
            Position = 0
        )]
        public SwitchParameter CompatibleInstances { get; set; }

        
        /// <summary>
        /// DatabaseMissedRecoverableRanges parameter set
        ///
        /// [GraphQL: mssqlDatabaseMissedRecoverableRanges]
        /// </summary>
        [Parameter(
            ParameterSetName = "DatabaseMissedRecoverableRanges",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of missed recoverable ranges for a Microsoft SQL Database.
[GraphQL: mssqlDatabaseMissedRecoverableRanges]",
            Position = 0
        )]
        public SwitchParameter DatabaseMissedRecoverableRanges { get; set; }

        
        /// <summary>
        /// AllDatabaseRestoreFiles parameter set
        ///
        /// [GraphQL: allMssqlDatabaseRestoreFiles]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllDatabaseRestoreFiles",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Provides a list of database files to be restored for the specified restore or export operation.
[GraphQL: allMssqlDatabaseRestoreFiles]",
            Position = 0
        )]
        public SwitchParameter AllDatabaseRestoreFiles { get; set; }

        
        /// <summary>
        /// DatabaseLiveMounts parameter set
        ///
        /// [GraphQL: mssqlDatabaseLiveMounts]
        /// </summary>
        [Parameter(
            ParameterSetName = "DatabaseLiveMounts",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of Microsoft SQL Database live mounts.
[GraphQL: mssqlDatabaseLiveMounts]",
            Position = 0
        )]
        public SwitchParameter DatabaseLiveMounts { get; set; }

        
        /// <summary>
        /// DefaultProperties parameter set
        ///
        /// [GraphQL: mssqlDefaultProperties]
        /// </summary>
        [Parameter(
            ParameterSetName = "DefaultProperties",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The current default properties for Microsoft SQL databases.
[GraphQL: mssqlDefaultProperties]",
            Position = 0
        )]
        public SwitchParameter DefaultProperties { get; set; }

        
        /// <summary>
        /// DatabaseRestoreEstimate parameter set
        ///
        /// [GraphQL: mssqlDatabaseRestoreEstimate]
        /// </summary>
        [Parameter(
            ParameterSetName = "DatabaseRestoreEstimate",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns a size estimate for a restore, export, or mount.
[GraphQL: mssqlDatabaseRestoreEstimate]",
            Position = 0
        )]
        public SwitchParameter DatabaseRestoreEstimate { get; set; }

        
        /// <summary>
        /// CdmLogShippingTargets parameter set
        ///
        /// [GraphQL: cdmMssqlLogShippingTargets]
        /// </summary>
        [Parameter(
            ParameterSetName = "CdmLogShippingTargets",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of Microsoft SQL log shipping target.
[GraphQL: cdmMssqlLogShippingTargets]",
            Position = 0
        )]
        public SwitchParameter CdmLogShippingTargets { get; set; }

        
        /// <summary>
        /// CdmLogShippingTarget parameter set
        ///
        /// [GraphQL: cdmMssqlLogShippingTarget]
        /// </summary>
        [Parameter(
            ParameterSetName = "CdmLogShippingTarget",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"A single Microsoft SQL log shipping target.
[GraphQL: cdmMssqlLogShippingTarget]",
            Position = 0
        )]
        public SwitchParameter CdmLogShippingTarget { get; set; }

        
        /// <summary>
        /// LogShippingTargets parameter set
        ///
        /// [GraphQL: mssqlLogShippingTargets]
        /// </summary>
        [Parameter(
            ParameterSetName = "LogShippingTargets",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of filtered Microsoft SQL log shipping targets.
[GraphQL: mssqlLogShippingTargets]",
            Position = 0
        )]
        public SwitchParameter LogShippingTargets { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(Op)
                {
                    case "TopLevelDescendants":
                        this.ProcessRecord_TopLevelDescendants();
                        break;
                    case "Databases":
                        this.ProcessRecord_Databases();
                        break;
                    case "AvailabilityGroup":
                        this.ProcessRecord_AvailabilityGroup();
                        break;
                    case "Instance":
                        this.ProcessRecord_Instance();
                        break;
                    case "Database":
                        this.ProcessRecord_Database();
                        break;
                    case "RecoverableRanges":
                        this.ProcessRecord_RecoverableRanges();
                        break;
                    case "DatabaseMissedSnapshots":
                        this.ProcessRecord_DatabaseMissedSnapshots();
                        break;
                    case "CompatibleInstances":
                        this.ProcessRecord_CompatibleInstances();
                        break;
                    case "DatabaseMissedRecoverableRanges":
                        this.ProcessRecord_DatabaseMissedRecoverableRanges();
                        break;
                    case "AllDatabaseRestoreFiles":
                        this.ProcessRecord_AllDatabaseRestoreFiles();
                        break;
                    case "DatabaseLiveMounts":
                        this.ProcessRecord_DatabaseLiveMounts();
                        break;
                    case "DefaultProperties":
                        this.ProcessRecord_DefaultProperties();
                        break;
                    case "DatabaseRestoreEstimate":
                        this.ProcessRecord_DatabaseRestoreEstimate();
                        break;
                    case "CdmLogShippingTargets":
                        this.ProcessRecord_CdmLogShippingTargets();
                        break;
                    case "CdmLogShippingTarget":
                        this.ProcessRecord_CdmLogShippingTarget();
                        break;
                    case "LogShippingTargets":
                        this.ProcessRecord_LogShippingTargets();
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
        // mssqlTopLevelDescendants.
        internal void ProcessRecord_TopLevelDescendants()
        {
            this._logger.name += " -TopLevelDescendants";
            // Create new graphql operation mssqlTopLevelDescendants
            InitQueryMssqlTopLevelDescendants();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlDatabases.
        internal void ProcessRecord_Databases()
        {
            this._logger.name += " -Databases";
            // Create new graphql operation mssqlDatabases
            InitQueryMssqlDatabases();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlAvailabilityGroup.
        internal void ProcessRecord_AvailabilityGroup()
        {
            this._logger.name += " -AvailabilityGroup";
            // Create new graphql operation mssqlAvailabilityGroup
            InitQueryMssqlAvailabilityGroup();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlInstance.
        internal void ProcessRecord_Instance()
        {
            this._logger.name += " -Instance";
            // Create new graphql operation mssqlInstance
            InitQueryMssqlInstance();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlDatabase.
        internal void ProcessRecord_Database()
        {
            this._logger.name += " -Database";
            // Create new graphql operation mssqlDatabase
            InitQueryMssqlDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlRecoverableRanges.
        internal void ProcessRecord_RecoverableRanges()
        {
            this._logger.name += " -RecoverableRanges";
            // Create new graphql operation mssqlRecoverableRanges
            InitQueryMssqlRecoverableRanges();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlDatabaseMissedSnapshots.
        internal void ProcessRecord_DatabaseMissedSnapshots()
        {
            this._logger.name += " -DatabaseMissedSnapshots";
            // Create new graphql operation mssqlDatabaseMissedSnapshots
            InitQueryMssqlDatabaseMissedSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlCompatibleInstances.
        internal void ProcessRecord_CompatibleInstances()
        {
            this._logger.name += " -CompatibleInstances";
            // Create new graphql operation mssqlCompatibleInstances
            InitQueryMssqlCompatibleInstances();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlDatabaseMissedRecoverableRanges.
        internal void ProcessRecord_DatabaseMissedRecoverableRanges()
        {
            this._logger.name += " -DatabaseMissedRecoverableRanges";
            // Create new graphql operation mssqlDatabaseMissedRecoverableRanges
            InitQueryMssqlDatabaseMissedRecoverableRanges();
        }

        // This parameter set invokes a single graphql operation:
        // allMssqlDatabaseRestoreFiles.
        internal void ProcessRecord_AllDatabaseRestoreFiles()
        {
            this._logger.name += " -AllDatabaseRestoreFiles";
            // Create new graphql operation allMssqlDatabaseRestoreFiles
            InitQueryAllMssqlDatabaseRestoreFiles();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlDatabaseLiveMounts.
        internal void ProcessRecord_DatabaseLiveMounts()
        {
            this._logger.name += " -DatabaseLiveMounts";
            // Create new graphql operation mssqlDatabaseLiveMounts
            InitQueryMssqlDatabaseLiveMounts();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlDefaultProperties.
        internal void ProcessRecord_DefaultProperties()
        {
            this._logger.name += " -DefaultProperties";
            // Create new graphql operation mssqlDefaultProperties
            InitQueryMssqlDefaultProperties();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlDatabaseRestoreEstimate.
        internal void ProcessRecord_DatabaseRestoreEstimate()
        {
            this._logger.name += " -DatabaseRestoreEstimate";
            // Create new graphql operation mssqlDatabaseRestoreEstimate
            InitQueryMssqlDatabaseRestoreEstimate();
        }

        // This parameter set invokes a single graphql operation:
        // cdmMssqlLogShippingTargets.
        internal void ProcessRecord_CdmLogShippingTargets()
        {
            this._logger.name += " -CdmLogShippingTargets";
            // Create new graphql operation cdmMssqlLogShippingTargets
            InitQueryCdmMssqlLogShippingTargets();
        }

        // This parameter set invokes a single graphql operation:
        // cdmMssqlLogShippingTarget.
        internal void ProcessRecord_CdmLogShippingTarget()
        {
            this._logger.name += " -CdmLogShippingTarget";
            // Create new graphql operation cdmMssqlLogShippingTarget
            InitQueryCdmMssqlLogShippingTarget();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlLogShippingTargets.
        internal void ProcessRecord_LogShippingTargets()
        {
            this._logger.name += " -LogShippingTargets";
            // Create new graphql operation mssqlLogShippingTargets
            InitQueryMssqlLogShippingTargets();
        }


        // Create new GraphQL Query:
        // mssqlTopLevelDescendants(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     typeFilter: [HierarchyObjectTypeEnum!]
        //     filter: [Filter!]
        //   ): MssqlTopLevelDescendantTypeConnection!
        internal void InitQueryMssqlTopLevelDescendants()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("typeFilter", "[HierarchyObjectTypeEnum!]"),
                Tuple.Create("filter", "[Filter!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMssqlTopLevelDescendants",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$typeFilter: [HierarchyObjectTypeEnum!],$filter: [Filter!])",
                "MssqlTopLevelDescendantTypeConnection",
                Query.MssqlTopLevelDescendants_ObjectFieldSpec,
                Query.MssqlTopLevelDescendantsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.typeFilter = @(
	<HierarchyObjectTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
)
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
        // mssqlDatabases(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): MssqlDatabaseConnection!
        internal void InitQueryMssqlDatabases()
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
                "QueryMssqlDatabases",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "MssqlDatabaseConnection",
                Query.MssqlDatabases_ObjectFieldSpec,
                Query.MssqlDatabasesFieldSpec,
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
        // mssqlAvailabilityGroup(fid: UUID!): MssqlAvailabilityGroup!
        internal void InitQueryMssqlAvailabilityGroup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMssqlAvailabilityGroup",
                "($fid: UUID!)",
                "MssqlAvailabilityGroup",
                Query.MssqlAvailabilityGroup_ObjectFieldSpec,
                Query.MssqlAvailabilityGroupFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // mssqlInstance(fid: UUID!): MssqlInstance!
        internal void InitQueryMssqlInstance()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMssqlInstance",
                "($fid: UUID!)",
                "MssqlInstance",
                Query.MssqlInstance_ObjectFieldSpec,
                Query.MssqlInstanceFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // mssqlDatabase(fid: UUID!): MssqlDatabase!
        internal void InitQueryMssqlDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMssqlDatabase",
                "($fid: UUID!)",
                "MssqlDatabase",
                Query.MssqlDatabase_ObjectFieldSpec,
                Query.MssqlDatabaseFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // mssqlRecoverableRanges(input: GetMssqlDbRecoverableRangesInput!): MssqlRecoverableRangeListResponse!
        internal void InitQueryMssqlRecoverableRanges()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetMssqlDbRecoverableRangesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMssqlRecoverableRanges",
                "($input: GetMssqlDbRecoverableRangesInput!)",
                "MssqlRecoverableRangeListResponse",
                Query.MssqlRecoverableRanges_ObjectFieldSpec,
                Query.MssqlRecoverableRangesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	afterTime = <DateTime>
	# OPTIONAL
	beforeTime = <DateTime>
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // mssqlDatabaseMissedSnapshots(input: GetMissedMssqlDbSnapshotsInput!): MissedSnapshotListResponse!
        internal void InitQueryMssqlDatabaseMissedSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetMissedMssqlDbSnapshotsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMssqlDatabaseMissedSnapshots",
                "($input: GetMissedMssqlDbSnapshotsInput!)",
                "MissedSnapshotListResponse",
                Query.MssqlDatabaseMissedSnapshots_ObjectFieldSpec,
                Query.MssqlDatabaseMissedSnapshotsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	afterTime = <DateTime>
	# OPTIONAL
	beforeTime = <DateTime>
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // mssqlCompatibleInstances(input: GetCompatibleMssqlInstancesV1Input!): MssqlInstanceSummaryListResponse!
        internal void InitQueryMssqlCompatibleInstances()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetCompatibleMssqlInstancesV1Input!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMssqlCompatibleInstances",
                "($input: GetCompatibleMssqlInstancesV1Input!)",
                "MssqlInstanceSummaryListResponse",
                Query.MssqlCompatibleInstances_ObjectFieldSpec,
                Query.MssqlCompatibleInstancesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	recoveryTime = <DateTime>
	# REQUIRED
	recoveryType = <V1GetCompatibleMssqlInstancesV1RequestRecoveryType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1GetCompatibleMssqlInstancesV1RequestRecoveryType]) for enum values.
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // mssqlDatabaseMissedRecoverableRanges(input: GetMssqlDbMissedRecoverableRangesInput!): MssqlMissedRecoverableRangeListResponse!
        internal void InitQueryMssqlDatabaseMissedRecoverableRanges()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetMssqlDbMissedRecoverableRangesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMssqlDatabaseMissedRecoverableRanges",
                "($input: GetMssqlDbMissedRecoverableRangesInput!)",
                "MssqlMissedRecoverableRangeListResponse",
                Query.MssqlDatabaseMissedRecoverableRanges_ObjectFieldSpec,
                Query.MssqlDatabaseMissedRecoverableRangesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	afterTime = <DateTime>
	# OPTIONAL
	beforeTime = <DateTime>
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // allMssqlDatabaseRestoreFiles(input: MssqlGetRestoreFilesV1Input!): V1MssqlGetRestoreFilesV1Response!
        internal void InitQueryAllMssqlDatabaseRestoreFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MssqlGetRestoreFilesV1Input!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllMssqlDatabaseRestoreFiles",
                "($input: MssqlGetRestoreFilesV1Input!)",
                "V1MssqlGetRestoreFilesV1Response",
                Query.AllMssqlDatabaseRestoreFiles_ObjectFieldSpec,
                Query.AllMssqlDatabaseRestoreFilesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	lsn = <System.String>
	# OPTIONAL
	recoveryForkGuid = <System.String>
	# OPTIONAL
	time = <DateTime>
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // mssqlDatabaseLiveMounts(
        //     first: Int
        //     after: String
        //     sortBy: MssqlDatabaseLiveMountSortByInput
        //     filters: [MssqlDatabaseLiveMountFilterInput!]
        //   ): MssqlDatabaseLiveMountConnection!
        internal void InitQueryMssqlDatabaseLiveMounts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "MssqlDatabaseLiveMountSortByInput"),
                Tuple.Create("filters", "[MssqlDatabaseLiveMountFilterInput!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMssqlDatabaseLiveMounts",
                "($first: Int,$after: String,$sortBy: MssqlDatabaseLiveMountSortByInput,$filters: [MssqlDatabaseLiveMountFilterInput!])",
                "MssqlDatabaseLiveMountConnection",
                Query.MssqlDatabaseLiveMounts_ObjectFieldSpec,
                Query.MssqlDatabaseLiveMountsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = @{
	# OPTIONAL
	field = <MssqlDatabaseLiveMountSortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlDatabaseLiveMountSortByField]) for enum values.
	# OPTIONAL
	sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}
# OPTIONAL
$inputs.Var.filters = @(
	@{
		# OPTIONAL
		field = <MssqlDatabaseLiveMountFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlDatabaseLiveMountFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
}
)"
            );
        }

        // Create new GraphQL Query:
        // mssqlDefaultProperties(input: GetDefaultDbPropertiesV1Input!): UpdateMssqlDefaultPropertiesReply!
        internal void InitQueryMssqlDefaultProperties()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetDefaultDbPropertiesV1Input!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMssqlDefaultProperties",
                "($input: GetDefaultDbPropertiesV1Input!)",
                "UpdateMssqlDefaultPropertiesReply",
                Query.MssqlDefaultProperties_ObjectFieldSpec,
                Query.MssqlDefaultPropertiesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // mssqlDatabaseRestoreEstimate(input: MssqlRestoreEstimateV1Input!): MssqlRestoreEstimateResult!
        internal void InitQueryMssqlDatabaseRestoreEstimate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MssqlRestoreEstimateV1Input!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMssqlDatabaseRestoreEstimate",
                "($input: MssqlRestoreEstimateV1Input!)",
                "MssqlRestoreEstimateResult",
                Query.MssqlDatabaseRestoreEstimate_ObjectFieldSpec,
                Query.MssqlDatabaseRestoreEstimateFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	lsn = <System.String>
	# OPTIONAL
	recoveryForkGuid = <System.String>
	# OPTIONAL
	time = <DateTime>
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // cdmMssqlLogShippingTargets(
        //     first: Int
        //     after: String
        //     sortBy: MssqlLogShippingTargetSortByInput
        //     filters: [MssqlLogShippingTargetFilterInput!]
        //   ): MssqlLogShippingTargetConnection!
        internal void InitQueryCdmMssqlLogShippingTargets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "MssqlLogShippingTargetSortByInput"),
                Tuple.Create("filters", "[MssqlLogShippingTargetFilterInput!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCdmMssqlLogShippingTargets",
                "($first: Int,$after: String,$sortBy: MssqlLogShippingTargetSortByInput,$filters: [MssqlLogShippingTargetFilterInput!])",
                "MssqlLogShippingTargetConnection",
                Query.CdmMssqlLogShippingTargets_ObjectFieldSpec,
                Query.CdmMssqlLogShippingTargetsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = @{
	# OPTIONAL
	field = <MssqlLogShippingTargetSortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlLogShippingTargetSortByField]) for enum values.
	# OPTIONAL
	sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}
# OPTIONAL
$inputs.Var.filters = @(
	@{
		# OPTIONAL
		field = <MssqlLogShippingTargetFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlLogShippingTargetFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
}
)"
            );
        }

        // Create new GraphQL Query:
        // cdmMssqlLogShippingTarget(fid: UUID!): MssqlLogShippingTarget
        internal void InitQueryCdmMssqlLogShippingTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCdmMssqlLogShippingTarget",
                "($fid: UUID!)",
                "MssqlLogShippingTarget",
                Query.CdmMssqlLogShippingTarget_ObjectFieldSpec,
                Query.CdmMssqlLogShippingTargetFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // mssqlLogShippingTargets(input: QueryLogShippingConfigurationsV2Input!): MssqlLogShippingSummaryV2ListResponse
        internal void InitQueryMssqlLogShippingTargets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "QueryLogShippingConfigurationsV2Input!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMssqlLogShippingTargets",
                "($input: QueryLogShippingConfigurationsV2Input!)",
                "MssqlLogShippingSummaryV2ListResponse",
                Query.MssqlLogShippingTargets_ObjectFieldSpec,
                Query.MssqlLogShippingTargetsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	limit = <System.Int32>
	# OPTIONAL
	location = <System.String>
	# OPTIONAL
	offset = <System.Int32>
	# OPTIONAL
	primaryDatabaseId = <System.String>
	# OPTIONAL
	primaryDatabaseName = <System.String>
	# OPTIONAL
	secondaryDatabaseName = <System.String>
	# OPTIONAL
	sortBy = <V2QueryLogShippingConfigurationsV2RequestSortBy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V2QueryLogShippingConfigurationsV2RequestSortBy]) for enum values.
	# OPTIONAL
	sortOrder = <V2QueryLogShippingConfigurationsV2RequestSortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V2QueryLogShippingConfigurationsV2RequestSortOrder]) for enum values.
	# OPTIONAL
	status = <V2QueryLogShippingConfigurationsV2RequestStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V2QueryLogShippingConfigurationsV2RequestStatus]) for enum values.
	# REQUIRED
	clusterUuid = <System.String>
}"
            );
        }


    } // class New_RscQueryMssql
}