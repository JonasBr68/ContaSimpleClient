// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    /// <summary> Contains the information to show the imported file preview data. </summary>
    public partial class ImportedPreviewDataApiModel
    {
        /// <summary> Initializes a new instance of ImportedPreviewDataApiModel. </summary>
        internal ImportedPreviewDataApiModel()
        {
            ImportedSampleData = new ChangeTrackingList<IList<string>>();
            MappingProperties = new ChangeTrackingList<ImportMappingPropertyApiModel>();
        }

        /// <summary> Initializes a new instance of ImportedPreviewDataApiModel. </summary>
        /// <param name="fileTotalColumns"> The total columns that the file contains. </param>
        /// <param name="fileTotalLines"> The total lines that the file contains. </param>
        /// <param name="headersLine"> The line where the file headers are located (if exists). </param>
        /// <param name="importedSampleData"> The imported sample data. </param>
        /// <param name="isMaxColumnsExceeded"> Returns if the max columns is exceeded. </param>
        /// <param name="mappingProperties"> The mappings for the import type. </param>
        /// <param name="startAtLine"> The line from the import starts. </param>
        internal ImportedPreviewDataApiModel(int? fileTotalColumns, int? fileTotalLines, int? headersLine, IReadOnlyList<IList<string>> importedSampleData, bool? isMaxColumnsExceeded, IReadOnlyList<ImportMappingPropertyApiModel> mappingProperties, int? startAtLine)
        {
            FileTotalColumns = fileTotalColumns;
            FileTotalLines = fileTotalLines;
            HeadersLine = headersLine;
            ImportedSampleData = importedSampleData;
            IsMaxColumnsExceeded = isMaxColumnsExceeded;
            MappingProperties = mappingProperties;
            StartAtLine = startAtLine;
        }

        /// <summary> The total columns that the file contains. </summary>
        public int? FileTotalColumns { get; }
        /// <summary> The total lines that the file contains. </summary>
        public int? FileTotalLines { get; }
        /// <summary> The line where the file headers are located (if exists). </summary>
        public int? HeadersLine { get; }
        /// <summary> The imported sample data. </summary>
        public IReadOnlyList<IList<string>> ImportedSampleData { get; }
        /// <summary> Returns if the max columns is exceeded. </summary>
        public bool? IsMaxColumnsExceeded { get; }
        /// <summary> The mappings for the import type. </summary>
        public IReadOnlyList<ImportMappingPropertyApiModel> MappingProperties { get; }
        /// <summary> The line from the import starts. </summary>
        public int? StartAtLine { get; }
    }
}
