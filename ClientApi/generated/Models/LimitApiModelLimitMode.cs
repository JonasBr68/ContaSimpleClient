// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> Limit mode. </summary>
    public readonly partial struct LimitApiModelLimitMode : IEquatable<LimitApiModelLimitMode>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="LimitApiModelLimitMode"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LimitApiModelLimitMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoLimitationValue = "NoLimitation";
        private const string AccountTypeLimitedValue = "AccountTypeLimited";
        private const string CustomLimitValue = "CustomLimit";

        /// <summary> NoLimitation. </summary>
        public static LimitApiModelLimitMode NoLimitation { get; } = new LimitApiModelLimitMode(NoLimitationValue);
        /// <summary> AccountTypeLimited. </summary>
        public static LimitApiModelLimitMode AccountTypeLimited { get; } = new LimitApiModelLimitMode(AccountTypeLimitedValue);
        /// <summary> CustomLimit. </summary>
        public static LimitApiModelLimitMode CustomLimit { get; } = new LimitApiModelLimitMode(CustomLimitValue);
        /// <summary> Determines if two <see cref="LimitApiModelLimitMode"/> values are the same. </summary>
        public static bool operator ==(LimitApiModelLimitMode left, LimitApiModelLimitMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LimitApiModelLimitMode"/> values are not the same. </summary>
        public static bool operator !=(LimitApiModelLimitMode left, LimitApiModelLimitMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LimitApiModelLimitMode"/>. </summary>
        public static implicit operator LimitApiModelLimitMode(string value) => new LimitApiModelLimitMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LimitApiModelLimitMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LimitApiModelLimitMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
