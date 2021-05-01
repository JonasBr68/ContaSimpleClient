// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace ContasimpleAPI.Models
{
    /// <summary> Defines the information for an AccountingPeriodMaintenance. </summary>
    public partial class AccountingPeriodMaintenanceApiModel
    {
        /// <summary> Initializes a new instance of AccountingPeriodMaintenanceApiModel. </summary>
        internal AccountingPeriodMaintenanceApiModel()
        {
            Status = "Closed";
        }

        /// <summary> Initializes a new instance of AccountingPeriodMaintenanceApiModel. </summary>
        /// <param name="closeDate"> The close date. </param>
        /// <param name="period"> The accounting period. </param>
        /// <param name="status"> The accounting period status. </param>
        /// <param name="statusDescription"> The status description. </param>
        internal AccountingPeriodMaintenanceApiModel(DateTimeOffset? closeDate, string period, string status, string statusDescription)
        {
            CloseDate = closeDate;
            Period = period;
            Status = status;
            StatusDescription = statusDescription;
        }

        /// <summary> The close date. </summary>
        public DateTimeOffset? CloseDate { get; }
        /// <summary> The accounting period. </summary>
        public string Period { get; }
        /// <summary> The accounting period status. </summary>
        public string Status { get; }
        /// <summary> The status description. </summary>
        public string StatusDescription { get; }
    }
}
