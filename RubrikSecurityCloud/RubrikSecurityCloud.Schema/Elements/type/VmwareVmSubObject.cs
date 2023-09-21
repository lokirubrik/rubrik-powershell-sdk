// VmwareVmSubObject.cs
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
    #region VmwareVmSubObject
    public class VmwareVmSubObject: BaseType
    {
        #region members

        //      C# -> System.String? CurrentDatastoreId
        // GraphQL -> currentDatastoreId: UUID (scalar)
        [JsonProperty("currentDatastoreId")]
        public System.String? CurrentDatastoreId { get; set; }

        //      C# -> System.Int32? DeviceKey
        // GraphQL -> deviceKey: Int! (scalar)
        [JsonProperty("deviceKey")]
        public System.Int32? DeviceKey { get; set; }

        //      C# -> System.Int64? FileSizeInBytes
        // GraphQL -> fileSizeInBytes: Long! (scalar)
        [JsonProperty("fileSizeInBytes")]
        public System.Int64? FileSizeInBytes { get; set; }

        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        [JsonProperty("filename")]
        public System.String? Filename { get; set; }

        //      C# -> System.String? VirtualDiskId
        // GraphQL -> virtualDiskId: UUID (scalar)
        [JsonProperty("virtualDiskId")]
        public System.String? VirtualDiskId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VmwareVmSubObject";
    }

    public VmwareVmSubObject Set(
        System.String? CurrentDatastoreId = null,
        System.Int32? DeviceKey = null,
        System.Int64? FileSizeInBytes = null,
        System.String? Filename = null,
        System.String? VirtualDiskId = null
    ) 
    {
        if ( CurrentDatastoreId != null ) {
            this.CurrentDatastoreId = CurrentDatastoreId;
        }
        if ( DeviceKey != null ) {
            this.DeviceKey = DeviceKey;
        }
        if ( FileSizeInBytes != null ) {
            this.FileSizeInBytes = FileSizeInBytes;
        }
        if ( Filename != null ) {
            this.Filename = Filename;
        }
        if ( VirtualDiskId != null ) {
            this.VirtualDiskId = VirtualDiskId;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? CurrentDatastoreId
        // GraphQL -> currentDatastoreId: UUID (scalar)
        if (this.CurrentDatastoreId != null) {
            s += ind + "currentDatastoreId\n" ;
        }
        //      C# -> System.Int32? DeviceKey
        // GraphQL -> deviceKey: Int! (scalar)
        if (this.DeviceKey != null) {
            s += ind + "deviceKey\n" ;
        }
        //      C# -> System.Int64? FileSizeInBytes
        // GraphQL -> fileSizeInBytes: Long! (scalar)
        if (this.FileSizeInBytes != null) {
            s += ind + "fileSizeInBytes\n" ;
        }
        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        if (this.Filename != null) {
            s += ind + "filename\n" ;
        }
        //      C# -> System.String? VirtualDiskId
        // GraphQL -> virtualDiskId: UUID (scalar)
        if (this.VirtualDiskId != null) {
            s += ind + "virtualDiskId\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CurrentDatastoreId
        // GraphQL -> currentDatastoreId: UUID (scalar)
        if (this.CurrentDatastoreId == null && ec.Includes("currentDatastoreId",true))
        {
            this.CurrentDatastoreId = "FETCH";
        }
        //      C# -> System.Int32? DeviceKey
        // GraphQL -> deviceKey: Int! (scalar)
        if (this.DeviceKey == null && ec.Includes("deviceKey",true))
        {
            this.DeviceKey = Int32.MinValue;
        }
        //      C# -> System.Int64? FileSizeInBytes
        // GraphQL -> fileSizeInBytes: Long! (scalar)
        if (this.FileSizeInBytes == null && ec.Includes("fileSizeInBytes",true))
        {
            this.FileSizeInBytes = new System.Int64();
        }
        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        if (this.Filename == null && ec.Includes("filename",true))
        {
            this.Filename = "FETCH";
        }
        //      C# -> System.String? VirtualDiskId
        // GraphQL -> virtualDiskId: UUID (scalar)
        if (this.VirtualDiskId == null && ec.Includes("virtualDiskId",true))
        {
            this.VirtualDiskId = "FETCH";
        }
    }


    #endregion

    } // class VmwareVmSubObject
    
    #endregion

    public static class ListVmwareVmSubObjectExtensions
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
            this List<VmwareVmSubObject> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VmwareVmSubObject> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VmwareVmSubObject());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VmwareVmSubObject> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types