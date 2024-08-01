### VsphereBlueprintNew
- platform: BlueprintPlatform
- children: list of VSphereVmChilds
- isArchived: System.Boolean
- status: BlueprintStatus
- version: System.Int32
- lastTestFailoverTimeOpt: DateTime
- lastTestFailoverStatus: BlueprintFailoverStatus
- lastFailoverTimeOpt: DateTime
- lastFailoverStatus: BlueprintFailoverStatus
- lastFailoverSource: System.String
  - Last failover source location.
- lastLocalRecoveryTimeOpt: DateTime
  - Last local recovery time.
- lastLocalRecoveryStatus: BlueprintFailoverStatus
  - Status of the last local recovery.
- lastIsolatedRecoveryTimeOpt: DateTime
  - Last isolated recovery time.
- lastIsolatedRecoveryStatus: BlueprintFailoverStatus
  - Status of the last isolated recovery.
- latestFailover: BlueprintFailover
- enableHydrationOpt: System.Boolean
  - Flag to enable hydration.
- timeoutBetweenPriorityGroups: list of System.Int64s
  - A list of numbers representing the length of time, in minutes, to pause between each priority group during recovery. The numbers are ordered to align with the order of the priority groups. For example, consider a Blueprint with 3 priority groups. For this Blueprint, a value of [5,10,0] implies that there is a 5-minute pause between the 1st and 2nd priority groups and a 10-minute pause between the 2nd and 3rd priority groups. The last value in the list is always 0.
- blueprintRecoveryType: BlueprintRecoveryType
  - Recovery type of the Recovery Plan.
- isBlueprintVisible: System.Boolean
  - Visibility of the Recovery Plan.
- blueprintRecoveryCount: BlueprintRecoveryCount
  - Recovery count of the Recovery Plan.
- blueprintWorkloadType: ObjectTypeEnum
- childConnection: BlueprintChildConnection
  - The list of child objects in the Recovery Plan.
- recoveryInfo: BlueprintRecoveryRanges
  - The recovery ranges of the Recovery Plan.
- id: System.String
  - The FID of the hierarchy object.
- name: System.String
  - The name of the hierarchy object.
- objectType: HierarchyObjectTypeEnum
  - The type of this object.
- slaAssignment: SlaAssignmentTypeEnum
  - The SLA Domain assignment type for this object.
- effectiveSlaDomain: SlaDomain
  - The effective SLA Domain of the hierarchy object.
- slaPauseStatus: System.Boolean
  - The pause status of the effective SLA Domain of the hierarchy object.
- snapshotDistribution: SnapshotDistribution
  - The distribution of the snapshots of the hierarchy object.
- effectiveRetentionSlaDomain: SlaDomain
  - The effective retention of the SLA Domain of the hierarchy object.
- configuredSlaDomain: SlaDomain
  - The SLA Domain configured for the hierarchy object.
- effectiveSlaSourceObject: PathNode
  - The path node of the effective SLA Domain source.
- logicalPath: list of PathNodes
  - A sequential list of this object's logical ancestors.
- physicalPath: list of PathNodes
  - A sequential list of this object's physical ancestors.
- numWorkloadDescendants: System.Int32
  - The number of descendant workloads of this object.
- allOrgs: list of Orgs
  - The organizations to which this hierarchy object belongs.
- securityMetadata: SecurityMetadata
  - Security posture metadata.
- authorizedOperations: list of Operations
  - The authorized operations on the object.
- sourceLocation: BlueprintLocation
  - The source location from which this object originated.
- targetLocation: BlueprintLocation
  - The target location to which the object failed over.
- numChildren: System.Int32
  - Number of child objects of the Blueprint.
- lastFailoverTime: DateTime
  - Last failover time.
- lastTestFailoverTime: DateTime
  - Last test failover time.
- lastLocalRecoveryTime: DateTime
  - Last local recovery time.
- lastIsolatedRecoveryTime: DateTime
  - Last isolated recovery time.
- isHydrationEnabled: System.Boolean
  - Status of hydration enablement.
- localRpoLagInfo: RpoLagInfo
  - Local RPO lag information.
- remoteRpoLagInfo: RpoLagInfo
  - Remote RPO lag information.
- blueprintSchedule: Schedule
  - Recovery schedule for this Recovery Plan.
- isBlueprintTargetConsistent: System.Boolean
  - Specifies whether the Recovery Plan is target-consistent.