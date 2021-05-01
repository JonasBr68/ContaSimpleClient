// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The Enum109. </summary>
    public readonly partial struct Enum109 : IEquatable<Enum109>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Enum109"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Enum109(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EsESValue = "es-ES";
        private const string EnUSValue = "en-US";
        private const string CaESValue = "ca-ES";

        /// <summary> es-ES. </summary>
        public static Enum109 EsES { get; } = new Enum109(EsESValue);
        /// <summary> en-US. </summary>
        public static Enum109 EnUS { get; } = new Enum109(EnUSValue);
        /// <summary> ca-ES. </summary>
        public static Enum109 CaES { get; } = new Enum109(CaESValue);
        /// <summary> Determines if two <see cref="Enum109"/> values are the same. </summary>
        public static bool operator ==(Enum109 left, Enum109 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum109"/> values are not the same. </summary>
        public static bool operator !=(Enum109 left, Enum109 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum109"/>. </summary>
        public static implicit operator Enum109(string value) => new Enum109(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum109 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum109 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
