// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Xml.Linq;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class UnitTypeApiModel
    {
        internal static UnitTypeApiModel DeserializeUnitTypeApiModel(JsonElement element)
        {
            Optional<string> category = default;
            Optional<long> id = default;
            Optional<string> longName = default;
            Optional<string> shortName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("category"))
                {
                    category = property.Value.GetString();
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
                if (property.NameEquals("longName"))
                {
                    longName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("shortName"))
                {
                    shortName = property.Value.GetString();
                    continue;
                }
            }
            return new UnitTypeApiModel(category.Value, Optional.ToNullable(id), longName.Value, shortName.Value);
        }

        internal static UnitTypeApiModel DeserializeUnitTypeApiModel(XElement element)
        {
            string category = default;
            long? id = default;
            string longName = default;
            string shortName = default;
            if (element.Element("category") is XElement categoryElement)
            {
                category = (string)categoryElement;
            }
            if (element.Element("id") is XElement idElement)
            {
                id = (long?)idElement;
            }
            if (element.Element("longName") is XElement longNameElement)
            {
                longName = (string)longNameElement;
            }
            if (element.Element("shortName") is XElement shortNameElement)
            {
                shortName = (string)shortNameElement;
            }
            return new UnitTypeApiModel(category, id, longName, shortName);
        }
    }
}
