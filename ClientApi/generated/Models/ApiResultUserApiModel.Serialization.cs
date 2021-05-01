// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class ApiResultUserApiModel
    {
        internal static ApiResultUserApiModel DeserializeApiResultUserApiModel(JsonElement element)
        {
            Optional<UserApiModel> data = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("data"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    data = UserApiModel.DeserializeUserApiModel(property.Value);
                    continue;
                }
            }
            return new ApiResultUserApiModel(data.Value);
        }
    }
}
