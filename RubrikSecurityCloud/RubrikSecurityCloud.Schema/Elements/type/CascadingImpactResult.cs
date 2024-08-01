// CascadingImpactResult.cs
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
    #region CascadingImpactResult
    public class CascadingImpactResult: BaseType
    {
        #region members

        //      C# -> System.String? OperationId
        // GraphQL -> operationId: String (scalar)
        [JsonProperty("operationId")]
        public System.String? OperationId { get; set; }

        //      C# -> List<AppItemWithCascadingImpact>? Result
        // GraphQL -> result: [AppItemWithCascadingImpact!]! (type)
        [JsonProperty("result")]
        public List<AppItemWithCascadingImpact>? Result { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CascadingImpactResult";
    }

    public CascadingImpactResult Set(
        System.String? OperationId = null,
        List<AppItemWithCascadingImpact>? Result = null
    ) 
    {
        if ( OperationId != null ) {
            this.OperationId = OperationId;
        }
        if ( Result != null ) {
            this.Result = Result;
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
        //      C# -> System.String? OperationId
        // GraphQL -> operationId: String (scalar)
        if (this.OperationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "operationId\n" ;
            } else {
                s += ind + "operationId\n" ;
            }
        }
        //      C# -> List<AppItemWithCascadingImpact>? Result
        // GraphQL -> result: [AppItemWithCascadingImpact!]! (type)
        if (this.Result != null) {
            var fspec = this.Result.AsFieldSpec(conf.Child("result"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "result" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? OperationId
        // GraphQL -> operationId: String (scalar)
        if (ec.Includes("operationId",true))
        {
            if(this.OperationId == null) {

                this.OperationId = "FETCH";

            } else {


            }
        }
        else if (this.OperationId != null && ec.Excludes("operationId",true))
        {
            this.OperationId = null;
        }
        //      C# -> List<AppItemWithCascadingImpact>? Result
        // GraphQL -> result: [AppItemWithCascadingImpact!]! (type)
        if (ec.Includes("result",false))
        {
            if(this.Result == null) {

                this.Result = new List<AppItemWithCascadingImpact>();
                this.Result.ApplyExploratoryFieldSpec(ec.NewChild("result"));

            } else {

                this.Result.ApplyExploratoryFieldSpec(ec.NewChild("result"));

            }
        }
        else if (this.Result != null && ec.Excludes("result",false))
        {
            this.Result = null;
        }
    }


    #endregion

    } // class CascadingImpactResult
    
    #endregion

    public static class ListCascadingImpactResultExtensions
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
            this List<CascadingImpactResult> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CascadingImpactResult> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CascadingImpactResult> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CascadingImpactResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CascadingImpactResult> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types