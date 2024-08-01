// HelpCenterReference.cs
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
    #region HelpCenterReference
 
    public class HelpCenterReference: BaseType, LlmReference
    {
        #region members

        //      C# -> DocumentType? DocType
        // GraphQL -> docType: DocumentType! (enum)
        [JsonProperty("docType")]
        public DocumentType? DocType { get; set; }

        //      C# -> System.String? DocId
        // GraphQL -> docId: String! (scalar)
        [JsonProperty("docId")]
        public System.String? DocId { get; set; }

        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        [JsonProperty("title")]
        public System.String? Title { get; set; }

        //      C# -> System.String? Url
        // GraphQL -> url: String! (scalar)
        [JsonProperty("url")]
        public System.String? Url { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HelpCenterReference";
    }

    public HelpCenterReference Set(
        DocumentType? DocType = null,
        System.String? DocId = null,
        System.String? Title = null,
        System.String? Url = null
    ) 
    {
        if ( DocType != null ) {
            this.DocType = DocType;
        }
        if ( DocId != null ) {
            this.DocId = DocId;
        }
        if ( Title != null ) {
            this.Title = Title;
        }
        if ( Url != null ) {
            this.Url = Url;
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
        //      C# -> DocumentType? DocType
        // GraphQL -> docType: DocumentType! (enum)
        if (this.DocType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "docType\n" ;
            } else {
                s += ind + "docType\n" ;
            }
        }
        //      C# -> System.String? DocId
        // GraphQL -> docId: String! (scalar)
        if (this.DocId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "docId\n" ;
            } else {
                s += ind + "docId\n" ;
            }
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (this.Title != null) {
            if (conf.Flat) {
                s += conf.Prefix + "title\n" ;
            } else {
                s += ind + "title\n" ;
            }
        }
        //      C# -> System.String? Url
        // GraphQL -> url: String! (scalar)
        if (this.Url != null) {
            if (conf.Flat) {
                s += conf.Prefix + "url\n" ;
            } else {
                s += ind + "url\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DocumentType? DocType
        // GraphQL -> docType: DocumentType! (enum)
        if (ec.Includes("docType",true))
        {
            if(this.DocType == null) {

                this.DocType = new DocumentType();

            } else {


            }
        }
        else if (this.DocType != null && ec.Excludes("docType",true))
        {
            this.DocType = null;
        }
        //      C# -> System.String? DocId
        // GraphQL -> docId: String! (scalar)
        if (ec.Includes("docId",true))
        {
            if(this.DocId == null) {

                this.DocId = "FETCH";

            } else {


            }
        }
        else if (this.DocId != null && ec.Excludes("docId",true))
        {
            this.DocId = null;
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (ec.Includes("title",true))
        {
            if(this.Title == null) {

                this.Title = "FETCH";

            } else {


            }
        }
        else if (this.Title != null && ec.Excludes("title",true))
        {
            this.Title = null;
        }
        //      C# -> System.String? Url
        // GraphQL -> url: String! (scalar)
        if (ec.Includes("url",true))
        {
            if(this.Url == null) {

                this.Url = "FETCH";

            } else {


            }
        }
        else if (this.Url != null && ec.Excludes("url",true))
        {
            this.Url = null;
        }
    }


    #endregion

    } // class HelpCenterReference
    
    #endregion

    public static class ListHelpCenterReferenceExtensions
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
            this List<HelpCenterReference> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HelpCenterReference> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HelpCenterReference> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HelpCenterReference());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HelpCenterReference> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types