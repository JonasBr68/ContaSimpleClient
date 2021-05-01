// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace ContasimpleAPI.Models
{
    /// <summary> Defines the information for an expense. </summary>
    public partial class ExpenseApiModel
    {
        /// <summary> Initializes a new instance of ExpenseApiModel. </summary>
        internal ExpenseApiModel()
        {
        }

        /// <summary> Initializes a new instance of ExpenseApiModel. </summary>
        /// <param name="aeatAprovedFileId"> If not NULL contains the identifier of the file that contains the related certified document. </param>
        /// <param name="amount"> The amount for the expense (including taxes). </param>
        /// <param name="computablePercentage"> The percentage of the expense that will be involved in the fiscal computations. </param>
        /// <param name="concept"> Brief description about what the expense was. </param>
        /// <param name="creationTime"> DateTime when the expenses was created. </param>
        /// <param name="expenseClass"> The type of expense. </param>
        /// <param name="expenseClassDescription"> The expense class description. </param>
        /// <param name="expenseDate"> Expense date. </param>
        /// <param name="expensePayment"> The payment method. </param>
        /// <param name="hasAeatAprovedFile"> Checks if the current invoice has a certified file. </param>
        /// <param name="id"> The expense identifier. </param>
        /// <param name="issuer"> Contains the expense entity. </param>
        /// <param name="modificationTime"> DateTime when the expenses was updated. </param>
        /// <param name="notes"> Some notes the use can input regarding the expense. </param>
        /// <param name="number"> The expense number. </param>
        /// <param name="period"> Expense period. </param>
        internal ExpenseApiModel(long? aeatAprovedFileId, double? amount, double? computablePercentage, string concept, DateTimeOffset? creationTime, int? expenseClass, string expenseClassDescription, DateTimeOffset? expenseDate, DocumentPaymentApiModel expensePayment, bool? hasAeatAprovedFile, long? id, ExpenseEntity issuer, DateTimeOffset? modificationTime, string notes, string number, string period)
        {
            AeatAprovedFileId = aeatAprovedFileId;
            Amount = amount;
            ComputablePercentage = computablePercentage;
            Concept = concept;
            CreationTime = creationTime;
            ExpenseClass = expenseClass;
            ExpenseClassDescription = expenseClassDescription;
            ExpenseDate = expenseDate;
            ExpensePayment = expensePayment;
            HasAeatAprovedFile = hasAeatAprovedFile;
            Id = id;
            Issuer = issuer;
            ModificationTime = modificationTime;
            Notes = notes;
            Number = number;
            Period = period;
        }

        /// <summary> If not NULL contains the identifier of the file that contains the related certified document. </summary>
        public long? AeatAprovedFileId { get; }
        /// <summary> The amount for the expense (including taxes). </summary>
        public double? Amount { get; }
        /// <summary> The percentage of the expense that will be involved in the fiscal computations. </summary>
        public double? ComputablePercentage { get; }
        /// <summary> Brief description about what the expense was. </summary>
        public string Concept { get; }
        /// <summary> DateTime when the expenses was created. </summary>
        public DateTimeOffset? CreationTime { get; }
        /// <summary> The type of expense. </summary>
        public int? ExpenseClass { get; }
        /// <summary> The expense class description. </summary>
        public string ExpenseClassDescription { get; }
        /// <summary> Expense date. </summary>
        public DateTimeOffset? ExpenseDate { get; }
        /// <summary> The payment method. </summary>
        public DocumentPaymentApiModel ExpensePayment { get; }
        /// <summary> Checks if the current invoice has a certified file. </summary>
        public bool? HasAeatAprovedFile { get; }
        /// <summary> The expense identifier. </summary>
        public long? Id { get; }
        /// <summary> Contains the expense entity. </summary>
        public ExpenseEntity Issuer { get; }
        /// <summary> DateTime when the expenses was updated. </summary>
        public DateTimeOffset? ModificationTime { get; }
        /// <summary> Some notes the use can input regarding the expense. </summary>
        public string Notes { get; }
        /// <summary> The expense number. </summary>
        public string Number { get; }
        /// <summary> Expense period. </summary>
        public string Period { get; }
    }
}
