## 10.5.0 - daily release
#### Az.Accounts 2.13.2
* Enabled in-tool notification for version upgrade by default.
* Upgraded Azure.Core to 1.35.0.

#### Az.Aks 5.6.0
* Removed parameter 'DockerBridgeCidr' from 'New-AzAksCluster'

#### Az.App 0.2.0
* Upgraded api version to 2023-05-01.

#### Az.CloudService 1.2.1
* Downgraded the api version of referenced network to 2021-03-01.

#### Az.CognitiveServices 1.14.1
* Updated SDK via autorest.powershell.

#### Az.Compute 6.4.0
* Added update functionality in 'Update-AzVmss' for parameters 'SecurityType', 'EnableSecureBoot', and 'EnableVtpm' for the parameter set with the Put operation.
* Upgraded Azure.Core to 1.35.0.
* [Breaking change] Removed unversioned and outdated linux image aliases of 'CentOS', 'RHEL', 'UbuntuLTS' and 'Debian'.
* [Breaking Change] Added defaulting logic for VM and VMSS creation to set SecurityType to TrustedLaunch and SecureBootEnabled and VTpmEnalbed to true when those are not set by the user.
* [Breaking Change] Added defaulting logic for Disk creation to default to TrustedLaunch when able. Allows the user to turn this off by setting the SecurityType to Standard.
* Added new parameters '-ElasticSanResourceId' and '-OptimizedForFrequentAttach' to 'New-AzDiskConfig' cmdlet.
* Added new parameter '-ElasticSanResourceId' to 'New-AzSnapshotConfig' cmdlet.
* Fixed 'New-AzVmss' and 'New-Azvm' to use 'SharedGalleryImageId' parameter.

#### Az.ConnectedKubernetes 0.10.0
* Added support for custom locations id and correlation Id.

#### Az.ConnectedMachine 0.5.1
* Removed the version check in MachineExtensionProperties

#### Az.ContainerInstance 3.2.3
* [Breaking Change] Fixed the typo that output property starting with PreviousState was misspelled as PreviouState. [#22268]

#### Az.ContainerRegistry 4.1.2
* Upgraded Azure.Core to 1.35.0.

#### Az.CosmosDB 1.13.0
* Added new parameter 'EnableBurstCapacity' to 'Update-AzCosmosDBAccount' and 'New-AzCosmosDBAccount'.
* Added new paramater 'MinimalTlsVersion' to 'Update-AzCosmosDBAccount' and 'New-AzCosmosDBAccount'.
* Added new property 'CustomerManagedKeyStatus' to 'Get-AzCosmosDBAccount'.

#### Az.Databricks 1.7.1
* Fixed an issue regarding Custom Managed Key.[#22463] [#22898]

#### Az.DataFactory 1.17.1
* Added ParquetReadSettings in ADF
* Fixed minor issues

#### Az.DataMigration 0.14.3
* Supported console app automatically upgrade.

#### Az.DesktopVirtualization 4.2.0
* Added cmdlets:
    - 'Get-AzWvdAppAttachPackage'
    - 'Import-AzWvdAppAttachPackageInfo'
    - 'New-AzWvdAppAttachPackage'
    - 'Remove-AzWvdAppAttachPackage'
    - 'Update-AzWvdAppAttachPackage'
* Added Private Link Cmdlets
    - 'Get-AzWvdPrivateEndpointConnection'
    - 'Get-AzWvdPrivateLinkResource'
    - 'Remove-AzWvdPrivateEndpointConnection'
* Added Scaling Plan Personal Schedule cmdlets
    - 'Get-AzWvdScalingPlanPersonalSchedule'
    - 'New-AzWvdScalingPlanPersonalSchedule'
    - 'Remove-AzWvdScalingPlanPersonalSchedule'
    - 'Update-AzWvdScalingPlanPersonalSchedule'
* Added Scaling Plan Pooled Schedule cmdlets
    - 'Get-AzWvdScalingPlanPooledSchedule'
    - 'New-AzWvdScalingPlanPooledSchedule'
    - 'Remove-AzWvdScalingPlanPooledSchedule'
    - 'Update-AzWvdScalingPlanPooledSchedule'
* Updated rampDownCapacityThresholdPct minimum value from 0 to 1 on ScalingPlanPooledSchedule cmdlets
* Added showInFeed property to ApplicationGroups

#### Az.DevCenter 1.0.0
* General availability for module Az.DevCenter

#### Az.Dns 1.2.0
* Added cmdlets:
    - 'Get-AzDnsDnssecConfig'
    - 'New-AzDnsDnssecConfig'
    - 'Remove-AzDnsDnssecConfig'
* Added three new record types, 'DS', 'TLSA' and 'NAPTR'.

#### Az.ElasticSan 0.1.2
* Added support for CMK and volume snapshots

#### Az.EventHub 4.2.0
*  Added parameter 'PartitionCount' to 'Set-AzEventHub'

#### Az.Functions 4.0.7
* Used ARM API to get Stacks information for Functions [#14682]
* Removed support to create v3 function apps (Functions v3 has reached EOL) [#20838]
* Removeed Preview flag for Java 17 function apps [#20009]
* Added support to create dotnet-isolated apps [#16349]
* Added support for custom handler [#12542]
* Redacted appsettings output on Get-AzFunctionApp and Update-AzFunctionAppSetting [#23241]

#### Az.HDInsight 6.0.2
* Fixed a bug where the get cluster command does not display abfss storage information.

#### Az.KeyVault 4.13.0
* Supported user assigned identity for Managed HSM in 'New/Update-AzKeyVaultManagedHsm' 
* [Breaking Change] Changed parameter 'SoftDeleteRetentionInDays' in 'New-AzKeyVaultManagedHsm' to mandatory.
* Upgraded Azure.Core to 1.35.0.

#### Az.Kusto 2.3.0
* Supported sandbox custom image
* Supported database CMK
* Supported cluster migration

#### Az.Maintenance 1.4.0
* Added support for maintenance configuration cancellation.

#### Az.Monitor 4.7.0
  * [Breaking Change] Data collection Rule upgraded API version to stable 2022-06-01
  * [Breaking Change] AMCS removed 'Set-AzDataCollectionRule' cmdlet
  * Added cmdlets for data collection endpoint:
    * 'Get-AzDataCollectionEndpoint'
    * 'New-AzDataCollectionEndpoint'
    * 'Remove-AzDataCollectionEndpoint'
    * 'Update-AzDataCollectionEndpoint'

#### Az.NetAppFiles 0.13.2
* Fixed some minor issues
* Upgraded Azure.Core to 1.35.0.

#### Az.Network 6.3.0
* [Breaking Change] Removed 'Geo' as a valid input for parameter 'VariableName' in 'NewAzureApplicationGatewayFirewallCustomRuleGroupByVariable'.
* Added AllowBranchToBranchTraffic property to New-AzRouteServer
* Added AllowBranchToBranchTraffic property to Get-AzRouteServer
* Changed Update-AzRouteServer functionality to fix bugs
    - AllowBranchToBranchTraffic is now a bool
    - Updating HubRoutingPreference property will not effect AllowBranchToBranchTraffic

#### Az.NetworkAnalytics 0.1.0
* First preview release for module Az.NetworkAnalytics

#### Az.NetworkCloud 1.0.0
* General availability of 'Az.NetworkCloud' module

#### Az.PolicyInsights 1.6.4
* Upgraded Azure.Core to 1.35.0.

#### Az.PowerBIEmbedded 1.3.0
* Removed deprecated workspace collection cmdlets

#### Az.RecoveryServices 6.6.1
* Fixed minor issues

#### Az.RedisCache 1.8.1
* Fixed minor issues

#### Az.Resources 6.12.0
* [Breaking Change] Redesigned CRUD cmdlets for 'PolicyAssignment', 'PolicyDefinition', 'PolicyExemption', 'PolicySetDefinition'. Please see Az 11 migration guide https://learn.microsoft.com/en-us/powershell/azure/migrate-az-10.0.0 for more detail.
* Supported  statements for user-defined types in Bicep files.
* Fixed reporting duplicate warnings when compiling Bicep files.
* Updated New and Set Management Group cmdlets to allow DeploymentSubscription to be optional.
* Fixed inexplicable error message when subscription and scope are neither provided in RoleAssignment/RoleDefinition related commands. [#22716]

#### Az.Search 0.10.0
* Added support for semantic search option

#### Az.Security 1.5.0
* Fixed some minor issues
* Updated Pricing cmdlets to support extensions
    'Get-AzSecurityPricing'
    'Set-AzSecurityPricing'

#### Az.SecurityInsights 3.1.1
* Removed unnecessary breaking change messages.

#### Az.SelfHelp 0.1.1
* Added support for discovery API as the first point of entry in Help RP.
* Added support for new solution types (Diagnostics, Azure Solutions, Troubleshooters) in preview
* Enabled customers to access Azure curated, relevant self-help solutions including diagnostics and Azure solutions at the resource and subscription scopes.
* Implemented filter parameters such as solutionType, problemClassificationId/problemId, resourceId, and resourceType to enable customers to get more granular results through discovery API.
* Enabled customers to trigger one or more applicable solutions such as diagnostics, components within Azure solutions, and Troubleshooters

#### Az.ServiceFabric 3.3.0
* Fixed minor issues

#### Az.Sql 4.11.0
* Added new parameters to 'New-AzSqlDatabaseFailoverGroup', 'Set-AzSqlDatabaseFailoverGroup'
    - PartnerServers
    - ReadOnlyEndpointTargetServer
* Added 'UseFreeLimit' and 'FreeLimitExhaustionBehavior' parameters to 'New-AzSqlDatabase', 'Get-AzSqlDatabase', 'Set-AzSqlDatabase'
* Added new cmdlets for Elastic Job Private Endpoints 'Get-AzSqlElasticJobPrivateEndpoint', 'New-AzSqlElasticJobPrivateEndpoint', 'Remove-AzSqlElasticJobPrivateEndpoint'
* Added new parameters 'WorkerCount', 'SkuName', 'Identity' to 'AzSqlElasticJobAgent' cmdlets
* Added support for optional SQL auth for Elastic Job Agent cmdlets
*   - The following parameters are now optional: 'CredentialName', 'OutputCredentialName', 'RefreshCredentialName'

#### Az.StackHCI 2.2.3
* Added support for ARC Onboarding using Cluster Managed Identity. 
* Removed previous IMDS Reg Key during Registration/Repair-Registration. 
* Removed creation of custom IMDS Reg Key during Arc Enablement.
* Improved logging experience.

#### Az.Storage 5.11.0
* Supported customer initiated migration
* Supported creationTime filter in Blob Inventory
    - 'New-AzStorageBlobInventoryPolicyRule'
* Supported traling dot in Azure file and directory name by default
    - 'Close-AzStorageFileHandle'
    - 'Get-AzStorageFile'
    - 'Get-AzStorageFileCopyState'
    - 'Get-AzStorageFileContent'
    - 'Get-AzStorageFileHandle'
    - 'New-AzStorageDirectory'
    - 'Remove-AzStorageDirectory'
    - 'Remove-AzStorageFile'
    - 'Rename-AzStorageDirectory'
    - 'Rename-AzStorageFile'
    - 'Set-AzStorageFileContent'
    - 'Start-AzStorageFileCopy'
    - 'Stop-AzStorageFileCopy'
* Upgraded Azure.Core to 1.35.0.
* [Breaking Change] Removed prefix '?' of the created SAS token
    - 'New-AzStorageBlobSasToken'
    - 'New-AzStorageContainerSasToken'
    - 'New-AzStorageAccountSasToken'
    - 'New-AzStorageFileSasToken'
    - 'New-AzStorageShareSasToken'
    - 'New-AzStorageQueueSasToken'
    - 'New-AzStorageTableSasToken'
* Migrated following Azure Queue dataplane cmdlets from 'Microsoft.Azure.Storage.Queue 11.2.2' to 'Azure.Storage.Queues 12.16.0'
    - 'New-AzStorageQueue'
    - 'Get-AzStorageQueue'
    - 'Remove-AzStorageQueue'
    - 'New-AzStorageQueueStoredAccessPolicy'
    - 'Get-AzStorageQueueStoredAccessPolicy'
    - 'Set-AzStorageQueueStoredAccessPolicy'
    - 'Remove-AzStorageQueueStoredAccessPolicy'

#### Az.StorageMover 1.2.0


#### Az.StorageSync 2.1.0
* Fixed minor issues.

#### Az.Subscription 0.11.0
* Invoke-AzSubscriptionAcceptOwnership:
    - Added alias '-DisplayName' to parameter '-SubscriptionName'.
* New-AzSubscriptionAlias:
    - Added alias '-DisplayName' to parameter '-SubscriptionName'.
* Rename-AzSubscription:
    - Changed parameter '-SubscriptionName' to required.
    - Added alias '-DisplayName' to parameter '-SubscriptionName'.
* Removed cmdlet 'Update-AzSubscriptionPolicy'
* Get-AzSubscriptionAcceptOwnershipStatus
    - Updated parameter type of 'SubscriptionId' from 'string[]' to 'string'.

#### Az.Synapse 3.0.4
* Upgraded Azure.Core to 1.35.0.

#### Az.TrafficManager 1.2.2
* Fixed some minor issues

#### Az.Websites 3.1.2
* Adjusted 'Publish-AzWebApp' default behavior

