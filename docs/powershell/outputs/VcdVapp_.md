### VcdVapp
- cdmId: System.String
  - The CDM ID of vCD vApp.
- isRelic: System.Boolean
- isTemplate: System.Boolean
  - Specifies whether this is a vApp template.
- isBestEffortSynchronizationEnabled: System.Boolean
  - Specifies whether the vApp is best effort synchronization Enabled.
- vcdVms: list of VcdVmInfos
  - Information about vCD-managed vApp child virtual machines.
- protectionDate: DateTime
  - The date when the SLA Domain was assigned or inherited.
- reportWorkload: Snappable
  - Contains statistics for the protected objects, for example, capacity.
- duplicatedVapps: list of DuplicatedVapps
  - List of duplicated vApps.
- logicalChildConnection: VcdVappLogicalChildTypeConnection
  - List of logical children.
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
- cluster: Cluster
  - Rubrik cluster where this object originated.
- primaryClusterLocation: DataLocation
  - The source cluster of this object. Returned as a data location because there is no guarantee that Rubrik has knowledge about the source cluster.
- pendingSla: SlaDomain
  - SLA Domain assignment of the object during the process of being communicated over to Rubrik CDM.
- pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion
  - Mapping from object ID to pending object deletion status.
- replicatedObjects: list of CdmHierarchyObjects
  - Objects either replicated by this object or related to this object by replication.
- crossAccountReplicatedObjectInfos: list of CrossAccountReplicatedObjectInfos
  - Cross-account objects either replicated by this object or related to this object by replication.
- latestUserNote: LatestUserNote
  - Latest user note information.
- replicatedObjectCount: System.Int32
  - The number of objects either replicated by this object or related to this object by replication.
- authorizedOperations: list of Operations
  - The authorized operations on the object.
- cdmLink: System.String
  - A link to view the workload on the CDM cluster. For dev use only.
- missedSnapshotConnection: MissedSnapshotCommonConnection
  - The list of missed snapshots for this workload.
- missedSnapshotGroupByConnection: MissedSnapshotGroupByConnection
  - The list of missed snapshots for this workload.
- snapshotConnection: CdmSnapshotConnection
  - The list of snapshots taken for this workload.
- snapshotGroupByConnection: CdmSnapshotGroupByConnection
  - GroupBy connection for the snapshots of this workload.
- snapshotGroupBySummary: CdmSnapshotGroupBySummaryConnection
  - GroupBy connection for the snapshots of this workload.
- newestIndexedSnapshot: CdmSnapshot
  - The most recent indexed snapshot of this workload.
- newestSnapshot: CdmSnapshot
  - The most recent snapshot of this workload.
- oldestSnapshot: CdmSnapshot
  - The oldest snapshot of this workload.
- onDemandSnapshotCount: System.Int32
  - The number of on-demand snapshots.
- newestArchivedSnapshot: CdmSnapshot
  - The newest snapshot archived to AWS.
- newestReplicatedSnapshot: CdmSnapshot
  - The newest snapshot replicated to a cluster.