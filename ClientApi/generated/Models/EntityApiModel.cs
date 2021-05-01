// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace ContasimpleAPI.Models
{
    /// <summary> Defines the information for working with entities. </summary>
    public partial class EntityApiModel
    {
        /// <summary> Initializes a new instance of EntityApiModel. </summary>
        /// <param name="nif"> The NIF number of the entity. </param>
        /// <param name="organization"> The organization name of the entity. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nif"/> or <paramref name="organization"/> is null. </exception>
        public EntityApiModel(string nif, string organization)
        {
            if (nif == null)
            {
                throw new ArgumentNullException(nameof(nif));
            }
            if (organization == null)
            {
                throw new ArgumentNullException(nameof(organization));
            }

            Nif = nif;
            Organization = organization;
        }

        /// <summary> Initializes a new instance of EntityApiModel. </summary>
        /// <param name="address"> The entity address. </param>
        /// <param name="city"> The entity city. </param>
        /// <param name="companyId"> The company that owns the entity. </param>
        /// <param name="country"> The entity country. Do not use (available only for old clients). Use the countryId otherwise. </param>
        /// <param name="countryId"> The country identifier. </param>
        /// <param name="customField1"> The entity custom field 1. </param>
        /// <param name="customField2"> The entity custom field 2. </param>
        /// <param name="discountPercentage"> The default discount percentage to apply on the concept lines for this entity. </param>
        /// <param name="email"> The entity email address. </param>
        /// <param name="fax"> The entity fax number. </param>
        /// <param name="firstname"> The person firstname (required for company type = autonomo). </param>
        /// <param name="id"> The identifier of the entity. </param>
        /// <param name="lastname"> The person lastname (required for company type = autonomo). </param>
        /// <param name="latitude">
        /// Map latitude of the contact. Does not have to match the exact address latitude
        /// 
        /// A value between: [-90, +90].
        /// </param>
        /// <param name="longitude">
        /// Map longitude of the contact. Does not have to match the exact address longitude
        /// 
        /// A value between: [-180,+180].
        /// </param>
        /// <param name="name"> The person name (required for company type = autonomo). </param>
        /// <param name="nif"> The NIF number of the entity. </param>
        /// <param name="notes"> The entity notes. </param>
        /// <param name="organization"> The organization name of the entity. </param>
        /// <param name="phone"> The entity phone number. </param>
        /// <param name="postalCode"> The entity postal code. </param>
        /// <param name="province"> The entity province. </param>
        /// <param name="type"> The type of entity. </param>
        /// <param name="url"> The entity URL address. </param>
        internal EntityApiModel(string address, string city, long? companyId, string country, long? countryId, string customField1, string customField2, double? discountPercentage, string email, string fax, string firstname, long? id, string lastname, double? latitude, double? longitude, string name, string nif, string notes, string organization, string phone, string postalCode, string province, EntityApiModelType? type, string url)
        {
            Address = address;
            City = city;
            CompanyId = companyId;
            Country = country;
            CountryId = countryId;
            CustomField1 = customField1;
            CustomField2 = customField2;
            DiscountPercentage = discountPercentage;
            Email = email;
            Fax = fax;
            Firstname = firstname;
            Id = id;
            Lastname = lastname;
            Latitude = latitude;
            Longitude = longitude;
            Name = name;
            Nif = nif;
            Notes = notes;
            Organization = organization;
            Phone = phone;
            PostalCode = postalCode;
            Province = province;
            Type = type;
            Url = url;
        }

        /// <summary> The entity address. </summary>
        public string Address { get; set; }
        /// <summary> The entity city. </summary>
        public string City { get; set; }
        /// <summary> The company that owns the entity. </summary>
        public long? CompanyId { get; set; }
        /// <summary> The entity country. Do not use (available only for old clients). Use the countryId otherwise. </summary>
        public string Country { get; set; }
        /// <summary> The country identifier. </summary>
        public long? CountryId { get; set; }
        /// <summary> The entity custom field 1. </summary>
        public string CustomField1 { get; set; }
        /// <summary> The entity custom field 2. </summary>
        public string CustomField2 { get; set; }
        /// <summary> The default discount percentage to apply on the concept lines for this entity. </summary>
        public double? DiscountPercentage { get; set; }
        /// <summary> The entity email address. </summary>
        public string Email { get; set; }
        /// <summary> The entity fax number. </summary>
        public string Fax { get; set; }
        /// <summary> The person firstname (required for company type = autonomo). </summary>
        public string Firstname { get; set; }
        /// <summary> The identifier of the entity. </summary>
        public long? Id { get; set; }
        /// <summary> The person lastname (required for company type = autonomo). </summary>
        public string Lastname { get; set; }
        /// <summary>
        /// Map latitude of the contact. Does not have to match the exact address latitude
        /// 
        /// A value between: [-90, +90].
        /// </summary>
        public double? Latitude { get; set; }
        /// <summary>
        /// Map longitude of the contact. Does not have to match the exact address longitude
        /// 
        /// A value between: [-180,+180].
        /// </summary>
        public double? Longitude { get; set; }
        /// <summary> The person name (required for company type = autonomo). </summary>
        public string Name { get; set; }
        /// <summary> The NIF number of the entity. </summary>
        public string Nif { get; set; }
        /// <summary> The entity notes. </summary>
        public string Notes { get; set; }
        /// <summary> The organization name of the entity. </summary>
        public string Organization { get; set; }
        /// <summary> The entity phone number. </summary>
        public string Phone { get; set; }
        /// <summary> The entity postal code. </summary>
        public string PostalCode { get; set; }
        /// <summary> The entity province. </summary>
        public string Province { get; set; }
        /// <summary> The type of entity. </summary>
        public EntityApiModelType? Type { get; set; }
        /// <summary> The entity URL address. </summary>
        public string Url { get; set; }
    }
}