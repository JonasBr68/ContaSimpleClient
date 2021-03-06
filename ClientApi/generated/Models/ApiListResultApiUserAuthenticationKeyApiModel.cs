// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    /// <summary> Implements the generic API list response. </summary>
    public partial class ApiListResultApiUserAuthenticationKeyApiModel
    {
        /// <summary> Initializes a new instance of ApiListResultApiUserAuthenticationKeyApiModel. </summary>
        internal ApiListResultApiUserAuthenticationKeyApiModel()
        {
            Data = new ChangeTrackingList<ApiUserAuthenticationKeyApiModel>();
        }

        /// <summary> Initializes a new instance of ApiListResultApiUserAuthenticationKeyApiModel. </summary>
        /// <param name="count"> Returns the number of elements in the result data. </param>
        /// <param name="data"> The API result. </param>
        /// <param name="totalCount"> Returns the total number of items. To be used for pagination. </param>
        internal ApiListResultApiUserAuthenticationKeyApiModel(long? count, IReadOnlyList<ApiUserAuthenticationKeyApiModel> data, long? totalCount)
        {
            Count = count;
            Data = data;
            TotalCount = totalCount;
        }

        /// <summary> Returns the number of elements in the result data. </summary>
        public long? Count { get; }
        /// <summary> The API result. </summary>
        public IReadOnlyList<ApiUserAuthenticationKeyApiModel> Data { get; }
        /// <summary> Returns the total number of items. To be used for pagination. </summary>
        public long? TotalCount { get; }
    }
}
