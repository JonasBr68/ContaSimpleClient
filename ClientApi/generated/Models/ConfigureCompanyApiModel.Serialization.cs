// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class ConfigureCompanyApiModel : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CompanyTypeId))
            {
                writer.WritePropertyName("companyTypeId");
                writer.WriteNumberValue(CompanyTypeId.Value);
            }
            if (Optional.IsDefined(CountryId))
            {
                writer.WritePropertyName("countryId");
                writer.WriteNumberValue(CountryId.Value);
            }
            if (Optional.IsDefined(Entity))
            {
                writer.WritePropertyName("entity");
                writer.WriteObjectValue(Entity);
            }
            if (Optional.IsDefined(FiscalRegionId))
            {
                writer.WritePropertyName("fiscalRegionId");
                writer.WriteNumberValue(FiscalRegionId.Value);
            }
            if (Optional.IsDefined(IrpfModeId))
            {
                writer.WritePropertyName("irpfModeId");
                writer.WriteNumberValue(IrpfModeId.Value);
            }
            if (Optional.IsDefined(VatModeId))
            {
                writer.WritePropertyName("vatModeId");
                writer.WriteNumberValue(VatModeId.Value);
            }
            writer.WriteEndObject();
        }
    }
}
