// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Implements the generic API response. </summary>
    public partial class ApiResultDeliveryNoteApiModel
    {
        /// <summary> Initializes a new instance of ApiResultDeliveryNoteApiModel. </summary>
        internal ApiResultDeliveryNoteApiModel()
        {
        }

        /// <summary> Initializes a new instance of ApiResultDeliveryNoteApiModel. </summary>
        /// <param name="data"> The API result. </param>
        internal ApiResultDeliveryNoteApiModel(DeliveryNoteApiModel data)
        {
            Data = data;
        }

        /// <summary> The API result. </summary>
        public DeliveryNoteApiModel Data { get; }
    }
}
