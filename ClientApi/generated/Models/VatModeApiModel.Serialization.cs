// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Xml.Linq;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class VatModeApiModel
    {
        internal static VatModeApiModel DeserializeVatModeApiModel(JsonElement element)
        {
            Optional<string> code = default;
            Optional<long> id = default;
            Optional<string> name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    id = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new VatModeApiModel(code.Value, Optional.ToNullable(id), name.Value);
        }

        internal static VatModeApiModel DeserializeVatModeApiModel(XElement element)
        {
            string code = default;
            long? id = default;
            string name = default;
            if (element.Element("code") is XElement codeElement)
            {
                code = (string)codeElement;
            }
            if (element.Element("id") is XElement idElement)
            {
                id = (long?)idElement;
            }
            if (element.Element("name") is XElement nameElement)
            {
                name = (string)nameElement;
            }
            return new VatModeApiModel(code, id, name);
        }
    }
}
