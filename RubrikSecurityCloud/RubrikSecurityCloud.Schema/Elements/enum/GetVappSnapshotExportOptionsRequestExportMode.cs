// GetVappSnapshotExportOptionsRequestExportMode.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace RubrikSecurityCloud.Types
{
    public enum GetVappSnapshotExportOptionsRequestExportMode
    {
        [EnumMember(Value = "V1_GET_VAPP_SNAPSHOT_EXPORT_OPTIONS_V1_REQUEST_EXPORT_MODE_EXPORT_TO_NEW_VAPP")]
        V1_GET_VAPP_SNAPSHOT_EXPORT_OPTIONS_V1_REQUEST_EXPORT_MODE_EXPORT_TO_NEW_VAPP,

        [EnumMember(Value = "V1_GET_VAPP_SNAPSHOT_EXPORT_OPTIONS_V1_REQUEST_EXPORT_MODE_EXPORT_TO_TARGET_VAPP")]
        V1_GET_VAPP_SNAPSHOT_EXPORT_OPTIONS_V1_REQUEST_EXPORT_MODE_EXPORT_TO_TARGET_VAPP,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum GetVappSnapshotExportOptionsRequestExportMode

} // namespace RubrikSecurityCloud.Types