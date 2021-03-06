// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace ContasimpleAPI.Models
{
    /// <summary> Defines the information about a platform that have access to the user information. </summary>
    public partial class ApiAccessApiModel
    {
        /// <summary> Initializes a new instance of ApiAccessApiModel. </summary>
        internal ApiAccessApiModel()
        {
        }

        /// <summary> Initializes a new instance of ApiAccessApiModel. </summary>
        /// <param name="apiClient"> API client information. </param>
        /// <param name="canDisable"> Indicates if the client can disable user access to the current API client. </param>
        /// <param name="firstAccessTime"> The first time the client accessed the user account. </param>
        /// <param name="isActive"> Indicates if the client access is valid or have been revoked. </param>
        /// <param name="lastAccessTime"> The last time the client accessed the user account. </param>
        internal ApiAccessApiModel(ApiClientApiModel apiClient, bool? canDisable, DateTimeOffset? firstAccessTime, bool? isActive, DateTimeOffset? lastAccessTime)
        {
            ApiClient = apiClient;
            CanDisable = canDisable;
            FirstAccessTime = firstAccessTime;
            IsActive = isActive;
            LastAccessTime = lastAccessTime;
        }

        /// <summary> API client information. </summary>
        public ApiClientApiModel ApiClient { get; }
        /// <summary> Indicates if the client can disable user access to the current API client. </summary>
        public bool? CanDisable { get; }
        /// <summary> The first time the client accessed the user account. </summary>
        public DateTimeOffset? FirstAccessTime { get; }
        /// <summary> Indicates if the client access is valid or have been revoked. </summary>
        public bool? IsActive { get; }
        /// <summary> The last time the client accessed the user account. </summary>
        public DateTimeOffset? LastAccessTime { get; }
    }
}
