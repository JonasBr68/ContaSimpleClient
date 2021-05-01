// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The Enum364. </summary>
    public readonly partial struct Enum364 : IEquatable<Enum364>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Enum364"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Enum364(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EsESValue = "es-ES";
        private const string EnUSValue = "en-US";
        private const string CaESValue = "ca-ES";

        /// <summary> es-ES. </summary>
        public static Enum364 EsES { get; } = new Enum364(EsESValue);
        /// <summary> en-US. </summary>
        public static Enum364 EnUS { get; } = new Enum364(EnUSValue);
        /// <summary> ca-ES. </summary>
        public static Enum364 CaES { get; } = new Enum364(CaESValue);
        /// <summary> Determines if two <see cref="Enum364"/> values are the same. </summary>
        public static bool operator ==(Enum364 left, Enum364 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum364"/> values are not the same. </summary>
        public static bool operator !=(Enum364 left, Enum364 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum364"/>. </summary>
        public static implicit operator Enum364(string value) => new Enum364(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum364 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum364 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
