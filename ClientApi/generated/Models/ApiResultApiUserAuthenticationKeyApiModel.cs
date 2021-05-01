// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Implements the generic API response. </summary>
    public partial class ApiResultApiUserAuthenticationKeyApiModel
    {
        /// <summary> Initializes a new instance of ApiResultApiUserAuthenticationKeyApiModel. </summary>
        internal ApiResultApiUserAuthenticationKeyApiModel()
        {
        }

        /// <summary> Initializes a new instance of ApiResultApiUserAuthenticationKeyApiModel. </summary>
        /// <param name="data"> The API result. </param>
        internal ApiResultApiUserAuthenticationKeyApiModel(ApiUserAuthenticationKeyApiModel data)
        {
            Data = data;
        }

        /// <summary> The API result. </summary>
        public ApiUserAuthenticationKeyApiModel Data { get; }
    }
}
