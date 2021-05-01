// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The Enum328. </summary>
    public readonly partial struct Enum328 : IEquatable<Enum328>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Enum328"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Enum328(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EsESValue = "es-ES";
        private const string EnUSValue = "en-US";
        private const string CaESValue = "ca-ES";

        /// <summary> es-ES. </summary>
        public static Enum328 EsES { get; } = new Enum328(EsESValue);
        /// <summary> en-US. </summary>
        public static Enum328 EnUS { get; } = new Enum328(EnUSValue);
        /// <summary> ca-ES. </summary>
        public static Enum328 CaES { get; } = new Enum328(CaESValue);
        /// <summary> Determines if two <see cref="Enum328"/> values are the same. </summary>
        public static bool operator ==(Enum328 left, Enum328 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum328"/> values are not the same. </summary>
        public static bool operator !=(Enum328 left, Enum328 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum328"/>. </summary>
        public static implicit operator Enum328(string value) => new Enum328(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum328 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum328 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}