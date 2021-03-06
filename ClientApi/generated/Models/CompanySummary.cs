// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> The CompanySummary. </summary>
    public partial class CompanySummary
    {
        /// <summary> Initializes a new instance of CompanySummary. </summary>
        internal CompanySummary()
        {
        }

        /// <summary> Initializes a new instance of CompanySummary. </summary>
        /// <param name="name"> . </param>
        /// <param name="organizationName"> . </param>
        /// <param name="province"> . </param>
        /// <param name="provinceCode"> . </param>
        /// <param name="uid"> . </param>
        internal CompanySummary(string name, string organizationName, string province, string provinceCode, string uid)
        {
            Name = name;
            OrganizationName = organizationName;
            Province = province;
            ProvinceCode = provinceCode;
            Uid = uid;
        }

        public string Name { get; }
        public string OrganizationName { get; }
        public string Province { get; }
        public string ProvinceCode { get; }
        public string Uid { get; }
    }
}
