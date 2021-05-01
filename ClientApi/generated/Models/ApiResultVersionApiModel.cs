// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Implements the generic API response. </summary>
    public partial class ApiResultVersionApiModel
    {
        /// <summary> Initializes a new instance of ApiResultVersionApiModel. </summary>
        internal ApiResultVersionApiModel()
        {
        }

        /// <summary> Initializes a new instance of ApiResultVersionApiModel. </summary>
        /// <param name="data"> The API result. </param>
        internal ApiResultVersionApiModel(VersionApiModel data)
        {
            Data = data;
        }

        /// <summary> The API result. </summary>
        public VersionApiModel Data { get; }
    }
}