// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    /// <summary> Contains the information for an estimate. </summary>
    public partial class EstimateApiModel
    {
        /// <summary> Initializes a new instance of EstimateApiModel. </summary>
        internal EstimateApiModel()
        {
            Lines = new ChangeTrackingList<EstimateLineApiModel>();
        }

        /// <summary> Initializes a new instance of EstimateApiModel. </summary>
        /// <param name="creationDate"> The date when the invoice was created. </param>
        /// <param name="entityString"> The name that represents the issuer or target entity of the invoice. </param>
        /// <param name="expirationDate"> Contains estimate issue date (could be null). </param>
        /// <param name="footer"> The invoice footer. </param>
        /// <param name="id"> The identifier of the invoice. </param>
        /// <param name="issueDate"> Contains estimate issue date (could be null). </param>
        /// <param name="issuer"> The entity issuer. The one who generated the invoice. </param>
        /// <param name="lastUpdateDate"> The last time the invoice was updated. </param>
        /// <param name="lines"> The line objects for the invoice. </param>
        /// <param name="notes"> Estimate notes. </param>
        /// <param name="number"> The estimate number. </param>
        /// <param name="numberingFormatId"> If not NULL contains the identifier of the selected numbering format. </param>
        /// <param name="originalIssuerEntityID"> Original ID of the issuer of the invoice. </param>
        /// <param name="originalTargetEntityID"> Original ID of the target of the invoice. </param>
        /// <param name="presupuestoDate"> The estimate date. </param>
        /// <param name="retentionAmount"> The invoice retention amount. </param>
        /// <param name="retentionPercentage"> The invoice retention percentage. </param>
        /// <param name="status"> The current status of the invoice. </param>
        /// <param name="target"> The entity target. The receiver of the invoice. </param>
        /// <param name="totalAmount">
        /// Gets the total final amount for the invoice (the value returned includes the
        /// 
        /// addition of the taxable amount plus the VAT amount for every line) less the
        /// 
        /// retention amount. TotalAmount = BI +IVA - Retencion + R.E.
        /// </param>
        /// <param name="totalReAmount"> The total RE amount of the invoice. </param>
        /// <param name="totalTaxableAmount">
        /// Gets the total taxable amount for the invoice (the value returned includes the
        /// 
        /// addition of the taxable amounts for the several lines). (Spain: Base imponible).
        /// </param>
        /// <param name="totalVatAmount">
        /// Gets the total VAT amount for the invoice (the value returned includes the
        /// 
        /// addition of the VAT amounts for the several lines).
        /// </param>
        /// <param name="type"> The invoice type. </param>
        internal EstimateApiModel(DateTimeOffset? creationDate, string entityString, DateTimeOffset? expirationDate, string footer, long? id, DateTimeOffset? issueDate, DocumentEntityApiModel issuer, DateTimeOffset? lastUpdateDate, IReadOnlyList<EstimateLineApiModel> lines, string notes, string number, long? numberingFormatId, long? originalIssuerEntityID, long? originalTargetEntityID, DateTimeOffset? presupuestoDate, double? retentionAmount, double? retentionPercentage, EstimateApiModelStatus? status, DocumentEntityApiModel target, double? totalAmount, double? totalReAmount, double? totalTaxableAmount, double? totalVatAmount, EstimateApiModelType? type)
        {
            CreationDate = creationDate;
            EntityString = entityString;
            ExpirationDate = expirationDate;
            Footer = footer;
            Id = id;
            IssueDate = issueDate;
            Issuer = issuer;
            LastUpdateDate = lastUpdateDate;
            Lines = lines;
            Notes = notes;
            Number = number;
            NumberingFormatId = numberingFormatId;
            OriginalIssuerEntityID = originalIssuerEntityID;
            OriginalTargetEntityID = originalTargetEntityID;
            PresupuestoDate = presupuestoDate;
            RetentionAmount = retentionAmount;
            RetentionPercentage = retentionPercentage;
            Status = status;
            Target = target;
            TotalAmount = totalAmount;
            TotalReAmount = totalReAmount;
            TotalTaxableAmount = totalTaxableAmount;
            TotalVatAmount = totalVatAmount;
            Type = type;
        }

        /// <summary> The date when the invoice was created. </summary>
        public DateTimeOffset? CreationDate { get; }
        /// <summary> The name that represents the issuer or target entity of the invoice. </summary>
        public string EntityString { get; }
        /// <summary> Contains estimate issue date (could be null). </summary>
        public DateTimeOffset? ExpirationDate { get; }
        /// <summary> The invoice footer. </summary>
        public string Footer { get; }
        /// <summary> The identifier of the invoice. </summary>
        public long? Id { get; }
        /// <summary> Contains estimate issue date (could be null). </summary>
        public DateTimeOffset? IssueDate { get; }
        /// <summary> The entity issuer. The one who generated the invoice. </summary>
        public DocumentEntityApiModel Issuer { get; }
        /// <summary> The last time the invoice was updated. </summary>
        public DateTimeOffset? LastUpdateDate { get; }
        /// <summary> The line objects for the invoice. </summary>
        public IReadOnlyList<EstimateLineApiModel> Lines { get; }
        /// <summary> Estimate notes. </summary>
        public string Notes { get; }
        /// <summary> The estimate number. </summary>
        public string Number { get; }
        /// <summary> If not NULL contains the identifier of the selected numbering format. </summary>
        public long? NumberingFormatId { get; }
        /// <summary> Original ID of the issuer of the invoice. </summary>
        public long? OriginalIssuerEntityID { get; }
        /// <summary> Original ID of the target of the invoice. </summary>
        public long? OriginalTargetEntityID { get; }
        /// <summary> The estimate date. </summary>
        public DateTimeOffset? PresupuestoDate { get; }
        /// <summary> The invoice retention amount. </summary>
        public double? RetentionAmount { get; }
        /// <summary> The invoice retention percentage. </summary>
        public double? RetentionPercentage { get; }
        /// <summary> The current status of the invoice. </summary>
        public EstimateApiModelStatus? Status { get; }
        /// <summary> The entity target. The receiver of the invoice. </summary>
        public DocumentEntityApiModel Target { get; }
        /// <summary>
        /// Gets the total final amount for the invoice (the value returned includes the
        /// 
        /// addition of the taxable amount plus the VAT amount for every line) less the
        /// 
        /// retention amount. TotalAmount = BI +IVA - Retencion + R.E.
        /// </summary>
        public double? TotalAmount { get; }
        /// <summary> The total RE amount of the invoice. </summary>
        public double? TotalReAmount { get; }
        /// <summary>
        /// Gets the total taxable amount for the invoice (the value returned includes the
        /// 
        /// addition of the taxable amounts for the several lines). (Spain: Base imponible).
        /// </summary>
        public double? TotalTaxableAmount { get; }
        /// <summary>
        /// Gets the total VAT amount for the invoice (the value returned includes the
        /// 
        /// addition of the VAT amounts for the several lines).
        /// </summary>
        public double? TotalVatAmount { get; }
        /// <summary> The invoice type. </summary>
        public EstimateApiModelType? Type { get; }
    }
}