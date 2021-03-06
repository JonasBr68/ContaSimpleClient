// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Xml.Linq;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class DeliveryNoteApiModel
    {
        internal static DeliveryNoteApiModel DeserializeDeliveryNoteApiModel(JsonElement element)
        {
            Optional<DateTimeOffset> deliveryNoteDate = default;
            Optional<string> entityString = default;
            Optional<string> footer = default;
            Optional<long> id = default;
            Optional<DateTimeOffset> issueDate = default;
            Optional<DocumentEntityApiModel> issuer = default;
            Optional<DateTimeOffset> lastUpdateDate = default;
            Optional<IReadOnlyList<DeliveryNoteLineApiModel>> lines = default;
            Optional<string> notes = default;
            Optional<string> number = default;
            Optional<long> numberingFormatId = default;
            Optional<long> originalIssuerEntityID = default;
            Optional<long> originalTargetEntityID = default;
            Optional<long> relatedEstimateId = default;
            Optional<double> retentionAmount = default;
            Optional<double> retentionPercentage = default;
            Optional<DeliveryNoteApiModelStatus> status = default;
            Optional<DocumentEntityApiModel> target = default;
            Optional<double> totalAmount = default;
            Optional<double> totalReAmount = default;
            Optional<double> totalTaxableAmount = default;
            Optional<double> totalVatAmount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deliveryNoteDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    deliveryNoteDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("entityString"))
                {
                    entityString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("footer"))
                {
                    footer = property.Value.GetString();
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
                if (property.NameEquals("issueDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    issueDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("issuer"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    issuer = DocumentEntityApiModel.DeserializeDocumentEntityApiModel(property.Value);
                    continue;
                }
                if (property.NameEquals("lastUpdateDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastUpdateDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lines"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DeliveryNoteLineApiModel> array = new List<DeliveryNoteLineApiModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeliveryNoteLineApiModel.DeserializeDeliveryNoteLineApiModel(item));
                    }
                    lines = array;
                    continue;
                }
                if (property.NameEquals("notes"))
                {
                    notes = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("number"))
                {
                    number = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("numberingFormatId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    numberingFormatId = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("originalIssuerEntityID"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    originalIssuerEntityID = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("originalTargetEntityID"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    originalTargetEntityID = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("relatedEstimateId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    relatedEstimateId = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("retentionAmount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    retentionAmount = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("retentionPercentage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    retentionPercentage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = new DeliveryNoteApiModelStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("target"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    target = DocumentEntityApiModel.DeserializeDocumentEntityApiModel(property.Value);
                    continue;
                }
                if (property.NameEquals("totalAmount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalAmount = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("totalReAmount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalReAmount = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("totalTaxableAmount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalTaxableAmount = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("totalVatAmount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalVatAmount = property.Value.GetDouble();
                    continue;
                }
            }
            return new DeliveryNoteApiModel(Optional.ToNullable(deliveryNoteDate), entityString.Value, footer.Value, Optional.ToNullable(id), Optional.ToNullable(issueDate), issuer.Value, Optional.ToNullable(lastUpdateDate), Optional.ToList(lines), notes.Value, number.Value, Optional.ToNullable(numberingFormatId), Optional.ToNullable(originalIssuerEntityID), Optional.ToNullable(originalTargetEntityID), Optional.ToNullable(relatedEstimateId), Optional.ToNullable(retentionAmount), Optional.ToNullable(retentionPercentage), Optional.ToNullable(status), target.Value, Optional.ToNullable(totalAmount), Optional.ToNullable(totalReAmount), Optional.ToNullable(totalTaxableAmount), Optional.ToNullable(totalVatAmount));
        }

        internal static DeliveryNoteApiModel DeserializeDeliveryNoteApiModel(XElement element)
        {
            DateTimeOffset? deliveryNoteDate = default;
            string entityString = default;
            string footer = default;
            long? id = default;
            DateTimeOffset? issueDate = default;
            DocumentEntityApiModel issuer = default;
            DateTimeOffset? lastUpdateDate = default;
            string notes = default;
            string number = default;
            long? numberingFormatId = default;
            long? originalIssuerEntityID = default;
            long? originalTargetEntityID = default;
            long? relatedEstimateId = default;
            double? retentionAmount = default;
            double? retentionPercentage = default;
            DeliveryNoteApiModelStatus? status = default;
            DocumentEntityApiModel target = default;
            double? totalAmount = default;
            double? totalReAmount = default;
            double? totalTaxableAmount = default;
            double? totalVatAmount = default;
            IReadOnlyList<DeliveryNoteLineApiModel> lines = default;
            if (element.Element("deliveryNoteDate") is XElement deliveryNoteDateElement)
            {
                deliveryNoteDate = deliveryNoteDateElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("entityString") is XElement entityStringElement)
            {
                entityString = (string)entityStringElement;
            }
            if (element.Element("footer") is XElement footerElement)
            {
                footer = (string)footerElement;
            }
            if (element.Element("id") is XElement idElement)
            {
                id = (long?)idElement;
            }
            if (element.Element("issueDate") is XElement issueDateElement)
            {
                issueDate = issueDateElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("issuer") is XElement issuerElement)
            {
                issuer = DocumentEntityApiModel.DeserializeDocumentEntityApiModel(issuerElement);
            }
            if (element.Element("lastUpdateDate") is XElement lastUpdateDateElement)
            {
                lastUpdateDate = lastUpdateDateElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("notes") is XElement notesElement)
            {
                notes = (string)notesElement;
            }
            if (element.Element("number") is XElement numberElement)
            {
                number = (string)numberElement;
            }
            if (element.Element("numberingFormatId") is XElement numberingFormatIdElement)
            {
                numberingFormatId = (long?)numberingFormatIdElement;
            }
            if (element.Element("originalIssuerEntityID") is XElement originalIssuerEntityIDElement)
            {
                originalIssuerEntityID = (long?)originalIssuerEntityIDElement;
            }
            if (element.Element("originalTargetEntityID") is XElement originalTargetEntityIDElement)
            {
                originalTargetEntityID = (long?)originalTargetEntityIDElement;
            }
            if (element.Element("relatedEstimateId") is XElement relatedEstimateIdElement)
            {
                relatedEstimateId = (long?)relatedEstimateIdElement;
            }
            if (element.Element("retentionAmount") is XElement retentionAmountElement)
            {
                retentionAmount = (double?)retentionAmountElement;
            }
            if (element.Element("retentionPercentage") is XElement retentionPercentageElement)
            {
                retentionPercentage = (double?)retentionPercentageElement;
            }
            if (element.Element("status") is XElement statusElement)
            {
                status = new DeliveryNoteApiModelStatus(statusElement.Value);
            }
            if (element.Element("target") is XElement targetElement)
            {
                target = DocumentEntityApiModel.DeserializeDocumentEntityApiModel(targetElement);
            }
            if (element.Element("totalAmount") is XElement totalAmountElement)
            {
                totalAmount = (double?)totalAmountElement;
            }
            if (element.Element("totalReAmount") is XElement totalReAmountElement)
            {
                totalReAmount = (double?)totalReAmountElement;
            }
            if (element.Element("totalTaxableAmount") is XElement totalTaxableAmountElement)
            {
                totalTaxableAmount = (double?)totalTaxableAmountElement;
            }
            if (element.Element("totalVatAmount") is XElement totalVatAmountElement)
            {
                totalVatAmount = (double?)totalVatAmountElement;
            }
            var array = new List<DeliveryNoteLineApiModel>();
            foreach (var e in element.Elements("DeliveryNoteLineApiModel"))
            {
                array.Add(DeliveryNoteLineApiModel.DeserializeDeliveryNoteLineApiModel(e));
            }
            lines = array;
            return new DeliveryNoteApiModel(deliveryNoteDate, entityString, footer, id, issueDate, issuer, lastUpdateDate, lines, notes, number, numberingFormatId, originalIssuerEntityID, originalTargetEntityID, relatedEstimateId, retentionAmount, retentionPercentage, status, target, totalAmount, totalReAmount, totalTaxableAmount, totalVatAmount);
        }
    }
}
