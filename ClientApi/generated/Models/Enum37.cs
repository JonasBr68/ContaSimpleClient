// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The Enum37. </summary>
    public readonly partial struct Enum37 : IEquatable<Enum37>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Enum37"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Enum37(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EsESValue = "es-ES";
        private const string EnUSValue = "en-US";
        private const string CaESValue = "ca-ES";

        /// <summary> es-ES. </summary>
        public static Enum37 EsES { get; } = new Enum37(EsESValue);
        /// <summary> en-US. </summary>
        public static Enum37 EnUS { get; } = new Enum37(EnUSValue);
        /// <summary> ca-ES. </summary>
        public static Enum37 CaES { get; } = new Enum37(CaESValue);
        /// <summary> Determines if two <see cref="Enum37"/> values are the same. </summary>
        public static bool operator ==(Enum37 left, Enum37 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum37"/> values are not the same. </summary>
        public static bool operator !=(Enum37 left, Enum37 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum37"/>. </summary>
        public static implicit operator Enum37(string value) => new Enum37(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum37 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum37 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
