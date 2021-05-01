// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The type of execution to process. </summary>
    public readonly partial struct PostContentSchemaGrantType : IEquatable<PostContentSchemaGrantType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="PostContentSchemaGrantType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PostContentSchemaGrantType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SignupValue = "signup";
        private const string PasswordValue = "password";
        private const string FacebookValue = "facebook";
        private const string GoogleValue = "google";
        private const string AppleValue = "apple";
        private const string RefreshTokenValue = "refresh_token";
        private const string ImpersonateValue = "impersonate";
        private const string ChangeCompanyValue = "change_company";
        private const string AuthenticationKeyValue = "authentication_key";
        private const string AutologinTokenValue = "autologin_token";

        /// <summary> signup. </summary>
        public static PostContentSchemaGrantType Signup { get; } = new PostContentSchemaGrantType(SignupValue);
        /// <summary> password. </summary>
        public static PostContentSchemaGrantType Password { get; } = new PostContentSchemaGrantType(PasswordValue);
        /// <summary> facebook. </summary>
        public static PostContentSchemaGrantType Facebook { get; } = new PostContentSchemaGrantType(FacebookValue);
        /// <summary> google. </summary>
        public static PostContentSchemaGrantType Google { get; } = new PostContentSchemaGrantType(GoogleValue);
        /// <summary> apple. </summary>
        public static PostContentSchemaGrantType Apple { get; } = new PostContentSchemaGrantType(AppleValue);
        /// <summary> refresh_token. </summary>
        public static PostContentSchemaGrantType RefreshToken { get; } = new PostContentSchemaGrantType(RefreshTokenValue);
        /// <summary> impersonate. </summary>
        public static PostContentSchemaGrantType Impersonate { get; } = new PostContentSchemaGrantType(ImpersonateValue);
        /// <summary> change_company. </summary>
        public static PostContentSchemaGrantType ChangeCompany { get; } = new PostContentSchemaGrantType(ChangeCompanyValue);
        /// <summary> authentication_key. </summary>
        public static PostContentSchemaGrantType AuthenticationKey { get; } = new PostContentSchemaGrantType(AuthenticationKeyValue);
        /// <summary> autologin_token. </summary>
        public static PostContentSchemaGrantType AutologinToken { get; } = new PostContentSchemaGrantType(AutologinTokenValue);
        /// <summary> Determines if two <see cref="PostContentSchemaGrantType"/> values are the same. </summary>
        public static bool operator ==(PostContentSchemaGrantType left, PostContentSchemaGrantType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PostContentSchemaGrantType"/> values are not the same. </summary>
        public static bool operator !=(PostContentSchemaGrantType left, PostContentSchemaGrantType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PostContentSchemaGrantType"/>. </summary>
        public static implicit operator PostContentSchemaGrantType(string value) => new PostContentSchemaGrantType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PostContentSchemaGrantType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PostContentSchemaGrantType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
