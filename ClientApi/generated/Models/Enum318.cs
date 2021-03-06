// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The Enum318. </summary>
    public readonly partial struct Enum318 : IEquatable<Enum318>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Enum318"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Enum318(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EsESValue = "es-ES";
        private const string EnUSValue = "en-US";
        private const string CaESValue = "ca-ES";

        /// <summary> es-ES. </summary>
        public static Enum318 EsES { get; } = new Enum318(EsESValue);
        /// <summary> en-US. </summary>
        public static Enum318 EnUS { get; } = new Enum318(EnUSValue);
        /// <summary> ca-ES. </summary>
        public static Enum318 CaES { get; } = new Enum318(CaESValue);
        /// <summary> Determines if two <see cref="Enum318"/> values are the same. </summary>
        public static bool operator ==(Enum318 left, Enum318 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum318"/> values are not the same. </summary>
        public static bool operator !=(Enum318 left, Enum318 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum318"/>. </summary>
        public static implicit operator Enum318(string value) => new Enum318(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum318 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum318 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
