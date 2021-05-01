// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace ContasimpleAPI.Models
{
    /// <summary> Defines the information for generating a public invoice. </summary>
    public partial class PublicInvoiceApiModel
    {
        /// <summary> Initializes a new instance of PublicInvoiceApiModel. </summary>
        /// <param name="invoiceDate"> The invoice date. </param>
        /// <param name="lines"> The line objects for the invoice. </param>
        /// <param name="me"> Information for the one generating the invoice. </param>
        /// <param name="number"> The invoice number. </param>
        /// <param name="options"> Invoice generation options download the document or false to send it by email to the information setted on &quot;me&quot;/&quot;email&quot; field. </param>
        /// <param name="target"> The information of the invoice destination. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="lines"/>, <paramref name="me"/>, <paramref name="number"/>, <paramref name="options"/>, or <paramref name="target"/> is null. </exception>
        public PublicInvoiceApiModel(DateTimeOffset invoiceDate, IEnumerable<PublicInvoiceLineApiModel> lines, PublicInvoiceEntityApiModel me, string number, PublicInvoiceSharingOptionsApiModel options, PublicInvoiceEntityApiModel target)
        {
            if (lines == null)
            {
                throw new ArgumentNullException(nameof(lines));
            }
            if (me == null)
            {
                throw new ArgumentNullException(nameof(me));
            }
            if (number == null)
            {
                throw new ArgumentNullException(nameof(number));
            }
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }
            if (target == null)
            {
                throw new ArgumentNullException(nameof(target));
            }

            InvoiceDate = invoiceDate;
            Lines = lines.ToList();
            Me = me;
            Number = number;
            Options = options;
            Target = target;
        }

        /// <summary> The invoice configuration (optional). </summary>
        public PublicInvoiceConfigurationApiModel Configuration { get; set; }
        /// <summary> Contains invoice expiration date (cuold be null). </summary>
        public DateTimeOffset? ExpirationDate { get; set; }
        /// <summary> Invoice notes. </summary>
        public string Footer { get; set; }
        /// <summary> The invoice date. </summary>
        public DateTimeOffset InvoiceDate { get; }
        /// <summary> The line objects for the invoice. </summary>
        public IList<PublicInvoiceLineApiModel> Lines { get; }
        /// <summary> The logo token to display on the invoice. Must be uploaded previously using the &quot;/public/invoice/logo&quot; service. </summary>
        public string Logo { get; set; }
        /// <summary> Information for the one generating the invoice. </summary>
        public PublicInvoiceEntityApiModel Me { get; }
        /// <summary> The invoice number. </summary>
        public string Number { get; }
        /// <summary> Invoice generation options download the document or false to send it by email to the information setted on &quot;me&quot;/&quot;email&quot; field. </summary>
        public PublicInvoiceSharingOptionsApiModel Options { get; }
        /// <summary> The invoice retention percentage. </summary>
        public double? RetentionPercentage { get; set; }
        /// <summary> The information of the invoice destination. </summary>
        public PublicInvoiceEntityApiModel Target { get; }
    }
}