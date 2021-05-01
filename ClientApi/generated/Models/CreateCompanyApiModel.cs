// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Defines the information for creating a new company. </summary>
    public partial class CreateCompanyApiModel
    {
        /// <summary> Initializes a new instance of CreateCompanyApiModel. </summary>
        public CreateCompanyApiModel()
        {
        }

        /// <summary> The contact email address of the new company to create. </summary>
        public string Email { get; set; }
        /// <summary> The type of the company to create. Only used if the current user has the necessary permissions. </summary>
        public CreateCompanyApiModelType? Type { get; set; }
    }
}
