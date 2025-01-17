// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Purview configuration. </summary>
    internal partial class FactoryPurviewConfiguration
    {
        /// <summary> Initializes a new instance of FactoryPurviewConfiguration. </summary>
        public FactoryPurviewConfiguration()
        {
        }

        /// <summary> Initializes a new instance of FactoryPurviewConfiguration. </summary>
        /// <param name="purviewResourceId"> Purview resource id. </param>
        internal FactoryPurviewConfiguration(ResourceIdentifier purviewResourceId)
        {
            PurviewResourceId = purviewResourceId;
        }

        /// <summary> Purview resource id. </summary>
        public ResourceIdentifier PurviewResourceId { get; set; }
    }
}
