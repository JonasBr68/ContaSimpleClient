// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace ContasimpleAPI.Models
{
    /// <summary> Defines the information for the estimate numbering format. </summary>
    public partial class EstimateNumberingFormatRequestApiModel
    {
        /// <summary> Initializes a new instance of EstimateNumberingFormatRequestApiModel. </summary>
        /// <param name="mask"> The numbering format mask. </param>
        /// <param name="name"> The name of the numbering format. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mask"/> or <paramref name="name"/> is null. </exception>
        public EstimateNumberingFormatRequestApiModel(string mask, string name)
        {
            if (mask == null)
            {
                throw new ArgumentNullException(nameof(mask));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Mask = mask;
            Name = name;
        }

        /// <summary> The numbering format mask. </summary>
        public string Mask { get; }
        /// <summary> The name of the numbering format. </summary>
        public string Name { get; }
    }
}
