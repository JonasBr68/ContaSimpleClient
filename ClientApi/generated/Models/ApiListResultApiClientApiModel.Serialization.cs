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
    public partial class ApiListResultApiClientApiModel
    {
        internal static ApiListResultApiClientApiModel DeserializeApiListResultApiClientApiModel(JsonElement element)
        {
            Optional<long> count = default;
            Optional<IReadOnlyList<ApiClientApiModel>> data = default;
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
                    List<ApiClientApiModel> array = new List<ApiClientApiModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApiClientApiModel.DeserializeApiClientApiModel(item));
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
            return new ApiListResultApiClientApiModel(Optional.ToNullable(count), Optional.ToList(data), Optional.ToNullable(totalCount));
        }

        internal static ApiListResultApiClientApiModel DeserializeApiListResultApiClientApiModel(XElement element)
        {
            long? count = default;
            long? totalCount = default;
            IReadOnlyList<ApiClientApiModel> data = default;
            if (element.Element("count") is XElement countElement)
            {
                count = (long?)countElement;
            }
            if (element.Element("totalCount") is XElement totalCountElement)
            {
                totalCount = (long?)totalCountElement;
            }
            var array = new List<ApiClientApiModel>();
            foreach (var e in element.Elements("ApiClientApiModel"))
            {
                array.Add(ApiClientApiModel.DeserializeApiClientApiModel(e));
            }
            data = array;
            return new ApiListResultApiClientApiModel(count, data, totalCount);
        }
    }
}
