// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The Enum327. </summary>
    public readonly partial struct Enum327 : IEquatable<Enum327>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Enum327"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Enum327(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EsESValue = "es-ES";
        private const string EnUSValue = "en-US";
        private const string CaESValue = "ca-ES";

        /// <summary> es-ES. </summary>
        public static Enum327 EsES { get; } = new Enum327(EsESValue);
        /// <summary> en-US. </summary>
        public static Enum327 EnUS { get; } = new Enum327(EnUSValue);
        /// <summary> ca-ES. </summary>
        public static Enum327 CaES { get; } = new Enum327(CaESValue);
        /// <summary> Determines if two <see cref="Enum327"/> values are the same. </summary>
        public static bool operator ==(Enum327 left, Enum327 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum327"/> values are not the same. </summary>
        public static bool operator !=(Enum327 left, Enum327 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum327"/>. </summary>
        public static implicit operator Enum327(string value) => new Enum327(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum327 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum327 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
