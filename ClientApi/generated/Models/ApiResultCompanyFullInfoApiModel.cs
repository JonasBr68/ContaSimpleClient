// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Implements the generic API response. </summary>
    public partial class ApiResultCompanyFullInfoApiModel
    {
        /// <summary> Initializes a new instance of ApiResultCompanyFullInfoApiModel. </summary>
        internal ApiResultCompanyFullInfoApiModel()
        {
        }

        /// <summary> Initializes a new instance of ApiResultCompanyFullInfoApiModel. </summary>
        /// <param name="data"> The API result. </param>
        internal ApiResultCompanyFullInfoApiModel(CompanyFullInfoApiModel data)
        {
            Data = data;
        }

        /// <summary> The API result. </summary>
        public CompanyFullInfoApiModel Data { get; }
    }
}
