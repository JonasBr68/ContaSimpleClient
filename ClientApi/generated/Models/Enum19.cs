// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The Enum19. </summary>
    public readonly partial struct Enum19 : IEquatable<Enum19>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Enum19"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Enum19(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EsESValue = "es-ES";
        private const string EnUSValue = "en-US";
        private const string CaESValue = "ca-ES";

        /// <summary> es-ES. </summary>
        public static Enum19 EsES { get; } = new Enum19(EsESValue);
        /// <summary> en-US. </summary>
        public static Enum19 EnUS { get; } = new Enum19(EnUSValue);
        /// <summary> ca-ES. </summary>
        public static Enum19 CaES { get; } = new Enum19(CaESValue);
        /// <summary> Determines if two <see cref="Enum19"/> values are the same. </summary>
        public static bool operator ==(Enum19 left, Enum19 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum19"/> values are not the same. </summary>
        public static bool operator !=(Enum19 left, Enum19 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum19"/>. </summary>
        public static implicit operator Enum19(string value) => new Enum19(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum19 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum19 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
