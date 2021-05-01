// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The user role into the company. </summary>
    public readonly partial struct EditRoleRequestApiModelUserCompanyRole : IEquatable<EditRoleRequestApiModelUserCompanyRole>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="EditRoleRequestApiModelUserCompanyRole"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EditRoleRequestApiModelUserCompanyRole(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CompanyAdminValue = "CompanyAdmin";
        private const string CompanyManagerValue = "CompanyManager";
        private const string CompanyUserValue = "CompanyUser";
        private const string CompanyUserAsManagerValue = "CompanyUserAsManager";
        private const string CompanyUserWorkHoursRegisterValue = "CompanyUserWorkHoursRegister";

        /// <summary> CompanyAdmin. </summary>
        public static EditRoleRequestApiModelUserCompanyRole CompanyAdmin { get; } = new EditRoleRequestApiModelUserCompanyRole(CompanyAdminValue);
        /// <summary> CompanyManager. </summary>
        public static EditRoleRequestApiModelUserCompanyRole CompanyManager { get; } = new EditRoleRequestApiModelUserCompanyRole(CompanyManagerValue);
        /// <summary> CompanyUser. </summary>
        public static EditRoleRequestApiModelUserCompanyRole CompanyUser { get; } = new EditRoleRequestApiModelUserCompanyRole(CompanyUserValue);
        /// <summary> CompanyUserAsManager. </summary>
        public static EditRoleRequestApiModelUserCompanyRole CompanyUserAsManager { get; } = new EditRoleRequestApiModelUserCompanyRole(CompanyUserAsManagerValue);
        /// <summary> CompanyUserWorkHoursRegister. </summary>
        public static EditRoleRequestApiModelUserCompanyRole CompanyUserWorkHoursRegister { get; } = new EditRoleRequestApiModelUserCompanyRole(CompanyUserWorkHoursRegisterValue);
        /// <summary> Determines if two <see cref="EditRoleRequestApiModelUserCompanyRole"/> values are the same. </summary>
        public static bool operator ==(EditRoleRequestApiModelUserCompanyRole left, EditRoleRequestApiModelUserCompanyRole right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EditRoleRequestApiModelUserCompanyRole"/> values are not the same. </summary>
        public static bool operator !=(EditRoleRequestApiModelUserCompanyRole left, EditRoleRequestApiModelUserCompanyRole right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EditRoleRequestApiModelUserCompanyRole"/>. </summary>
        public static implicit operator EditRoleRequestApiModelUserCompanyRole(string value) => new EditRoleRequestApiModelUserCompanyRole(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EditRoleRequestApiModelUserCompanyRole other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EditRoleRequestApiModelUserCompanyRole other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}