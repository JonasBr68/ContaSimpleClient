// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class SignFileTaskApiModel
    {
        internal static SignFileTaskApiModel DeserializeSignFileTaskApiModel(JsonElement element)
        {
            Optional<long> fileId = default;
            Optional<string> signedFileName = default;
            Optional<long> taskId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fileId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fileId = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("signedFileName"))
                {
                    signedFileName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("taskId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    taskId = property.Value.GetInt64();
                    continue;
                }
            }
            return new SignFileTaskApiModel(Optional.ToNullable(fileId), signedFileName.Value, Optional.ToNullable(taskId));
        }
    }
}
