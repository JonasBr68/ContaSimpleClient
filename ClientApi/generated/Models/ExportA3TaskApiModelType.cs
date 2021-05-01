// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The type of created task. </summary>
    public readonly partial struct ExportA3TaskApiModelType : IEquatable<ExportA3TaskApiModelType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ExportA3TaskApiModelType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ExportA3TaskApiModelType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UploadInvoiceToDropboxValue = "UploadInvoiceToDropbox";
        private const string ExportInvoicesPdfAsZipFileValue = "ExportInvoicesPdfAsZipFile";
        private const string UploadInvoiceToGoogleDriveValue = "UploadInvoiceToGoogleDrive";
        private const string UploadBudgetToDropboxValue = "UploadBudgetToDropbox";
        private const string UploadBudgetToGoogleDriveValue = "UploadBudgetToGoogleDrive";
        private const string UploadDeliveryNoteToDropboxValue = "UploadDeliveryNoteToDropbox";
        private const string UploadDeliveryNoteToGoogleDriveValue = "UploadDeliveryNoteToGoogleDrive";
        private const string GenerateA3AccountingTransferValue = "GenerateA3AccountingTransfer";
        private const string ExportBookIVAValue = "ExportBookIVA";
        private const string ExportBookIrpfValue = "ExportBookIRPF";
        private const string ExportBookIvairpfValue = "ExportBookIVAIRPF";
        private const string ExportAccountingAdvancedValue = "ExportAccountingAdvanced";
        private const string GenerateBankRemittanceValue = "GenerateBankRemittance";
        private const string GenerateBankRemittanceRefundValue = "GenerateBankRemittanceRefund";
        private const string SignVirtualDiskFileValue = "SignVirtualDiskFile";
        private const string ImportDataFromFileValue = "ImportDataFromFile";

        /// <summary> UploadInvoiceToDropbox. </summary>
        public static ExportA3TaskApiModelType UploadInvoiceToDropbox { get; } = new ExportA3TaskApiModelType(UploadInvoiceToDropboxValue);
        /// <summary> ExportInvoicesPdfAsZipFile. </summary>
        public static ExportA3TaskApiModelType ExportInvoicesPdfAsZipFile { get; } = new ExportA3TaskApiModelType(ExportInvoicesPdfAsZipFileValue);
        /// <summary> UploadInvoiceToGoogleDrive. </summary>
        public static ExportA3TaskApiModelType UploadInvoiceToGoogleDrive { get; } = new ExportA3TaskApiModelType(UploadInvoiceToGoogleDriveValue);
        /// <summary> UploadBudgetToDropbox. </summary>
        public static ExportA3TaskApiModelType UploadBudgetToDropbox { get; } = new ExportA3TaskApiModelType(UploadBudgetToDropboxValue);
        /// <summary> UploadBudgetToGoogleDrive. </summary>
        public static ExportA3TaskApiModelType UploadBudgetToGoogleDrive { get; } = new ExportA3TaskApiModelType(UploadBudgetToGoogleDriveValue);
        /// <summary> UploadDeliveryNoteToDropbox. </summary>
        public static ExportA3TaskApiModelType UploadDeliveryNoteToDropbox { get; } = new ExportA3TaskApiModelType(UploadDeliveryNoteToDropboxValue);
        /// <summary> UploadDeliveryNoteToGoogleDrive. </summary>
        public static ExportA3TaskApiModelType UploadDeliveryNoteToGoogleDrive { get; } = new ExportA3TaskApiModelType(UploadDeliveryNoteToGoogleDriveValue);
        /// <summary> GenerateA3AccountingTransfer. </summary>
        public static ExportA3TaskApiModelType GenerateA3AccountingTransfer { get; } = new ExportA3TaskApiModelType(GenerateA3AccountingTransferValue);
        /// <summary> ExportBookIVA. </summary>
        public static ExportA3TaskApiModelType ExportBookIVA { get; } = new ExportA3TaskApiModelType(ExportBookIVAValue);
        /// <summary> ExportBookIRPF. </summary>
        public static ExportA3TaskApiModelType ExportBookIrpf { get; } = new ExportA3TaskApiModelType(ExportBookIrpfValue);
        /// <summary> ExportBookIVAIRPF. </summary>
        public static ExportA3TaskApiModelType ExportBookIvairpf { get; } = new ExportA3TaskApiModelType(ExportBookIvairpfValue);
        /// <summary> ExportAccountingAdvanced. </summary>
        public static ExportA3TaskApiModelType ExportAccountingAdvanced { get; } = new ExportA3TaskApiModelType(ExportAccountingAdvancedValue);
        /// <summary> GenerateBankRemittance. </summary>
        public static ExportA3TaskApiModelType GenerateBankRemittance { get; } = new ExportA3TaskApiModelType(GenerateBankRemittanceValue);
        /// <summary> GenerateBankRemittanceRefund. </summary>
        public static ExportA3TaskApiModelType GenerateBankRemittanceRefund { get; } = new ExportA3TaskApiModelType(GenerateBankRemittanceRefundValue);
        /// <summary> SignVirtualDiskFile. </summary>
        public static ExportA3TaskApiModelType SignVirtualDiskFile { get; } = new ExportA3TaskApiModelType(SignVirtualDiskFileValue);
        /// <summary> ImportDataFromFile. </summary>
        public static ExportA3TaskApiModelType ImportDataFromFile { get; } = new ExportA3TaskApiModelType(ImportDataFromFileValue);
        /// <summary> Determines if two <see cref="ExportA3TaskApiModelType"/> values are the same. </summary>
        public static bool operator ==(ExportA3TaskApiModelType left, ExportA3TaskApiModelType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ExportA3TaskApiModelType"/> values are not the same. </summary>
        public static bool operator !=(ExportA3TaskApiModelType left, ExportA3TaskApiModelType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ExportA3TaskApiModelType"/>. </summary>
        public static implicit operator ExportA3TaskApiModelType(string value) => new ExportA3TaskApiModelType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ExportA3TaskApiModelType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ExportA3TaskApiModelType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}