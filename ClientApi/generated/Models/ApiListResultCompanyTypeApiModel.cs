// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    /// <summary> Implements the generic API list response. </summary>
    public partial class ApiListResultCompanyTypeApiModel
    {
        /// <summary> Initializes a new instance of ApiListResultCompanyTypeApiModel. </summary>
        internal ApiListResultCompanyTypeApiModel()
        {
            Data = new ChangeTrackingList<CompanyTypeApiModel>();
        }

        /// <summary> Initializes a new instance of ApiListResultCompanyTypeApiModel. </summary>
        /// <param name="count"> Returns the number of elements in the result data. </param>
        /// <param name="data"> The API result. </param>
        /// <param name="totalCount"> Returns the total number of items. To be used for pagination. </param>
        internal ApiListResultCompanyTypeApiModel(long? count, IReadOnlyList<CompanyTypeApiModel> data, long? totalCount)
        {
            Count = count;
            Data = data;
            TotalCount = totalCount;
        }

        /// <summary> Returns the number of elements in the result data. </summary>
        public long? Count { get; }
        /// <summary> The API result. </summary>
        public IReadOnlyList<CompanyTypeApiModel> Data { get; }
        /// <summary> Returns the total number of items. To be used for pagination. </summary>
        public long? TotalCount { get; }
    }
}
