// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The Enum435. </summary>
    public readonly partial struct Enum435 : IEquatable<Enum435>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Enum435"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Enum435(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EsESValue = "es-ES";
        private const string EnUSValue = "en-US";
        private const string CaESValue = "ca-ES";

        /// <summary> es-ES. </summary>
        public static Enum435 EsES { get; } = new Enum435(EsESValue);
        /// <summary> en-US. </summary>
        public static Enum435 EnUS { get; } = new Enum435(EnUSValue);
        /// <summary> ca-ES. </summary>
        public static Enum435 CaES { get; } = new Enum435(CaESValue);
        /// <summary> Determines if two <see cref="Enum435"/> values are the same. </summary>
        public static bool operator ==(Enum435 left, Enum435 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum435"/> values are not the same. </summary>
        public static bool operator !=(Enum435 left, Enum435 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum435"/>. </summary>
        public static implicit operator Enum435(string value) => new Enum435(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum435 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum435 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
