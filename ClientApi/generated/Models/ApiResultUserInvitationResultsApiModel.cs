// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Implements the generic API response. </summary>
    public partial class ApiResultUserInvitationResultsApiModel
    {
        /// <summary> Initializes a new instance of ApiResultUserInvitationResultsApiModel. </summary>
        internal ApiResultUserInvitationResultsApiModel()
        {
        }

        /// <summary> Initializes a new instance of ApiResultUserInvitationResultsApiModel. </summary>
        /// <param name="data"> The API result. </param>
        internal ApiResultUserInvitationResultsApiModel(UserInvitationResultsApiModel data)
        {
            Data = data;
        }

        /// <summary> The API result. </summary>
        public UserInvitationResultsApiModel Data { get; }
    }
}