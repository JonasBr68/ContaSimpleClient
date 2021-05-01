// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The numbering format type. </summary>
    public readonly partial struct InvoiceNumberingFormatApiModelType : IEquatable<InvoiceNumberingFormatApiModelType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="InvoiceNumberingFormatApiModelType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InvoiceNumberingFormatApiModelType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NormalValue = "Normal";
        private const string RectifyingValue = "Rectifying";

        /// <summary> Normal. </summary>
        public static InvoiceNumberingFormatApiModelType Normal { get; } = new InvoiceNumberingFormatApiModelType(NormalValue);
        /// <summary> Rectifying. </summary>
        public static InvoiceNumberingFormatApiModelType Rectifying { get; } = new InvoiceNumberingFormatApiModelType(RectifyingValue);
        /// <summary> Determines if two <see cref="InvoiceNumberingFormatApiModelType"/> values are the same. </summary>
        public static bool operator ==(InvoiceNumberingFormatApiModelType left, InvoiceNumberingFormatApiModelType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InvoiceNumberingFormatApiModelType"/> values are not the same. </summary>
        public static bool operator !=(InvoiceNumberingFormatApiModelType left, InvoiceNumberingFormatApiModelType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="InvoiceNumberingFormatApiModelType"/>. </summary>
        public static implicit operator InvoiceNumberingFormatApiModelType(string value) => new InvoiceNumberingFormatApiModelType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InvoiceNumberingFormatApiModelType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InvoiceNumberingFormatApiModelType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}