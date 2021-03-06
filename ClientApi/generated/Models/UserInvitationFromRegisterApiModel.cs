// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Class that contains the information for accept an invitation to a company from the register. </summary>
    public partial class UserInvitationFromRegisterApiModel
    {
        /// <summary> Initializes a new instance of UserInvitationFromRegisterApiModel. </summary>
        public UserInvitationFromRegisterApiModel()
        {
        }

        /// <summary> The invitation id. </summary>
        public long? InvitationId { get; set; }
        /// <summary> The invitation token. </summary>
        public string InvitationToken { get; set; }
    }
}
