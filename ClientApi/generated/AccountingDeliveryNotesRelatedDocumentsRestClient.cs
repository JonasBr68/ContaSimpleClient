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
    internal partial class AccountingDeliveryNotesRelatedDocumentsRestClient
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of AccountingDeliveryNotesRelatedDocumentsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public AccountingDeliveryNotesRelatedDocumentsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            endpoint ??= new Uri("https://api.contasimple.com");

            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateDeleteRelatedEstimateRequest(long deliveryNoteId, string version, Enum31? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/accounting/deliveryNotes/", false);
            uri.AppendPath(deliveryNoteId, true);
            uri.AppendPath("/relatedEstimate", false);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json");
            return message;
        }

        /// <summary> Removes the delivery note related estimate. </summary>
        /// <param name="deliveryNoteId"> The identifier of the delivery note to delete the related estimate. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public async Task<Response<ApiResultBoolean>> DeleteRelatedEstimateAsync(long deliveryNoteId, string version, Enum31? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateDeleteRelatedEstimateRequest(deliveryNoteId, version, acceptLanguage);
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

        /// <summary> Removes the delivery note related estimate. </summary>
        /// <param name="deliveryNoteId"> The identifier of the delivery note to delete the related estimate. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public Response<ApiResultBoolean> DeleteRelatedEstimate(long deliveryNoteId, string version, Enum31? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateDeleteRelatedEstimateRequest(deliveryNoteId, version, acceptLanguage);
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

        internal HttpMessage CreateGetRelatedEstimateRequest(long deliveryNoteId, string version, Enum32? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/accounting/deliveryNotes/", false);
            uri.AppendPath(deliveryNoteId, true);
            uri.AppendPath("/relatedEstimate", false);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json");
            return message;
        }

        /// <summary> Gets the estimate related to the requested delivery note id. </summary>
        /// <param name="deliveryNoteId"> The identifier of the delivery note to retrieve the related estimate. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public async Task<Response<ApiResultEstimateApiModel>> GetRelatedEstimateAsync(long deliveryNoteId, string version, Enum32? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateGetRelatedEstimateRequest(deliveryNoteId, version, acceptLanguage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultEstimateApiModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApiResultEstimateApiModel.DeserializeApiResultEstimateApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the estimate related to the requested delivery note id. </summary>
        /// <param name="deliveryNoteId"> The identifier of the delivery note to retrieve the related estimate. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public Response<ApiResultEstimateApiModel> GetRelatedEstimate(long deliveryNoteId, string version, Enum32? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateGetRelatedEstimateRequest(deliveryNoteId, version, acceptLanguage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultEstimateApiModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApiResultEstimateApiModel.DeserializeApiResultEstimateApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRelatedEstimateRequest(long deliveryNoteId, long estimateId, string version, Enum35? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/accounting/deliveryNotes/", false);
            uri.AppendPath(deliveryNoteId, true);
            uri.AppendPath("/relatedEstimate/", false);
            uri.AppendPath(estimateId, true);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json");
            return message;
        }

        /// <summary> Updates the delivery note related estimate. </summary>
        /// <param name="deliveryNoteId"> The identifier of the delivery note to update the related estimate. </param>
        /// <param name="estimateId"> The identifier of the estimate to attach. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public async Task<Response<ApiResultEstimateApiModel>> UpdateRelatedEstimateAsync(long deliveryNoteId, long estimateId, string version, Enum35? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateUpdateRelatedEstimateRequest(deliveryNoteId, estimateId, version, acceptLanguage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultEstimateApiModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApiResultEstimateApiModel.DeserializeApiResultEstimateApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Updates the delivery note related estimate. </summary>
        /// <param name="deliveryNoteId"> The identifier of the delivery note to update the related estimate. </param>
        /// <param name="estimateId"> The identifier of the estimate to attach. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public Response<ApiResultEstimateApiModel> UpdateRelatedEstimate(long deliveryNoteId, long estimateId, string version, Enum35? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateUpdateRelatedEstimateRequest(deliveryNoteId, estimateId, version, acceptLanguage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultEstimateApiModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApiResultEstimateApiModel.DeserializeApiResultEstimateApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRelatedInvoicesRequest(long deliveryNoteId, string version, Enum36? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/accounting/deliveryNotes/", false);
            uri.AppendPath(deliveryNoteId, true);
            uri.AppendPath("/relatedInvoices", false);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json");
            return message;
        }

        /// <summary> Removes the delivery note related invoices. </summary>
        /// <param name="deliveryNoteId"> The identifier of the delivery note to delete the related invoices. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public async Task<Response<ApiResultBoolean>> DeleteRelatedInvoicesAsync(long deliveryNoteId, string version, Enum36? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateDeleteRelatedInvoicesRequest(deliveryNoteId, version, acceptLanguage);
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

        /// <summary> Removes the delivery note related invoices. </summary>
        /// <param name="deliveryNoteId"> The identifier of the delivery note to delete the related invoices. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public Response<ApiResultBoolean> DeleteRelatedInvoices(long deliveryNoteId, string version, Enum36? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateDeleteRelatedInvoicesRequest(deliveryNoteId, version, acceptLanguage);
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

        internal HttpMessage CreateGetRelatedInvoicesRequest(long deliveryNoteId, string version, Enum37? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/accounting/deliveryNotes/", false);
            uri.AppendPath(deliveryNoteId, true);
            uri.AppendPath("/relatedInvoices", false);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json, application/xml, text/xml");
            return message;
        }

        /// <summary> Gets the invoices related to the requested delivery note id. </summary>
        /// <param name="deliveryNoteId"> The identifier of the delivery note to retrieve the related invoices. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public async Task<Response<ApiListResultInvoiceApiModel>> GetRelatedInvoicesAsync(long deliveryNoteId, string version, Enum37? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateGetRelatedInvoicesRequest(deliveryNoteId, version, acceptLanguage);
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

        /// <summary> Gets the invoices related to the requested delivery note id. </summary>
        /// <param name="deliveryNoteId"> The identifier of the delivery note to retrieve the related invoices. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public Response<ApiListResultInvoiceApiModel> GetRelatedInvoices(long deliveryNoteId, string version, Enum37? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateGetRelatedInvoicesRequest(deliveryNoteId, version, acceptLanguage);
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

        internal HttpMessage CreateUpdateRelatedInvoicesRequest(long deliveryNoteId, string version, string invoices, Enum42? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/accounting/deliveryNotes/", false);
            uri.AppendPath(deliveryNoteId, true);
            uri.AppendPath("/relatedInvoices", false);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json, application/xml, text/xml");
            request.Headers.Add("Content-Type", "text/html");
            request.Content = new StringRequestContent(invoices);
            return message;
        }

        /// <summary>
        /// Assigns the list of invoices to the given delivery note.
        /// 
        /// Does not remove current assigned invoices.
        /// </summary>
        /// <param name="deliveryNoteId"> The identifier of the delivery note to assign the invoices. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="invoices"> The list of invoice identifiers. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="invoices"/> is null. </exception>
        public async Task<Response<ApiListResultInvoiceApiModel>> UpdateRelatedInvoicesAsync(long deliveryNoteId, string version, string invoices, Enum42? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (invoices == null)
            {
                throw new ArgumentNullException(nameof(invoices));
            }

            using var message = CreateUpdateRelatedInvoicesRequest(deliveryNoteId, version, invoices, acceptLanguage);
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

        /// <summary>
        /// Assigns the list of invoices to the given delivery note.
        /// 
        /// Does not remove current assigned invoices.
        /// </summary>
        /// <param name="deliveryNoteId"> The identifier of the delivery note to assign the invoices. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="invoices"> The list of invoice identifiers. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="invoices"/> is null. </exception>
        public Response<ApiListResultInvoiceApiModel> UpdateRelatedInvoices(long deliveryNoteId, string version, string invoices, Enum42? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (invoices == null)
            {
                throw new ArgumentNullException(nameof(invoices));
            }

            using var message = CreateUpdateRelatedInvoicesRequest(deliveryNoteId, version, invoices, acceptLanguage);
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

        internal HttpMessage CreateUpdateRelatedInvoicesRequest(long deliveryNoteId, string version, InvoiceIdentifiersListApiModel invoices, Enum42? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/accounting/deliveryNotes/", false);
            uri.AppendPath(deliveryNoteId, true);
            uri.AppendPath("/relatedInvoices", false);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json, application/xml, text/xml");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(invoices);
            request.Content = content;
            return message;
        }

        /// <summary>
        /// Assigns the list of invoices to the given delivery note.
        /// 
        /// Does not remove current assigned invoices.
        /// </summary>
        /// <param name="deliveryNoteId"> The identifier of the delivery note to assign the invoices. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="invoices"> The list of invoice identifiers. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="invoices"/> is null. </exception>
        public async Task<Response<ApiListResultInvoiceApiModel>> UpdateRelatedInvoicesAsync(long deliveryNoteId, string version, InvoiceIdentifiersListApiModel invoices, Enum42? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (invoices == null)
            {
                throw new ArgumentNullException(nameof(invoices));
            }

            using var message = CreateUpdateRelatedInvoicesRequest(deliveryNoteId, version, invoices, acceptLanguage);
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

        /// <summary>
        /// Assigns the list of invoices to the given delivery note.
        /// 
        /// Does not remove current assigned invoices.
        /// </summary>
        /// <param name="deliveryNoteId"> The identifier of the delivery note to assign the invoices. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="invoices"> The list of invoice identifiers. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="invoices"/> is null. </exception>
        public Response<ApiListResultInvoiceApiModel> UpdateRelatedInvoices(long deliveryNoteId, string version, InvoiceIdentifiersListApiModel invoices, Enum42? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (invoices == null)
            {
                throw new ArgumentNullException(nameof(invoices));
            }

            using var message = CreateUpdateRelatedInvoicesRequest(deliveryNoteId, version, invoices, acceptLanguage);
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

        internal HttpMessage CreateDeleteRelatedInvoicesIdRequest(long deliveryNoteId, long invoiceId, string version, Enum43? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/accounting/deliveryNotes/", false);
            uri.AppendPath(deliveryNoteId, true);
            uri.AppendPath("/relatedInvoices/", false);
            uri.AppendPath(invoiceId, true);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json");
            return message;
        }

        /// <summary> Removes the relation between the given delivery note and invoice. </summary>
        /// <param name="deliveryNoteId"> The identifier of the delivery note to delete the related invoice. </param>
        /// <param name="invoiceId"> The identifier of the invoice to remove. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public async Task<Response<ApiResultBoolean>> DeleteRelatedInvoicesIdAsync(long deliveryNoteId, long invoiceId, string version, Enum43? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateDeleteRelatedInvoicesIdRequest(deliveryNoteId, invoiceId, version, acceptLanguage);
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

        /// <summary> Removes the relation between the given delivery note and invoice. </summary>
        /// <param name="deliveryNoteId"> The identifier of the delivery note to delete the related invoice. </param>
        /// <param name="invoiceId"> The identifier of the invoice to remove. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public Response<ApiResultBoolean> DeleteRelatedInvoicesId(long deliveryNoteId, long invoiceId, string version, Enum43? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateDeleteRelatedInvoicesIdRequest(deliveryNoteId, invoiceId, version, acceptLanguage);
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
