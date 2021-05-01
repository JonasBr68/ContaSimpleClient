// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Implements the generic API response. </summary>
    public partial class ApiResultTaskStatusApiModel
    {
        /// <summary> Initializes a new instance of ApiResultTaskStatusApiModel. </summary>
        internal ApiResultTaskStatusApiModel()
        {
        }

        /// <summary> Initializes a new instance of ApiResultTaskStatusApiModel. </summary>
        /// <param name="data"> The API result. </param>
        internal ApiResultTaskStatusApiModel(TaskStatusApiModel data)
        {
            Data = data;
        }

        /// <summary> The API result. </summary>
        public TaskStatusApiModel Data { get; }
    }
}