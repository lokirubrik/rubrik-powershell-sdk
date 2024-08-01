// SyslogSeverityTypeEnum.cs
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
    public enum SyslogSeverityTypeEnum
    {
        [EnumMember(Value = "ALL_SEVERITY")]
        ALL_SEVERITY,

        [EnumMember(Value = "CRITICAL")]
        CRITICAL,

        [EnumMember(Value = "INFORMATIONAL")]
        INFORMATIONAL,

        [EnumMember(Value = "WARNING")]
        WARNING,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum SyslogSeverityTypeEnum

} // namespace RubrikSecurityCloud.Types