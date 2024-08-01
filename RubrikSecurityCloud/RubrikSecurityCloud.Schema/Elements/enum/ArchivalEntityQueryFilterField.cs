// ArchivalEntityQueryFilterField.cs
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
    public enum ArchivalEntityQueryFilterField
    {
        [EnumMember(Value = "FILTER_FIELD_UNSPECIFIED")]
        FILTER_FIELD_UNSPECIFIED,

        [EnumMember(Value = "LOCATION_REDUNDANCY")]
        LOCATION_REDUNDANCY,

        [EnumMember(Value = "LOCATION_TIER")]
        LOCATION_TIER,

        [EnumMember(Value = "LOCATION_TYPE")]
        LOCATION_TYPE,

        [EnumMember(Value = "NAME")]
        NAME,

        [EnumMember(Value = "REGION")]
        REGION,

        [EnumMember(Value = "STATUS")]
        STATUS,

        [EnumMember(Value = "USE_CASE_TYPE")]
        USE_CASE_TYPE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ArchivalEntityQueryFilterField

} // namespace RubrikSecurityCloud.Types