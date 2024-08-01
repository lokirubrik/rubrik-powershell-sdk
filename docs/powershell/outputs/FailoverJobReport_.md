### FailoverJobReport
Failover job reports for Recovery Plan.

- jobId: System.String
  - The job ID for the failover.
- jobType: System.String
  - The job type.
- status: System.String
  - The status of the failover.
- startTime: System.Int64
  - The start time for the failover.
- endTime: System.Int64
  - The end time of the failover.
- elapsedTime: System.Int64
  - The elapsed time of the failover.
- progress: System.Single
  - The progress percentage for the failover.
- steps: list of FailoverSteps
  - The specific steps for the failover.
- recoveryName: System.String
  - Name given to the recovery.
- recoveryPlanName: System.String
  - Name of the Recovery Plan.
- objectIds: list of System.Strings
  - IDs of the object that are part of the recovery.
- isArchived: System.Boolean
  - Specifies whether or not the Recovery Plan is archived.
- dataTransferType: System.String
  - Type of data transfer.
- triggeredFrom: RecoveryTriggeredType
  - Specifies how the recovery was triggered.
- canSaveAsPlan: System.Boolean
  - Specifies whether the recovery can be saved as a Recovery Plan.
- blueprintId: System.String
  - Recovery Plan ID.
- isBlueprintVisible: System.Boolean
  - Specifies if the Blueprint is visible.
- blueprintName: System.String
  - Name of the Blueprint.