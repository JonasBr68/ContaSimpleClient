// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Implements the generic API response. </summary>
    public partial class ApiResultEstimateApiModel
    {
        /// <summary> Initializes a new instance of ApiResultEstimateApiModel. </summary>
        internal ApiResultEstimateApiModel()
        {
        }

        /// <summary> Initializes a new instance of ApiResultEstimateApiModel. </summary>
        /// <param name="data"> The API result. </param>
        internal ApiResultEstimateApiModel(EstimateApiModel data)
        {
            Data = data;
        }

        /// <summary> The API result. </summary>
        public EstimateApiModel Data { get; }
    }
}
