// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Class that contains the information of a sign file task. </summary>
    public partial class SignFileTaskApiModel
    {
        /// <summary> Initializes a new instance of SignFileTaskApiModel. </summary>
        internal SignFileTaskApiModel()
        {
        }

        /// <summary> Initializes a new instance of SignFileTaskApiModel. </summary>
        /// <param name="fileId"> The file id that will be signed. </param>
        /// <param name="signedFileName"> The name of the signed file. </param>
        /// <param name="taskId"> The task id. </param>
        internal SignFileTaskApiModel(long? fileId, string signedFileName, long? taskId)
        {
            FileId = fileId;
            SignedFileName = signedFileName;
            TaskId = taskId;
        }

        /// <summary> The file id that will be signed. </summary>
        public long? FileId { get; }
        /// <summary> The name of the signed file. </summary>
        public string SignedFileName { get; }
        /// <summary> The task id. </summary>
        public long? TaskId { get; }
    }
}
