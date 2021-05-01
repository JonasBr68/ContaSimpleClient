// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The Enum96. </summary>
    public readonly partial struct Enum96 : IEquatable<Enum96>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Enum96"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Enum96(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EsESValue = "es-ES";
        private const string EnUSValue = "en-US";
        private const string CaESValue = "ca-ES";

        /// <summary> es-ES. </summary>
        public static Enum96 EsES { get; } = new Enum96(EsESValue);
        /// <summary> en-US. </summary>
        public static Enum96 EnUS { get; } = new Enum96(EnUSValue);
        /// <summary> ca-ES. </summary>
        public static Enum96 CaES { get; } = new Enum96(CaESValue);
        /// <summary> Determines if two <see cref="Enum96"/> values are the same. </summary>
        public static bool operator ==(Enum96 left, Enum96 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum96"/> values are not the same. </summary>
        public static bool operator !=(Enum96 left, Enum96 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum96"/>. </summary>
        public static implicit operator Enum96(string value) => new Enum96(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum96 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum96 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}