// PrincipalRiskySummaryPrincipalType.cs
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
    public enum PrincipalRiskySummaryPrincipalType
    {
        [EnumMember(Value = "ASSUMABLE_IDENTITY")]
        ASSUMABLE_IDENTITY,

        [EnumMember(Value = "EXTERNAL_ACCOUNT")]
        EXTERNAL_ACCOUNT,

        [EnumMember(Value = "GROUP")]
        GROUP,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "USER")]
        USER


    } // enum PrincipalRiskySummaryPrincipalType

} // namespace RubrikSecurityCloud.Types