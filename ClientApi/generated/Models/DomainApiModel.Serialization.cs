// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Xml.Linq;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class DomainApiModel
    {
        internal static DomainApiModel DeserializeDomainApiModel(JsonElement element)
        {
            Optional<ApiClientWithSecretApiModel> apiClient = default;
            Optional<string> code = default;
            Optional<long> defaultCountry = default;
            Optional<string> defaultCulture = default;
            Optional<bool> enableEInformaIntegration = default;
            Optional<string> hostname = default;
            Optional<long> id = default;
            Optional<string> name = default;
            Optional<string> secureKey = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("apiClient"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    apiClient = ApiClientWithSecretApiModel.DeserializeApiClientWithSecretApiModel(property.Value);
                    continue;
                }
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultCountry"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    defaultCountry = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("defaultCulture"))
                {
                    defaultCulture = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enableEInformaIntegration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enableEInformaIntegration = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("hostname"))
                {
                    hostname = property.Value.GetString();
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
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secureKey"))
                {
                    secureKey = property.Value.GetString();
                    continue;
                }
            }
            return new DomainApiModel(apiClient.Value, code.Value, Optional.ToNullable(defaultCountry), defaultCulture.Value, Optional.ToNullable(enableEInformaIntegration), hostname.Value, Optional.ToNullable(id), name.Value, secureKey.Value);
        }

        internal static DomainApiModel DeserializeDomainApiModel(XElement element)
        {
            ApiClientWithSecretApiModel apiClient = default;
            string code = default;
            long? defaultCountry = default;
            string defaultCulture = default;
            bool? enableEInformaIntegration = default;
            string hostname = default;
            long? id = default;
            string name = default;
            string secureKey = default;
            if (element.Element("apiClient") is XElement apiClientElement)
            {
                apiClient = ApiClientWithSecretApiModel.DeserializeApiClientWithSecretApiModel(apiClientElement);
            }
            if (element.Element("code") is XElement codeElement)
            {
                code = (string)codeElement;
            }
            if (element.Element("defaultCountry") is XElement defaultCountryElement)
            {
                defaultCountry = (long?)defaultCountryElement;
            }
            if (element.Element("defaultCulture") is XElement defaultCultureElement)
            {
                defaultCulture = (string)defaultCultureElement;
            }
            if (element.Element("enableEInformaIntegration") is XElement enableEInformaIntegrationElement)
            {
                enableEInformaIntegration = (bool?)enableEInformaIntegrationElement;
            }
            if (element.Element("hostname") is XElement hostnameElement)
            {
                hostname = (string)hostnameElement;
            }
            if (element.Element("id") is XElement idElement)
            {
                id = (long?)idElement;
            }
            if (element.Element("name") is XElement nameElement)
            {
                name = (string)nameElement;
            }
            if (element.Element("secureKey") is XElement secureKeyElement)
            {
                secureKey = (string)secureKeyElement;
            }
            return new DomainApiModel(apiClient, code, defaultCountry, defaultCulture, enableEInformaIntegration, hostname, id, name, secureKey);
        }
    }
}