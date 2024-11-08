// RetentionUnit.cs
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
    public enum RetentionUnit
    {
        [EnumMember(Value = "DAYS")]
        DAYS,

        [EnumMember(Value = "HOURS")]
        HOURS,

        [EnumMember(Value = "MINUTES")]
        MINUTES,

        [EnumMember(Value = "MONTHS")]
        MONTHS,

        [EnumMember(Value = "QUARTERS")]
        QUARTERS,

        [EnumMember(Value = "WEEKS")]
        WEEKS,

        [EnumMember(Value = "YEARS")]
        YEARS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum RetentionUnit

} // namespace RubrikSecurityCloud.Types