// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class ConfigureCompanyEntityApiModel : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Address))
            {
                writer.WritePropertyName("address");
                writer.WriteStringValue(Address);
            }
            if (Optional.IsDefined(City))
            {
                writer.WritePropertyName("city");
                writer.WriteStringValue(City);
            }
            if (Optional.IsDefined(CompanyId))
            {
                writer.WritePropertyName("companyId");
                writer.WriteNumberValue(CompanyId.Value);
            }
            if (Optional.IsDefined(Country))
            {
                writer.WritePropertyName("country");
                writer.WriteStringValue(Country);
            }
            if (Optional.IsDefined(CountryId))
            {
                writer.WritePropertyName("countryId");
                writer.WriteNumberValue(CountryId.Value);
            }
            if (Optional.IsDefined(CustomField1))
            {
                writer.WritePropertyName("customField1");
                writer.WriteStringValue(CustomField1);
            }
            if (Optional.IsDefined(CustomField2))
            {
                writer.WritePropertyName("customField2");
                writer.WriteStringValue(CustomField2);
            }
            if (Optional.IsDefined(Email))
            {
                writer.WritePropertyName("email");
                writer.WriteStringValue(Email);
            }
            if (Optional.IsDefined(Fax))
            {
                writer.WritePropertyName("fax");
                writer.WriteStringValue(Fax);
            }
            if (Optional.IsDefined(Firstname))
            {
                writer.WritePropertyName("firstname");
                writer.WriteStringValue(Firstname);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteNumberValue(Id.Value);
            }
            if (Optional.IsDefined(Lastname))
            {
                writer.WritePropertyName("lastname");
                writer.WriteStringValue(Lastname);
            }
            if (Optional.IsDefined(Latitude))
            {
                writer.WritePropertyName("latitude");
                writer.WriteNumberValue(Latitude.Value);
            }
            if (Optional.IsDefined(Longitude))
            {
                writer.WritePropertyName("longitude");
                writer.WriteNumberValue(Longitude.Value);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("nif");
            writer.WriteStringValue(Nif);
            if (Optional.IsDefined(Notes))
            {
                writer.WritePropertyName("notes");
                writer.WriteStringValue(Notes);
            }
            writer.WritePropertyName("organization");
            writer.WriteStringValue(Organization);
            if (Optional.IsDefined(Phone))
            {
                writer.WritePropertyName("phone");
                writer.WriteStringValue(Phone);
            }
            if (Optional.IsDefined(PostalCode))
            {
                writer.WritePropertyName("postalCode");
                writer.WriteStringValue(PostalCode);
            }
            if (Optional.IsDefined(Province))
            {
                writer.WritePropertyName("province");
                writer.WriteStringValue(Province);
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type.Value.ToString());
            }
            if (Optional.IsDefined(Url))
            {
                writer.WritePropertyName("url");
                writer.WriteStringValue(Url);
            }
            writer.WriteEndObject();
        }
    }
}
