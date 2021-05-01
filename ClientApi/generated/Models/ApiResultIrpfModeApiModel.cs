// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Implements the generic API response. </summary>
    public partial class ApiResultIrpfModeApiModel
    {
        /// <summary> Initializes a new instance of ApiResultIrpfModeApiModel. </summary>
        internal ApiResultIrpfModeApiModel()
        {
        }

        /// <summary> Initializes a new instance of ApiResultIrpfModeApiModel. </summary>
        /// <param name="data"> The API result. </param>
        internal ApiResultIrpfModeApiModel(IrpfModeApiModel data)
        {
            Data = data;
        }

        /// <summary> The API result. </summary>
        public IrpfModeApiModel Data { get; }
    }
}