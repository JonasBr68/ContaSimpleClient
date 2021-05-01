// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class CompanySummary
    {
        internal static CompanySummary DeserializeCompanySummary(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> organizationName = default;
            Optional<string> province = default;
            Optional<string> provinceCode = default;
            Optional<string> uid = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("organizationName"))
                {
                    organizationName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("province"))
                {
                    province = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provinceCode"))
                {
                    provinceCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("uid"))
                {
                    uid = property.Value.GetString();
                    continue;
                }
            }
            return new CompanySummary(name.Value, organizationName.Value, province.Value, provinceCode.Value, uid.Value);
        }
    }
}