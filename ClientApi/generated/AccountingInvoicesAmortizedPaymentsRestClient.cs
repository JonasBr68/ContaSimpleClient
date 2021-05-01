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
    internal partial class AccountingInvoicesAmortizedPaymentsRestClient
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of AccountingInvoicesAmortizedPaymentsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public AccountingInvoicesAmortizedPaymentsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            endpoint ??= new Uri("https://api.contasimple.com");

            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetPaymentsRequest(long invoiceId, string version, string period, int? startIndex, int? numRows, string sort, Enum104? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/accounting/", false);
            uri.AppendPath(period, true);
            uri.AppendPath("/invoices/amortized/", false);
            uri.AppendPath(invoiceId, true);
            uri.AppendPath("/payments", false);
            if (startIndex != null)
            {
                uri.AppendQuery("startIndex", startIndex.Value, true);
            }
            if (numRows != null)
            {
                uri.AppendQuery("numRows", numRows.Value, true);
            }
            if (sort != null)
            {
                uri.AppendQuery("sort", sort, true);
            }
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json, application/xml, text/xml");
            return message;
        }

        /// <summary> Gets the payments information for the given invoice id. </summary>
        /// <param name="invoiceId"> The identifier of the invoice to retrieve the payments. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="period"> The String to use. </param>
        /// <param name="startIndex"> The Integer to use. </param>
        /// <param name="numRows"> The Integer to use. </param>
        /// <param name="sort"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="period"/> is null. </exception>
        public async Task<Response<ApiListResultDocumentPaymentApiModel>> GetPaymentsAsync(long invoiceId, string version, string period, int? startIndex = null, int? numRows = null, string sort = null, Enum104? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (period == null)
            {
                throw new ArgumentNullException(nameof(period));
            }

            using var message = CreateGetPaymentsRequest(invoiceId, version, period, startIndex, numRows, sort, acceptLanguage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiListResultDocumentPaymentApiModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApiListResultDocumentPaymentApiModel.DeserializeApiListResultDocumentPaymentApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the payments information for the given invoice id. </summary>
        /// <param name="invoiceId"> The identifier of the invoice to retrieve the payments. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="period"> The String to use. </param>
        /// <param name="startIndex"> The Integer to use. </param>
        /// <param name="numRows"> The Integer to use. </param>
        /// <param name="sort"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="period"/> is null. </exception>
        public Response<ApiListResultDocumentPaymentApiModel> GetPayments(long invoiceId, string version, string period, int? startIndex = null, int? numRows = null, string sort = null, Enum104? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (period == null)
            {
                throw new ArgumentNullException(nameof(period));
            }

            using var message = CreateGetPaymentsRequest(invoiceId, version, period, startIndex, numRows, sort, acceptLanguage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiListResultDocumentPaymentApiModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApiListResultDocumentPaymentApiModel.DeserializeApiListResultDocumentPaymentApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreatePaymentRequest(long invoiceId, string version, string period, string payment, Enum105? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/accounting/", false);
            uri.AppendPath(period, true);
            uri.AppendPath("/invoices/amortized/", false);
            uri.AppendPath(invoiceId, true);
            uri.AppendPath("/payments", false);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json");
            request.Headers.Add("Content-Type", "text/html");
            request.Content = new StringRequestContent(payment);
            return message;
        }

        /// <summary> Gets the payments information for the given invoice id. </summary>
        /// <param name="invoiceId"> The identifier of the invoice to retrieve the payments. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="period"> The String to use. </param>
        /// <param name="payment"> The information of the payment. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/>, <paramref name="period"/>, or <paramref name="payment"/> is null. </exception>
        public async Task<Response<ApiResultDocumentPaymentApiModel>> CreatePaymentAsync(long invoiceId, string version, string period, string payment, Enum105? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (period == null)
            {
                throw new ArgumentNullException(nameof(period));
            }
            if (payment == null)
            {
                throw new ArgumentNullException(nameof(payment));
            }

            using var message = CreateCreatePaymentRequest(invoiceId, version, period, payment, acceptLanguage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultDocumentPaymentApiModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApiResultDocumentPaymentApiModel.DeserializeApiResultDocumentPaymentApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the payments information for the given invoice id. </summary>
        /// <param name="invoiceId"> The identifier of the invoice to retrieve the payments. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="period"> The String to use. </param>
        /// <param name="payment"> The information of the payment. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/>, <paramref name="period"/>, or <paramref name="payment"/> is null. </exception>
        public Response<ApiResultDocumentPaymentApiModel> CreatePayment(long invoiceId, string version, string period, string payment, Enum105? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (period == null)
            {
                throw new ArgumentNullException(nameof(period));
            }
            if (payment == null)
            {
                throw new ArgumentNullException(nameof(payment));
            }

            using var message = CreateCreatePaymentRequest(invoiceId, version, period, payment, acceptLanguage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultDocumentPaymentApiModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApiResultDocumentPaymentApiModel.DeserializeApiResultDocumentPaymentApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreatePaymentRequest(long invoiceId, string version, string period, InvoicePaymentRequestApiModel payment, Enum105? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/accounting/", false);
            uri.AppendPath(period, true);
            uri.AppendPath("/invoices/amortized/", false);
            uri.AppendPath(invoiceId, true);
            uri.AppendPath("/payments", false);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(payment);
            request.Content = content;
            return message;
        }

        /// <summary> Gets the payments information for the given invoice id. </summary>
        /// <param name="invoiceId"> The identifier of the invoice to retrieve the payments. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="period"> The String to use. </param>
        /// <param name="payment"> The information of the payment. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/>, <paramref name="period"/>, or <paramref name="payment"/> is null. </exception>
        public async Task<Response<ApiResultDocumentPaymentApiModel>> CreatePaymentAsync(long invoiceId, string version, string period, InvoicePaymentRequestApiModel payment, Enum105? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (period == null)
            {
                throw new ArgumentNullException(nameof(period));
            }
            if (payment == null)
            {
                throw new ArgumentNullException(nameof(payment));
            }

            using var message = CreateCreatePaymentRequest(invoiceId, version, period, payment, acceptLanguage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultDocumentPaymentApiModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApiResultDocumentPaymentApiModel.DeserializeApiResultDocumentPaymentApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the payments information for the given invoice id. </summary>
        /// <param name="invoiceId"> The identifier of the invoice to retrieve the payments. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="period"> The String to use. </param>
        /// <param name="payment"> The information of the payment. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/>, <paramref name="period"/>, or <paramref name="payment"/> is null. </exception>
        public Response<ApiResultDocumentPaymentApiModel> CreatePayment(long invoiceId, string version, string period, InvoicePaymentRequestApiModel payment, Enum105? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (period == null)
            {
                throw new ArgumentNullException(nameof(period));
            }
            if (payment == null)
            {
                throw new ArgumentNullException(nameof(payment));
            }

            using var message = CreateCreatePaymentRequest(invoiceId, version, period, payment, acceptLanguage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultDocumentPaymentApiModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApiResultDocumentPaymentApiModel.DeserializeApiResultDocumentPaymentApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeletePaymentRequest(long invoiceId, long invoicePaymentId, string version, string period, Enum106? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/accounting/", false);
            uri.AppendPath(period, true);
            uri.AppendPath("/invoices/amortized/", false);
            uri.AppendPath(invoiceId, true);
            uri.AppendPath("/payments/", false);
            uri.AppendPath(invoicePaymentId, true);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json");
            return message;
        }

        /// <summary> Gets the payments information for the given invoice id. </summary>
        /// <param name="invoiceId"> The identifier of the invoice to retrieve the payments. </param>
        /// <param name="invoicePaymentId"> The identifier of the invoice payment to remove. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="period"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="period"/> is null. </exception>
        public async Task<Response<ApiResultInt64>> DeletePaymentAsync(long invoiceId, long invoicePaymentId, string version, string period, Enum106? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (period == null)
            {
                throw new ArgumentNullException(nameof(period));
            }

            using var message = CreateDeletePaymentRequest(invoiceId, invoicePaymentId, version, period, acceptLanguage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultInt64 value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApiResultInt64.DeserializeApiResultInt64(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the payments information for the given invoice id. </summary>
        /// <param name="invoiceId"> The identifier of the invoice to retrieve the payments. </param>
        /// <param name="invoicePaymentId"> The identifier of the invoice payment to remove. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="period"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="period"/> is null. </exception>
        public Response<ApiResultInt64> DeletePayment(long invoiceId, long invoicePaymentId, string version, string period, Enum106? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (period == null)
            {
                throw new ArgumentNullException(nameof(period));
            }

            using var message = CreateDeletePaymentRequest(invoiceId, invoicePaymentId, version, period, acceptLanguage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultInt64 value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApiResultInt64.DeserializeApiResultInt64(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
