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
    internal partial class ProductStockRestClient
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of ProductStockRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public ProductStockRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            endpoint ??= new Uri("https://api.contasimple.com");

            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateListRequest(string version, int? startIndex, int? numRows, Enum437? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/products/stockOperations", false);
            if (startIndex != null)
            {
                uri.AppendQuery("startIndex", startIndex.Value, true);
            }
            if (numRows != null)
            {
                uri.AppendQuery("numRows", numRows.Value, true);
            }
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json, application/xml, text/xml");
            return message;
        }

        /// <summary> Gets the list of stock operations for the current company. </summary>
        /// <param name="version"> The String to use. </param>
        /// <param name="startIndex"> The Integer to use. </param>
        /// <param name="numRows"> The Integer to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public async Task<Response<ApiListResultProductStockOperationApiModel>> ListAsync(string version, int? startIndex = null, int? numRows = null, Enum437? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateListRequest(version, startIndex, numRows, acceptLanguage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiListResultProductStockOperationApiModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApiListResultProductStockOperationApiModel.DeserializeApiListResultProductStockOperationApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the list of stock operations for the current company. </summary>
        /// <param name="version"> The String to use. </param>
        /// <param name="startIndex"> The Integer to use. </param>
        /// <param name="numRows"> The Integer to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public Response<ApiListResultProductStockOperationApiModel> List(string version, int? startIndex = null, int? numRows = null, Enum437? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateListRequest(version, startIndex, numRows, acceptLanguage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiListResultProductStockOperationApiModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApiListResultProductStockOperationApiModel.DeserializeApiListResultProductStockOperationApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePostRequest(string version, string operation, Enum442? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/products/stockOperations", false);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json");
            request.Headers.Add("Content-Type", "text/html");
            request.Content = new StringRequestContent(operation);
            return message;
        }

        /// <summary> Inserts a new product stock operation. </summary>
        /// <param name="version"> The String to use. </param>
        /// <param name="operation"> The information of the operation. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="operation"/> is null. </exception>
        public async Task<Response<ApiResultProductStockOperationApiModel>> PostAsync(string version, string operation, Enum442? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (operation == null)
            {
                throw new ArgumentNullException(nameof(operation));
            }

            using var message = CreatePostRequest(version, operation, acceptLanguage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultProductStockOperationApiModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApiResultProductStockOperationApiModel.DeserializeApiResultProductStockOperationApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Inserts a new product stock operation. </summary>
        /// <param name="version"> The String to use. </param>
        /// <param name="operation"> The information of the operation. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="operation"/> is null. </exception>
        public Response<ApiResultProductStockOperationApiModel> Post(string version, string operation, Enum442? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (operation == null)
            {
                throw new ArgumentNullException(nameof(operation));
            }

            using var message = CreatePostRequest(version, operation, acceptLanguage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultProductStockOperationApiModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApiResultProductStockOperationApiModel.DeserializeApiResultProductStockOperationApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePostRequest(string version, ProductStockOperationRequestApiModel operation, Enum442? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/products/stockOperations", false);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(operation);
            request.Content = content;
            return message;
        }

        /// <summary> Inserts a new product stock operation. </summary>
        /// <param name="version"> The String to use. </param>
        /// <param name="operation"> The information of the operation. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="operation"/> is null. </exception>
        public async Task<Response<ApiResultProductStockOperationApiModel>> PostAsync(string version, ProductStockOperationRequestApiModel operation, Enum442? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (operation == null)
            {
                throw new ArgumentNullException(nameof(operation));
            }

            using var message = CreatePostRequest(version, operation, acceptLanguage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultProductStockOperationApiModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApiResultProductStockOperationApiModel.DeserializeApiResultProductStockOperationApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Inserts a new product stock operation. </summary>
        /// <param name="version"> The String to use. </param>
        /// <param name="operation"> The information of the operation. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="operation"/> is null. </exception>
        public Response<ApiResultProductStockOperationApiModel> Post(string version, ProductStockOperationRequestApiModel operation, Enum442? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (operation == null)
            {
                throw new ArgumentNullException(nameof(operation));
            }

            using var message = CreatePostRequest(version, operation, acceptLanguage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultProductStockOperationApiModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApiResultProductStockOperationApiModel.DeserializeApiResultProductStockOperationApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetProductsWithStockControlledAtDeliveryNoteStockOperationsRequest(string version, IEnumerable<long> deliveryNotesListDeliveryNoteId, Enum444? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/products/stockOperations/productsWithStockControlledAtDeliveryNoteOperations", false);
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
        /// Returns the products which the stock was controlled in delivery note operations (create/edit a delivery note with stock control activated,
        /// 
        /// create a delivery note from an estimate with the stock control activated or delivery notes invoicing with the stock control activated).
        /// </summary>
        /// <param name="version"> The String to use. </param>
        /// <param name="deliveryNotesListDeliveryNoteId"> A list of delivery note ids. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public async Task<Response<ApiListResultDeliveryNoteProductInfoApiModel>> GetProductsWithStockControlledAtDeliveryNoteStockOperationsAsync(string version, IEnumerable<long> deliveryNotesListDeliveryNoteId = null, Enum444? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateGetProductsWithStockControlledAtDeliveryNoteStockOperationsRequest(version, deliveryNotesListDeliveryNoteId, acceptLanguage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiListResultDeliveryNoteProductInfoApiModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApiListResultDeliveryNoteProductInfoApiModel.DeserializeApiListResultDeliveryNoteProductInfoApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Returns the products which the stock was controlled in delivery note operations (create/edit a delivery note with stock control activated,
        /// 
        /// create a delivery note from an estimate with the stock control activated or delivery notes invoicing with the stock control activated).
        /// </summary>
        /// <param name="version"> The String to use. </param>
        /// <param name="deliveryNotesListDeliveryNoteId"> A list of delivery note ids. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public Response<ApiListResultDeliveryNoteProductInfoApiModel> GetProductsWithStockControlledAtDeliveryNoteStockOperations(string version, IEnumerable<long> deliveryNotesListDeliveryNoteId = null, Enum444? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateGetProductsWithStockControlledAtDeliveryNoteStockOperationsRequest(version, deliveryNotesListDeliveryNoteId, acceptLanguage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiListResultDeliveryNoteProductInfoApiModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApiListResultDeliveryNoteProductInfoApiModel.DeserializeApiListResultDeliveryNoteProductInfoApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetStockHasAlreadyControlledFromEstimateToDeliveryNoteRequest(long estimateId, string version, Enum446? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/products/stockOperations/stockAlreadyControlledFromEstimateToDeliveryNote/", false);
            uri.AppendPath(estimateId, true);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json");
            return message;
        }

        /// <summary> Returns if the stock has already been controlled creating a delivery note from the estimate passed as parameter. </summary>
        /// <param name="estimateId"> The estimate id. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public async Task<Response<ApiResultBoolean>> GetStockHasAlreadyControlledFromEstimateToDeliveryNoteAsync(long estimateId, string version, Enum446? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateGetStockHasAlreadyControlledFromEstimateToDeliveryNoteRequest(estimateId, version, acceptLanguage);
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

        /// <summary> Returns if the stock has already been controlled creating a delivery note from the estimate passed as parameter. </summary>
        /// <param name="estimateId"> The estimate id. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public Response<ApiResultBoolean> GetStockHasAlreadyControlledFromEstimateToDeliveryNote(long estimateId, string version, Enum446? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateGetStockHasAlreadyControlledFromEstimateToDeliveryNoteRequest(estimateId, version, acceptLanguage);
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

        internal HttpMessage CreateGetStockHasAlreadyControlledFromEstimateToInvoiceRequest(long estimateId, string version, Enum447? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/products/stockOperations/stockAlreadyControlledFromEstimateToInvoice/", false);
            uri.AppendPath(estimateId, true);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json");
            return message;
        }

        /// <summary> Returns if the stock has already been controlled creating an invoice from the estimate passed as parameter. </summary>
        /// <param name="estimateId"> The estimate id. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public async Task<Response<ApiResultBoolean>> GetStockHasAlreadyControlledFromEstimateToInvoiceAsync(long estimateId, string version, Enum447? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateGetStockHasAlreadyControlledFromEstimateToInvoiceRequest(estimateId, version, acceptLanguage);
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

        /// <summary> Returns if the stock has already been controlled creating an invoice from the estimate passed as parameter. </summary>
        /// <param name="estimateId"> The estimate id. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public Response<ApiResultBoolean> GetStockHasAlreadyControlledFromEstimateToInvoice(long estimateId, string version, Enum447? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateGetStockHasAlreadyControlledFromEstimateToInvoiceRequest(estimateId, version, acceptLanguage);
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