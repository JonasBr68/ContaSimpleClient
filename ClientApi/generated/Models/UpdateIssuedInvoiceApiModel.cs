// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace ContasimpleAPI.Models
{
    /// <summary> Defines the information for update an issued invoice. </summary>
    public partial class UpdateIssuedInvoiceApiModel
    {
        /// <summary> Initializes a new instance of UpdateIssuedInvoiceApiModel. </summary>
        /// <param name="date"> The invoice date. </param>
        /// <param name="invoiceClass"> The issued / received invoice class. </param>
        /// <param name="lines"> The number of lines that compose the invoice. </param>
        /// <param name="number"> The invoice number to create. </param>
        /// <param name="targetEntity"> The invoice target entity information. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="lines"/>, <paramref name="number"/>, or <paramref name="targetEntity"/> is null. </exception>
        public UpdateIssuedInvoiceApiModel(DateTimeOffset date, int invoiceClass, IEnumerable<InvoiceLineRequestApiModel> lines, string number, UpdateDocumentEntityApiModel targetEntity)
        {
            if (lines == null)
            {
                throw new ArgumentNullException(nameof(lines));
            }
            if (number == null)
            {
                throw new ArgumentNullException(nameof(number));
            }
            if (targetEntity == null)
            {
                throw new ArgumentNullException(nameof(targetEntity));
            }

            Date = date;
            InvoiceClass = invoiceClass;
            Lines = lines.ToList();
            Number = number;
            TargetEntity = targetEntity;
        }

        /// <summary> The invoice date. </summary>
        public DateTimeOffset Date { get; }
        /// <summary> The invoice expiration time (can be null). </summary>
        public DateTimeOffset? ExpirationDate { get; set; }
        /// <summary> Invoice notes. </summary>
        public string Footer { get; set; }
        /// <summary> The issued / received invoice class. </summary>
        public int InvoiceClass { get; }
        /// <summary> The number of lines that compose the invoice. </summary>
        public IList<InvoiceLineRequestApiModel> Lines { get; }
        /// <summary> Invoice notes. </summary>
        public string Notes { get; set; }
        /// <summary> The invoice number to create. </summary>
        public string Number { get; }
        /// <summary> The id of the numbering format applied to the invoice number (optional). </summary>
        public long? NumberingFormatId { get; set; }
        /// <summary> The operation date of the invoice. </summary>
        public DateTimeOffset? OperationDate { get; set; }
        /// <summary>
        /// The operation type for the invoice.
        /// 
        /// Depends on the type of invoice and the company configuration.
        /// </summary>
        public string OperationType { get; set; }
        /// <summary> If not NULL contains the identifier of the invoice which the current invoice is rectifying. </summary>
        public long? RectifiesInvoiceId { get; set; }
        /// <summary> The percentage of the retention value. </summary>
        public double? RetentionPercentage { get; set; }
        /// <summary> The invoice target entity information. </summary>
        public UpdateDocumentEntityApiModel TargetEntity { get; }
    }
}