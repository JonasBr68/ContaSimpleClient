// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Xml.Linq;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class RetentionTypeApiModel
    {
        internal static RetentionTypeApiModel DeserializeRetentionTypeApiModel(JsonElement element)
        {
            Optional<RetentionTypeApiModelCategory> category = default;
            Optional<long> id = default;
            Optional<bool> isDefault = default;
            Optional<string> name = default;
            Optional<int> order = default;
            Optional<double> percent = default;
            Optional<RetentionTypeApiModelType> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("category"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    category = new RetentionTypeApiModelCategory(property.Value.GetString());
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
                if (property.NameEquals("isDefault"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isDefault = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("order"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    order = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("percent"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    percent = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new RetentionTypeApiModelType(property.Value.GetString());
                    continue;
                }
            }
            return new RetentionTypeApiModel(Optional.ToNullable(category), Optional.ToNullable(id), Optional.ToNullable(isDefault), name.Value, Optional.ToNullable(order), Optional.ToNullable(percent), Optional.ToNullable(type));
        }

        internal static RetentionTypeApiModel DeserializeRetentionTypeApiModel(XElement element)
        {
            RetentionTypeApiModelCategory? category = default;
            long? id = default;
            bool? isDefault = default;
            string name = default;
            int? order = default;
            double? percent = default;
            RetentionTypeApiModelType? type = default;
            if (element.Element("category") is XElement categoryElement)
            {
                category = new RetentionTypeApiModelCategory(categoryElement.Value);
            }
            if (element.Element("id") is XElement idElement)
            {
                id = (long?)idElement;
            }
            if (element.Element("isDefault") is XElement isDefaultElement)
            {
                isDefault = (bool?)isDefaultElement;
            }
            if (element.Element("name") is XElement nameElement)
            {
                name = (string)nameElement;
            }
            if (element.Element("order") is XElement orderElement)
            {
                order = (int?)orderElement;
            }
            if (element.Element("percent") is XElement percentElement)
            {
                percent = (double?)percentElement;
            }
            if (element.Element("type") is XElement typeElement)
            {
                type = new RetentionTypeApiModelType(typeElement.Value);
            }
            return new RetentionTypeApiModel(category, id, isDefault, name, order, percent, type);
        }
    }
}
