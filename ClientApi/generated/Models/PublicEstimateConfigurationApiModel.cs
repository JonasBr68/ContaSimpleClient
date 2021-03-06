// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Defines the configuration for generating an invoice from the public service. </summary>
    public partial class PublicEstimateConfigurationApiModel
    {
        /// <summary> Initializes a new instance of PublicEstimateConfigurationApiModel. </summary>
        public PublicEstimateConfigurationApiModel()
        {
        }

        /// <summary> The company identifier name. </summary>
        public string CompanyIdentifierName { get; set; }
        /// <summary> THe language to generate the estimate. </summary>
        public string Culture { get; set; }
        /// <summary> The currency used for the estimate. </summary>
        public string Currency { get; set; }
        /// <summary> The name of the RE tax. </summary>
        public string ReName { get; set; }
        /// <summary> The name of the Retention tax. </summary>
        public string RetentionName { get; set; }
        /// <summary> The name of the VAT tax. </summary>
        public string VatName { get; set; }
    }
}
