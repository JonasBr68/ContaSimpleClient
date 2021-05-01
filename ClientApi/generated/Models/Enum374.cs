// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The Enum374. </summary>
    public readonly partial struct Enum374 : IEquatable<Enum374>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Enum374"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Enum374(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EsESValue = "es-ES";
        private const string EnUSValue = "en-US";
        private const string CaESValue = "ca-ES";

        /// <summary> es-ES. </summary>
        public static Enum374 EsES { get; } = new Enum374(EsESValue);
        /// <summary> en-US. </summary>
        public static Enum374 EnUS { get; } = new Enum374(EnUSValue);
        /// <summary> ca-ES. </summary>
        public static Enum374 CaES { get; } = new Enum374(CaESValue);
        /// <summary> Determines if two <see cref="Enum374"/> values are the same. </summary>
        public static bool operator ==(Enum374 left, Enum374 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum374"/> values are not the same. </summary>
        public static bool operator !=(Enum374 left, Enum374 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum374"/>. </summary>
        public static implicit operator Enum374(string value) => new Enum374(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum374 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum374 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
