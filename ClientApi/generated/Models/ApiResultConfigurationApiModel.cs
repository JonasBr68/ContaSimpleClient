// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Implements the generic API response. </summary>
    public partial class ApiResultConfigurationApiModel
    {
        /// <summary> Initializes a new instance of ApiResultConfigurationApiModel. </summary>
        internal ApiResultConfigurationApiModel()
        {
        }

        /// <summary> Initializes a new instance of ApiResultConfigurationApiModel. </summary>
        /// <param name="data"> The API result. </param>
        internal ApiResultConfigurationApiModel(ConfigurationApiModel data)
        {
            Data = data;
        }

        /// <summary> The API result. </summary>
        public ConfigurationApiModel Data { get; }
    }
}
