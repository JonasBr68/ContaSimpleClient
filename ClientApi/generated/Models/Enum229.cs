// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The Enum229. </summary>
    public readonly partial struct Enum229 : IEquatable<Enum229>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Enum229"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Enum229(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EsESValue = "es-ES";
        private const string EnUSValue = "en-US";
        private const string CaESValue = "ca-ES";

        /// <summary> es-ES. </summary>
        public static Enum229 EsES { get; } = new Enum229(EsESValue);
        /// <summary> en-US. </summary>
        public static Enum229 EnUS { get; } = new Enum229(EnUSValue);
        /// <summary> ca-ES. </summary>
        public static Enum229 CaES { get; } = new Enum229(CaESValue);
        /// <summary> Determines if two <see cref="Enum229"/> values are the same. </summary>
        public static bool operator ==(Enum229 left, Enum229 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum229"/> values are not the same. </summary>
        public static bool operator !=(Enum229 left, Enum229 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum229"/>. </summary>
        public static implicit operator Enum229(string value) => new Enum229(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum229 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum229 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
