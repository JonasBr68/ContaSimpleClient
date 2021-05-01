// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The Enum411. </summary>
    public readonly partial struct Enum411 : IEquatable<Enum411>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Enum411"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Enum411(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WebValue = "Web";
        private const string IOSValue = "iOS";
        private const string AndroidValue = "Android";

        /// <summary> Web. </summary>
        public static Enum411 Web { get; } = new Enum411(WebValue);
        /// <summary> iOS. </summary>
        public static Enum411 IOS { get; } = new Enum411(IOSValue);
        /// <summary> Android. </summary>
        public static Enum411 Android { get; } = new Enum411(AndroidValue);
        /// <summary> Determines if two <see cref="Enum411"/> values are the same. </summary>
        public static bool operator ==(Enum411 left, Enum411 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum411"/> values are not the same. </summary>
        public static bool operator !=(Enum411 left, Enum411 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum411"/>. </summary>
        public static implicit operator Enum411(string value) => new Enum411(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum411 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum411 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
