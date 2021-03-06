// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class Version
    {
        internal static Version DeserializeVersion(JsonElement element)
        {
            Optional<int> build = default;
            Optional<int> major = default;
            Optional<int> majorRevision = default;
            Optional<int> minor = default;
            Optional<int> minorRevision = default;
            Optional<int> revision = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("build"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    build = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("major"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    major = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("majorRevision"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    majorRevision = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minor"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minor = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minorRevision"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minorRevision = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("revision"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    revision = property.Value.GetInt32();
                    continue;
                }
            }
            return new Version(Optional.ToNullable(build), Optional.ToNullable(major), Optional.ToNullable(majorRevision), Optional.ToNullable(minor), Optional.ToNullable(minorRevision), Optional.ToNullable(revision));
        }
    }
}
