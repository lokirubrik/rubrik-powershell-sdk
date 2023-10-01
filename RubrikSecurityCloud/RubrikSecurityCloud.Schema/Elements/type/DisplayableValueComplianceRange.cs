// DisplayableValueComplianceRange.cs
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
    #region DisplayableValueComplianceRange
 
    public class DisplayableValueComplianceRange: BaseType, DisplayableValue
    {
        #region members

        //      C# -> ComplianceDuration? Value
        // GraphQL -> value: ComplianceDuration (enum)
        [JsonProperty("value")]
        public ComplianceDuration? Value { get; set; }

        //      C# -> System.String? DisplayValue
        // GraphQL -> displayValue: String! (scalar)
        [JsonProperty("displayValue")]
        public System.String? DisplayValue { get; set; }

        //      C# -> System.String? ReportHeader
        // GraphQL -> reportHeader: String! (scalar)
        [JsonProperty("reportHeader")]
        public System.String? ReportHeader { get; set; }

        //      C# -> System.String? SerializedValue
        // GraphQL -> serializedValue: String! (scalar)
        [JsonProperty("serializedValue")]
        public System.String? SerializedValue { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DisplayableValueComplianceRange";
    }

    public DisplayableValueComplianceRange Set(
        ComplianceDuration? Value = null,
        System.String? DisplayValue = null,
        System.String? ReportHeader = null,
        System.String? SerializedValue = null
    ) 
    {
        if ( Value != null ) {
            this.Value = Value;
        }
        if ( DisplayValue != null ) {
            this.DisplayValue = DisplayValue;
        }
        if ( ReportHeader != null ) {
            this.ReportHeader = ReportHeader;
        }
        if ( SerializedValue != null ) {
            this.SerializedValue = SerializedValue;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> ComplianceDuration? Value
        // GraphQL -> value: ComplianceDuration (enum)
        if (this.Value != null) {
            if (conf.Flat) {
                s += conf.Prefix + "value\n" ;
            } else {
                s += ind + "value\n" ;
            }
        }
        //      C# -> System.String? DisplayValue
        // GraphQL -> displayValue: String! (scalar)
        if (this.DisplayValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "displayValue\n" ;
            } else {
                s += ind + "displayValue\n" ;
            }
        }
        //      C# -> System.String? ReportHeader
        // GraphQL -> reportHeader: String! (scalar)
        if (this.ReportHeader != null) {
            if (conf.Flat) {
                s += conf.Prefix + "reportHeader\n" ;
            } else {
                s += ind + "reportHeader\n" ;
            }
        }
        //      C# -> System.String? SerializedValue
        // GraphQL -> serializedValue: String! (scalar)
        if (this.SerializedValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "serializedValue\n" ;
            } else {
                s += ind + "serializedValue\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ComplianceDuration? Value
        // GraphQL -> value: ComplianceDuration (enum)
        if (ec.Includes("value",true))
        {
            if(this.Value == null) {

                this.Value = new ComplianceDuration();

            } else {


            }
        }
        else if (this.Value != null && ec.Excludes("value",true))
        {
            this.Value = null;
        }
        //      C# -> System.String? DisplayValue
        // GraphQL -> displayValue: String! (scalar)
        if (ec.Includes("displayValue",true))
        {
            if(this.DisplayValue == null) {

                this.DisplayValue = "FETCH";

            } else {


            }
        }
        else if (this.DisplayValue != null && ec.Excludes("displayValue",true))
        {
            this.DisplayValue = null;
        }
        //      C# -> System.String? ReportHeader
        // GraphQL -> reportHeader: String! (scalar)
        if (ec.Includes("reportHeader",true))
        {
            if(this.ReportHeader == null) {

                this.ReportHeader = "FETCH";

            } else {


            }
        }
        else if (this.ReportHeader != null && ec.Excludes("reportHeader",true))
        {
            this.ReportHeader = null;
        }
        //      C# -> System.String? SerializedValue
        // GraphQL -> serializedValue: String! (scalar)
        if (ec.Includes("serializedValue",true))
        {
            if(this.SerializedValue == null) {

                this.SerializedValue = "FETCH";

            } else {


            }
        }
        else if (this.SerializedValue != null && ec.Excludes("serializedValue",true))
        {
            this.SerializedValue = null;
        }
    }


    #endregion

    } // class DisplayableValueComplianceRange
    
    #endregion

    public static class ListDisplayableValueComplianceRangeExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<DisplayableValueComplianceRange> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<DisplayableValueComplianceRange> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DisplayableValueComplianceRange> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DisplayableValueComplianceRange());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DisplayableValueComplianceRange> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types