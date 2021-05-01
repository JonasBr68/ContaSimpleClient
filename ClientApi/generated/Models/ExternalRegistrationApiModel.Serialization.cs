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
    public partial class ExternalRegistrationApiModel
    {
        internal static ExternalRegistrationApiModel DeserializeExternalRegistrationApiModel(JsonElement element)
        {
            Optional<string> companyContactEmail = default;
            Optional<long> companyId = default;
            Optional<string> companyName = default;
            Optional<string> companyNif = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<string> email = default;
            Optional<string> externalReference = default;
            Optional<long> id = default;
            Optional<string> integrationCode = default;
            Optional<bool> isCompanyRemoved = default;
            Optional<bool> isUserRemoved = default;
            Optional<DateTimeOffset> lastUpdateTime = default;
            Optional<DateTimeOffset> startDate = default;
            Optional<ExternalRegistrationApiModelStatus> status = default;
            Optional<string> statusDescription = default;
            Optional<DateTimeOffset> terminationDate = default;
            Optional<string> userContactEmail = default;
            Optional<long> userId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("companyContactEmail"))
                {
                    companyContactEmail = property.Value.GetString();
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
                if (property.NameEquals("companyName"))
                {
                    companyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("companyNif"))
                {
                    companyNif = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("creationTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    creationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("email"))
                {
                    email = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("externalReference"))
                {
                    externalReference = property.Value.GetString();
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
                if (property.NameEquals("integrationCode"))
                {
                    integrationCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isCompanyRemoved"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isCompanyRemoved = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isUserRemoved"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isUserRemoved = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("lastUpdateTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastUpdateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("startDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = new ExternalRegistrationApiModelStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("statusDescription"))
                {
                    statusDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("terminationDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    terminationDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("userContactEmail"))
                {
                    userContactEmail = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    userId = property.Value.GetInt64();
                    continue;
                }
            }
            return new ExternalRegistrationApiModel(companyContactEmail.Value, Optional.ToNullable(companyId), companyName.Value, companyNif.Value, Optional.ToNullable(creationTime), email.Value, externalReference.Value, Optional.ToNullable(id), integrationCode.Value, Optional.ToNullable(isCompanyRemoved), Optional.ToNullable(isUserRemoved), Optional.ToNullable(lastUpdateTime), Optional.ToNullable(startDate), Optional.ToNullable(status), statusDescription.Value, Optional.ToNullable(terminationDate), userContactEmail.Value, Optional.ToNullable(userId));
        }

        internal static ExternalRegistrationApiModel DeserializeExternalRegistrationApiModel(XElement element)
        {
            string companyContactEmail = default;
            long? companyId = default;
            string companyName = default;
            string companyNif = default;
            DateTimeOffset? creationTime = default;
            string email = default;
            string externalReference = default;
            long? id = default;
            string integrationCode = default;
            bool? isCompanyRemoved = default;
            bool? isUserRemoved = default;
            DateTimeOffset? lastUpdateTime = default;
            DateTimeOffset? startDate = default;
            ExternalRegistrationApiModelStatus? status = default;
            string statusDescription = default;
            DateTimeOffset? terminationDate = default;
            string userContactEmail = default;
            long? userId = default;
            if (element.Element("companyContactEmail") is XElement companyContactEmailElement)
            {
                companyContactEmail = (string)companyContactEmailElement;
            }
            if (element.Element("companyId") is XElement companyIdElement)
            {
                companyId = (long?)companyIdElement;
            }
            if (element.Element("companyName") is XElement companyNameElement)
            {
                companyName = (string)companyNameElement;
            }
            if (element.Element("companyNif") is XElement companyNifElement)
            {
                companyNif = (string)companyNifElement;
            }
            if (element.Element("creationTime") is XElement creationTimeElement)
            {
                creationTime = creationTimeElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("email") is XElement emailElement)
            {
                email = (string)emailElement;
            }
            if (element.Element("externalReference") is XElement externalReferenceElement)
            {
                externalReference = (string)externalReferenceElement;
            }
            if (element.Element("id") is XElement idElement)
            {
                id = (long?)idElement;
            }
            if (element.Element("integrationCode") is XElement integrationCodeElement)
            {
                integrationCode = (string)integrationCodeElement;
            }
            if (element.Element("isCompanyRemoved") is XElement isCompanyRemovedElement)
            {
                isCompanyRemoved = (bool?)isCompanyRemovedElement;
            }
            if (element.Element("isUserRemoved") is XElement isUserRemovedElement)
            {
                isUserRemoved = (bool?)isUserRemovedElement;
            }
            if (element.Element("lastUpdateTime") is XElement lastUpdateTimeElement)
            {
                lastUpdateTime = lastUpdateTimeElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("startDate") is XElement startDateElement)
            {
                startDate = startDateElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("status") is XElement statusElement)
            {
                status = new ExternalRegistrationApiModelStatus(statusElement.Value);
            }
            if (element.Element("statusDescription") is XElement statusDescriptionElement)
            {
                statusDescription = (string)statusDescriptionElement;
            }
            if (element.Element("terminationDate") is XElement terminationDateElement)
            {
                terminationDate = terminationDateElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("userContactEmail") is XElement userContactEmailElement)
            {
                userContactEmail = (string)userContactEmailElement;
            }
            if (element.Element("userId") is XElement userIdElement)
            {
                userId = (long?)userIdElement;
            }
            return new ExternalRegistrationApiModel(companyContactEmail, companyId, companyName, companyNif, creationTime, email, externalReference, id, integrationCode, isCompanyRemoved, isUserRemoved, lastUpdateTime, startDate, status, statusDescription, terminationDate, userContactEmail, userId);
        }
    }
}