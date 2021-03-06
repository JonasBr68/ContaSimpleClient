// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Defines the information for an operation type. </summary>
    public partial class OperationTypeApiModel
    {
        /// <summary> Initializes a new instance of OperationTypeApiModel. </summary>
        internal OperationTypeApiModel()
        {
        }

        /// <summary> Initializes a new instance of OperationTypeApiModel. </summary>
        /// <param name="description"> The description of the operation type. </param>
        /// <param name="operation"> The operation type value. </param>
        /// <param name="transaction"> The name of the operation type. </param>
        internal OperationTypeApiModel(string description, OperationTypeApiModelOperation? operation, string transaction)
        {
            Description = description;
            Operation = operation;
            Transaction = transaction;
        }

        /// <summary> The description of the operation type. </summary>
        public string Description { get; }
        /// <summary> The operation type value. </summary>
        public OperationTypeApiModelOperation? Operation { get; }
        /// <summary> The name of the operation type. </summary>
        public string Transaction { get; }
    }
}
