// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Implements the generic API response. </summary>
    public partial class ApiResultWorkingHoursRegistryConfigurationApiModel
    {
        /// <summary> Initializes a new instance of ApiResultWorkingHoursRegistryConfigurationApiModel. </summary>
        internal ApiResultWorkingHoursRegistryConfigurationApiModel()
        {
        }

        /// <summary> Initializes a new instance of ApiResultWorkingHoursRegistryConfigurationApiModel. </summary>
        /// <param name="data"> The API result. </param>
        internal ApiResultWorkingHoursRegistryConfigurationApiModel(WorkingHoursRegistryConfigurationApiModel data)
        {
            Data = data;
        }

        /// <summary> The API result. </summary>
        public WorkingHoursRegistryConfigurationApiModel Data { get; }
    }
}
