// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The Enum220. </summary>
    public readonly partial struct Enum220 : IEquatable<Enum220>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Enum220"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Enum220(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EsESValue = "es-ES";
        private const string EnUSValue = "en-US";
        private const string CaESValue = "ca-ES";

        /// <summary> es-ES. </summary>
        public static Enum220 EsES { get; } = new Enum220(EsESValue);
        /// <summary> en-US. </summary>
        public static Enum220 EnUS { get; } = new Enum220(EnUSValue);
        /// <summary> ca-ES. </summary>
        public static Enum220 CaES { get; } = new Enum220(CaESValue);
        /// <summary> Determines if two <see cref="Enum220"/> values are the same. </summary>
        public static bool operator ==(Enum220 left, Enum220 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum220"/> values are not the same. </summary>
        public static bool operator !=(Enum220 left, Enum220 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum220"/>. </summary>
        public static implicit operator Enum220(string value) => new Enum220(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum220 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum220 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
