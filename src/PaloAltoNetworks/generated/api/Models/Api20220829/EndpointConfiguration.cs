// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829
{
    using static Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Runtime.Extensions;

    /// <summary>Endpoint Configuration for frontend and backend</summary>
    public partial class EndpointConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.IEndpointConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.IEndpointConfigurationInternal
    {

        /// <summary>Backing field for <see cref="Address" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.IIPAddress _address;

        /// <summary>Address Space</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Origin(Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.IIPAddress Address { get => (this._address = this._address ?? new Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.IPAddress()); set => this._address = value; }

        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Origin(Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.PropertyOrigin.Inlined)]
        public string AddressResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.IIPAddressInternal)Address).ResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.IIPAddressInternal)Address).ResourceId = value ?? null; }

        /// <summary>Address value</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Origin(Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.PropertyOrigin.Inlined)]
        public string IPAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.IIPAddressInternal)Address).Address; set => ((Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.IIPAddressInternal)Address).Address = value ?? null; }

        /// <summary>Internal Acessors for Address</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.IIPAddress Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.IEndpointConfigurationInternal.Address { get => (this._address = this._address ?? new Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.IPAddress()); set { {_address = value;} } }

        /// <summary>Backing field for <see cref="Port" /> property.</summary>
        private string _port;

        /// <summary>port ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Origin(Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.PropertyOrigin.Owned)]
        public string Port { get => this._port; set => this._port = value; }

        /// <summary>Creates an new <see cref="EndpointConfiguration" /> instance.</summary>
        public EndpointConfiguration()
        {

        }
    }
    /// Endpoint Configuration for frontend and backend
    public partial interface IEndpointConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Runtime.IJsonSerializable
    {
        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource Id",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string AddressResourceId { get; set; }
        /// <summary>Address value</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Address value",
        SerializedName = @"address",
        PossibleTypes = new [] { typeof(string) })]
        string IPAddress { get; set; }
        /// <summary>port ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"port ID",
        SerializedName = @"port",
        PossibleTypes = new [] { typeof(string) })]
        string Port { get; set; }

    }
    /// Endpoint Configuration for frontend and backend
    internal partial interface IEndpointConfigurationInternal

    {
        /// <summary>Address Space</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.IIPAddress Address { get; set; }
        /// <summary>Resource Id</summary>
        string AddressResourceId { get; set; }
        /// <summary>Address value</summary>
        string IPAddress { get; set; }
        /// <summary>port ID</summary>
        string Port { get; set; }

    }
}