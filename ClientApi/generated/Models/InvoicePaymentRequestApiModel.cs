// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace ContasimpleAPI.Models
{
    /// <summary> Defines the information to register an invoice payment. </summary>
    public partial class InvoicePaymentRequestApiModel
    {
        /// <summary> Initializes a new instance of InvoicePaymentRequestApiModel. </summary>
        /// <param name="amount"> The payed amount. </param>
        /// <param name="date"> The payment date. </param>
        /// <param name="paymentMethodId"> The identifier of the payment method. </param>
        public InvoicePaymentRequestApiModel(double amount, DateTimeOffset date, long paymentMethodId)
        {
            Amount = amount;
            Date = date;
            PaymentMethodId = paymentMethodId;
        }

        /// <summary> The payed amount. </summary>
        public double Amount { get; }
        /// <summary> The payment date. </summary>
        public DateTimeOffset Date { get; }
        /// <summary> The identifier of the payment method. </summary>
        public long PaymentMethodId { get; }
    }
}
