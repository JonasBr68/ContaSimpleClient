// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The Enum154. </summary>
    public readonly partial struct Enum154 : IEquatable<Enum154>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Enum154"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Enum154(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MemoryValue = "Memory";
        private const string RedisValue = "Redis";
        private const string AllValue = "All";

        /// <summary> Memory. </summary>
        public static Enum154 Memory { get; } = new Enum154(MemoryValue);
        /// <summary> Redis. </summary>
        public static Enum154 Redis { get; } = new Enum154(RedisValue);
        /// <summary> All. </summary>
        public static Enum154 All { get; } = new Enum154(AllValue);
        /// <summary> Determines if two <see cref="Enum154"/> values are the same. </summary>
        public static bool operator ==(Enum154 left, Enum154 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum154"/> values are not the same. </summary>
        public static bool operator !=(Enum154 left, Enum154 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum154"/>. </summary>
        public static implicit operator Enum154(string value) => new Enum154(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum154 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum154 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
