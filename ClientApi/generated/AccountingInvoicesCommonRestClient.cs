// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using ContasimpleAPI.Models;

namespace ContasimpleAPI
{
    internal partial class AccountingInvoicesCommonRestClient
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of AccountingInvoicesCommonRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public AccountingInvoicesCommonRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            endpoint ??= new Uri("https://api.contasimple.com");

            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateDeliveryNoteLinesToInvoiceLinesRequest(string version, IEnumerable<long> deliveryNotesListDeliveryNoteId, Enum72? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/accounting/invoices/deliveryNoteLinesToInvoiceLines", false);
            if (deliveryNotesListDeliveryNoteId != null)
            {
                uri.AppendQueryDelimited("deliveryNotesList.deliveryNoteId", deliveryNotesListDeliveryNoteId, ",", true);
            }
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json, application/xml, text/xml");
            return message;
        }

        /// <summary>
        /// Returns the lines of the delivery notes passed as parameter converted to invoice lines. For each delivery note, its lines are grouped by taxes when
        /// 
        /// the user has configured the option &quot;group delivery note lines at delivery notes invoicing&quot;. If the option is disabled, returns the lines converted
        /// 
        /// &quot;line by line&quot;.
        /// </summary>
        /// <param name="version"> The String to use. </param>
        /// <param name="deliveryNotesListDeliveryNoteId"> A list of delivery note ids. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public async Task<Response<ApiListResultInvoiceLineApiModel>> DeliveryNoteLinesToInvoiceLinesAsync(string version, IEnumerable<long> deliveryNotesListDeliveryNoteId = null, Enum72? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateDeliveryNoteLinesToInvoiceLinesRequest(version, deliveryNotesListDeliveryNoteId, acceptLanguage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiListResultInvoiceLineApiModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApiListResultInvoiceLineApiModel.DeserializeApiListResultInvoiceLineApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Returns the lines of the delivery notes passed as parameter converted to invoice lines. For each delivery note, its lines are grouped by taxes when
        /// 
        /// the user has configured the option &quot;group delivery note lines at delivery notes invoicing&quot;. If the option is disabled, returns the lines converted
        /// 
        /// &quot;line by line&quot;.
        /// </summary>
        /// <param name="version"> The String to use. </param>
        /// <param name="deliveryNotesListDeliveryNoteId"> A list of delivery note ids. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public Response<ApiListResultInvoiceLineApiModel> DeliveryNoteLinesToInvoiceLines(string version, IEnumerable<long> deliveryNotesListDeliveryNoteId = null, Enum72? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateDeliveryNoteLinesToInvoiceLinesRequest(version, deliveryNotesListDeliveryNoteId, acceptLanguage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiListResultInvoiceLineApiModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApiListResultInvoiceLineApiModel.DeserializeApiListResultInvoiceLineApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateSearchByNumberRequest(string version, string query, Enum73? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/accounting/invoices/search/number", false);
            if (query != null)
            {
                uri.AppendQuery("query", query, true);
            }
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json, application/xml, text/xml");
            return message;
        }

        /// <summary> Searches the invoices with the given number. </summary>
        /// <param name="version"> The String to use. </param>
        /// <param name="query"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public async Task<Response<ApiListResultInvoiceApiModel>> SearchByNumberAsync(string version, string query = null, Enum73? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateSearchByNumberRequest(version, query, acceptLanguage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiListResultInvoiceApiModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApiListResultInvoiceApiModel.DeserializeApiListResultInvoiceApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Searches the invoices with the given number. </summary>
        /// <param name="version"> The String to use. </param>
        /// <param name="query"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public Response<ApiListResultInvoiceApiModel> SearchByNumber(string version, string query = null, Enum73? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateSearchByNumberRequest(version, query, acceptLanguage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiListResultInvoiceApiModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApiListResultInvoiceApiModel.DeserializeApiListResultInvoiceApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(long invoiceId, string version, Enum74? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/accounting/invoices/", false);
            uri.AppendPath(invoiceId, true);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json");
            return message;
        }

        /// <summary> Gets the entity information for the given invoice id. </summary>
        /// <param name="invoiceId"> The identifier of the invoice to retrieve. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public async Task<Response<ApiResultInvoiceApiModel>> GetAsync(long invoiceId, string version, Enum74? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateGetRequest(invoiceId, version, acceptLanguage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultInvoiceApiModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApiResultInvoiceApiModel.DeserializeApiResultInvoiceApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the entity information for the given invoice id. </summary>
        /// <param name="invoiceId"> The identifier of the invoice to retrieve. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public Response<ApiResultInvoiceApiModel> Get(long invoiceId, string version, Enum74? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateGetRequest(invoiceId, version, acceptLanguage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultInvoiceApiModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApiResultInvoiceApiModel.DeserializeApiResultInvoiceApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateAttachRequest(long invoiceId, string version, Enum75? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/accounting/invoices/", false);
            uri.AppendPath(invoiceId, true);
            uri.AppendPath("/attach", false);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json, application/xml, text/xml");
            return message;
        }

        /// <summary> Attaches a file or files to the given invoice. </summary>
        /// <param name="invoiceId"> The identifier of the invoice to attach files to. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public async Task<Response<ApiListResultFileApiModel>> AttachAsync(long invoiceId, string version, Enum75? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateAttachRequest(invoiceId, version, acceptLanguage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiListResultFileApiModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApiListResultFileApiModel.DeserializeApiListResultFileApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Attaches a file or files to the given invoice. </summary>
        /// <param name="invoiceId"> The identifier of the invoice to attach files to. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public Response<ApiListResultFileApiModel> Attach(long invoiceId, string version, Enum75? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateAttachRequest(invoiceId, version, acceptLanguage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiListResultFileApiModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApiListResultFileApiModel.DeserializeApiListResultFileApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateAttachmentsRequest(long invoiceId, string version, int? startIndex, int? numRows, string sort, Enum76? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/accounting/invoices/", false);
            uri.AppendPath(invoiceId, true);
            uri.AppendPath("/attachments", false);
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

        /// <summary> Returns the list of attachments of this invoice. </summary>
        /// <param name="invoiceId"> The identifier of the invoice to attach files to. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="startIndex"> The Integer to use. </param>
        /// <param name="numRows"> The Integer to use. </param>
        /// <param name="sort"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public async Task<Response<ApiListResultFileApiModel>> AttachmentsAsync(long invoiceId, string version, int? startIndex = null, int? numRows = null, string sort = null, Enum76? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateAttachmentsRequest(invoiceId, version, startIndex, numRows, sort, acceptLanguage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiListResultFileApiModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApiListResultFileApiModel.DeserializeApiListResultFileApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Returns the list of attachments of this invoice. </summary>
        /// <param name="invoiceId"> The identifier of the invoice to attach files to. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="startIndex"> The Integer to use. </param>
        /// <param name="numRows"> The Integer to use. </param>
        /// <param name="sort"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public Response<ApiListResultFileApiModel> Attachments(long invoiceId, string version, int? startIndex = null, int? numRows = null, string sort = null, Enum76? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateAttachmentsRequest(invoiceId, version, startIndex, numRows, sort, acceptLanguage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiListResultFileApiModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApiListResultFileApiModel.DeserializeApiListResultFileApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePdfRequest(long invoiceId, string version, Enum81? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/accounting/invoices/", false);
            uri.AppendPath(invoiceId, true);
            uri.AppendPath("/pdf", false);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json, application/xml, text/xml");
            return message;
        }

        /// <summary> Downloads the PDF for the given invoice. </summary>
        /// <param name="invoiceId"> The identifier of the invoice to retrieve. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public async Task<Response<object>> PdfAsync(long invoiceId, string version, Enum81? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreatePdfRequest(invoiceId, version, acceptLanguage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        object value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = document.RootElement.GetObject();
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Downloads the PDF for the given invoice. </summary>
        /// <param name="invoiceId"> The identifier of the invoice to retrieve. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public Response<object> Pdf(long invoiceId, string version, Enum81? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreatePdfRequest(invoiceId, version, acceptLanguage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        object value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = document.RootElement.GetObject();
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
