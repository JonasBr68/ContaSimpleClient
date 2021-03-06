// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class SendDocumentApiModel : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(BlindCopy))
            {
                writer.WritePropertyName("blindCopy");
                writer.WriteBooleanValue(BlindCopy.Value);
            }
            writer.WritePropertyName("body");
            writer.WriteStringValue(Body);
            if (Optional.IsDefined(ReplyTo))
            {
                writer.WritePropertyName("replyTo");
                writer.WriteStringValue(ReplyTo);
            }
            writer.WritePropertyName("subject");
            writer.WriteStringValue(Subject);
            writer.WritePropertyName("to");
            writer.WriteStringValue(To);
            writer.WriteEndObject();
        }
    }
}
