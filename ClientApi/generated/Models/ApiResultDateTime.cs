// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace ContasimpleAPI.Models
{
    /// <summary> Implements the generic API response. </summary>
    public partial class ApiResultDateTime
    {
        /// <summary> Initializes a new instance of ApiResultDateTime. </summary>
        internal ApiResultDateTime()
        {
        }

        /// <summary> Initializes a new instance of ApiResultDateTime. </summary>
        /// <param name="data"> The API result. </param>
        internal ApiResultDateTime(DateTimeOffset? data)
        {
            Data = data;
        }

        /// <summary> The API result. </summary>
        public DateTimeOffset? Data { get; }
    }
}
