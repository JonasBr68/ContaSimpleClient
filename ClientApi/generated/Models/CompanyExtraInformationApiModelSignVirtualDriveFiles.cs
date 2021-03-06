// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The sign option for the virtual drive files. </summary>
    public readonly partial struct CompanyExtraInformationApiModelSignVirtualDriveFiles : IEquatable<CompanyExtraInformationApiModelSignVirtualDriveFiles>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="CompanyExtraInformationApiModelSignVirtualDriveFiles"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CompanyExtraInformationApiModelSignVirtualDriveFiles(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoSignValue = "NoSign";
        private const string SignWithDomainCertValue = "SignWithDomainCert";
        private const string SignWithCompanyCertValue = "SignWithCompanyCert";

        /// <summary> NoSign. </summary>
        public static CompanyExtraInformationApiModelSignVirtualDriveFiles NoSign { get; } = new CompanyExtraInformationApiModelSignVirtualDriveFiles(NoSignValue);
        /// <summary> SignWithDomainCert. </summary>
        public static CompanyExtraInformationApiModelSignVirtualDriveFiles SignWithDomainCert { get; } = new CompanyExtraInformationApiModelSignVirtualDriveFiles(SignWithDomainCertValue);
        /// <summary> SignWithCompanyCert. </summary>
        public static CompanyExtraInformationApiModelSignVirtualDriveFiles SignWithCompanyCert { get; } = new CompanyExtraInformationApiModelSignVirtualDriveFiles(SignWithCompanyCertValue);
        /// <summary> Determines if two <see cref="CompanyExtraInformationApiModelSignVirtualDriveFiles"/> values are the same. </summary>
        public static bool operator ==(CompanyExtraInformationApiModelSignVirtualDriveFiles left, CompanyExtraInformationApiModelSignVirtualDriveFiles right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CompanyExtraInformationApiModelSignVirtualDriveFiles"/> values are not the same. </summary>
        public static bool operator !=(CompanyExtraInformationApiModelSignVirtualDriveFiles left, CompanyExtraInformationApiModelSignVirtualDriveFiles right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CompanyExtraInformationApiModelSignVirtualDriveFiles"/>. </summary>
        public static implicit operator CompanyExtraInformationApiModelSignVirtualDriveFiles(string value) => new CompanyExtraInformationApiModelSignVirtualDriveFiles(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CompanyExtraInformationApiModelSignVirtualDriveFiles other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CompanyExtraInformationApiModelSignVirtualDriveFiles other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
