// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Implements the generic API response. </summary>
    public partial class ApiResultAccountingPeriodMaintenanceApiModel
    {
        /// <summary> Initializes a new instance of ApiResultAccountingPeriodMaintenanceApiModel. </summary>
        internal ApiResultAccountingPeriodMaintenanceApiModel()
        {
        }

        /// <summary> Initializes a new instance of ApiResultAccountingPeriodMaintenanceApiModel. </summary>
        /// <param name="data"> The API result. </param>
        internal ApiResultAccountingPeriodMaintenanceApiModel(AccountingPeriodMaintenanceApiModel data)
        {
            Data = data;
        }

        /// <summary> The API result. </summary>
        public AccountingPeriodMaintenanceApiModel Data { get; }
    }
}
