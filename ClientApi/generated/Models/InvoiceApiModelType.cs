// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The invoice type. </summary>
    public readonly partial struct InvoiceApiModelType : IEquatable<InvoiceApiModelType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="InvoiceApiModelType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InvoiceApiModelType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IssuedValue = "Issued";
        private const string ReceivedValue = "Received";
        private const string AmortizedValue = "Amortized";

        /// <summary> Issued. </summary>
        public static InvoiceApiModelType Issued { get; } = new InvoiceApiModelType(IssuedValue);
        /// <summary> Received. </summary>
        public static InvoiceApiModelType Received { get; } = new InvoiceApiModelType(ReceivedValue);
        /// <summary> Amortized. </summary>
        public static InvoiceApiModelType Amortized { get; } = new InvoiceApiModelType(AmortizedValue);
        /// <summary> Determines if two <see cref="InvoiceApiModelType"/> values are the same. </summary>
        public static bool operator ==(InvoiceApiModelType left, InvoiceApiModelType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InvoiceApiModelType"/> values are not the same. </summary>
        public static bool operator !=(InvoiceApiModelType left, InvoiceApiModelType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="InvoiceApiModelType"/>. </summary>
        public static implicit operator InvoiceApiModelType(string value) => new InvoiceApiModelType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InvoiceApiModelType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InvoiceApiModelType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
