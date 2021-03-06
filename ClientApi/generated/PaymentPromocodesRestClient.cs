// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using ContasimpleAPI.Models;

namespace ContasimpleAPI
{
    internal partial class PaymentPromocodesRestClient
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of PaymentPromocodesRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public PaymentPromocodesRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            endpoint ??= new Uri("https://api.contasimple.com");

            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetPaymentPromocodeRequest(string code, string version, Enum425? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/payments/promocodes/", false);
            uri.AppendPath(code, true);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json");
            return message;
        }

        /// <summary> Gets the payment promocode. </summary>
        /// <param name="code"> The identifier of the note to retrieve. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> or <paramref name="version"/> is null. </exception>
        public async Task<Response<ApiResultPaymentPromocode>> GetPaymentPromocodeAsync(string code, string version, Enum425? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (code == null)
            {
                throw new ArgumentNullException(nameof(code));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateGetPaymentPromocodeRequest(code, version, acceptLanguage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultPaymentPromocode value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApiResultPaymentPromocode.DeserializeApiResultPaymentPromocode(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the payment promocode. </summary>
        /// <param name="code"> The identifier of the note to retrieve. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> or <paramref name="version"/> is null. </exception>
        public Response<ApiResultPaymentPromocode> GetPaymentPromocode(string code, string version, Enum425? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (code == null)
            {
                throw new ArgumentNullException(nameof(code));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateGetPaymentPromocodeRequest(code, version, acceptLanguage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultPaymentPromocode value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApiResultPaymentPromocode.DeserializeApiResultPaymentPromocode(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateIsPaymentPromocodeUsedByCompanyRequest(long paymentPromocodeId, long companyId, string version, Enum426? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/payments/promocodes/", false);
            uri.AppendPath(paymentPromocodeId, true);
            uri.AppendPath("/isUsedBy/", false);
            uri.AppendPath(companyId, true);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json");
            return message;
        }

        /// <summary> Checks if a promotional code has been already used by a company. </summary>
        /// <param name="paymentPromocodeId"> Id of the promotion. </param>
        /// <param name="companyId"> Id of the company. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public async Task<Response<ApiResultBoolean>> IsPaymentPromocodeUsedByCompanyAsync(long paymentPromocodeId, long companyId, string version, Enum426? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateIsPaymentPromocodeUsedByCompanyRequest(paymentPromocodeId, companyId, version, acceptLanguage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultBoolean value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApiResultBoolean.DeserializeApiResultBoolean(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Checks if a promotional code has been already used by a company. </summary>
        /// <param name="paymentPromocodeId"> Id of the promotion. </param>
        /// <param name="companyId"> Id of the company. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public Response<ApiResultBoolean> IsPaymentPromocodeUsedByCompany(long paymentPromocodeId, long companyId, string version, Enum426? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateIsPaymentPromocodeUsedByCompanyRequest(paymentPromocodeId, companyId, version, acceptLanguage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultBoolean value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApiResultBoolean.DeserializeApiResultBoolean(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
