// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace ContasimpleAPI.Models
{
    /// <summary> Defines the information for a support message template. </summary>
    public partial class SupportMessageTemplateApiModel
    {
        /// <summary> Initializes a new instance of SupportMessageTemplateApiModel. </summary>
        /// <param name="message"> Template message. </param>
        /// <param name="title"> Template title. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="message"/> or <paramref name="title"/> is null. </exception>
        public SupportMessageTemplateApiModel(string message, string title)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }
            if (title == null)
            {
                throw new ArgumentNullException(nameof(title));
            }

            Message = message;
            Title = title;
        }

        /// <summary> Initializes a new instance of SupportMessageTemplateApiModel. </summary>
        /// <param name="category"> Template category. </param>
        /// <param name="creationDate"> Template creation time. </param>
        /// <param name="id"> Template identifier. </param>
        /// <param name="lastUpdate"> Template last update time. </param>
        /// <param name="message"> Template message. </param>
        /// <param name="title"> Template title. </param>
        internal SupportMessageTemplateApiModel(string category, DateTimeOffset? creationDate, long? id, DateTimeOffset? lastUpdate, string message, string title)
        {
            Category = category;
            CreationDate = creationDate;
            Id = id;
            LastUpdate = lastUpdate;
            Message = message;
            Title = title;
        }

        /// <summary> Template category. </summary>
        public string Category { get; set; }
        /// <summary> Template creation time. </summary>
        public DateTimeOffset? CreationDate { get; set; }
        /// <summary> Template identifier. </summary>
        public long? Id { get; set; }
        /// <summary> Template last update time. </summary>
        public DateTimeOffset? LastUpdate { get; set; }
        /// <summary> Template message. </summary>
        public string Message { get; set; }
        /// <summary> Template title. </summary>
        public string Title { get; set; }
    }
}
