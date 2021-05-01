// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Implements the generic API response. </summary>
    public partial class ApiResultLimitsApiModel
    {
        /// <summary> Initializes a new instance of ApiResultLimitsApiModel. </summary>
        internal ApiResultLimitsApiModel()
        {
        }

        /// <summary> Initializes a new instance of ApiResultLimitsApiModel. </summary>
        /// <param name="data"> The API result. </param>
        internal ApiResultLimitsApiModel(LimitsApiModel data)
        {
            Data = data;
        }

        /// <summary> The API result. </summary>
        public LimitsApiModel Data { get; }
    }
}
