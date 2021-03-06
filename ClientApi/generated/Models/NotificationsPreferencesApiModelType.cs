// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The notification type. </summary>
    public readonly partial struct NotificationsPreferencesApiModelType : IEquatable<NotificationsPreferencesApiModelType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="NotificationsPreferencesApiModelType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NotificationsPreferencesApiModelType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AppValue = "App";
        private const string PromotionValue = "Promotion";

        /// <summary> App. </summary>
        public static NotificationsPreferencesApiModelType App { get; } = new NotificationsPreferencesApiModelType(AppValue);
        /// <summary> Promotion. </summary>
        public static NotificationsPreferencesApiModelType Promotion { get; } = new NotificationsPreferencesApiModelType(PromotionValue);
        /// <summary> Determines if two <see cref="NotificationsPreferencesApiModelType"/> values are the same. </summary>
        public static bool operator ==(NotificationsPreferencesApiModelType left, NotificationsPreferencesApiModelType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NotificationsPreferencesApiModelType"/> values are not the same. </summary>
        public static bool operator !=(NotificationsPreferencesApiModelType left, NotificationsPreferencesApiModelType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NotificationsPreferencesApiModelType"/>. </summary>
        public static implicit operator NotificationsPreferencesApiModelType(string value) => new NotificationsPreferencesApiModelType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NotificationsPreferencesApiModelType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NotificationsPreferencesApiModelType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
