// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class PermissionsApiModel
    {
        internal static PermissionsApiModel DeserializePermissionsApiModel(JsonElement element)
        {
            Optional<PermissionsApiModelCompanyRole> companyRole = default;
            Optional<IReadOnlyList<ModulePermissionsApiModel>> modules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("companyRole"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    companyRole = new PermissionsApiModelCompanyRole(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("modules"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ModulePermissionsApiModel> array = new List<ModulePermissionsApiModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ModulePermissionsApiModel.DeserializeModulePermissionsApiModel(item));
                    }
                    modules = array;
                    continue;
                }
            }
            return new PermissionsApiModel(Optional.ToNullable(companyRole), Optional.ToList(modules));
        }
    }
}
