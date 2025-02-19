// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Extensions;

    /// <summary>
    /// The project environment type for partial update. Properties not provided in the update request will not be changed.
    /// </summary>
    public partial class ProjectEnvironmentTypeUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentTypeUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentTypeUpdateInternal
    {

        /// <summary>A map of roles to assign to the environment creator.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentTypeUpdatePropertiesCreatorRoleAssignmentRoles CreatorRoleAssignmentRole { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentTypeUpdatePropertiesInternal)Property).CreatorRoleAssignmentRole; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentTypeUpdatePropertiesInternal)Property).CreatorRoleAssignmentRole = value ?? null /* model class */; }

        /// <summary>
        /// Id of a subscription that the environment type will be mapped to. The environment's resources will be deployed into this
        /// subscription.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public string DeploymentTargetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentTypeUpdatePropertiesInternal)Property).DeploymentTargetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentTypeUpdatePropertiesInternal)Property).DeploymentTargetId = value ?? null; }

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.IManagedServiceIdentity _identity;

        /// <summary>Managed identity properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.IManagedServiceIdentity Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.ManagedServiceIdentity()); set => this._identity = value; }

        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.IManagedServiceIdentityInternal)Identity).PrincipalId; }

        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.IManagedServiceIdentityInternal)Identity).TenantId; }

        /// <summary>
        /// Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ManagedServiceIdentityType? IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.IManagedServiceIdentityInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.IManagedServiceIdentityInternal)Identity).Type = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ManagedServiceIdentityType)""); }

        /// <summary>
        /// The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
        /// The dictionary values can be empty objects ({}) in requests.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.IUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>Internal Acessors for CreatorRoleAssignment</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentTypeUpdatePropertiesCreatorRoleAssignment Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentTypeUpdateInternal.CreatorRoleAssignment { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentTypeUpdatePropertiesInternal)Property).CreatorRoleAssignment; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentTypeUpdatePropertiesInternal)Property).CreatorRoleAssignment = value; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.IManagedServiceIdentity Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentTypeUpdateInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.ManagedServiceIdentity()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentTypeUpdateInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.IManagedServiceIdentityInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.IManagedServiceIdentityInternal)Identity).PrincipalId = value; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentTypeUpdateInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.IManagedServiceIdentityInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.IManagedServiceIdentityInternal)Identity).TenantId = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentTypeUpdateProperties Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentTypeUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ProjectEnvironmentTypeUpdateProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentTypeUpdateProperties _property;

        /// <summary>Properties to configure an environment type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentTypeUpdateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ProjectEnvironmentTypeUpdateProperties()); set => this._property = value; }

        /// <summary>Defines whether this Environment Type can be used in this Project.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.EnvironmentTypeEnableStatus? Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentTypeUpdatePropertiesInternal)Property).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentTypeUpdatePropertiesInternal)Property).Status = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.EnvironmentTypeEnableStatus)""); }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ITags _tag;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ITags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.Tags()); set => this._tag = value; }

        /// <summary>
        /// Role Assignments created on environment backing resources. This is a mapping from a user object ID to an object of role
        /// definition IDs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentTypeUpdatePropertiesUserRoleAssignments UserRoleAssignment { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentTypeUpdatePropertiesInternal)Property).UserRoleAssignment; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentTypeUpdatePropertiesInternal)Property).UserRoleAssignment = value ?? null /* model class */; }

        /// <summary>Creates an new <see cref="ProjectEnvironmentTypeUpdate" /> instance.</summary>
        public ProjectEnvironmentTypeUpdate()
        {

        }
    }
    /// The project environment type for partial update. Properties not provided in the update request will not be changed.
    public partial interface IProjectEnvironmentTypeUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.IJsonSerializable
    {
        /// <summary>A map of roles to assign to the environment creator.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A map of roles to assign to the environment creator.",
        SerializedName = @"roles",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentTypeUpdatePropertiesCreatorRoleAssignmentRoles) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentTypeUpdatePropertiesCreatorRoleAssignmentRoles CreatorRoleAssignmentRole { get; set; }
        /// <summary>
        /// Id of a subscription that the environment type will be mapped to. The environment's resources will be deployed into this
        /// subscription.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of a subscription that the environment type will be mapped to. The environment's resources will be deployed into this subscription.",
        SerializedName = @"deploymentTargetId",
        PossibleTypes = new [] { typeof(string) })]
        string DeploymentTargetId { get; set; }
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPrincipalId { get;  }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTenantId { get;  }
        /// <summary>
        /// Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ManagedServiceIdentityType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ManagedServiceIdentityType? IdentityType { get; set; }
        /// <summary>
        /// The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
        /// The dictionary values can be empty objects ({}) in requests.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}. The dictionary values can be empty objects ({}) in requests.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.IUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>Defines whether this Environment Type can be used in this Project.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Defines whether this Environment Type can be used in this Project.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.EnvironmentTypeEnableStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.EnvironmentTypeEnableStatus? Status { get; set; }
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ITags) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ITags Tag { get; set; }
        /// <summary>
        /// Role Assignments created on environment backing resources. This is a mapping from a user object ID to an object of role
        /// definition IDs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Role Assignments created on environment backing resources. This is a mapping from a user object ID to an object of role definition IDs.",
        SerializedName = @"userRoleAssignments",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentTypeUpdatePropertiesUserRoleAssignments) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentTypeUpdatePropertiesUserRoleAssignments UserRoleAssignment { get; set; }

    }
    /// The project environment type for partial update. Properties not provided in the update request will not be changed.
    internal partial interface IProjectEnvironmentTypeUpdateInternal

    {
        /// <summary>The role definition assigned to the environment creator on backing resources.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentTypeUpdatePropertiesCreatorRoleAssignment CreatorRoleAssignment { get; set; }
        /// <summary>A map of roles to assign to the environment creator.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentTypeUpdatePropertiesCreatorRoleAssignmentRoles CreatorRoleAssignmentRole { get; set; }
        /// <summary>
        /// Id of a subscription that the environment type will be mapped to. The environment's resources will be deployed into this
        /// subscription.
        /// </summary>
        string DeploymentTargetId { get; set; }
        /// <summary>Managed identity properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.IManagedServiceIdentity Identity { get; set; }
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityTenantId { get; set; }
        /// <summary>
        /// Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ManagedServiceIdentityType? IdentityType { get; set; }
        /// <summary>
        /// The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
        /// The dictionary values can be empty objects ({}) in requests.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>Properties to configure an environment type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentTypeUpdateProperties Property { get; set; }
        /// <summary>Defines whether this Environment Type can be used in this Project.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.EnvironmentTypeEnableStatus? Status { get; set; }
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ITags Tag { get; set; }
        /// <summary>
        /// Role Assignments created on environment backing resources. This is a mapping from a user object ID to an object of role
        /// definition IDs.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentTypeUpdatePropertiesUserRoleAssignments UserRoleAssignment { get; set; }

    }
}