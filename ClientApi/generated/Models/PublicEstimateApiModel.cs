// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace ContasimpleAPI.Models
{
    /// <summary> Defines the information for generating a public estimate. </summary>
    public partial class PublicEstimateApiModel
    {
        /// <summary> Initializes a new instance of PublicEstimateApiModel. </summary>
        /// <param name="lines"> The line objects for the estimate. </param>
        /// <param name="me"> Information for the one generating the estimate. </param>
        /// <param name="number"> The estimate number. </param>
        /// <param name="options"> Estimate generation options download the document or false to send it by email to the information setted on &quot;me&quot;/&quot;email&quot; field. </param>
        /// <param name="presupuestoDate"> The estimate date. </param>
        /// <param name="target"> The information of the estimate destination. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="lines"/>, <paramref name="me"/>, <paramref name="number"/>, <paramref name="options"/>, or <paramref name="target"/> is null. </exception>
        public PublicEstimateApiModel(IEnumerable<PublicEstimateLineApiModel> lines, PublicEstimateEntityApiModel me, string number, PublicEstimateSharingOptionsApiModel options, DateTimeOffset presupuestoDate, PublicEstimateEntityApiModel target)
        {
            if (lines == null)
            {
                throw new ArgumentNullException(nameof(lines));
            }
            if (me == null)
            {
                throw new ArgumentNullException(nameof(me));
            }
            if (number == null)
            {
                throw new ArgumentNullException(nameof(number));
            }
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }
            if (target == null)
            {
                throw new ArgumentNullException(nameof(target));
            }

            Lines = lines.ToList();
            Me = me;
            Number = number;
            Options = options;
            PresupuestoDate = presupuestoDate;
            Target = target;
        }

        /// <summary> The estimate configuration (optional). </summary>
        public PublicEstimateConfigurationApiModel Configuration { get; set; }
        /// <summary> Contains estimate expiration date (cuold be null). </summary>
        public DateTimeOffset? ExpirationDate { get; set; }
        /// <summary> Estimate notes. </summary>
        public string Footer { get; set; }
        /// <summary> The line objects for the estimate. </summary>
        public IList<PublicEstimateLineApiModel> Lines { get; }
        /// <summary> The logo token to display on the estimate. Must be uploaded previously using the &quot;/public/estimate/logo&quot; service. </summary>
        public string Logo { get; set; }
        /// <summary> Information for the one generating the estimate. </summary>
        public PublicEstimateEntityApiModel Me { get; }
        /// <summary> The estimate number. </summary>
        public string Number { get; }
        /// <summary> Estimate generation options download the document or false to send it by email to the information setted on &quot;me&quot;/&quot;email&quot; field. </summary>
        public PublicEstimateSharingOptionsApiModel Options { get; }
        /// <summary> The estimate date. </summary>
        public DateTimeOffset PresupuestoDate { get; }
        /// <summary> The estimate retention percentage. </summary>
        public double? RetentionPercentage { get; set; }
        /// <summary> The information of the estimate destination. </summary>
        public PublicEstimateEntityApiModel Target { get; }
    }
}
