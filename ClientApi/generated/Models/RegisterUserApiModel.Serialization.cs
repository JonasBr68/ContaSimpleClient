// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class RegisterUserApiModel : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Brand))
            {
                writer.WritePropertyName("brand");
                writer.WriteNumberValue(Brand.Value);
            }
            writer.WritePropertyName("clientId");
            writer.WriteStringValue(ClientId);
            writer.WritePropertyName("clientSecret");
            writer.WriteStringValue(ClientSecret);
            writer.WritePropertyName("password");
            writer.WriteStringValue(Password);
            if (Optional.IsDefined(PromoCode))
            {
                writer.WritePropertyName("promoCode");
                writer.WriteStringValue(PromoCode);
            }
            if (Optional.IsDefined(UserInvitation))
            {
                writer.WritePropertyName("userInvitation");
                writer.WriteObjectValue(UserInvitation);
            }
            writer.WritePropertyName("username");
            writer.WriteStringValue(Username);
            writer.WriteEndObject();
        }
    }
}