// StartBulkRecoveryV2Reply.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region StartBulkRecoveryV2Reply
    public class StartBulkRecoveryV2Reply: BaseType
    {
        #region members

        //      C# -> System.String? BulkRecoveryInstanceId
        // GraphQL -> bulkRecoveryInstanceId: UUID (scalar)
        [JsonProperty("bulkRecoveryInstanceId")]
        public System.String? BulkRecoveryInstanceId { get; set; }

        //      C# -> System.String? Error
        // GraphQL -> error: String (scalar)
        [JsonProperty("error")]
        public System.String? Error { get; set; }

        //      C# -> System.Int64? JobId
        // GraphQL -> jobId: Long (scalar)
        [JsonProperty("jobId")]
        public System.Int64? JobId { get; set; }

        //      C# -> System.String? RecoveryName
        // GraphQL -> recoveryName: String (scalar)
        [JsonProperty("recoveryName")]
        public System.String? RecoveryName { get; set; }

        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: UUID (scalar)
        [JsonProperty("taskchainId")]
        public System.String? TaskchainId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "StartBulkRecoveryV2Reply";
    }

    public StartBulkRecoveryV2Reply Set(
        System.String? BulkRecoveryInstanceId = null,
        System.String? Error = null,
        System.Int64? JobId = null,
        System.String? RecoveryName = null,
        System.String? TaskchainId = null
    ) 
    {
        if ( BulkRecoveryInstanceId != null ) {
            this.BulkRecoveryInstanceId = BulkRecoveryInstanceId;
        }
        if ( Error != null ) {
            this.Error = Error;
        }
        if ( JobId != null ) {
            this.JobId = JobId;
        }
        if ( RecoveryName != null ) {
            this.RecoveryName = RecoveryName;
        }
        if ( TaskchainId != null ) {
            this.TaskchainId = TaskchainId;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? BulkRecoveryInstanceId
        // GraphQL -> bulkRecoveryInstanceId: UUID (scalar)
        if (this.BulkRecoveryInstanceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bulkRecoveryInstanceId\n" ;
            } else {
                s += ind + "bulkRecoveryInstanceId\n" ;
            }
        }
        //      C# -> System.String? Error
        // GraphQL -> error: String (scalar)
        if (this.Error != null) {
            if (conf.Flat) {
                s += conf.Prefix + "error\n" ;
            } else {
                s += ind + "error\n" ;
            }
        }
        //      C# -> System.Int64? JobId
        // GraphQL -> jobId: Long (scalar)
        if (this.JobId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "jobId\n" ;
            } else {
                s += ind + "jobId\n" ;
            }
        }
        //      C# -> System.String? RecoveryName
        // GraphQL -> recoveryName: String (scalar)
        if (this.RecoveryName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryName\n" ;
            } else {
                s += ind + "recoveryName\n" ;
            }
        }
        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: UUID (scalar)
        if (this.TaskchainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "taskchainId\n" ;
            } else {
                s += ind + "taskchainId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? BulkRecoveryInstanceId
        // GraphQL -> bulkRecoveryInstanceId: UUID (scalar)
        if (ec.Includes("bulkRecoveryInstanceId",true))
        {
            if(this.BulkRecoveryInstanceId == null) {

                this.BulkRecoveryInstanceId = "FETCH";

            } else {


            }
        }
        else if (this.BulkRecoveryInstanceId != null && ec.Excludes("bulkRecoveryInstanceId",true))
        {
            this.BulkRecoveryInstanceId = null;
        }
        //      C# -> System.String? Error
        // GraphQL -> error: String (scalar)
        if (ec.Includes("error",true))
        {
            if(this.Error == null) {

                this.Error = "FETCH";

            } else {


            }
        }
        else if (this.Error != null && ec.Excludes("error",true))
        {
            this.Error = null;
        }
        //      C# -> System.Int64? JobId
        // GraphQL -> jobId: Long (scalar)
        if (ec.Includes("jobId",true))
        {
            if(this.JobId == null) {

                this.JobId = new System.Int64();

            } else {


            }
        }
        else if (this.JobId != null && ec.Excludes("jobId",true))
        {
            this.JobId = null;
        }
        //      C# -> System.String? RecoveryName
        // GraphQL -> recoveryName: String (scalar)
        if (ec.Includes("recoveryName",true))
        {
            if(this.RecoveryName == null) {

                this.RecoveryName = "FETCH";

            } else {


            }
        }
        else if (this.RecoveryName != null && ec.Excludes("recoveryName",true))
        {
            this.RecoveryName = null;
        }
        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: UUID (scalar)
        if (ec.Includes("taskchainId",true))
        {
            if(this.TaskchainId == null) {

                this.TaskchainId = "FETCH";

            } else {


            }
        }
        else if (this.TaskchainId != null && ec.Excludes("taskchainId",true))
        {
            this.TaskchainId = null;
        }
    }


    #endregion

    } // class StartBulkRecoveryV2Reply
    
    #endregion

    public static class ListStartBulkRecoveryV2ReplyExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<StartBulkRecoveryV2Reply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<StartBulkRecoveryV2Reply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<StartBulkRecoveryV2Reply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new StartBulkRecoveryV2Reply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<StartBulkRecoveryV2Reply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types