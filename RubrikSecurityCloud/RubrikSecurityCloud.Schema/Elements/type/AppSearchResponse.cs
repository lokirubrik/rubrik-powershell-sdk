// AppSearchResponse.cs
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
    #region AppSearchResponse
    public class AppSearchResponse: BaseType
    {
        #region members

        //      C# -> System.String? ChildObjectId
        // GraphQL -> childObjectId: String! (scalar)
        [JsonProperty("childObjectId")]
        public System.String? ChildObjectId { get; set; }

        //      C# -> System.String? ChildObjectName
        // GraphQL -> childObjectName: String! (scalar)
        [JsonProperty("childObjectName")]
        public System.String? ChildObjectName { get; set; }

        //      C# -> SearchResultResponse? SearchResponse
        // GraphQL -> searchResponse: SearchResultResponse (type)
        [JsonProperty("searchResponse")]
        public SearchResultResponse? SearchResponse { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AppSearchResponse";
    }

    public AppSearchResponse Set(
        System.String? ChildObjectId = null,
        System.String? ChildObjectName = null,
        SearchResultResponse? SearchResponse = null
    ) 
    {
        if ( ChildObjectId != null ) {
            this.ChildObjectId = ChildObjectId;
        }
        if ( ChildObjectName != null ) {
            this.ChildObjectName = ChildObjectName;
        }
        if ( SearchResponse != null ) {
            this.SearchResponse = SearchResponse;
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
        //      C# -> System.String? ChildObjectId
        // GraphQL -> childObjectId: String! (scalar)
        if (this.ChildObjectId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "childObjectId\n" ;
            } else {
                s += ind + "childObjectId\n" ;
            }
        }
        //      C# -> System.String? ChildObjectName
        // GraphQL -> childObjectName: String! (scalar)
        if (this.ChildObjectName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "childObjectName\n" ;
            } else {
                s += ind + "childObjectName\n" ;
            }
        }
        //      C# -> SearchResultResponse? SearchResponse
        // GraphQL -> searchResponse: SearchResultResponse (type)
        if (this.SearchResponse != null) {
            var fspec = this.SearchResponse.AsFieldSpec(conf.Child("searchResponse"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "searchResponse" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ChildObjectId
        // GraphQL -> childObjectId: String! (scalar)
        if (ec.Includes("childObjectId",true))
        {
            if(this.ChildObjectId == null) {

                this.ChildObjectId = "FETCH";

            } else {


            }
        }
        else if (this.ChildObjectId != null && ec.Excludes("childObjectId",true))
        {
            this.ChildObjectId = null;
        }
        //      C# -> System.String? ChildObjectName
        // GraphQL -> childObjectName: String! (scalar)
        if (ec.Includes("childObjectName",true))
        {
            if(this.ChildObjectName == null) {

                this.ChildObjectName = "FETCH";

            } else {


            }
        }
        else if (this.ChildObjectName != null && ec.Excludes("childObjectName",true))
        {
            this.ChildObjectName = null;
        }
        //      C# -> SearchResultResponse? SearchResponse
        // GraphQL -> searchResponse: SearchResultResponse (type)
        if (ec.Includes("searchResponse",false))
        {
            if(this.SearchResponse == null) {

                this.SearchResponse = new SearchResultResponse();
                this.SearchResponse.ApplyExploratoryFieldSpec(ec.NewChild("searchResponse"));

            } else {

                this.SearchResponse.ApplyExploratoryFieldSpec(ec.NewChild("searchResponse"));

            }
        }
        else if (this.SearchResponse != null && ec.Excludes("searchResponse",false))
        {
            this.SearchResponse = null;
        }
    }


    #endregion

    } // class AppSearchResponse
    
    #endregion

    public static class ListAppSearchResponseExtensions
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
            this List<AppSearchResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AppSearchResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AppSearchResponse> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AppSearchResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AppSearchResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types