// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class ElectronicSignatureConfigurationApiModel
    {
        internal static ElectronicSignatureConfigurationApiModel DeserializeElectronicSignatureConfigurationApiModel(JsonElement element)
        {
            Optional<bool> hasCompanyCertificate = default;
            Optional<bool> hasDomainCertificate = default;
            Optional<ElectronicSignatureConfigurationApiModelPlanType> planType = default;
            Optional<ElectronicSignatureConfigurationApiModelSignElectronicInvoices> signElectronicInvoices = default;
            Optional<ElectronicSignatureConfigurationApiModelSignPDFDeliveryNotes> signPDFDeliveryNotes = default;
            Optional<ElectronicSignatureConfigurationApiModelSignPDFEstimates> signPDFEstimates = default;
            Optional<ElectronicSignatureConfigurationApiModelSignPDFInvoices> signPDFInvoices = default;
            Optional<ElectronicSignatureConfigurationApiModelSignVirtualDriveFiles> signVirtualDriveFiles = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hasCompanyCertificate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    hasCompanyCertificate = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("hasDomainCertificate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    hasDomainCertificate = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("planType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    planType = new ElectronicSignatureConfigurationApiModelPlanType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("signElectronicInvoices"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    signElectronicInvoices = new ElectronicSignatureConfigurationApiModelSignElectronicInvoices(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("signPDFDeliveryNotes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    signPDFDeliveryNotes = new ElectronicSignatureConfigurationApiModelSignPDFDeliveryNotes(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("signPDFEstimates"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    signPDFEstimates = new ElectronicSignatureConfigurationApiModelSignPDFEstimates(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("signPDFInvoices"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    signPDFInvoices = new ElectronicSignatureConfigurationApiModelSignPDFInvoices(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("signVirtualDriveFiles"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    signVirtualDriveFiles = new ElectronicSignatureConfigurationApiModelSignVirtualDriveFiles(property.Value.GetString());
                    continue;
                }
            }
            return new ElectronicSignatureConfigurationApiModel(Optional.ToNullable(hasCompanyCertificate), Optional.ToNullable(hasDomainCertificate), Optional.ToNullable(planType), Optional.ToNullable(signElectronicInvoices), Optional.ToNullable(signPDFDeliveryNotes), Optional.ToNullable(signPDFEstimates), Optional.ToNullable(signPDFInvoices), Optional.ToNullable(signVirtualDriveFiles));
        }
    }
}
