// BundleImage.cs
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
    #region BundleImage
    public class BundleImage: BaseType
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Sha
        // GraphQL -> sha: String! (scalar)
        [JsonProperty("sha")]
        public System.String? Sha { get; set; }

        //      C# -> System.String? Tag
        // GraphQL -> tag: String! (scalar)
        [JsonProperty("tag")]
        public System.String? Tag { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BundleImage";
    }

    public BundleImage Set(
        System.String? Name = null,
        System.String? Sha = null,
        System.String? Tag = null
    ) 
    {
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Sha != null ) {
            this.Sha = Sha;
        }
        if ( Tag != null ) {
            this.Tag = Tag;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? Sha
        // GraphQL -> sha: String! (scalar)
        if (this.Sha != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sha\n" ;
            } else {
                s += ind + "sha\n" ;
            }
        }
        //      C# -> System.String? Tag
        // GraphQL -> tag: String! (scalar)
        if (this.Tag != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tag\n" ;
            } else {
                s += ind + "tag\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
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
        //      C# -> System.String? Sha
        // GraphQL -> sha: String! (scalar)
        if (ec.Includes("sha",true))
        {
            if(this.Sha == null) {

                this.Sha = "FETCH";

            } else {


            }
        }
        else if (this.Sha != null && ec.Excludes("sha",true))
        {
            this.Sha = null;
        }
        //      C# -> System.String? Tag
        // GraphQL -> tag: String! (scalar)
        if (ec.Includes("tag",true))
        {
            if(this.Tag == null) {

                this.Tag = "FETCH";

            } else {


            }
        }
        else if (this.Tag != null && ec.Excludes("tag",true))
        {
            this.Tag = null;
        }
    }


    #endregion

    } // class BundleImage
    
    #endregion

    public static class ListBundleImageExtensions
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
            this List<BundleImage> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<BundleImage> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BundleImage> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BundleImage());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BundleImage> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types