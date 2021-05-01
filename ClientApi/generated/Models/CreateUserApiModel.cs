// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace ContasimpleAPI.Models
{
    /// <summary> Contains the information to create a new user. </summary>
    public partial class CreateUserApiModel
    {
        /// <summary> Initializes a new instance of CreateUserApiModel. </summary>
        /// <param name="password"> The password of the new user to create. </param>
        /// <param name="username"> The username of the new user to create. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="password"/> or <paramref name="username"/> is null. </exception>
        public CreateUserApiModel(string password, string username)
        {
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }
            if (username == null)
            {
                throw new ArgumentNullException(nameof(username));
            }

            Password = password;
            Username = username;
        }

        /// <summary> The password of the new user to create. </summary>
        public string Password { get; }
        /// <summary> The role of the new user to create. </summary>
        public CreateUserApiModelRole? Role { get; set; }
        /// <summary> The username of the new user to create. </summary>
        public string Username { get; }
    }
}