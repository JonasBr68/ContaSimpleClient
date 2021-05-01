// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Contains the information for the electronic signature. </summary>
    public partial class ElectronicSignatureRequestApiModel
    {
        /// <summary> Initializes a new instance of ElectronicSignatureRequestApiModel. </summary>
        public ElectronicSignatureRequestApiModel()
        {
        }

        /// <summary> The electronic invoices signature type. </summary>
        public ElectronicSignatureRequestApiModelSignElectronicInvoices? SignElectronicInvoices { get; set; }
        /// <summary> The delivery notes signature type. </summary>
        public ElectronicSignatureRequestApiModelSignPDFDeliveryNotes? SignPDFDeliveryNotes { get; set; }
        /// <summary> The pdf estimate signature type. </summary>
        public ElectronicSignatureRequestApiModelSignPDFEstimates? SignPDFEstimates { get; set; }
        /// <summary> The pdf invoices signature type. </summary>
        public ElectronicSignatureRequestApiModelSignPDFInvoices? SignPDFInvoices { get; set; }
        /// <summary> The virtual disk signature type. </summary>
        public ElectronicSignatureRequestApiModelSignVirtualDriveFiles? SignVirtualDriveFiles { get; set; }
    }
}