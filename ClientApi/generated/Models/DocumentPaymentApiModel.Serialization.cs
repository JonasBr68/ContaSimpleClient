// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Xml.Linq;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class DocumentPaymentApiModel
    {
        internal static DocumentPaymentApiModel DeserializeDocumentPaymentApiModel(JsonElement element)
        {
            Optional<double> amount = default;
            Optional<DateTimeOffset> date = default;
            Optional<long> id = default;
            Optional<PaymentMethodApiModel> paymentMethod = default;
            Optional<string> paymentMethodName = default;
            Optional<string> paymentMethodNumber = default;
            Optional<string> paymentMethodType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("amount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    amount = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("date"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    date = property.Value.GetDateTimeOffset("O");
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
                if (property.NameEquals("paymentMethod"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    paymentMethod = PaymentMethodApiModel.DeserializePaymentMethodApiModel(property.Value);
                    continue;
                }
                if (property.NameEquals("paymentMethodName"))
                {
                    paymentMethodName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("paymentMethodNumber"))
                {
                    paymentMethodNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("paymentMethodType"))
                {
                    paymentMethodType = property.Value.GetString();
                    continue;
                }
            }
            return new DocumentPaymentApiModel(Optional.ToNullable(amount), Optional.ToNullable(date), Optional.ToNullable(id), paymentMethod.Value, paymentMethodName.Value, paymentMethodNumber.Value, paymentMethodType.Value);
        }

        internal static DocumentPaymentApiModel DeserializeDocumentPaymentApiModel(XElement element)
        {
            double? amount = default;
            DateTimeOffset? date = default;
            long? id = default;
            PaymentMethodApiModel paymentMethod = default;
            string paymentMethodName = default;
            string paymentMethodNumber = default;
            string paymentMethodType = default;
            if (element.Element("amount") is XElement amountElement)
            {
                amount = (double?)amountElement;
            }
            if (element.Element("date") is XElement dateElement)
            {
                date = dateElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("id") is XElement idElement)
            {
                id = (long?)idElement;
            }
            if (element.Element("paymentMethod") is XElement paymentMethodElement)
            {
                paymentMethod = PaymentMethodApiModel.DeserializePaymentMethodApiModel(paymentMethodElement);
            }
            if (element.Element("paymentMethodName") is XElement paymentMethodNameElement)
            {
                paymentMethodName = (string)paymentMethodNameElement;
            }
            if (element.Element("paymentMethodNumber") is XElement paymentMethodNumberElement)
            {
                paymentMethodNumber = (string)paymentMethodNumberElement;
            }
            if (element.Element("paymentMethodType") is XElement paymentMethodTypeElement)
            {
                paymentMethodType = (string)paymentMethodTypeElement;
            }
            return new DocumentPaymentApiModel(amount, date, id, paymentMethod, paymentMethodName, paymentMethodNumber, paymentMethodType);
        }
    }
}
