// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The current plan of the company. </summary>
    public readonly partial struct CompanyLightweightApiModelType : IEquatable<CompanyLightweightApiModelType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="CompanyLightweightApiModelType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CompanyLightweightApiModelType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasicoValue = "Basico";
        private const string ProfesionalValue = "Profesional";
        private const string UltimateValue = "Ultimate";

        /// <summary> Basico. </summary>
        public static CompanyLightweightApiModelType Basico { get; } = new CompanyLightweightApiModelType(BasicoValue);
        /// <summary> Profesional. </summary>
        public static CompanyLightweightApiModelType Profesional { get; } = new CompanyLightweightApiModelType(ProfesionalValue);
        /// <summary> Ultimate. </summary>
        public static CompanyLightweightApiModelType Ultimate { get; } = new CompanyLightweightApiModelType(UltimateValue);
        /// <summary> Determines if two <see cref="CompanyLightweightApiModelType"/> values are the same. </summary>
        public static bool operator ==(CompanyLightweightApiModelType left, CompanyLightweightApiModelType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CompanyLightweightApiModelType"/> values are not the same. </summary>
        public static bool operator !=(CompanyLightweightApiModelType left, CompanyLightweightApiModelType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CompanyLightweightApiModelType"/>. </summary>
        public static implicit operator CompanyLightweightApiModelType(string value) => new CompanyLightweightApiModelType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CompanyLightweightApiModelType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CompanyLightweightApiModelType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}