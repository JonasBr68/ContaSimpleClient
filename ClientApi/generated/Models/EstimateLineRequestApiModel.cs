// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace ContasimpleAPI.Models
{
    /// <summary> Contains the information for an estimate line. </summary>
    public partial class EstimateLineRequestApiModel
    {
        /// <summary> Initializes a new instance of EstimateLineRequestApiModel. </summary>
        /// <param name="concept"> The estimate line concept. </param>
        /// <param name="quantity"> The quantity of items on the estimate line. </param>
        /// <param name="totalTaxableAmount">
        /// The total taxable amount of the line.
        /// 
        /// There is a limit of two decimals.
        /// 
        /// This value is required to show the same rounded value applied by the client on the PDF.
        /// </param>
        /// <param name="unitAmount">
        /// The estimate line unit base amount
        /// 
        /// There is a limit of two decimals.
        /// </param>
        /// <param name="vatAmount">
        /// The VAT amount of the estimate line
        /// 
        /// There is a limit of two decimals.
        /// </param>
        /// <param name="vatPercentage"> The VAT percentage to apply to the estimate line. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="concept"/> is null. </exception>
        public EstimateLineRequestApiModel(string concept, double quantity, double totalTaxableAmount, double unitAmount, double vatAmount, double vatPercentage)
        {
            if (concept == null)
            {
                throw new ArgumentNullException(nameof(concept));
            }

            Concept = concept;
            Quantity = quantity;
            TotalTaxableAmount = totalTaxableAmount;
            UnitAmount = unitAmount;
            VatAmount = vatAmount;
            VatPercentage = vatPercentage;
        }

        /// <summary> The estimate line concept. </summary>
        public string Concept { get; }
        /// <summary> A detailed description for the estimate. </summary>
        public string DetailedDescription { get; set; }
        /// <summary> The discount percentage to apply to the estimate. </summary>
        public double? DiscountPercentage { get; set; }
        /// <summary> The selected product id for stock control (optional). </summary>
        public long? ProductId { get; set; }
        /// <summary> The selected product name associated to the line for stock control. </summary>
        public string ProductName { get; set; }
        /// <summary> The selected product sku associated to the line for stock control. </summary>
        public string ProductSku { get; set; }
        /// <summary> The quantity of items on the estimate line. </summary>
        public double Quantity { get; }
        /// <summary>
        /// The RE amount of the estimate line
        /// 
        /// There is a limit of two decimals.
        /// </summary>
        public double? ReAmount { get; set; }
        /// <summary> The RE percentage to apply to the estimate line. </summary>
        public double? RePercentage { get; set; }
        /// <summary>
        /// The total taxable amount of the line.
        /// 
        /// There is a limit of two decimals.
        /// 
        /// This value is required to show the same rounded value applied by the client on the PDF.
        /// </summary>
        public double TotalTaxableAmount { get; }
        /// <summary>
        /// The estimate line unit base amount
        /// 
        /// There is a limit of two decimals.
        /// </summary>
        public double UnitAmount { get; }
        /// <summary>
        /// The VAT amount of the estimate line
        /// 
        /// There is a limit of two decimals.
        /// </summary>
        public double VatAmount { get; }
        /// <summary> The VAT percentage to apply to the estimate line. </summary>
        public double VatPercentage { get; }
    }
}
