// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class ModulePermissionsApiModel
    {
        internal static ModulePermissionsApiModel DeserializeModulePermissionsApiModel(JsonElement element)
        {
            Optional<IReadOnlyList<ActionPermissionsApiModel>> actions = default;
            Optional<ModulePermissionsApiModelName> name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ActionPermissionsApiModel> array = new List<ActionPermissionsApiModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ActionPermissionsApiModel.DeserializeActionPermissionsApiModel(item));
                    }
                    actions = array;
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    name = new ModulePermissionsApiModelName(property.Value.GetString());
                    continue;
                }
            }
            return new ModulePermissionsApiModel(Optional.ToList(actions), Optional.ToNullable(name));
        }
    }
}
