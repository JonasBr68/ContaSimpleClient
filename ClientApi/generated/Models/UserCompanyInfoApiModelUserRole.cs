// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The user role into the company. </summary>
    public readonly partial struct UserCompanyInfoApiModelUserRole : IEquatable<UserCompanyInfoApiModelUserRole>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="UserCompanyInfoApiModelUserRole"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public UserCompanyInfoApiModelUserRole(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UserValue = "User";
        private const string MultiUserValue = "MultiUser";
        private const string ManagerValue = "Manager";
        private const string AdministratorValue = "Administrator";
        private const string RootValue = "Root";

        /// <summary> User. </summary>
        public static UserCompanyInfoApiModelUserRole User { get; } = new UserCompanyInfoApiModelUserRole(UserValue);
        /// <summary> MultiUser. </summary>
        public static UserCompanyInfoApiModelUserRole MultiUser { get; } = new UserCompanyInfoApiModelUserRole(MultiUserValue);
        /// <summary> Manager. </summary>
        public static UserCompanyInfoApiModelUserRole Manager { get; } = new UserCompanyInfoApiModelUserRole(ManagerValue);
        /// <summary> Administrator. </summary>
        public static UserCompanyInfoApiModelUserRole Administrator { get; } = new UserCompanyInfoApiModelUserRole(AdministratorValue);
        /// <summary> Root. </summary>
        public static UserCompanyInfoApiModelUserRole Root { get; } = new UserCompanyInfoApiModelUserRole(RootValue);
        /// <summary> Determines if two <see cref="UserCompanyInfoApiModelUserRole"/> values are the same. </summary>
        public static bool operator ==(UserCompanyInfoApiModelUserRole left, UserCompanyInfoApiModelUserRole right) => left.Equals(right);
        /// <summary> Determines if two <see cref="UserCompanyInfoApiModelUserRole"/> values are not the same. </summary>
        public static bool operator !=(UserCompanyInfoApiModelUserRole left, UserCompanyInfoApiModelUserRole right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="UserCompanyInfoApiModelUserRole"/>. </summary>
        public static implicit operator UserCompanyInfoApiModelUserRole(string value) => new UserCompanyInfoApiModelUserRole(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is UserCompanyInfoApiModelUserRole other && Equals(other);
        /// <inheritdoc />
        public bool Equals(UserCompanyInfoApiModelUserRole other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
