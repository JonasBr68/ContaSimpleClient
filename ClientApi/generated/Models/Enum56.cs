// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The Enum56. </summary>
    public readonly partial struct Enum56 : IEquatable<Enum56>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Enum56"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Enum56(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EsESValue = "es-ES";
        private const string EnUSValue = "en-US";
        private const string CaESValue = "ca-ES";

        /// <summary> es-ES. </summary>
        public static Enum56 EsES { get; } = new Enum56(EsESValue);
        /// <summary> en-US. </summary>
        public static Enum56 EnUS { get; } = new Enum56(EnUSValue);
        /// <summary> ca-ES. </summary>
        public static Enum56 CaES { get; } = new Enum56(CaESValue);
        /// <summary> Determines if two <see cref="Enum56"/> values are the same. </summary>
        public static bool operator ==(Enum56 left, Enum56 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum56"/> values are not the same. </summary>
        public static bool operator !=(Enum56 left, Enum56 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum56"/>. </summary>
        public static implicit operator Enum56(string value) => new Enum56(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum56 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum56 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}