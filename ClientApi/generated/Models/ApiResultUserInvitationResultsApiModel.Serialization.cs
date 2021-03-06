// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class ApiResultUserInvitationResultsApiModel
    {
        internal static ApiResultUserInvitationResultsApiModel DeserializeApiResultUserInvitationResultsApiModel(JsonElement element)
        {
            Optional<UserInvitationResultsApiModel> data = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("data"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    data = UserInvitationResultsApiModel.DeserializeUserInvitationResultsApiModel(property.Value);
                    continue;
                }
            }
            return new ApiResultUserInvitationResultsApiModel(data.Value);
        }
    }
}
