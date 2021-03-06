// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Xml.Linq;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class NotificationApiModel
    {
        internal static NotificationApiModel DeserializeNotificationApiModel(JsonElement element)
        {
            Optional<IReadOnlyList<NotificationAction>> actions = default;
            Optional<long> companyId = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<object> extra = default;
            Optional<long> id = default;
            Optional<NotificationApiModelKind> kind = default;
            Optional<string> message = default;
            Optional<bool> read = default;
            Optional<string> title = default;
            Optional<DateTimeOffset> updateTime = default;
            Optional<string> url = default;
            Optional<long> userId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<NotificationAction> array = new List<NotificationAction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NotificationAction.DeserializeNotificationAction(item));
                    }
                    actions = array;
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
                if (property.NameEquals("extra"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    extra = property.Value.GetObject();
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
                if (property.NameEquals("kind"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    kind = new NotificationApiModelKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("read"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    read = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("title"))
                {
                    title = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("updateTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    updateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("url"))
                {
                    url = property.Value.GetString();
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
            return new NotificationApiModel(Optional.ToList(actions), Optional.ToNullable(companyId), Optional.ToNullable(creationTime), extra.Value, Optional.ToNullable(id), Optional.ToNullable(kind), message.Value, Optional.ToNullable(read), title.Value, Optional.ToNullable(updateTime), url.Value, Optional.ToNullable(userId));
        }

        internal static NotificationApiModel DeserializeNotificationApiModel(XElement element)
        {
            long? companyId = default;
            DateTimeOffset? creationTime = default;
            object extra = default;
            long? id = default;
            NotificationApiModelKind? kind = default;
            string message = default;
            bool? read = default;
            string title = default;
            DateTimeOffset? updateTime = default;
            string url = default;
            long? userId = default;
            IReadOnlyList<NotificationAction> actions = default;
            if (element.Element("companyId") is XElement companyIdElement)
            {
                companyId = (long?)companyIdElement;
            }
            if (element.Element("creationTime") is XElement creationTimeElement)
            {
                creationTime = creationTimeElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("extra") is XElement extraElement)
            {
                extra = extraElement.GetObjectValue(null);
            }
            if (element.Element("id") is XElement idElement)
            {
                id = (long?)idElement;
            }
            if (element.Element("kind") is XElement kindElement)
            {
                kind = new NotificationApiModelKind(kindElement.Value);
            }
            if (element.Element("message") is XElement messageElement)
            {
                message = (string)messageElement;
            }
            if (element.Element("read") is XElement readElement)
            {
                read = (bool?)readElement;
            }
            if (element.Element("title") is XElement titleElement)
            {
                title = (string)titleElement;
            }
            if (element.Element("updateTime") is XElement updateTimeElement)
            {
                updateTime = updateTimeElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("url") is XElement urlElement)
            {
                url = (string)urlElement;
            }
            if (element.Element("userId") is XElement userIdElement)
            {
                userId = (long?)userIdElement;
            }
            var array = new List<NotificationAction>();
            foreach (var e in element.Elements("NotificationAction"))
            {
                array.Add(NotificationAction.DeserializeNotificationAction(e));
            }
            actions = array;
            return new NotificationApiModel(actions, companyId, creationTime, extra, id, kind, message, read, title, updateTime, url, userId);
        }
    }
}
