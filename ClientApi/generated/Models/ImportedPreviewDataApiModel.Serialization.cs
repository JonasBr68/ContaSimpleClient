// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class ImportedPreviewDataApiModel
    {
        internal static ImportedPreviewDataApiModel DeserializeImportedPreviewDataApiModel(JsonElement element)
        {
            Optional<int> fileTotalColumns = default;
            Optional<int> fileTotalLines = default;
            Optional<int> headersLine = default;
            Optional<IReadOnlyList<IList<string>>> importedSampleData = default;
            Optional<bool> isMaxColumnsExceeded = default;
            Optional<IReadOnlyList<ImportMappingPropertyApiModel>> mappingProperties = default;
            Optional<int> startAtLine = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fileTotalColumns"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fileTotalColumns = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("fileTotalLines"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fileTotalLines = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("headersLine"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    headersLine = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("importedSampleData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<IList<string>> array = new List<IList<string>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        List<string> array0 = new List<string>();
                        foreach (var item0 in item.EnumerateArray())
                        {
                            array0.Add(item0.GetString());
                        }
                        array.Add(array0);
                    }
                    importedSampleData = array;
                    continue;
                }
                if (property.NameEquals("isMaxColumnsExceeded"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isMaxColumnsExceeded = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("mappingProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ImportMappingPropertyApiModel> array = new List<ImportMappingPropertyApiModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ImportMappingPropertyApiModel.DeserializeImportMappingPropertyApiModel(item));
                    }
                    mappingProperties = array;
                    continue;
                }
                if (property.NameEquals("startAtLine"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startAtLine = property.Value.GetInt32();
                    continue;
                }
            }
            return new ImportedPreviewDataApiModel(Optional.ToNullable(fileTotalColumns), Optional.ToNullable(fileTotalLines), Optional.ToNullable(headersLine), Optional.ToList(importedSampleData), Optional.ToNullable(isMaxColumnsExceeded), Optional.ToList(mappingProperties), Optional.ToNullable(startAtLine));
        }
    }
}
