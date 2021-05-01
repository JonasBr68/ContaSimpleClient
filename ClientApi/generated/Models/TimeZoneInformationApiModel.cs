// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Class that contains the time zone information. </summary>
    public partial class TimeZoneInformationApiModel
    {
        /// <summary> Initializes a new instance of TimeZoneInformationApiModel. </summary>
        internal TimeZoneInformationApiModel()
        {
        }

        /// <summary> Initializes a new instance of TimeZoneInformationApiModel. </summary>
        /// <param name="displayName"> The time zone display name. </param>
        /// <param name="id"> The time zone id. </param>
        internal TimeZoneInformationApiModel(string displayName, string id)
        {
            DisplayName = displayName;
            Id = id;
        }

        /// <summary> The time zone display name. </summary>
        public string DisplayName { get; }
        /// <summary> The time zone id. </summary>
        public string Id { get; }
    }
}