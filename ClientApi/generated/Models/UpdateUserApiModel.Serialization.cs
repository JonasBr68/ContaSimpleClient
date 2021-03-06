// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class UpdateUserApiModel : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(BirthDate))
            {
                writer.WritePropertyName("birthDate");
                writer.WriteStringValue(BirthDate.Value, "O");
            }
            if (Optional.IsDefined(Email))
            {
                writer.WritePropertyName("email");
                writer.WriteStringValue(Email);
            }
            if (Optional.IsDefined(Gender))
            {
                writer.WritePropertyName("gender");
                writer.WriteStringValue(Gender.Value.ToString());
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Phone))
            {
                writer.WritePropertyName("phone");
                writer.WriteStringValue(Phone);
            }
            if (Optional.IsDefined(Surname))
            {
                writer.WritePropertyName("surname");
                writer.WriteStringValue(Surname);
            }
            if (Optional.IsDefined(UiCulture))
            {
                writer.WritePropertyName("uiCulture");
                writer.WriteStringValue(UiCulture);
            }
            writer.WriteEndObject();
        }
    }
}
