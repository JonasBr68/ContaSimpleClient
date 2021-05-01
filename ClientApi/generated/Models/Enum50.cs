// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The Enum50. </summary>
    public readonly partial struct Enum50 : IEquatable<Enum50>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Enum50"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Enum50(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EsESValue = "es-ES";
        private const string EnUSValue = "en-US";
        private const string CaESValue = "ca-ES";

        /// <summary> es-ES. </summary>
        public static Enum50 EsES { get; } = new Enum50(EsESValue);
        /// <summary> en-US. </summary>
        public static Enum50 EnUS { get; } = new Enum50(EnUSValue);
        /// <summary> ca-ES. </summary>
        public static Enum50 CaES { get; } = new Enum50(CaESValue);
        /// <summary> Determines if two <see cref="Enum50"/> values are the same. </summary>
        public static bool operator ==(Enum50 left, Enum50 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum50"/> values are not the same. </summary>
        public static bool operator !=(Enum50 left, Enum50 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum50"/>. </summary>
        public static implicit operator Enum50(string value) => new Enum50(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum50 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum50 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}