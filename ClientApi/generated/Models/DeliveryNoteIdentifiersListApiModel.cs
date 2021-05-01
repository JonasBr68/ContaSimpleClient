// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    /// <summary> The list of delivery note identifier. </summary>
    public partial class DeliveryNoteIdentifiersListApiModel
    {
        /// <summary> Initializes a new instance of DeliveryNoteIdentifiersListApiModel. </summary>
        public DeliveryNoteIdentifiersListApiModel()
        {
            Identifiers = new ChangeTrackingList<long>();
        }

        /// <summary> The list of identifiers. </summary>
        public IList<long> Identifiers { get; }
    }
}