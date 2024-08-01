// ArchivalLocationEncryptionHealth.cs
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
    #region ArchivalLocationEncryptionHealth
    public class ArchivalLocationEncryptionHealth: BaseType
    {
        #region members

        //      C# -> ArchivalLocationEncryptionHealthStatus? EncryptionHealthStatus
        // GraphQL -> encryptionHealthStatus: ArchivalLocationEncryptionHealthStatus! (enum)
        [JsonProperty("encryptionHealthStatus")]
        public ArchivalLocationEncryptionHealthStatus? EncryptionHealthStatus { get; set; }

        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String (scalar)
        [JsonProperty("errorMessage")]
        public System.String? ErrorMessage { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ArchivalLocationEncryptionHealth";
    }

    public ArchivalLocationEncryptionHealth Set(
        ArchivalLocationEncryptionHealthStatus? EncryptionHealthStatus = null,
        System.String? ErrorMessage = null
    ) 
    {
        if ( EncryptionHealthStatus != null ) {
            this.EncryptionHealthStatus = EncryptionHealthStatus;
        }
        if ( ErrorMessage != null ) {
            this.ErrorMessage = ErrorMessage;
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
        //      C# -> ArchivalLocationEncryptionHealthStatus? EncryptionHealthStatus
        // GraphQL -> encryptionHealthStatus: ArchivalLocationEncryptionHealthStatus! (enum)
        if (this.EncryptionHealthStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "encryptionHealthStatus\n" ;
            } else {
                s += ind + "encryptionHealthStatus\n" ;
            }
        }
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String (scalar)
        if (this.ErrorMessage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "errorMessage\n" ;
            } else {
                s += ind + "errorMessage\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ArchivalLocationEncryptionHealthStatus? EncryptionHealthStatus
        // GraphQL -> encryptionHealthStatus: ArchivalLocationEncryptionHealthStatus! (enum)
        if (ec.Includes("encryptionHealthStatus",true))
        {
            if(this.EncryptionHealthStatus == null) {

                this.EncryptionHealthStatus = new ArchivalLocationEncryptionHealthStatus();

            } else {


            }
        }
        else if (this.EncryptionHealthStatus != null && ec.Excludes("encryptionHealthStatus",true))
        {
            this.EncryptionHealthStatus = null;
        }
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String (scalar)
        if (ec.Includes("errorMessage",true))
        {
            if(this.ErrorMessage == null) {

                this.ErrorMessage = "FETCH";

            } else {


            }
        }
        else if (this.ErrorMessage != null && ec.Excludes("errorMessage",true))
        {
            this.ErrorMessage = null;
        }
    }


    #endregion

    } // class ArchivalLocationEncryptionHealth
    
    #endregion

    public static class ListArchivalLocationEncryptionHealthExtensions
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
            this List<ArchivalLocationEncryptionHealth> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ArchivalLocationEncryptionHealth> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ArchivalLocationEncryptionHealth> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ArchivalLocationEncryptionHealth());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ArchivalLocationEncryptionHealth> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types