// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    /// <summary> Class that contains the configuration for a import file request. </summary>
    public partial class ImportFileRequestApiModel
    {
        /// <summary> Initializes a new instance of ImportFileRequestApiModel. </summary>
        public ImportFileRequestApiModel()
        {
            SelectedMappings = new ChangeTrackingList<string>();
        }

        /// <summary> The uploaded filename to import. </summary>
        public string Filename { get; set; }
        /// <summary> The line where the file headers are located (if exists). </summary>
        public int? HeadersLine { get; set; }
        /// <summary> The import type. </summary>
        public ImportFileRequestApiModelImportType? ImportType { get; set; }
        /// <summary> The selected mappings that contains the properties to import. </summary>
        public IList<string> SelectedMappings { get; }
        /// <summary> The line of the file from the import starts. </summary>
        public int? StartAtLine { get; set; }
    }
}
