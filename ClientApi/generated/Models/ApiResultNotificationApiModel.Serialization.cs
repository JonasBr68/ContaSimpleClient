// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class ApiResultNotificationApiModel
    {
        internal static ApiResultNotificationApiModel DeserializeApiResultNotificationApiModel(JsonElement element)
        {
            Optional<NotificationApiModel> data = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("data"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    data = NotificationApiModel.DeserializeNotificationApiModel(property.Value);
                    continue;
                }
            }
            return new ApiResultNotificationApiModel(data.Value);
        }
    }
}
