// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Class that contains the information for the edition of the user company role. </summary>
    public partial class UpdateUserCompanyRoleApiModel
    {
        /// <summary> Initializes a new instance of UpdateUserCompanyRoleApiModel. </summary>
        internal UpdateUserCompanyRoleApiModel()
        {
        }

        /// <summary> Initializes a new instance of UpdateUserCompanyRoleApiModel. </summary>
        /// <param name="userCompanyId"> The user id that is being edited. </param>
        /// <param name="userCompanyRole"> The user company role of the edition. </param>
        internal UpdateUserCompanyRoleApiModel(long? userCompanyId, UpdateUserCompanyRoleApiModelUserCompanyRole? userCompanyRole)
        {
            UserCompanyId = userCompanyId;
            UserCompanyRole = userCompanyRole;
        }

        /// <summary> The user id that is being edited. </summary>
        public long? UserCompanyId { get; }
        /// <summary> The user company role of the edition. </summary>
        public UpdateUserCompanyRoleApiModelUserCompanyRole? UserCompanyRole { get; }
    }
}
