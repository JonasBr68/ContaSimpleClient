// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Implements the generic API response. </summary>
    public partial class ApiResultAsyncTasksStatusModel
    {
        /// <summary> Initializes a new instance of ApiResultAsyncTasksStatusModel. </summary>
        internal ApiResultAsyncTasksStatusModel()
        {
        }

        /// <summary> Initializes a new instance of ApiResultAsyncTasksStatusModel. </summary>
        /// <param name="data"> The API result. </param>
        internal ApiResultAsyncTasksStatusModel(AsyncTasksStatusModel data)
        {
            Data = data;
        }

        /// <summary> The API result. </summary>
        public AsyncTasksStatusModel Data { get; }
    }
}
