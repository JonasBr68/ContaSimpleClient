// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The user role into the company. </summary>
    public readonly partial struct UserInvitationApiModelRole : IEquatable<UserInvitationApiModelRole>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="UserInvitationApiModelRole"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public UserInvitationApiModelRole(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CompanyAdminValue = "CompanyAdmin";
        private const string CompanyManagerValue = "CompanyManager";
        private const string CompanyUserValue = "CompanyUser";
        private const string CompanyUserAsManagerValue = "CompanyUserAsManager";
        private const string CompanyUserWorkHoursRegisterValue = "CompanyUserWorkHoursRegister";

        /// <summary> CompanyAdmin. </summary>
        public static UserInvitationApiModelRole CompanyAdmin { get; } = new UserInvitationApiModelRole(CompanyAdminValue);
        /// <summary> CompanyManager. </summary>
        public static UserInvitationApiModelRole CompanyManager { get; } = new UserInvitationApiModelRole(CompanyManagerValue);
        /// <summary> CompanyUser. </summary>
        public static UserInvitationApiModelRole CompanyUser { get; } = new UserInvitationApiModelRole(CompanyUserValue);
        /// <summary> CompanyUserAsManager. </summary>
        public static UserInvitationApiModelRole CompanyUserAsManager { get; } = new UserInvitationApiModelRole(CompanyUserAsManagerValue);
        /// <summary> CompanyUserWorkHoursRegister. </summary>
        public static UserInvitationApiModelRole CompanyUserWorkHoursRegister { get; } = new UserInvitationApiModelRole(CompanyUserWorkHoursRegisterValue);
        /// <summary> Determines if two <see cref="UserInvitationApiModelRole"/> values are the same. </summary>
        public static bool operator ==(UserInvitationApiModelRole left, UserInvitationApiModelRole right) => left.Equals(right);
        /// <summary> Determines if two <see cref="UserInvitationApiModelRole"/> values are not the same. </summary>
        public static bool operator !=(UserInvitationApiModelRole left, UserInvitationApiModelRole right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="UserInvitationApiModelRole"/>. </summary>
        public static implicit operator UserInvitationApiModelRole(string value) => new UserInvitationApiModelRole(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is UserInvitationApiModelRole other && Equals(other);
        /// <inheritdoc />
        public bool Equals(UserInvitationApiModelRole other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
