// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Defines the information for sharing the generated invoice. </summary>
    public partial class PublicInvoiceSharingOptionsApiModel
    {
        /// <summary> Initializes a new instance of PublicInvoiceSharingOptionsApiModel. </summary>
        public PublicInvoiceSharingOptionsApiModel()
        {
        }

        /// <summary> Defines a custom message to send to the invoice destination. </summary>
        public string CustomMessage { get; set; }
        /// <summary> Set to true to download the invoice. </summary>
        public bool? Download { get; set; }
        /// <summary> Set to true to send the invoice by email. Requires the email information to be set on the entities information. </summary>
        public bool? SendByEmail { get; set; }
        /// <summary> Set to true to subscribe the invoice issuer to platform newsletter. </summary>
        public bool? SubscribeToNewsletter { get; set; }
    }
}
