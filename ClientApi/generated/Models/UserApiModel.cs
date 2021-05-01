// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace ContasimpleAPI.Models
{
    /// <summary> Identifies the information for an application user. </summary>
    public partial class UserApiModel
    {
        /// <summary> Initializes a new instance of UserApiModel. </summary>
        internal UserApiModel()
        {
        }

        /// <summary> Initializes a new instance of UserApiModel. </summary>
        /// <param name="birthDate"> Indicates the birth date of the user. </param>
        /// <param name="brandId"> The ID of the brand where the company was registered. </param>
        /// <param name="canCreateCompanies"> Indicates if the user can create. </param>
        /// <param name="displayName"> The user display name. </param>
        /// <param name="email"> The user email address. </param>
        /// <param name="gender"> Indicates the gender of the user. </param>
        /// <param name="hasAdminRights"> Indicates if the user is an admin. </param>
        /// <param name="hasManagerRights"> Indicates if the user is a manager. </param>
        /// <param name="id"> User identifier. </param>
        /// <param name="name"> The user name. </param>
        /// <param name="phone"> Indicates the user phone number. </param>
        /// <param name="surname"> The user surname. </param>
        /// <param name="timeZone"> The timezone of the user. </param>
        /// <param name="uiCulture"> User preferred culture. </param>
        internal UserApiModel(DateTimeOffset? birthDate, long? brandId, bool? canCreateCompanies, string displayName, string email, UserApiModelGender? gender, bool? hasAdminRights, bool? hasManagerRights, long? id, string name, string phone, string surname, string timeZone, string uiCulture)
        {
            BirthDate = birthDate;
            BrandId = brandId;
            CanCreateCompanies = canCreateCompanies;
            DisplayName = displayName;
            Email = email;
            Gender = gender;
            HasAdminRights = hasAdminRights;
            HasManagerRights = hasManagerRights;
            Id = id;
            Name = name;
            Phone = phone;
            Surname = surname;
            TimeZone = timeZone;
            UiCulture = uiCulture;
        }

        /// <summary> Indicates the birth date of the user. </summary>
        public DateTimeOffset? BirthDate { get; }
        /// <summary> The ID of the brand where the company was registered. </summary>
        public long? BrandId { get; }
        /// <summary> Indicates if the user can create. </summary>
        public bool? CanCreateCompanies { get; }
        /// <summary> The user display name. </summary>
        public string DisplayName { get; }
        /// <summary> The user email address. </summary>
        public string Email { get; }
        /// <summary> Indicates the gender of the user. </summary>
        public UserApiModelGender? Gender { get; }
        /// <summary> Indicates if the user is an admin. </summary>
        public bool? HasAdminRights { get; }
        /// <summary> Indicates if the user is a manager. </summary>
        public bool? HasManagerRights { get; }
        /// <summary> User identifier. </summary>
        public long? Id { get; }
        /// <summary> The user name. </summary>
        public string Name { get; }
        /// <summary> Indicates the user phone number. </summary>
        public string Phone { get; }
        /// <summary> The user surname. </summary>
        public string Surname { get; }
        /// <summary> The timezone of the user. </summary>
        public string TimeZone { get; }
        /// <summary> User preferred culture. </summary>
        public string UiCulture { get; }
    }
}