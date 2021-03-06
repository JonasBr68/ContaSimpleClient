// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The RE type. </summary>
    public readonly partial struct ReTypeApiModelType : IEquatable<ReTypeApiModelType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ReTypeApiModelType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ReTypeApiModelType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RegionFiscalValue = "RegionFiscal";
        private const string UsuarioValue = "Usuario";

        /// <summary> RegionFiscal. </summary>
        public static ReTypeApiModelType RegionFiscal { get; } = new ReTypeApiModelType(RegionFiscalValue);
        /// <summary> Usuario. </summary>
        public static ReTypeApiModelType Usuario { get; } = new ReTypeApiModelType(UsuarioValue);
        /// <summary> Determines if two <see cref="ReTypeApiModelType"/> values are the same. </summary>
        public static bool operator ==(ReTypeApiModelType left, ReTypeApiModelType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ReTypeApiModelType"/> values are not the same. </summary>
        public static bool operator !=(ReTypeApiModelType left, ReTypeApiModelType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ReTypeApiModelType"/>. </summary>
        public static implicit operator ReTypeApiModelType(string value) => new ReTypeApiModelType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ReTypeApiModelType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ReTypeApiModelType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
