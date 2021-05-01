// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace ContasimpleAPI.Models
{
    /// <summary> Defines the information for creating a folder. </summary>
    public partial class CreateFolderApiModel
    {
        /// <summary> Initializes a new instance of CreateFolderApiModel. </summary>
        /// <param name="name"> The name of the folder to create. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public CreateFolderApiModel(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> The name of the folder to create. </summary>
        public string Name { get; }
        /// <summary> The parent ID of the new folder. </summary>
        public long? ParentId { get; set; }
    }
}