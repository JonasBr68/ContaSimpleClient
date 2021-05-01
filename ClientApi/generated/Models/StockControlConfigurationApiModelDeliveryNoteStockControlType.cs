// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The delivery notes stock control configuration. </summary>
    public readonly partial struct StockControlConfigurationApiModelDeliveryNoteStockControlType : IEquatable<StockControlConfigurationApiModelDeliveryNoteStockControlType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="StockControlConfigurationApiModelDeliveryNoteStockControlType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StockControlConfigurationApiModelDeliveryNoteStockControlType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NeverValue = "Never";
        private const string CreateEditValue = "Create_edit";
        private const string InvoiceValue = "Invoice";

        /// <summary> Never. </summary>
        public static StockControlConfigurationApiModelDeliveryNoteStockControlType Never { get; } = new StockControlConfigurationApiModelDeliveryNoteStockControlType(NeverValue);
        /// <summary> Create_edit. </summary>
        public static StockControlConfigurationApiModelDeliveryNoteStockControlType CreateEdit { get; } = new StockControlConfigurationApiModelDeliveryNoteStockControlType(CreateEditValue);
        /// <summary> Invoice. </summary>
        public static StockControlConfigurationApiModelDeliveryNoteStockControlType Invoice { get; } = new StockControlConfigurationApiModelDeliveryNoteStockControlType(InvoiceValue);
        /// <summary> Determines if two <see cref="StockControlConfigurationApiModelDeliveryNoteStockControlType"/> values are the same. </summary>
        public static bool operator ==(StockControlConfigurationApiModelDeliveryNoteStockControlType left, StockControlConfigurationApiModelDeliveryNoteStockControlType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StockControlConfigurationApiModelDeliveryNoteStockControlType"/> values are not the same. </summary>
        public static bool operator !=(StockControlConfigurationApiModelDeliveryNoteStockControlType left, StockControlConfigurationApiModelDeliveryNoteStockControlType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="StockControlConfigurationApiModelDeliveryNoteStockControlType"/>. </summary>
        public static implicit operator StockControlConfigurationApiModelDeliveryNoteStockControlType(string value) => new StockControlConfigurationApiModelDeliveryNoteStockControlType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StockControlConfigurationApiModelDeliveryNoteStockControlType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StockControlConfigurationApiModelDeliveryNoteStockControlType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}