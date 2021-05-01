// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    /// <summary> Defines the information for a country. </summary>
    public partial class CountryApiModel
    {
        /// <summary> Initializes a new instance of CountryApiModel. </summary>
        internal CountryApiModel()
        {
            FiscalRegions = new ChangeTrackingList<FiscalRegionApiModel>();
        }

        /// <summary> Initializes a new instance of CountryApiModel. </summary>
        /// <param name="defaultTimeZone"> The default timezone for the country. </param>
        /// <param name="displayOnAccountConfiguration"> Indicates that the country is available for account configuration. </param>
        /// <param name="fiscalRegions"> The list of fiscal regions on the country. </param>
        /// <param name="id"> The identifier of the country. </param>
        /// <param name="isoCodeAlpha2"> The country ISO Alpha-2 code. </param>
        /// <param name="isoCodeAlpha3"> The country ISO Alpha-3 code. </param>
        /// <param name="name"> The name of the country. </param>
        /// <param name="nifValidationRegex"> The regular expression to use for validation NIF for this country. </param>
        internal CountryApiModel(string defaultTimeZone, bool? displayOnAccountConfiguration, IReadOnlyList<FiscalRegionApiModel> fiscalRegions, long? id, string isoCodeAlpha2, string isoCodeAlpha3, string name, string nifValidationRegex)
        {
            DefaultTimeZone = defaultTimeZone;
            DisplayOnAccountConfiguration = displayOnAccountConfiguration;
            FiscalRegions = fiscalRegions;
            Id = id;
            IsoCodeAlpha2 = isoCodeAlpha2;
            IsoCodeAlpha3 = isoCodeAlpha3;
            Name = name;
            NifValidationRegex = nifValidationRegex;
        }

        /// <summary> The default timezone for the country. </summary>
        public string DefaultTimeZone { get; }
        /// <summary> Indicates that the country is available for account configuration. </summary>
        public bool? DisplayOnAccountConfiguration { get; }
        /// <summary> The list of fiscal regions on the country. </summary>
        public IReadOnlyList<FiscalRegionApiModel> FiscalRegions { get; }
        /// <summary> The identifier of the country. </summary>
        public long? Id { get; }
        /// <summary> The country ISO Alpha-2 code. </summary>
        public string IsoCodeAlpha2 { get; }
        /// <summary> The country ISO Alpha-3 code. </summary>
        public string IsoCodeAlpha3 { get; }
        /// <summary> The name of the country. </summary>
        public string Name { get; }
        /// <summary> The regular expression to use for validation NIF for this country. </summary>
        public string NifValidationRegex { get; }
    }
}
