// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Xml.Linq;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class TimeZoneInformationApiModel
    {
        internal static TimeZoneInformationApiModel DeserializeTimeZoneInformationApiModel(JsonElement element)
        {
            Optional<string> displayName = default;
            Optional<string> id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
            }
            return new TimeZoneInformationApiModel(displayName.Value, id.Value);
        }

        internal static TimeZoneInformationApiModel DeserializeTimeZoneInformationApiModel(XElement element)
        {
            string displayName = default;
            string id = default;
            if (element.Element("displayName") is XElement displayNameElement)
            {
                displayName = (string)displayNameElement;
            }
            if (element.Element("id") is XElement idElement)
            {
                id = (string)idElement;
            }
            return new TimeZoneInformationApiModel(displayName, id);
        }
    }
}
