// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class ApiResultUpdateUserCompanyRoleApiModel
    {
        internal static ApiResultUpdateUserCompanyRoleApiModel DeserializeApiResultUpdateUserCompanyRoleApiModel(JsonElement element)
        {
            Optional<UpdateUserCompanyRoleApiModel> data = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("data"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    data = UpdateUserCompanyRoleApiModel.DeserializeUpdateUserCompanyRoleApiModel(property.Value);
                    continue;
                }
            }
            return new ApiResultUpdateUserCompanyRoleApiModel(data.Value);
        }
    }
}
