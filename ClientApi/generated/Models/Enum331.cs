// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The Enum331. </summary>
    public readonly partial struct Enum331 : IEquatable<Enum331>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Enum331"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Enum331(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CustomersValue = "Customers";
        private const string SuppliersValue = "Suppliers";
        private const string ProductsValue = "Products";
        private const string ProductsStockControlValue = "ProductsStockControl";

        /// <summary> Customers. </summary>
        public static Enum331 Customers { get; } = new Enum331(CustomersValue);
        /// <summary> Suppliers. </summary>
        public static Enum331 Suppliers { get; } = new Enum331(SuppliersValue);
        /// <summary> Products. </summary>
        public static Enum331 Products { get; } = new Enum331(ProductsValue);
        /// <summary> ProductsStockControl. </summary>
        public static Enum331 ProductsStockControl { get; } = new Enum331(ProductsStockControlValue);
        /// <summary> Determines if two <see cref="Enum331"/> values are the same. </summary>
        public static bool operator ==(Enum331 left, Enum331 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum331"/> values are not the same. </summary>
        public static bool operator !=(Enum331 left, Enum331 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum331"/>. </summary>
        public static implicit operator Enum331(string value) => new Enum331(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum331 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum331 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
