// NodeTunnelStatusConnection.cs
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
    #region NodeTunnelStatusConnection
    public class NodeTunnelStatusConnection: BaseType
    {
        #region members

        //      C# -> System.Boolean? HasMore
        // GraphQL -> hasMore: Boolean (scalar)
        [JsonProperty("hasMore")]
        public System.Boolean? HasMore { get; set; }

        //      C# -> System.String? NextCursor
        // GraphQL -> nextCursor: String (scalar)
        [JsonProperty("nextCursor")]
        public System.String? NextCursor { get; set; }

        //      C# -> System.Int64? Total
        // GraphQL -> total: Long (scalar)
        [JsonProperty("total")]
        public System.Int64? Total { get; set; }

        //      C# -> List<NodeTunnelStatus>? Data
        // GraphQL -> data: [NodeTunnelStatus!]! (type)
        [JsonProperty("data")]
        public List<NodeTunnelStatus>? Data { get; set; }

        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NodeTunnelStatusConnection";
    }

    public NodeTunnelStatusConnection Set(
        System.Boolean? HasMore = null,
        System.String? NextCursor = null,
        System.Int64? Total = null,
        List<NodeTunnelStatus>? Data = null,
        PageInfo? PageInfo = null
    ) 
    {
        if ( HasMore != null ) {
            this.HasMore = HasMore;
        }
        if ( NextCursor != null ) {
            this.NextCursor = NextCursor;
        }
        if ( Total != null ) {
            this.Total = Total;
        }
        if ( Data != null ) {
            this.Data = Data;
        }
        if ( PageInfo != null ) {
            this.PageInfo = PageInfo;
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
        //      C# -> System.Boolean? HasMore
        // GraphQL -> hasMore: Boolean (scalar)
        if (this.HasMore != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasMore\n" ;
            } else {
                s += ind + "hasMore\n" ;
            }
        }
        //      C# -> System.String? NextCursor
        // GraphQL -> nextCursor: String (scalar)
        if (this.NextCursor != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nextCursor\n" ;
            } else {
                s += ind + "nextCursor\n" ;
            }
        }
        //      C# -> System.Int64? Total
        // GraphQL -> total: Long (scalar)
        if (this.Total != null) {
            if (conf.Flat) {
                s += conf.Prefix + "total\n" ;
            } else {
                s += ind + "total\n" ;
            }
        }
        //      C# -> List<NodeTunnelStatus>? Data
        // GraphQL -> data: [NodeTunnelStatus!]! (type)
        if (this.Data != null) {
            var fspec = this.Data.AsFieldSpec(conf.Child("data"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "data" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        if (this.PageInfo != null) {
            var fspec = this.PageInfo.AsFieldSpec(conf.Child("pageInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "pageInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? HasMore
        // GraphQL -> hasMore: Boolean (scalar)
        if (ec.Includes("hasMore",true))
        {
            if(this.HasMore == null) {

                this.HasMore = true;

            } else {


            }
        }
        else if (this.HasMore != null && ec.Excludes("hasMore",true))
        {
            this.HasMore = null;
        }
        //      C# -> System.String? NextCursor
        // GraphQL -> nextCursor: String (scalar)
        if (ec.Includes("nextCursor",true))
        {
            if(this.NextCursor == null) {

                this.NextCursor = "FETCH";

            } else {


            }
        }
        else if (this.NextCursor != null && ec.Excludes("nextCursor",true))
        {
            this.NextCursor = null;
        }
        //      C# -> System.Int64? Total
        // GraphQL -> total: Long (scalar)
        if (ec.Includes("total",true))
        {
            if(this.Total == null) {

                this.Total = new System.Int64();

            } else {


            }
        }
        else if (this.Total != null && ec.Excludes("total",true))
        {
            this.Total = null;
        }
        //      C# -> List<NodeTunnelStatus>? Data
        // GraphQL -> data: [NodeTunnelStatus!]! (type)
        if (ec.Includes("data",false))
        {
            if(this.Data == null) {

                this.Data = new List<NodeTunnelStatus>();
                this.Data.ApplyExploratoryFieldSpec(ec.NewChild("data"));

            } else {

                this.Data.ApplyExploratoryFieldSpec(ec.NewChild("data"));

            }
        }
        else if (this.Data != null && ec.Excludes("data",false))
        {
            this.Data = null;
        }
        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        if (ec.Includes("pageInfo",false))
        {
            if(this.PageInfo == null) {

                this.PageInfo = new PageInfo();
                this.PageInfo.ApplyExploratoryFieldSpec(ec.NewChild("pageInfo"));

            } else {

                this.PageInfo.ApplyExploratoryFieldSpec(ec.NewChild("pageInfo"));

            }
        }
        else if (this.PageInfo != null && ec.Excludes("pageInfo",false))
        {
            this.PageInfo = null;
        }
    }


    #endregion

    } // class NodeTunnelStatusConnection
    
    #endregion

    public static class ListNodeTunnelStatusConnectionExtensions
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
            this List<NodeTunnelStatusConnection> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NodeTunnelStatusConnection> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NodeTunnelStatusConnection> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NodeTunnelStatusConnection());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NodeTunnelStatusConnection> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types