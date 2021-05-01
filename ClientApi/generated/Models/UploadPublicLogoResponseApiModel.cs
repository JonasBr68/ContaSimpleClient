// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace ContasimpleAPI.Models
{
    /// <summary> Defines the information for an uploadded public logo. </summary>
    public partial class UploadPublicLogoResponseApiModel
    {
        /// <summary> Initializes a new instance of UploadPublicLogoResponseApiModel. </summary>
        internal UploadPublicLogoResponseApiModel()
        {
        }

        /// <summary> Initializes a new instance of UploadPublicLogoResponseApiModel. </summary>
        /// <param name="expiration"> The expiration of the uploaded logo. </param>
        /// <param name="token"> The identifeir of the uploaded logo. </param>
        internal UploadPublicLogoResponseApiModel(DateTimeOffset? expiration, string token)
        {
            Expiration = expiration;
            Token = token;
        }

        /// <summary> The expiration of the uploaded logo. </summary>
        public DateTimeOffset? Expiration { get; }
        /// <summary> The identifeir of the uploaded logo. </summary>
        public string Token { get; }
    }
}
