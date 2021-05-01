// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Implements the generic API response. </summary>
    public partial class ApiResultCategoryApiModel
    {
        /// <summary> Initializes a new instance of ApiResultCategoryApiModel. </summary>
        internal ApiResultCategoryApiModel()
        {
        }

        /// <summary> Initializes a new instance of ApiResultCategoryApiModel. </summary>
        /// <param name="data"> The API result. </param>
        internal ApiResultCategoryApiModel(CategoryApiModel data)
        {
            Data = data;
        }

        /// <summary> The API result. </summary>
        public CategoryApiModel Data { get; }
    }
}
