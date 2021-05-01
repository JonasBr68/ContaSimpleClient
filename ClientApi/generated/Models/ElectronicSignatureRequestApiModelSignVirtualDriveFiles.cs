// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The virtual disk signature type. </summary>
    public readonly partial struct ElectronicSignatureRequestApiModelSignVirtualDriveFiles : IEquatable<ElectronicSignatureRequestApiModelSignVirtualDriveFiles>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ElectronicSignatureRequestApiModelSignVirtualDriveFiles"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ElectronicSignatureRequestApiModelSignVirtualDriveFiles(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoSignValue = "NoSign";
        private const string SignWithDomainCertValue = "SignWithDomainCert";
        private const string SignWithCompanyCertValue = "SignWithCompanyCert";

        /// <summary> NoSign. </summary>
        public static ElectronicSignatureRequestApiModelSignVirtualDriveFiles NoSign { get; } = new ElectronicSignatureRequestApiModelSignVirtualDriveFiles(NoSignValue);
        /// <summary> SignWithDomainCert. </summary>
        public static ElectronicSignatureRequestApiModelSignVirtualDriveFiles SignWithDomainCert { get; } = new ElectronicSignatureRequestApiModelSignVirtualDriveFiles(SignWithDomainCertValue);
        /// <summary> SignWithCompanyCert. </summary>
        public static ElectronicSignatureRequestApiModelSignVirtualDriveFiles SignWithCompanyCert { get; } = new ElectronicSignatureRequestApiModelSignVirtualDriveFiles(SignWithCompanyCertValue);
        /// <summary> Determines if two <see cref="ElectronicSignatureRequestApiModelSignVirtualDriveFiles"/> values are the same. </summary>
        public static bool operator ==(ElectronicSignatureRequestApiModelSignVirtualDriveFiles left, ElectronicSignatureRequestApiModelSignVirtualDriveFiles right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ElectronicSignatureRequestApiModelSignVirtualDriveFiles"/> values are not the same. </summary>
        public static bool operator !=(ElectronicSignatureRequestApiModelSignVirtualDriveFiles left, ElectronicSignatureRequestApiModelSignVirtualDriveFiles right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ElectronicSignatureRequestApiModelSignVirtualDriveFiles"/>. </summary>
        public static implicit operator ElectronicSignatureRequestApiModelSignVirtualDriveFiles(string value) => new ElectronicSignatureRequestApiModelSignVirtualDriveFiles(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ElectronicSignatureRequestApiModelSignVirtualDriveFiles other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ElectronicSignatureRequestApiModelSignVirtualDriveFiles other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}