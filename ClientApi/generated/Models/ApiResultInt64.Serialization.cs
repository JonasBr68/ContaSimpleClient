// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class ApiResultInt64
    {
        internal static ApiResultInt64 DeserializeApiResultInt64(JsonElement element)
        {
            Optional<long> data = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("data"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    data = property.Value.GetInt64();
                    continue;
                }
            }
            return new ApiResultInt64(Optional.ToNullable(data));
        }
    }
}
