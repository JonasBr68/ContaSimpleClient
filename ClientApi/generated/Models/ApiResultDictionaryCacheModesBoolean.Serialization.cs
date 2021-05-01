// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class ApiResultDictionaryCacheModesBoolean
    {
        internal static ApiResultDictionaryCacheModesBoolean DeserializeApiResultDictionaryCacheModesBoolean(JsonElement element)
        {
            Optional<ApiResultDictionaryCacheModesBooleanData> data = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("data"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    data = ApiResultDictionaryCacheModesBooleanData.DeserializeApiResultDictionaryCacheModesBooleanData(property.Value);
                    continue;
                }
            }
            return new ApiResultDictionaryCacheModesBoolean(data.Value);
        }
    }
}