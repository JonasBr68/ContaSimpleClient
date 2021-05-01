// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ContasimpleAPI.Models
{
    /// <summary> Contains the information of a company email configuration. </summary>
    public partial class MailConfigurationApiModel
    {
        /// <summary> Initializes a new instance of MailConfigurationApiModel. </summary>
        internal MailConfigurationApiModel()
        {
        }

        /// <summary> Initializes a new instance of MailConfigurationApiModel. </summary>
        /// <param name="defaultValueReplyTo"> The default value for the &quot;reply to&quot; field. </param>
        /// <param name="fromEmail"> The email address to display as &quot;from&quot; field. </param>
        /// <param name="fromName"> The name to display as &quot;from&quot; field. </param>
        /// <param name="mailProvider"> The kind of provider configured for the current company. </param>
        /// <param name="shouldHideReplyToAndCopyField"> If the company requires the &quot;ReplyTo&quot; and &quot;SendBccCopy&quot; to be hidden. </param>
        internal MailConfigurationApiModel(string defaultValueReplyTo, string fromEmail, string fromName, MailConfigurationApiModelMailProvider? mailProvider, bool? shouldHideReplyToAndCopyField)
        {
            DefaultValueReplyTo = defaultValueReplyTo;
            FromEmail = fromEmail;
            FromName = fromName;
            MailProvider = mailProvider;
            ShouldHideReplyToAndCopyField = shouldHideReplyToAndCopyField;
        }

        /// <summary> The default value for the &quot;reply to&quot; field. </summary>
        public string DefaultValueReplyTo { get; }
        /// <summary> The email address to display as &quot;from&quot; field. </summary>
        public string FromEmail { get; }
        /// <summary> The name to display as &quot;from&quot; field. </summary>
        public string FromName { get; }
        /// <summary> The kind of provider configured for the current company. </summary>
        public MailConfigurationApiModelMailProvider? MailProvider { get; }
        /// <summary> If the company requires the &quot;ReplyTo&quot; and &quot;SendBccCopy&quot; to be hidden. </summary>
        public bool? ShouldHideReplyToAndCopyField { get; }
    }
}