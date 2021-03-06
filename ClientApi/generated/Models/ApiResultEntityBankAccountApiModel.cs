// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Implements the generic API response. </summary>
    public partial class ApiResultEntityBankAccountApiModel
    {
        /// <summary> Initializes a new instance of ApiResultEntityBankAccountApiModel. </summary>
        internal ApiResultEntityBankAccountApiModel()
        {
        }

        /// <summary> Initializes a new instance of ApiResultEntityBankAccountApiModel. </summary>
        /// <param name="data"> The API result. </param>
        internal ApiResultEntityBankAccountApiModel(EntityBankAccountApiModel data)
        {
            Data = data;
        }

        /// <summary> The API result. </summary>
        public EntityBankAccountApiModel Data { get; }
    }
}
