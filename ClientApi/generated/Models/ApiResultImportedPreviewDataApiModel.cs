// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Implements the generic API response. </summary>
    public partial class ApiResultImportedPreviewDataApiModel
    {
        /// <summary> Initializes a new instance of ApiResultImportedPreviewDataApiModel. </summary>
        internal ApiResultImportedPreviewDataApiModel()
        {
        }

        /// <summary> Initializes a new instance of ApiResultImportedPreviewDataApiModel. </summary>
        /// <param name="data"> The API result. </param>
        internal ApiResultImportedPreviewDataApiModel(ImportedPreviewDataApiModel data)
        {
            Data = data;
        }

        /// <summary> The API result. </summary>
        public ImportedPreviewDataApiModel Data { get; }
    }
}
