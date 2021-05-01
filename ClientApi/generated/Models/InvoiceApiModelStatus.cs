// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The current status of the invoice. </summary>
    public readonly partial struct InvoiceApiModelStatus : IEquatable<InvoiceApiModelStatus>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="InvoiceApiModelStatus"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InvoiceApiModelStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string IncompleteValue = "Incomplete";
        private const string PayedValue = "Payed";

        /// <summary> Pending. </summary>
        public static InvoiceApiModelStatus Pending { get; } = new InvoiceApiModelStatus(PendingValue);
        /// <summary> Incomplete. </summary>
        public static InvoiceApiModelStatus Incomplete { get; } = new InvoiceApiModelStatus(IncompleteValue);
        /// <summary> Payed. </summary>
        public static InvoiceApiModelStatus Payed { get; } = new InvoiceApiModelStatus(PayedValue);
        /// <summary> Determines if two <see cref="InvoiceApiModelStatus"/> values are the same. </summary>
        public static bool operator ==(InvoiceApiModelStatus left, InvoiceApiModelStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InvoiceApiModelStatus"/> values are not the same. </summary>
        public static bool operator !=(InvoiceApiModelStatus left, InvoiceApiModelStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="InvoiceApiModelStatus"/>. </summary>
        public static implicit operator InvoiceApiModelStatus(string value) => new InvoiceApiModelStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InvoiceApiModelStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InvoiceApiModelStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
