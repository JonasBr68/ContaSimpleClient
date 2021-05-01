// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class ApiResultCountryApiModel
    {
        internal static ApiResultCountryApiModel DeserializeApiResultCountryApiModel(JsonElement element)
        {
            Optional<CountryApiModel> data = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("data"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    data = CountryApiModel.DeserializeCountryApiModel(property.Value);
                    continue;
                }
            }
            return new ApiResultCountryApiModel(data.Value);
        }
    }
}
