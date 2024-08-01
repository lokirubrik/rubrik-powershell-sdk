### ManagedVolume
Managed Volume information.

- provisionedSize: System.Int64
  - Size provisioned for the Managed Volume in bytes.
- numChannels: System.Int32
  - Number of channels in the Managed Volume.
- clientNamePatterns: list of System.Strings
  - Allowed host names.
- isRelic: System.Boolean
  - If the managed volume is in relic state.
- subnet: System.String
  - Subnet of the Managed Volume.
- smbShare: ManagedVolumeSmbShare
  - SMB share details of the Managed Volume.
- managedVolumeType: ManagedVolumeType
  - The type of the Managed Volume.
- protectionDate: DateTime
  - The date on which the effective SLA Domain was assigned or inherited.
- clientConfig: ManagedVolumeSlaClientConfig
  - Client configuration related to backup scripts.
- hostDetail: ManagedVolumeHostDetail
  - Specifies host details for the SLA Managed Volume.
- descendantConnection: ManagedVolumeDescendantTypeConnection
  - List of descendants.
- physicalChildConnection: ManagedVolumePhysicalChildTypeConnection
  - List of physical children.
- cluster: Cluster
  - Cdm cluster information.
- queuedSnapshots: ManagedVolumeQueuedSnapshotConnection
  - The list of queued snapshots for this Managed Volume.
- reportWorkload: Snappable
  - Includes statistics for the protected objects, for example, archive Storage.
- queuedSnapshotGroupBys: ManagedVolumeQueuedSnapshotGroupByConnection
  - The list of Managed Volume queued snapshots for this workload.
- mountState: MountState
  - Mount state of the Managed Volume.
- liveMounts: ManagedVolumeMountConnection
  - Paginated list of Live Mounts for Managed Volume.
- mainMount: ManagedVolumeMount
  - Main Mount for the Managed Volume.
- host: PhysicalHost
  - Physical Host for the Managed Volume.
- physicalUsedSize: System.Int64
  - The Managed Volume's physical size in bytes.
- protocol: ManagedVolumeShareType
  - Mount protocol used for Managed Volume.
- state: ManagedVolumeState
  - State of the Managed Volume.
- applicationTag: ManagedVolumeApplicationTag
  - Mount protocol used for Managed Volume.
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
- cdmId: System.String
  - The ID of the workload on the Rubrik CDM cluster.
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