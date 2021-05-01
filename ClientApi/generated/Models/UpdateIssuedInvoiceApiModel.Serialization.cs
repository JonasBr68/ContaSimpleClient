// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class UpdateIssuedInvoiceApiModel : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("date");
            writer.WriteStringValue(Date, "O");
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
            writer.WritePropertyName("invoiceClass");
            writer.WriteNumberValue(InvoiceClass);
            writer.WritePropertyName("lines");
            writer.WriteStartArray();
            foreach (var item in Lines)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Notes))
            {
                writer.WritePropertyName("notes");
                writer.WriteStringValue(Notes);
            }
            writer.WritePropertyName("number");
            writer.WriteStringValue(Number);
            if (Optional.IsDefined(NumberingFormatId))
            {
                writer.WritePropertyName("numberingFormatId");
                writer.WriteNumberValue(NumberingFormatId.Value);
            }
            if (Optional.IsDefined(OperationDate))
            {
                writer.WritePropertyName("operationDate");
                writer.WriteStringValue(OperationDate.Value, "O");
            }
            if (Optional.IsDefined(OperationType))
            {
                writer.WritePropertyName("operationType");
                writer.WriteStringValue(OperationType);
            }
            if (Optional.IsDefined(RectifiesInvoiceId))
            {
                writer.WritePropertyName("rectifiesInvoiceId");
                writer.WriteNumberValue(RectifiesInvoiceId.Value);
            }
            if (Optional.IsDefined(RetentionPercentage))
            {
                writer.WritePropertyName("retentionPercentage");
                writer.WriteNumberValue(RetentionPercentage.Value);
            }
            writer.WritePropertyName("targetEntity");
            writer.WriteObjectValue(TargetEntity);
            writer.WriteEndObject();
        }
    }
}
