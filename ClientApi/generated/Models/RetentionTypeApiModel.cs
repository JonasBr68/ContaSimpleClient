// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Contains the information for a retention type. </summary>
    public partial class RetentionTypeApiModel
    {
        /// <summary> Initializes a new instance of RetentionTypeApiModel. </summary>
        internal RetentionTypeApiModel()
        {
        }

        /// <summary> Initializes a new instance of RetentionTypeApiModel. </summary>
        /// <param name="category"> The retention category. </param>
        /// <param name="id"> The retention identifier. </param>
        /// <param name="isDefault"> Indicates if the retention is the default one. </param>
        /// <param name="name"> The retention name. </param>
        /// <param name="order"> The display order. </param>
        /// <param name="percent"> The retention percentaje. </param>
        /// <param name="type"> The retention type. </param>
        internal RetentionTypeApiModel(RetentionTypeApiModelCategory? category, long? id, bool? isDefault, string name, int? order, double? percent, RetentionTypeApiModelType? type)
        {
            Category = category;
            Id = id;
            IsDefault = isDefault;
            Name = name;
            Order = order;
            Percent = percent;
            Type = type;
        }

        /// <summary> The retention category. </summary>
        public RetentionTypeApiModelCategory? Category { get; }
        /// <summary> The retention identifier. </summary>
        public long? Id { get; }
        /// <summary> Indicates if the retention is the default one. </summary>
        public bool? IsDefault { get; }
        /// <summary> The retention name. </summary>
        public string Name { get; }
        /// <summary> The display order. </summary>
        public int? Order { get; }
        /// <summary> The retention percentaje. </summary>
        public double? Percent { get; }
        /// <summary> The retention type. </summary>
        public RetentionTypeApiModelType? Type { get; }
    }
}
