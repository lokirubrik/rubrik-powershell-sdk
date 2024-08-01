// UnifiedFeatureFlag.cs
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
    #region UnifiedFeatureFlag
    public class UnifiedFeatureFlag: BaseType
    {
        #region members

        //      C# -> FlagDataType? DataType
        // GraphQL -> dataType: FlagDataType! (enum)
        [JsonProperty("dataType")]
        public FlagDataType? DataType { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Variant
        // GraphQL -> variant: String! (scalar)
        [JsonProperty("variant")]
        public System.String? Variant { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UnifiedFeatureFlag";
    }

    public UnifiedFeatureFlag Set(
        FlagDataType? DataType = null,
        System.String? Name = null,
        System.String? Variant = null
    ) 
    {
        if ( DataType != null ) {
            this.DataType = DataType;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Variant != null ) {
            this.Variant = Variant;
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
        //      C# -> FlagDataType? DataType
        // GraphQL -> dataType: FlagDataType! (enum)
        if (this.DataType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataType\n" ;
            } else {
                s += ind + "dataType\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? Variant
        // GraphQL -> variant: String! (scalar)
        if (this.Variant != null) {
            if (conf.Flat) {
                s += conf.Prefix + "variant\n" ;
            } else {
                s += ind + "variant\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> FlagDataType? DataType
        // GraphQL -> dataType: FlagDataType! (enum)
        if (ec.Includes("dataType",true))
        {
            if(this.DataType == null) {

                this.DataType = new FlagDataType();

            } else {


            }
        }
        else if (this.DataType != null && ec.Excludes("dataType",true))
        {
            this.DataType = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? Variant
        // GraphQL -> variant: String! (scalar)
        if (ec.Includes("variant",true))
        {
            if(this.Variant == null) {

                this.Variant = "FETCH";

            } else {


            }
        }
        else if (this.Variant != null && ec.Excludes("variant",true))
        {
            this.Variant = null;
        }
    }


    #endregion

    } // class UnifiedFeatureFlag
    
    #endregion

    public static class ListUnifiedFeatureFlagExtensions
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
            this List<UnifiedFeatureFlag> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UnifiedFeatureFlag> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UnifiedFeatureFlag> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UnifiedFeatureFlag());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UnifiedFeatureFlag> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types