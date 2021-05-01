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
    public partial class ApiListResultWorkingHoursSumTotalApiModel
    {
        internal static ApiListResultWorkingHoursSumTotalApiModel DeserializeApiListResultWorkingHoursSumTotalApiModel(JsonElement element)
        {
            Optional<long> count = default;
            Optional<IReadOnlyList<WorkingHoursSumTotalApiModel>> data = default;
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
                    List<WorkingHoursSumTotalApiModel> array = new List<WorkingHoursSumTotalApiModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WorkingHoursSumTotalApiModel.DeserializeWorkingHoursSumTotalApiModel(item));
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
            return new ApiListResultWorkingHoursSumTotalApiModel(Optional.ToNullable(count), Optional.ToList(data), Optional.ToNullable(totalCount));
        }

        internal static ApiListResultWorkingHoursSumTotalApiModel DeserializeApiListResultWorkingHoursSumTotalApiModel(XElement element)
        {
            long? count = default;
            long? totalCount = default;
            IReadOnlyList<WorkingHoursSumTotalApiModel> data = default;
            if (element.Element("count") is XElement countElement)
            {
                count = (long?)countElement;
            }
            if (element.Element("totalCount") is XElement totalCountElement)
            {
                totalCount = (long?)totalCountElement;
            }
            var array = new List<WorkingHoursSumTotalApiModel>();
            foreach (var e in element.Elements("WorkingHoursSumTotalApiModel"))
            {
                array.Add(WorkingHoursSumTotalApiModel.DeserializeWorkingHoursSumTotalApiModel(e));
            }
            data = array;
            return new ApiListResultWorkingHoursSumTotalApiModel(count, data, totalCount);
        }
    }
}