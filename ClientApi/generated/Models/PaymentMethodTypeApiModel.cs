// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Defines the information for a payment method type. </summary>
    public partial class PaymentMethodTypeApiModel
    {
        /// <summary> Initializes a new instance of PaymentMethodTypeApiModel. </summary>
        internal PaymentMethodTypeApiModel()
        {
        }

        /// <summary> Initializes a new instance of PaymentMethodTypeApiModel. </summary>
        /// <param name="allowsCreation"> Indicates if the payment method is allowed for creation. </param>
        /// <param name="text"> The localized text of the type. </param>
        /// <param name="value"> The payment method value. </param>
        internal PaymentMethodTypeApiModel(bool? allowsCreation, string text, string value)
        {
            AllowsCreation = allowsCreation;
            Text = text;
            Value = value;
        }

        /// <summary> Indicates if the payment method is allowed for creation. </summary>
        public bool? AllowsCreation { get; }
        /// <summary> The localized text of the type. </summary>
        public string Text { get; }
        /// <summary> The payment method value. </summary>
        public string Value { get; }
    }
}