// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class AccountingAmortizationSummaryApiModel
    {
        internal static AccountingAmortizationSummaryApiModel DeserializeAccountingAmortizationSummaryApiModel(JsonElement element)
        {
            Optional<int> numberOfInvoices = default;
            Optional<double> totalAmount = default;
            Optional<double> totalComputableAmount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("numberOfInvoices"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    numberOfInvoices = property.Value.GetInt32();
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
                if (property.NameEquals("totalComputableAmount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalComputableAmount = property.Value.GetDouble();
                    continue;
                }
            }
            return new AccountingAmortizationSummaryApiModel(Optional.ToNullable(numberOfInvoices), Optional.ToNullable(totalAmount), Optional.ToNullable(totalComputableAmount));
        }
    }
}
