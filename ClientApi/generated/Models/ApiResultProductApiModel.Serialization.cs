// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class ApiResultProductApiModel
    {
        internal static ApiResultProductApiModel DeserializeApiResultProductApiModel(JsonElement element)
        {
            Optional<ProductApiModel> data = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("data"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    data = ProductApiModel.DeserializeProductApiModel(property.Value);
                    continue;
                }
            }
            return new ApiResultProductApiModel(data.Value);
        }
    }
}
