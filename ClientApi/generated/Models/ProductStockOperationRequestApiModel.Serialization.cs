// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class ProductStockOperationRequestApiModel : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Amount))
            {
                writer.WritePropertyName("amount");
                writer.WriteNumberValue(Amount.Value);
            }
            if (Optional.IsDefined(Comments))
            {
                writer.WritePropertyName("comments");
                writer.WriteStringValue(Comments);
            }
            if (Optional.IsDefined(ProductId))
            {
                writer.WritePropertyName("productId");
                writer.WriteNumberValue(ProductId.Value);
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type.Value.ToString());
            }
            writer.WriteEndObject();
        }
    }
}
