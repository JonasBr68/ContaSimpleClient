// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Implements the generic API response. </summary>
    public partial class ApiResultStockForDocumentsAndProductsEnabledApiModel
    {
        /// <summary> Initializes a new instance of ApiResultStockForDocumentsAndProductsEnabledApiModel. </summary>
        internal ApiResultStockForDocumentsAndProductsEnabledApiModel()
        {
        }

        /// <summary> Initializes a new instance of ApiResultStockForDocumentsAndProductsEnabledApiModel. </summary>
        /// <param name="data"> The API result. </param>
        internal ApiResultStockForDocumentsAndProductsEnabledApiModel(StockForDocumentsAndProductsEnabledApiModel data)
        {
            Data = data;
        }

        /// <summary> The API result. </summary>
        public StockForDocumentsAndProductsEnabledApiModel Data { get; }
    }
}
