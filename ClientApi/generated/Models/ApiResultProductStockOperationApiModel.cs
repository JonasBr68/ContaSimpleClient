// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Implements the generic API response. </summary>
    public partial class ApiResultProductStockOperationApiModel
    {
        /// <summary> Initializes a new instance of ApiResultProductStockOperationApiModel. </summary>
        internal ApiResultProductStockOperationApiModel()
        {
        }

        /// <summary> Initializes a new instance of ApiResultProductStockOperationApiModel. </summary>
        /// <param name="data"> The API result. </param>
        internal ApiResultProductStockOperationApiModel(ProductStockOperationApiModel data)
        {
            Data = data;
        }

        /// <summary> The API result. </summary>
        public ProductStockOperationApiModel Data { get; }
    }
}
