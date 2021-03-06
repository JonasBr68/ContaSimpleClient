// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> Indicates the gender of the user. </summary>
    public readonly partial struct UserApiModelGender : IEquatable<UserApiModelGender>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="UserApiModelGender"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public UserApiModelGender(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MaleValue = "Male";
        private const string FemaleValue = "Female";

        /// <summary> Male. </summary>
        public static UserApiModelGender Male { get; } = new UserApiModelGender(MaleValue);
        /// <summary> Female. </summary>
        public static UserApiModelGender Female { get; } = new UserApiModelGender(FemaleValue);
        /// <summary> Determines if two <see cref="UserApiModelGender"/> values are the same. </summary>
        public static bool operator ==(UserApiModelGender left, UserApiModelGender right) => left.Equals(right);
        /// <summary> Determines if two <see cref="UserApiModelGender"/> values are not the same. </summary>
        public static bool operator !=(UserApiModelGender left, UserApiModelGender right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="UserApiModelGender"/>. </summary>
        public static implicit operator UserApiModelGender(string value) => new UserApiModelGender(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is UserApiModelGender other && Equals(other);
        /// <inheritdoc />
        public bool Equals(UserApiModelGender other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
