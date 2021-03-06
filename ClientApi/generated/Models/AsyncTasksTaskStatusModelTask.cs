// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The requested task. </summary>
    public readonly partial struct AsyncTasksTaskStatusModelTask : IEquatable<AsyncTasksTaskStatusModelTask>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="AsyncTasksTaskStatusModelTask"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AsyncTasksTaskStatusModelTask(string value)
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
        public static AsyncTasksTaskStatusModelTask UploadInvoiceToDropbox { get; } = new AsyncTasksTaskStatusModelTask(UploadInvoiceToDropboxValue);
        /// <summary> ExportInvoicesPdfAsZipFile. </summary>
        public static AsyncTasksTaskStatusModelTask ExportInvoicesPdfAsZipFile { get; } = new AsyncTasksTaskStatusModelTask(ExportInvoicesPdfAsZipFileValue);
        /// <summary> UploadInvoiceToGoogleDrive. </summary>
        public static AsyncTasksTaskStatusModelTask UploadInvoiceToGoogleDrive { get; } = new AsyncTasksTaskStatusModelTask(UploadInvoiceToGoogleDriveValue);
        /// <summary> UploadBudgetToDropbox. </summary>
        public static AsyncTasksTaskStatusModelTask UploadBudgetToDropbox { get; } = new AsyncTasksTaskStatusModelTask(UploadBudgetToDropboxValue);
        /// <summary> UploadBudgetToGoogleDrive. </summary>
        public static AsyncTasksTaskStatusModelTask UploadBudgetToGoogleDrive { get; } = new AsyncTasksTaskStatusModelTask(UploadBudgetToGoogleDriveValue);
        /// <summary> UploadDeliveryNoteToDropbox. </summary>
        public static AsyncTasksTaskStatusModelTask UploadDeliveryNoteToDropbox { get; } = new AsyncTasksTaskStatusModelTask(UploadDeliveryNoteToDropboxValue);
        /// <summary> UploadDeliveryNoteToGoogleDrive. </summary>
        public static AsyncTasksTaskStatusModelTask UploadDeliveryNoteToGoogleDrive { get; } = new AsyncTasksTaskStatusModelTask(UploadDeliveryNoteToGoogleDriveValue);
        /// <summary> GenerateA3AccountingTransfer. </summary>
        public static AsyncTasksTaskStatusModelTask GenerateA3AccountingTransfer { get; } = new AsyncTasksTaskStatusModelTask(GenerateA3AccountingTransferValue);
        /// <summary> ExportBookIVA. </summary>
        public static AsyncTasksTaskStatusModelTask ExportBookIVA { get; } = new AsyncTasksTaskStatusModelTask(ExportBookIVAValue);
        /// <summary> ExportBookIRPF. </summary>
        public static AsyncTasksTaskStatusModelTask ExportBookIrpf { get; } = new AsyncTasksTaskStatusModelTask(ExportBookIrpfValue);
        /// <summary> ExportBookIVAIRPF. </summary>
        public static AsyncTasksTaskStatusModelTask ExportBookIvairpf { get; } = new AsyncTasksTaskStatusModelTask(ExportBookIvairpfValue);
        /// <summary> ExportAccountingAdvanced. </summary>
        public static AsyncTasksTaskStatusModelTask ExportAccountingAdvanced { get; } = new AsyncTasksTaskStatusModelTask(ExportAccountingAdvancedValue);
        /// <summary> GenerateBankRemittance. </summary>
        public static AsyncTasksTaskStatusModelTask GenerateBankRemittance { get; } = new AsyncTasksTaskStatusModelTask(GenerateBankRemittanceValue);
        /// <summary> GenerateBankRemittanceRefund. </summary>
        public static AsyncTasksTaskStatusModelTask GenerateBankRemittanceRefund { get; } = new AsyncTasksTaskStatusModelTask(GenerateBankRemittanceRefundValue);
        /// <summary> SignVirtualDiskFile. </summary>
        public static AsyncTasksTaskStatusModelTask SignVirtualDiskFile { get; } = new AsyncTasksTaskStatusModelTask(SignVirtualDiskFileValue);
        /// <summary> ImportDataFromFile. </summary>
        public static AsyncTasksTaskStatusModelTask ImportDataFromFile { get; } = new AsyncTasksTaskStatusModelTask(ImportDataFromFileValue);
        /// <summary> Determines if two <see cref="AsyncTasksTaskStatusModelTask"/> values are the same. </summary>
        public static bool operator ==(AsyncTasksTaskStatusModelTask left, AsyncTasksTaskStatusModelTask right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AsyncTasksTaskStatusModelTask"/> values are not the same. </summary>
        public static bool operator !=(AsyncTasksTaskStatusModelTask left, AsyncTasksTaskStatusModelTask right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AsyncTasksTaskStatusModelTask"/>. </summary>
        public static implicit operator AsyncTasksTaskStatusModelTask(string value) => new AsyncTasksTaskStatusModelTask(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AsyncTasksTaskStatusModelTask other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AsyncTasksTaskStatusModelTask other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
