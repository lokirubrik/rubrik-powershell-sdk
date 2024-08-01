// JiraIssueChangeDetailsSortByField.cs
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
    public enum JiraIssueChangeDetailsSortByField
    {
        [EnumMember(Value = "ADDED")]
        ADDED,

        [EnumMember(Value = "DELETED")]
        DELETED,

        [EnumMember(Value = "MODIFIED")]
        MODIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum JiraIssueChangeDetailsSortByField

} // namespace RubrikSecurityCloud.Types