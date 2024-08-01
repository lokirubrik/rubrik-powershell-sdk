### JiraIssue
Jira issue.

- naturalId: System.String
  - The natural ID of the Jira issue.
- projectId: System.String
  - The Rubrik ID of the project to which this issue belongs.
- key: System.String
  - The key of the Jira issue, for example, ED-123.
- summary: System.String
  - The summary of the Jira issue.
- issueType: JiraIssueType
  - The issue type of the Jira issue.
- assignee: AtlassianUser
  - The user to which the issue is assigned.
- isRelic: System.Boolean
  - Specifies whether the Jira issue is a relic.
- appItemTypeToken: System.String
  - Issues token type.
- reporter: AtlassianUser
  - The user who reported the issue.
- components: list of JiraProjectComponents
  - The project components of the Jira issue.
- priority: JiraIssuePriority
  - The priority of the Jira issue.
- createdAtUtc: DateTime
  - The time when the Jira issue was created.
- updatedAtUtc: DateTime
  - The time when the Jira issue was updated.
- actionType: AppItemActionType
  - Action performed on the issue in the given action date time range. This is defined only when the actionDate filter is set.