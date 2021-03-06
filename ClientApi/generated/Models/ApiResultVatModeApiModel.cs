// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Implements the generic API response. </summary>
    public partial class ApiResultVatModeApiModel
    {
        /// <summary> Initializes a new instance of ApiResultVatModeApiModel. </summary>
        internal ApiResultVatModeApiModel()
        {
        }

        /// <summary> Initializes a new instance of ApiResultVatModeApiModel. </summary>
        /// <param name="data"> The API result. </param>
        internal ApiResultVatModeApiModel(VatModeApiModel data)
        {
            Data = data;
        }

        /// <summary> The API result. </summary>
        public VatModeApiModel Data { get; }
    }
}
