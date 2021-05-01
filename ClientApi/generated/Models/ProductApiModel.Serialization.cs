// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Xml.Linq;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class ProductApiModel
    {
        internal static ProductApiModel DeserializeProductApiModel(JsonElement element)
        {
            Optional<double> acquisitionCost = default;
            Optional<bool> active = default;
            Optional<bool> allowProductSellWhenNoStock = default;
            Optional<long> categoryId = default;
            Optional<long> companyId = default;
            Optional<double> currentStock = default;
            Optional<string> customField1 = default;
            Optional<string> customField2 = default;
            Optional<string> customField3 = default;
            Optional<string> customField4 = default;
            Optional<string> description = default;
            Optional<double> discountPercentage = default;
            Optional<double> discountedPrice = default;
            Optional<string> externalReference = default;
            Optional<string> fullCategoriesPath = default;
            Optional<long> id = default;
            Optional<string> internalCode = default;
            Optional<bool> isStockCompanyNotificationEnabled = default;
            Optional<bool> isStockControlEnabled = default;
            Optional<bool> isStockEmailNotificationEnabled = default;
            Optional<bool> isStockNotificationDisplayOnDashboardEnabled = default;
            Optional<bool> isStockNotificationEnabled = default;
            Optional<double> minUnitsTriggerAlarm = default;
            Optional<string> name = default;
            Optional<string> notes = default;
            Optional<double> price = default;
            Optional<long> unitTypeId = default;
            Optional<string> unitTypeLongName = default;
            Optional<string> unitTypeShortName = default;
            Optional<double> vat = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("acquisitionCost"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    acquisitionCost = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("active"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    active = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowProductSellWhenNoStock"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    allowProductSellWhenNoStock = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("categoryId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    categoryId = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("companyId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    companyId = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("currentStock"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    currentStock = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("customField1"))
                {
                    customField1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customField2"))
                {
                    customField2 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customField3"))
                {
                    customField3 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customField4"))
                {
                    customField4 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("discountPercentage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    discountPercentage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("discountedPrice"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    discountedPrice = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("externalReference"))
                {
                    externalReference = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fullCategoriesPath"))
                {
                    fullCategoriesPath = property.Value.GetString();
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
                if (property.NameEquals("internalCode"))
                {
                    internalCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isStockCompanyNotificationEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isStockCompanyNotificationEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isStockControlEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isStockControlEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isStockEmailNotificationEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isStockEmailNotificationEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isStockNotificationDisplayOnDashboardEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isStockNotificationDisplayOnDashboardEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isStockNotificationEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isStockNotificationEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("minUnitsTriggerAlarm"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minUnitsTriggerAlarm = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("notes"))
                {
                    notes = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("price"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    price = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("unitTypeId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    unitTypeId = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("unitTypeLongName"))
                {
                    unitTypeLongName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unitTypeShortName"))
                {
                    unitTypeShortName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vat"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    vat = property.Value.GetDouble();
                    continue;
                }
            }
            return new ProductApiModel(Optional.ToNullable(acquisitionCost), Optional.ToNullable(active), Optional.ToNullable(allowProductSellWhenNoStock), Optional.ToNullable(categoryId), Optional.ToNullable(companyId), Optional.ToNullable(currentStock), customField1.Value, customField2.Value, customField3.Value, customField4.Value, description.Value, Optional.ToNullable(discountPercentage), Optional.ToNullable(discountedPrice), externalReference.Value, fullCategoriesPath.Value, Optional.ToNullable(id), internalCode.Value, Optional.ToNullable(isStockCompanyNotificationEnabled), Optional.ToNullable(isStockControlEnabled), Optional.ToNullable(isStockEmailNotificationEnabled), Optional.ToNullable(isStockNotificationDisplayOnDashboardEnabled), Optional.ToNullable(isStockNotificationEnabled), Optional.ToNullable(minUnitsTriggerAlarm), name.Value, notes.Value, Optional.ToNullable(price), Optional.ToNullable(unitTypeId), unitTypeLongName.Value, unitTypeShortName.Value, Optional.ToNullable(vat));
        }

        internal static ProductApiModel DeserializeProductApiModel(XElement element)
        {
            double? acquisitionCost = default;
            bool? active = default;
            bool? allowProductSellWhenNoStock = default;
            long? categoryId = default;
            long? companyId = default;
            double? currentStock = default;
            string customField1 = default;
            string customField2 = default;
            string customField3 = default;
            string customField4 = default;
            string description = default;
            double? discountPercentage = default;
            double? discountedPrice = default;
            string externalReference = default;
            string fullCategoriesPath = default;
            long? id = default;
            string internalCode = default;
            bool? isStockCompanyNotificationEnabled = default;
            bool? isStockControlEnabled = default;
            bool? isStockEmailNotificationEnabled = default;
            bool? isStockNotificationDisplayOnDashboardEnabled = default;
            bool? isStockNotificationEnabled = default;
            double? minUnitsTriggerAlarm = default;
            string name = default;
            string notes = default;
            double? price = default;
            long? unitTypeId = default;
            string unitTypeLongName = default;
            string unitTypeShortName = default;
            double? vat = default;
            if (element.Element("acquisitionCost") is XElement acquisitionCostElement)
            {
                acquisitionCost = (double?)acquisitionCostElement;
            }
            if (element.Element("active") is XElement activeElement)
            {
                active = (bool?)activeElement;
            }
            if (element.Element("allowProductSellWhenNoStock") is XElement allowProductSellWhenNoStockElement)
            {
                allowProductSellWhenNoStock = (bool?)allowProductSellWhenNoStockElement;
            }
            if (element.Element("categoryId") is XElement categoryIdElement)
            {
                categoryId = (long?)categoryIdElement;
            }
            if (element.Element("companyId") is XElement companyIdElement)
            {
                companyId = (long?)companyIdElement;
            }
            if (element.Element("currentStock") is XElement currentStockElement)
            {
                currentStock = (double?)currentStockElement;
            }
            if (element.Element("customField1") is XElement customField1Element)
            {
                customField1 = (string)customField1Element;
            }
            if (element.Element("customField2") is XElement customField2Element)
            {
                customField2 = (string)customField2Element;
            }
            if (element.Element("customField3") is XElement customField3Element)
            {
                customField3 = (string)customField3Element;
            }
            if (element.Element("customField4") is XElement customField4Element)
            {
                customField4 = (string)customField4Element;
            }
            if (element.Element("description") is XElement descriptionElement)
            {
                description = (string)descriptionElement;
            }
            if (element.Element("discountPercentage") is XElement discountPercentageElement)
            {
                discountPercentage = (double?)discountPercentageElement;
            }
            if (element.Element("discountedPrice") is XElement discountedPriceElement)
            {
                discountedPrice = (double?)discountedPriceElement;
            }
            if (element.Element("externalReference") is XElement externalReferenceElement)
            {
                externalReference = (string)externalReferenceElement;
            }
            if (element.Element("fullCategoriesPath") is XElement fullCategoriesPathElement)
            {
                fullCategoriesPath = (string)fullCategoriesPathElement;
            }
            if (element.Element("id") is XElement idElement)
            {
                id = (long?)idElement;
            }
            if (element.Element("internalCode") is XElement internalCodeElement)
            {
                internalCode = (string)internalCodeElement;
            }
            if (element.Element("isStockCompanyNotificationEnabled") is XElement isStockCompanyNotificationEnabledElement)
            {
                isStockCompanyNotificationEnabled = (bool?)isStockCompanyNotificationEnabledElement;
            }
            if (element.Element("isStockControlEnabled") is XElement isStockControlEnabledElement)
            {
                isStockControlEnabled = (bool?)isStockControlEnabledElement;
            }
            if (element.Element("isStockEmailNotificationEnabled") is XElement isStockEmailNotificationEnabledElement)
            {
                isStockEmailNotificationEnabled = (bool?)isStockEmailNotificationEnabledElement;
            }
            if (element.Element("isStockNotificationDisplayOnDashboardEnabled") is XElement isStockNotificationDisplayOnDashboardEnabledElement)
            {
                isStockNotificationDisplayOnDashboardEnabled = (bool?)isStockNotificationDisplayOnDashboardEnabledElement;
            }
            if (element.Element("isStockNotificationEnabled") is XElement isStockNotificationEnabledElement)
            {
                isStockNotificationEnabled = (bool?)isStockNotificationEnabledElement;
            }
            if (element.Element("minUnitsTriggerAlarm") is XElement minUnitsTriggerAlarmElement)
            {
                minUnitsTriggerAlarm = (double?)minUnitsTriggerAlarmElement;
            }
            if (element.Element("name") is XElement nameElement)
            {
                name = (string)nameElement;
            }
            if (element.Element("notes") is XElement notesElement)
            {
                notes = (string)notesElement;
            }
            if (element.Element("price") is XElement priceElement)
            {
                price = (double?)priceElement;
            }
            if (element.Element("unitTypeId") is XElement unitTypeIdElement)
            {
                unitTypeId = (long?)unitTypeIdElement;
            }
            if (element.Element("unitTypeLongName") is XElement unitTypeLongNameElement)
            {
                unitTypeLongName = (string)unitTypeLongNameElement;
            }
            if (element.Element("unitTypeShortName") is XElement unitTypeShortNameElement)
            {
                unitTypeShortName = (string)unitTypeShortNameElement;
            }
            if (element.Element("vat") is XElement vatElement)
            {
                vat = (double?)vatElement;
            }
            return new ProductApiModel(acquisitionCost, active, allowProductSellWhenNoStock, categoryId, companyId, currentStock, customField1, customField2, customField3, customField4, description, discountPercentage, discountedPrice, externalReference, fullCategoriesPath, id, internalCode, isStockCompanyNotificationEnabled, isStockControlEnabled, isStockEmailNotificationEnabled, isStockNotificationDisplayOnDashboardEnabled, isStockNotificationEnabled, minUnitsTriggerAlarm, name, notes, price, unitTypeId, unitTypeLongName, unitTypeShortName, vat);
        }
    }
}
