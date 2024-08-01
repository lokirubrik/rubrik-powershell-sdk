// RecoveryModeType.cs
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
    public enum RecoveryModeType
    {
        [EnumMember(Value = "AD_HOC")]
        AD_HOC,

        [EnumMember(Value = "RECOVERY_MODE_UNKNOWN")]
        RECOVERY_MODE_UNKNOWN,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum RecoveryModeType

} // namespace RubrikSecurityCloud.Types