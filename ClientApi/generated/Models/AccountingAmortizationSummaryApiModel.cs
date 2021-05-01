// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Contains the information for the amortizations. </summary>
    public partial class AccountingAmortizationSummaryApiModel
    {
        /// <summary> Initializes a new instance of AccountingAmortizationSummaryApiModel. </summary>
        internal AccountingAmortizationSummaryApiModel()
        {
        }

        /// <summary> Initializes a new instance of AccountingAmortizationSummaryApiModel. </summary>
        /// <param name="numberOfInvoices"> The total number of invoices. </param>
        /// <param name="totalAmount"> The total amount. </param>
        /// <param name="totalComputableAmount"> The total computable amount. </param>
        internal AccountingAmortizationSummaryApiModel(int? numberOfInvoices, double? totalAmount, double? totalComputableAmount)
        {
            NumberOfInvoices = numberOfInvoices;
            TotalAmount = totalAmount;
            TotalComputableAmount = totalComputableAmount;
        }

        /// <summary> The total number of invoices. </summary>
        public int? NumberOfInvoices { get; }
        /// <summary> The total amount. </summary>
        public double? TotalAmount { get; }
        /// <summary> The total computable amount. </summary>
        public double? TotalComputableAmount { get; }
    }
}
