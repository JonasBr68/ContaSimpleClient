// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace ContasimpleAPI.Models
{
    /// <summary> Contains the information for an invoice footer. </summary>
    public partial class InvoiceFooterApiModel
    {
        /// <summary> Initializes a new instance of InvoiceFooterApiModel. </summary>
        /// <param name="description"> The contents of the invoice footer. </param>
        /// <param name="title"> The title of the footer. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="description"/> or <paramref name="title"/> is null. </exception>
        public InvoiceFooterApiModel(string description, string title)
        {
            if (description == null)
            {
                throw new ArgumentNullException(nameof(description));
            }
            if (title == null)
            {
                throw new ArgumentNullException(nameof(title));
            }

            Description = description;
            Title = title;
        }

        /// <summary> Initializes a new instance of InvoiceFooterApiModel. </summary>
        /// <param name="description"> The contents of the invoice footer. </param>
        /// <param name="id"> The identifier of the oinveoice footer. </param>
        /// <param name="title"> The title of the footer. </param>
        internal InvoiceFooterApiModel(string description, long? id, string title)
        {
            Description = description;
            Id = id;
            Title = title;
        }

        /// <summary> The contents of the invoice footer. </summary>
        public string Description { get; set; }
        /// <summary> The identifier of the oinveoice footer. </summary>
        public long? Id { get; set; }
        /// <summary> The title of the footer. </summary>
        public string Title { get; set; }
    }
}
