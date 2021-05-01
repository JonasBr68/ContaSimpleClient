// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class CompanyDomainConfigurationApiModel
    {
        internal static CompanyDomainConfigurationApiModel DeserializeCompanyDomainConfigurationApiModel(JsonElement element)
        {
            Optional<string> code = default;
            Optional<long> domainId = default;
            Optional<bool> isAeatCertificationEnabled = default;
            Optional<bool> isDisabledByPendingPayment = default;
            Optional<bool> migrateToContasimpleDomain = default;
            Optional<string> migrateToContasimpleDomainDescription = default;
            Optional<string> name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domainId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    domainId = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("isAeatCertificationEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isAeatCertificationEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isDisabledByPendingPayment"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isDisabledByPendingPayment = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("migrateToContasimpleDomain"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    migrateToContasimpleDomain = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("migrateToContasimpleDomainDescription"))
                {
                    migrateToContasimpleDomainDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new CompanyDomainConfigurationApiModel(code.Value, Optional.ToNullable(domainId), Optional.ToNullable(isAeatCertificationEnabled), Optional.ToNullable(isDisabledByPendingPayment), Optional.ToNullable(migrateToContasimpleDomain), migrateToContasimpleDomainDescription.Value, name.Value);
        }
    }
}
