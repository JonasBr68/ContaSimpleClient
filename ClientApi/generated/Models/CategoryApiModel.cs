// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace ContasimpleAPI.Models
{
    /// <summary> Defines the information of a product category. </summary>
    public partial class CategoryApiModel
    {
        /// <summary> Initializes a new instance of CategoryApiModel. </summary>
        /// <param name="name"> The category name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public CategoryApiModel(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> Initializes a new instance of CategoryApiModel. </summary>
        /// <param name="companyId"> The company that owns the category. </param>
        /// <param name="id"> The identifier of the category. </param>
        /// <param name="name"> The category name. </param>
        /// <param name="parentID"> The category parent ID. </param>
        internal CategoryApiModel(long? companyId, long? id, string name, long? parentID)
        {
            CompanyId = companyId;
            Id = id;
            Name = name;
            ParentID = parentID;
        }

        /// <summary> The company that owns the category. </summary>
        public long? CompanyId { get; set; }
        /// <summary> The identifier of the category. </summary>
        public long? Id { get; set; }
        /// <summary> The category name. </summary>
        public string Name { get; set; }
        /// <summary> The category parent ID. </summary>
        public long? ParentID { get; set; }
    }
}
