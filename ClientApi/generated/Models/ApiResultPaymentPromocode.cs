// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Implements the generic API response. </summary>
    public partial class ApiResultPaymentPromocode
    {
        /// <summary> Initializes a new instance of ApiResultPaymentPromocode. </summary>
        internal ApiResultPaymentPromocode()
        {
        }

        /// <summary> Initializes a new instance of ApiResultPaymentPromocode. </summary>
        /// <param name="data"> The API result. </param>
        internal ApiResultPaymentPromocode(PaymentPromocode data)
        {
            Data = data;
        }

        /// <summary> The API result. </summary>
        public PaymentPromocode Data { get; }
    }
}
