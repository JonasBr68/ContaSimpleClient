// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class PublicEstimateApiModel : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Configuration))
            {
                writer.WritePropertyName("configuration");
                writer.WriteObjectValue(Configuration);
            }
            if (Optional.IsDefined(ExpirationDate))
            {
                writer.WritePropertyName("expirationDate");
                writer.WriteStringValue(ExpirationDate.Value, "O");
            }
            if (Optional.IsDefined(Footer))
            {
                writer.WritePropertyName("footer");
                writer.WriteStringValue(Footer);
            }
            writer.WritePropertyName("lines");
            writer.WriteStartArray();
            foreach (var item in Lines)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Logo))
            {
                writer.WritePropertyName("logo");
                writer.WriteStringValue(Logo);
            }
            writer.WritePropertyName("me");
            writer.WriteObjectValue(Me);
            writer.WritePropertyName("number");
            writer.WriteStringValue(Number);
            writer.WritePropertyName("options");
            writer.WriteObjectValue(Options);
            writer.WritePropertyName("presupuestoDate");
            writer.WriteStringValue(PresupuestoDate, "O");
            if (Optional.IsDefined(RetentionPercentage))
            {
                writer.WritePropertyName("retentionPercentage");
                writer.WriteNumberValue(RetentionPercentage.Value);
            }
            writer.WritePropertyName("target");
            writer.WriteObjectValue(Target);
            writer.WriteEndObject();
        }
    }
}
