// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Defines the limit for a single type. </summary>
    public partial class LimitApiModel
    {
        /// <summary> Initializes a new instance of LimitApiModel. </summary>
        internal LimitApiModel()
        {
        }

        /// <summary> Initializes a new instance of LimitApiModel. </summary>
        /// <param name="current"> Current item count. </param>
        /// <param name="limit"> Current product limit. </param>
        /// <param name="limitMode"> Limit mode. </param>
        internal LimitApiModel(long? current, long? limit, LimitApiModelLimitMode? limitMode)
        {
            Current = current;
            Limit = limit;
            LimitMode = limitMode;
        }

        /// <summary> Current item count. </summary>
        public long? Current { get; }
        /// <summary> Current product limit. </summary>
        public long? Limit { get; }
        /// <summary> Limit mode. </summary>
        public LimitApiModelLimitMode? LimitMode { get; }
    }
}