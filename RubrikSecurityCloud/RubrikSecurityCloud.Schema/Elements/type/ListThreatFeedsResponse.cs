// ListThreatFeedsResponse.cs
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
    #region ListThreatFeedsResponse
    public class ListThreatFeedsResponse: BaseType
    {
        #region members

        //      C# -> List<FeedInfo>? Feeds
        // GraphQL -> feeds: [FeedInfo!]! (type)
        [JsonProperty("feeds")]
        public List<FeedInfo>? Feeds { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ListThreatFeedsResponse";
    }

    public ListThreatFeedsResponse Set(
        List<FeedInfo>? Feeds = null
    ) 
    {
        if ( Feeds != null ) {
            this.Feeds = Feeds;
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
        //      C# -> List<FeedInfo>? Feeds
        // GraphQL -> feeds: [FeedInfo!]! (type)
        if (this.Feeds != null) {
            var fspec = this.Feeds.AsFieldSpec(conf.Child("feeds"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "feeds" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<FeedInfo>? Feeds
        // GraphQL -> feeds: [FeedInfo!]! (type)
        if (ec.Includes("feeds",false))
        {
            if(this.Feeds == null) {

                this.Feeds = new List<FeedInfo>();
                this.Feeds.ApplyExploratoryFieldSpec(ec.NewChild("feeds"));

            } else {

                this.Feeds.ApplyExploratoryFieldSpec(ec.NewChild("feeds"));

            }
        }
        else if (this.Feeds != null && ec.Excludes("feeds",false))
        {
            this.Feeds = null;
        }
    }


    #endregion

    } // class ListThreatFeedsResponse
    
    #endregion

    public static class ListListThreatFeedsResponseExtensions
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
            this List<ListThreatFeedsResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ListThreatFeedsResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ListThreatFeedsResponse> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ListThreatFeedsResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ListThreatFeedsResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types