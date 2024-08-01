// ChartViewType.cs
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
    public enum ChartViewType
    {
        [EnumMember(Value = "CHART_UNSPECIFIED")]
        CHART_UNSPECIFIED,

        [EnumMember(Value = "COMPLIANCE_STATUS_ALL_CHART")]
        COMPLIANCE_STATUS_ALL_CHART,

        [EnumMember(Value = "COMPLIANCE_STATUS_CLUSTER_CHART")]
        COMPLIANCE_STATUS_CLUSTER_CHART,

        [EnumMember(Value = "COMPLIANCE_STATUS_CLUSTER_TYPE_CHART")]
        COMPLIANCE_STATUS_CLUSTER_TYPE_CHART,

        [EnumMember(Value = "COMPLIANCE_STATUS_OBJECT_TYPE_CHART")]
        COMPLIANCE_STATUS_OBJECT_TYPE_CHART,

        [EnumMember(Value = "INDEXING_REPORT_BY_OBJECT_CHART")]
        INDEXING_REPORT_BY_OBJECT_CHART,

        [EnumMember(Value = "INDEXING_REPORT_BY_SLA_CHART")]
        INDEXING_REPORT_BY_SLA_CHART,

        [EnumMember(Value = "INFRASTRUCTURE_ALL_CHART")]
        INFRASTRUCTURE_ALL_CHART,

        [EnumMember(Value = "INFRASTRUCTURE_BY_TYPE_CHART")]
        INFRASTRUCTURE_BY_TYPE_CHART,

        [EnumMember(Value = "OBJECT_BACKUP_TASK_SUMMARY_BY_SLA_CHART")]
        OBJECT_BACKUP_TASK_SUMMARY_BY_SLA_CHART,

        [EnumMember(Value = "OBJECT_BACKUP_TASK_SUMMARY_MISSED_TASK_BY_OBJECT_CHART")]
        OBJECT_BACKUP_TASK_SUMMARY_MISSED_TASK_BY_OBJECT_CHART,

        [EnumMember(Value = "OBJECT_CAPACITY_ALL_CHART")]
        OBJECT_CAPACITY_ALL_CHART,

        [EnumMember(Value = "OBJECT_CAPACITY_BY_CLUSTER_CHART")]
        OBJECT_CAPACITY_BY_CLUSTER_CHART,

        [EnumMember(Value = "OBJECT_CAPACITY_BY_CLUSTER_TYPE_CHART")]
        OBJECT_CAPACITY_BY_CLUSTER_TYPE_CHART,

        [EnumMember(Value = "OBJECT_CAPACITY_BY_OBJECT_TYPE_BYTES_TRANSFERRED_CHART")]
        OBJECT_CAPACITY_BY_OBJECT_TYPE_BYTES_TRANSFERRED_CHART,

        [EnumMember(Value = "OBJECT_CAPACITY_BY_OBJECT_TYPE_CHART")]
        OBJECT_CAPACITY_BY_OBJECT_TYPE_CHART,

        [EnumMember(Value = "OBJECT_CAPACITY_BY_OBJECT_TYPE_SOURCE_SIZE_CHART")]
        OBJECT_CAPACITY_BY_OBJECT_TYPE_SOURCE_SIZE_CHART,

        [EnumMember(Value = "OBJECT_CAPACITY_OVERTIME_LOCAL_DATA_STORE_CHART")]
        OBJECT_CAPACITY_OVERTIME_LOCAL_DATA_STORE_CHART,

        [EnumMember(Value = "OBJECT_CAPACITY_OVERTIME_PROTECTED_OBJECTS_COUNT_CHART")]
        OBJECT_CAPACITY_OVERTIME_PROTECTED_OBJECTS_COUNT_CHART,

        [EnumMember(Value = "OBJECT_CAPACITY_OVERTIME_SOURCE_SIZE_CHART")]
        OBJECT_CAPACITY_OVERTIME_SOURCE_SIZE_CHART,

        [EnumMember(Value = "PROTECTION_ALL_CHART")]
        PROTECTION_ALL_CHART,

        [EnumMember(Value = "PROTECTION_BY_CLUSTER_CHART")]
        PROTECTION_BY_CLUSTER_CHART,

        [EnumMember(Value = "PROTECTION_BY_CLUSTER_TYPE_CHART")]
        PROTECTION_BY_CLUSTER_TYPE_CHART,

        [EnumMember(Value = "PROTECTION_BY_OBJECT_TYPE_CHART")]
        PROTECTION_BY_OBJECT_TYPE_CHART,

        [EnumMember(Value = "PROTECTION_BY_TIME_CHART")]
        PROTECTION_BY_TIME_CHART,

        [EnumMember(Value = "PROTECTION_TASKS_ALL_CHART")]
        PROTECTION_TASKS_ALL_CHART,

        [EnumMember(Value = "PROTECTION_TASKS_CLUSTER_CHART")]
        PROTECTION_TASKS_CLUSTER_CHART,

        [EnumMember(Value = "PROTECTION_TASKS_CLUSTER_TYPE_CHART")]
        PROTECTION_TASKS_CLUSTER_TYPE_CHART,

        [EnumMember(Value = "PROTECTION_TASKS_OBJECT_TYPE_CHART")]
        PROTECTION_TASKS_OBJECT_TYPE_CHART,

        [EnumMember(Value = "PROTECTION_TASKS_STATUS_CHART")]
        PROTECTION_TASKS_STATUS_CHART,

        [EnumMember(Value = "PROTECTION_TASKS_TIME_CHART")]
        PROTECTION_TASKS_TIME_CHART,

        [EnumMember(Value = "READABLE_SNAPSHOTS_BY_CLUSTER_COLUMN_CHART")]
        READABLE_SNAPSHOTS_BY_CLUSTER_COLUMN_CHART,

        [EnumMember(Value = "READABLE_SNAPSHOTS_BY_SEVERITY_DONUT_CHART")]
        READABLE_SNAPSHOTS_BY_SEVERITY_DONUT_CHART,

        [EnumMember(Value = "READABLE_SNAPSHOTS_BY_TIME_AREA_CHART")]
        READABLE_SNAPSHOTS_BY_TIME_AREA_CHART,

        [EnumMember(Value = "RECOVERY_TASKS_ALL_CHART")]
        RECOVERY_TASKS_ALL_CHART,

        [EnumMember(Value = "RECOVERY_TASKS_CLUSTER_CHART")]
        RECOVERY_TASKS_CLUSTER_CHART,

        [EnumMember(Value = "RECOVERY_TASKS_CLUSTER_TYPE_CHART")]
        RECOVERY_TASKS_CLUSTER_TYPE_CHART,

        [EnumMember(Value = "RECOVERY_TASKS_OBJECT_TYPE_CHART")]
        RECOVERY_TASKS_OBJECT_TYPE_CHART,

        [EnumMember(Value = "RECOVERY_TASKS_STATUS_CHART")]
        RECOVERY_TASKS_STATUS_CHART,

        [EnumMember(Value = "RECOVERY_TASKS_TIME_CHART")]
        RECOVERY_TASKS_TIME_CHART,

        [EnumMember(Value = "THREAT_MONITORING_FILE_MATCHES_TIMELINE")]
        THREAT_MONITORING_FILE_MATCHES_TIMELINE,

        [EnumMember(Value = "THREAT_MONITORING_MATCHED_OBJECTS_PIE_CHART")]
        THREAT_MONITORING_MATCHED_OBJECTS_PIE_CHART,

        [EnumMember(Value = "UNREADABLE_OBJECTS_BY_TIME_AREA_CHART")]
        UNREADABLE_OBJECTS_BY_TIME_AREA_CHART,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ChartViewType

} // namespace RubrikSecurityCloud.Types