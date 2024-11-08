// AmiType.cs
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
    public enum AmiType
    {
        [EnumMember(Value = "CREATED_AT_RUNTIME")]
        CREATED_AT_RUNTIME,

        [EnumMember(Value = "EXISTING")]
        EXISTING,

        [EnumMember(Value = "USER_SPECIFIED")]
        USER_SPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum AmiType

} // namespace RubrikSecurityCloud.Types