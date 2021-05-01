// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace ContasimpleAPI.Models
{
    /// <summary> Defines the information for a company. </summary>
    public partial class CompanyLightweightApiModel
    {
        /// <summary> Initializes a new instance of CompanyLightweightApiModel. </summary>
        internal CompanyLightweightApiModel()
        {
        }

        /// <summary> Initializes a new instance of CompanyLightweightApiModel. </summary>
        /// <param name="activated"> Indicates if the company is active. </param>
        /// <param name="displayName"> Gets the name to appear on the screen for the company. </param>
        /// <param name="domainId"> The ID of the domain where the company resides. </param>
        /// <param name="email"> Indicates the email address to contact the company. </param>
        /// <param name="expirationDate"> The company current plan expiration date. </param>
        /// <param name="id"> The unique identifier of the company. </param>
        /// <param name="isDefault"> Indicates that the current company is the user default company. </param>
        /// <param name="nif"> Indicates the NIF of the company. </param>
        /// <param name="organizationName"> Indicates the name of the company. </param>
        /// <param name="requiresConfiguration"> Indicates that the company requires to be configured (equivalent to web initial setup). </param>
        /// <param name="type"> The current plan of the company. </param>
        internal CompanyLightweightApiModel(int? activated, string displayName, long? domainId, string email, DateTimeOffset? expirationDate, long? id, bool? isDefault, string nif, string organizationName, bool? requiresConfiguration, CompanyLightweightApiModelType? type)
        {
            Activated = activated;
            DisplayName = displayName;
            DomainId = domainId;
            Email = email;
            ExpirationDate = expirationDate;
            Id = id;
            IsDefault = isDefault;
            Nif = nif;
            OrganizationName = organizationName;
            RequiresConfiguration = requiresConfiguration;
            Type = type;
        }

        /// <summary> Indicates if the company is active. </summary>
        public int? Activated { get; }
        /// <summary> Gets the name to appear on the screen for the company. </summary>
        public string DisplayName { get; }
        /// <summary> The ID of the domain where the company resides. </summary>
        public long? DomainId { get; }
        /// <summary> Indicates the email address to contact the company. </summary>
        public string Email { get; }
        /// <summary> The company current plan expiration date. </summary>
        public DateTimeOffset? ExpirationDate { get; }
        /// <summary> The unique identifier of the company. </summary>
        public long? Id { get; }
        /// <summary> Indicates that the current company is the user default company. </summary>
        public bool? IsDefault { get; }
        /// <summary> Indicates the NIF of the company. </summary>
        public string Nif { get; }
        /// <summary> Indicates the name of the company. </summary>
        public string OrganizationName { get; }
        /// <summary> Indicates that the company requires to be configured (equivalent to web initial setup). </summary>
        public bool? RequiresConfiguration { get; }
        /// <summary> The current plan of the company. </summary>
        public CompanyLightweightApiModelType? Type { get; }
    }
}
