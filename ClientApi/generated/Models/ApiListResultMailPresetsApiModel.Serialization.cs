// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using System.Xml.Linq;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class ApiListResultMailPresetsApiModel
    {
        internal static ApiListResultMailPresetsApiModel DeserializeApiListResultMailPresetsApiModel(JsonElement element)
        {
            Optional<long> count = default;
            Optional<IReadOnlyList<MailPresetsApiModel>> data = default;
            Optional<long> totalCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("count"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    count = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("data"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MailPresetsApiModel> array = new List<MailPresetsApiModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MailPresetsApiModel.DeserializeMailPresetsApiModel(item));
                    }
                    data = array;
                    continue;
                }
                if (property.NameEquals("totalCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalCount = property.Value.GetInt64();
                    continue;
                }
            }
            return new ApiListResultMailPresetsApiModel(Optional.ToNullable(count), Optional.ToList(data), Optional.ToNullable(totalCount));
        }

        internal static ApiListResultMailPresetsApiModel DeserializeApiListResultMailPresetsApiModel(XElement element)
        {
            long? count = default;
            long? totalCount = default;
            IReadOnlyList<MailPresetsApiModel> data = default;
            if (element.Element("count") is XElement countElement)
            {
                count = (long?)countElement;
            }
            if (element.Element("totalCount") is XElement totalCountElement)
            {
                totalCount = (long?)totalCountElement;
            }
            var array = new List<MailPresetsApiModel>();
            foreach (var e in element.Elements("MailPresetsApiModel"))
            {
                array.Add(MailPresetsApiModel.DeserializeMailPresetsApiModel(e));
            }
            data = array;
            return new ApiListResultMailPresetsApiModel(count, data, totalCount);
        }
    }
}
