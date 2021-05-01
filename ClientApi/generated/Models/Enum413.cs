// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The Enum413. </summary>
    public readonly partial struct Enum413 : IEquatable<Enum413>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Enum413"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Enum413(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WebValue = "Web";
        private const string IOSValue = "iOS";
        private const string AndroidValue = "Android";

        /// <summary> Web. </summary>
        public static Enum413 Web { get; } = new Enum413(WebValue);
        /// <summary> iOS. </summary>
        public static Enum413 IOS { get; } = new Enum413(IOSValue);
        /// <summary> Android. </summary>
        public static Enum413 Android { get; } = new Enum413(AndroidValue);
        /// <summary> Determines if two <see cref="Enum413"/> values are the same. </summary>
        public static bool operator ==(Enum413 left, Enum413 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum413"/> values are not the same. </summary>
        public static bool operator !=(Enum413 left, Enum413 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum413"/>. </summary>
        public static implicit operator Enum413(string value) => new Enum413(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum413 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum413 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
