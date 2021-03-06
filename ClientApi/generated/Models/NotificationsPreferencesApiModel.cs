// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Defines the information for a notification preference. </summary>
    public partial class NotificationsPreferencesApiModel
    {
        /// <summary> Initializes a new instance of NotificationsPreferencesApiModel. </summary>
        /// <param name="channel"> The notification channel. </param>
        /// <param name="enabled"> Indicates if the notification is enabled. </param>
        /// <param name="type"> The notification type. </param>
        public NotificationsPreferencesApiModel(NotificationsPreferencesApiModelChannel channel, bool enabled, NotificationsPreferencesApiModelType type)
        {
            Channel = channel;
            Enabled = enabled;
            Type = type;
        }

        /// <summary> The notification channel. </summary>
        public NotificationsPreferencesApiModelChannel Channel { get; set; }
        /// <summary> Indicates if the notification is enabled. </summary>
        public bool Enabled { get; set; }
        /// <summary> The notification type. </summary>
        public NotificationsPreferencesApiModelType Type { get; set; }
    }
}
