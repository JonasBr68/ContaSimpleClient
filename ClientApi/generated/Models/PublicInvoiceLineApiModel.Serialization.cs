// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class PublicInvoiceLineApiModel : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("concept");
            writer.WriteStringValue(Concept);
            writer.WritePropertyName("quantity");
            writer.WriteNumberValue(Quantity);
            if (Optional.IsDefined(RePercentage))
            {
                writer.WritePropertyName("rePercentage");
                writer.WriteNumberValue(RePercentage.Value);
            }
            writer.WritePropertyName("totalTaxableAmount");
            writer.WriteNumberValue(TotalTaxableAmount);
            writer.WritePropertyName("unitTaxableAmount");
            writer.WriteNumberValue(UnitTaxableAmount);
            if (Optional.IsDefined(VatPercentage))
            {
                writer.WritePropertyName("vatPercentage");
                writer.WriteNumberValue(VatPercentage.Value);
            }
            writer.WriteEndObject();
        }
    }
}
