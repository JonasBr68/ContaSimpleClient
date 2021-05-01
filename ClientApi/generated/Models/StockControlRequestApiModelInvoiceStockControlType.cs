// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The issued invoices stock control configuration. </summary>
    public readonly partial struct StockControlRequestApiModelInvoiceStockControlType : IEquatable<StockControlRequestApiModelInvoiceStockControlType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="StockControlRequestApiModelInvoiceStockControlType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StockControlRequestApiModelInvoiceStockControlType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NeverValue = "Never";
        private const string CreateEditValue = "Create_edit";

        /// <summary> Never. </summary>
        public static StockControlRequestApiModelInvoiceStockControlType Never { get; } = new StockControlRequestApiModelInvoiceStockControlType(NeverValue);
        /// <summary> Create_edit. </summary>
        public static StockControlRequestApiModelInvoiceStockControlType CreateEdit { get; } = new StockControlRequestApiModelInvoiceStockControlType(CreateEditValue);
        /// <summary> Determines if two <see cref="StockControlRequestApiModelInvoiceStockControlType"/> values are the same. </summary>
        public static bool operator ==(StockControlRequestApiModelInvoiceStockControlType left, StockControlRequestApiModelInvoiceStockControlType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StockControlRequestApiModelInvoiceStockControlType"/> values are not the same. </summary>
        public static bool operator !=(StockControlRequestApiModelInvoiceStockControlType left, StockControlRequestApiModelInvoiceStockControlType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="StockControlRequestApiModelInvoiceStockControlType"/>. </summary>
        public static implicit operator StockControlRequestApiModelInvoiceStockControlType(string value) => new StockControlRequestApiModelInvoiceStockControlType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StockControlRequestApiModelInvoiceStockControlType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StockControlRequestApiModelInvoiceStockControlType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
