// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Implements the generic API response. </summary>
    public partial class ApiResultElectronicSignatureConfigurationApiModel
    {
        /// <summary> Initializes a new instance of ApiResultElectronicSignatureConfigurationApiModel. </summary>
        internal ApiResultElectronicSignatureConfigurationApiModel()
        {
        }

        /// <summary> Initializes a new instance of ApiResultElectronicSignatureConfigurationApiModel. </summary>
        /// <param name="data"> The API result. </param>
        internal ApiResultElectronicSignatureConfigurationApiModel(ElectronicSignatureConfigurationApiModel data)
        {
            Data = data;
        }

        /// <summary> The API result. </summary>
        public ElectronicSignatureConfigurationApiModel Data { get; }
    }
}
