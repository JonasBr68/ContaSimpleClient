// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class ApiResultCompanyFullInfoApiModel
    {
        internal static ApiResultCompanyFullInfoApiModel DeserializeApiResultCompanyFullInfoApiModel(JsonElement element)
        {
            Optional<CompanyFullInfoApiModel> data = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("data"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    data = CompanyFullInfoApiModel.DeserializeCompanyFullInfoApiModel(property.Value);
                    continue;
                }
            }
            return new ApiResultCompanyFullInfoApiModel(data.Value);
        }
    }
}
