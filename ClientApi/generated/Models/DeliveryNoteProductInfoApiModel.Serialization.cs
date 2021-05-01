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
    public partial class DeliveryNoteProductInfoApiModel
    {
        internal static DeliveryNoteProductInfoApiModel DeserializeDeliveryNoteProductInfoApiModel(JsonElement element)
        {
            Optional<IReadOnlyList<DocumentStockControlledInfoApiModel>> documents = default;
            Optional<long> productId = default;
            Optional<string> productName = default;
            Optional<string> productNameSKU = default;
            Optional<string> productSKU = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("documents"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DocumentStockControlledInfoApiModel> array = new List<DocumentStockControlledInfoApiModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentStockControlledInfoApiModel.DeserializeDocumentStockControlledInfoApiModel(item));
                    }
                    documents = array;
                    continue;
                }
                if (property.NameEquals("productId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    productId = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("productName"))
                {
                    productName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("productNameSKU"))
                {
                    productNameSKU = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("productSKU"))
                {
                    productSKU = property.Value.GetString();
                    continue;
                }
            }
            return new DeliveryNoteProductInfoApiModel(Optional.ToList(documents), Optional.ToNullable(productId), productName.Value, productNameSKU.Value, productSKU.Value);
        }

        internal static DeliveryNoteProductInfoApiModel DeserializeDeliveryNoteProductInfoApiModel(XElement element)
        {
            long? productId = default;
            string productName = default;
            string productNameSKU = default;
            string productSKU = default;
            IReadOnlyList<DocumentStockControlledInfoApiModel> documents = default;
            if (element.Element("productId") is XElement productIdElement)
            {
                productId = (long?)productIdElement;
            }
            if (element.Element("productName") is XElement productNameElement)
            {
                productName = (string)productNameElement;
            }
            if (element.Element("productNameSKU") is XElement productNameSKUElement)
            {
                productNameSKU = (string)productNameSKUElement;
            }
            if (element.Element("productSKU") is XElement productSKUElement)
            {
                productSKU = (string)productSKUElement;
            }
            var array = new List<DocumentStockControlledInfoApiModel>();
            foreach (var e in element.Elements("DocumentStockControlledInfoApiModel"))
            {
                array.Add(DocumentStockControlledInfoApiModel.DeserializeDocumentStockControlledInfoApiModel(e));
            }
            documents = array;
            return new DeliveryNoteProductInfoApiModel(documents, productId, productName, productNameSKU, productSKU);
        }
    }
}
