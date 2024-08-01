// RequiredPrivilege.cs
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
    #region RequiredPrivilege
    public class RequiredPrivilege: BaseType
    {
        #region members

        //      C# -> System.String? Label
        // GraphQL -> label: String! (scalar)
        [JsonProperty("label")]
        public System.String? Label { get; set; }

        //      C# -> System.String? PrivilegeId
        // GraphQL -> privilegeId: String! (scalar)
        [JsonProperty("privilegeId")]
        public System.String? PrivilegeId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RequiredPrivilege";
    }

    public RequiredPrivilege Set(
        System.String? Label = null,
        System.String? PrivilegeId = null
    ) 
    {
        if ( Label != null ) {
            this.Label = Label;
        }
        if ( PrivilegeId != null ) {
            this.PrivilegeId = PrivilegeId;
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
        //      C# -> System.String? Label
        // GraphQL -> label: String! (scalar)
        if (this.Label != null) {
            if (conf.Flat) {
                s += conf.Prefix + "label\n" ;
            } else {
                s += ind + "label\n" ;
            }
        }
        //      C# -> System.String? PrivilegeId
        // GraphQL -> privilegeId: String! (scalar)
        if (this.PrivilegeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "privilegeId\n" ;
            } else {
                s += ind + "privilegeId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Label
        // GraphQL -> label: String! (scalar)
        if (ec.Includes("label",true))
        {
            if(this.Label == null) {

                this.Label = "FETCH";

            } else {


            }
        }
        else if (this.Label != null && ec.Excludes("label",true))
        {
            this.Label = null;
        }
        //      C# -> System.String? PrivilegeId
        // GraphQL -> privilegeId: String! (scalar)
        if (ec.Includes("privilegeId",true))
        {
            if(this.PrivilegeId == null) {

                this.PrivilegeId = "FETCH";

            } else {


            }
        }
        else if (this.PrivilegeId != null && ec.Excludes("privilegeId",true))
        {
            this.PrivilegeId = null;
        }
    }


    #endregion

    } // class RequiredPrivilege
    
    #endregion

    public static class ListRequiredPrivilegeExtensions
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
            this List<RequiredPrivilege> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RequiredPrivilege> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RequiredPrivilege> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RequiredPrivilege());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RequiredPrivilege> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types