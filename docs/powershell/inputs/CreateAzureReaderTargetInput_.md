### CreateAzureReaderTargetInput
Input for creating an Azure Reader Target.

- name: System.String
  - Field for specifying name of the target.
- clusterUuid: System.String
  - Field for specifying cluster UUID of the target.
- storageAccountName: System.String
  - Field for specifying storage account name.
- accessKey: System.String
  - Field for specifying access key of the target.
- containerName: System.String
  - Field for specifying container name of the target.
- cloudAccountId: System.String
  - Field for specifying cloud account ID.
- instanceType: InstanceTypeEnum
  - Field for specifying instance type of Azure target.
- rsaKey: System.String
  - Field for specifying RSA key for encryption.
- computeSettings: AzureCloudComputeSettingsInput
  - Field for Azure compute settings.
- proxySettings: ProxySettingsInput
  - Field for specifying compute settings.
- isConsolidationEnabled: System.Boolean
  - Field for specifying whether consolidation is enabled or not.
- immutabilitySettings: AzureImmutabilitySettings
  - Field for specifying immutability settings of Azure target.
- readerRetrievalMethod: ReaderRetrievalMethod
  - Field for specifying the metadata to be retrieved from a target.
- retrievalTier: AzureRetrievalTier
  - Retrieval tier to use for retrieving data from archive storage.
- bypassProxy: System.Boolean
  - Specifies whether the proxy settings should be bypassed for creating this target location.
- azureKeyVaultKey: AzureKeyVaultKeyIdentifierWithoutKeyVersionInput
  - Azure Key Vault key used to encrypt the archival target.