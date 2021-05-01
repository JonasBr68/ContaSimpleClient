// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The sign option for the PDF invoices. </summary>
    public readonly partial struct CompanyExtraInformationApiModelSignPDFInvoices : IEquatable<CompanyExtraInformationApiModelSignPDFInvoices>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="CompanyExtraInformationApiModelSignPDFInvoices"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CompanyExtraInformationApiModelSignPDFInvoices(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoSignValue = "NoSign";
        private const string SignWithDomainCertValue = "SignWithDomainCert";
        private const string SignWithCompanyCertValue = "SignWithCompanyCert";

        /// <summary> NoSign. </summary>
        public static CompanyExtraInformationApiModelSignPDFInvoices NoSign { get; } = new CompanyExtraInformationApiModelSignPDFInvoices(NoSignValue);
        /// <summary> SignWithDomainCert. </summary>
        public static CompanyExtraInformationApiModelSignPDFInvoices SignWithDomainCert { get; } = new CompanyExtraInformationApiModelSignPDFInvoices(SignWithDomainCertValue);
        /// <summary> SignWithCompanyCert. </summary>
        public static CompanyExtraInformationApiModelSignPDFInvoices SignWithCompanyCert { get; } = new CompanyExtraInformationApiModelSignPDFInvoices(SignWithCompanyCertValue);
        /// <summary> Determines if two <see cref="CompanyExtraInformationApiModelSignPDFInvoices"/> values are the same. </summary>
        public static bool operator ==(CompanyExtraInformationApiModelSignPDFInvoices left, CompanyExtraInformationApiModelSignPDFInvoices right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CompanyExtraInformationApiModelSignPDFInvoices"/> values are not the same. </summary>
        public static bool operator !=(CompanyExtraInformationApiModelSignPDFInvoices left, CompanyExtraInformationApiModelSignPDFInvoices right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CompanyExtraInformationApiModelSignPDFInvoices"/>. </summary>
        public static implicit operator CompanyExtraInformationApiModelSignPDFInvoices(string value) => new CompanyExtraInformationApiModelSignPDFInvoices(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CompanyExtraInformationApiModelSignPDFInvoices other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CompanyExtraInformationApiModelSignPDFInvoices other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
