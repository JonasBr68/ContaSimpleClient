// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace ContasimpleAPI.Models
{
    /// <summary> Defines the information for generating a public estimate. </summary>
    public partial class PublicEstimateEntityApiModel
    {
        /// <summary> Initializes a new instance of PublicEstimateEntityApiModel. </summary>
        /// <param name="name"> The organization name of the entity. </param>
        /// <param name="nif"> The NIF number of the entity. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="nif"/> is null. </exception>
        public PublicEstimateEntityApiModel(string name, string nif)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (nif == null)
            {
                throw new ArgumentNullException(nameof(nif));
            }

            Name = name;
            Nif = nif;
        }

        /// <summary> The entity address. </summary>
        public string Address { get; set; }
        /// <summary> The entity city. </summary>
        public string City { get; set; }
        /// <summary> The country identifier. </summary>
        public long? CountryId { get; set; }
        /// <summary> The entity email address. </summary>
        public string Email { get; set; }
        /// <summary> The entity fax number. </summary>
        public string Fax { get; set; }
        /// <summary> The organization name of the entity. </summary>
        public string Name { get; }
        /// <summary> The NIF number of the entity. </summary>
        public string Nif { get; }
        /// <summary> The entity phone number. </summary>
        public string Phone { get; set; }
        /// <summary> The entity postal code. </summary>
        public string PostalCode { get; set; }
        /// <summary> The entity province. </summary>
        public string Province { get; set; }
    }
}
