// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Implements the generic API response. </summary>
    public partial class ApiResultWorkingHoursApiModel
    {
        /// <summary> Initializes a new instance of ApiResultWorkingHoursApiModel. </summary>
        internal ApiResultWorkingHoursApiModel()
        {
        }

        /// <summary> Initializes a new instance of ApiResultWorkingHoursApiModel. </summary>
        /// <param name="data"> The API result. </param>
        internal ApiResultWorkingHoursApiModel(WorkingHoursApiModel data)
        {
            Data = data;
        }

        /// <summary> The API result. </summary>
        public WorkingHoursApiModel Data { get; }
    }
}
