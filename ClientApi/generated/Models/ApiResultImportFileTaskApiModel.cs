// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Implements the generic API response. </summary>
    public partial class ApiResultImportFileTaskApiModel
    {
        /// <summary> Initializes a new instance of ApiResultImportFileTaskApiModel. </summary>
        internal ApiResultImportFileTaskApiModel()
        {
        }

        /// <summary> Initializes a new instance of ApiResultImportFileTaskApiModel. </summary>
        /// <param name="data"> The API result. </param>
        internal ApiResultImportFileTaskApiModel(ImportFileTaskApiModel data)
        {
            Data = data;
        }

        /// <summary> The API result. </summary>
        public ImportFileTaskApiModel Data { get; }
    }
}
