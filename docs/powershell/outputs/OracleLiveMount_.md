### OracleLiveMount
Oracle live mount.

- cdmId: System.String
  - ID of the Oracle live mount.
- creationDate: DateTime
  - Date when live mount was created.
- isReady: System.Boolean
  - Describes if the live mount is ready.
- mountedDatabaseName: System.String
  - Name of the mounted database.
- targetHostMount: System.String
  - The full path for the directory on the target host where the NFS share is mounted.
- isFilesOnlyMount: System.Boolean
  - Indicates if mount is files only.
- isInstantRecovered: System.Boolean
  - Indicates whether this mount was created during an instant recovery or live mount.
- sourceDatabaseName: System.String
  - Name of the source database that has been mounted.
- targetOracleRac: OracleRac
  - Target Oracle RAC of the live mount. If the live mount target is an Oracle Host, this value will be null and the field targetOracleHost will be populated instead.
- targetOracleHost: OracleHost
  - Target Oracle host of the live mount. If the live mount target is an Oracle RAC, this value will be null and the field targetOracleRac will be populated instead.
- id: System.String
  - Fid of the Oracle live mount.
- cluster: Cluster
  - Cluster of the live mount.
- owner: User
  - The creator of the live mount.
- sourceSnapshot: CdmSnapshot
  - Source snapshot of the Oracle live mount.
- sourceDatabase: OracleDatabase
  - Source Oracle database of the live mount.
- mountedDatabase: OracleDatabase
  - Mounted database of the live mount.
- status: OracleLiveMountStatus
  - Status of the live mount.