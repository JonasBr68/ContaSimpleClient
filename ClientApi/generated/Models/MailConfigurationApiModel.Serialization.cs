// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class MailConfigurationApiModel
    {
        internal static MailConfigurationApiModel DeserializeMailConfigurationApiModel(JsonElement element)
        {
            Optional<string> defaultValueReplyTo = default;
            Optional<string> fromEmail = default;
            Optional<string> fromName = default;
            Optional<MailConfigurationApiModelMailProvider> mailProvider = default;
            Optional<bool> shouldHideReplyToAndCopyField = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultValueReplyTo"))
                {
                    defaultValueReplyTo = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fromEmail"))
                {
                    fromEmail = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fromName"))
                {
                    fromName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mailProvider"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    mailProvider = new MailConfigurationApiModelMailProvider(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("shouldHideReplyToAndCopyField"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    shouldHideReplyToAndCopyField = property.Value.GetBoolean();
                    continue;
                }
            }
            return new MailConfigurationApiModel(defaultValueReplyTo.Value, fromEmail.Value, fromName.Value, Optional.ToNullable(mailProvider), Optional.ToNullable(shouldHideReplyToAndCopyField));
        }
    }
}
