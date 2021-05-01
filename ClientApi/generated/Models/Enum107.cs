// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The Enum107. </summary>
    public readonly partial struct Enum107 : IEquatable<Enum107>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Enum107"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Enum107(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EsESValue = "es-ES";
        private const string EnUSValue = "en-US";
        private const string CaESValue = "ca-ES";

        /// <summary> es-ES. </summary>
        public static Enum107 EsES { get; } = new Enum107(EsESValue);
        /// <summary> en-US. </summary>
        public static Enum107 EnUS { get; } = new Enum107(EnUSValue);
        /// <summary> ca-ES. </summary>
        public static Enum107 CaES { get; } = new Enum107(CaESValue);
        /// <summary> Determines if two <see cref="Enum107"/> values are the same. </summary>
        public static bool operator ==(Enum107 left, Enum107 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum107"/> values are not the same. </summary>
        public static bool operator !=(Enum107 left, Enum107 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum107"/>. </summary>
        public static implicit operator Enum107(string value) => new Enum107(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum107 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum107 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}