// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Defines the information related with the WorkingHoursRegistry module configuration. </summary>
    public partial class WorkingHoursRegistryConfigurationApiModel
    {
        /// <summary> Initializes a new instance of WorkingHoursRegistryConfigurationApiModel. </summary>
        internal WorkingHoursRegistryConfigurationApiModel()
        {
        }

        /// <summary> Initializes a new instance of WorkingHoursRegistryConfigurationApiModel. </summary>
        /// <param name="maxWorkingDayHours"> Number of hours that a user can work in a single day. </param>
        internal WorkingHoursRegistryConfigurationApiModel(long? maxWorkingDayHours)
        {
            MaxWorkingDayHours = maxWorkingDayHours;
        }

        /// <summary> Number of hours that a user can work in a single day. </summary>
        public long? MaxWorkingDayHours { get; }
    }
}
