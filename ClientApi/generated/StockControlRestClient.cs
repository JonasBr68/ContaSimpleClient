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
    internal partial class StockControlRestClient
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of StockControlRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public StockControlRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            endpoint ??= new Uri("https://api.contasimple.com");

            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetRequest(string version, Enum254? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/configuration/stockControl", false);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json");
            return message;
        }

        /// <summary> Gets the company stock control configuration. </summary>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public async Task<Response<ApiResultStockControlConfigurationApiModel>> GetAsync(string version, Enum254? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateGetRequest(version, acceptLanguage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultStockControlConfigurationApiModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApiResultStockControlConfigurationApiModel.DeserializeApiResultStockControlConfigurationApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the company stock control configuration. </summary>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public Response<ApiResultStockControlConfigurationApiModel> Get(string version, Enum254? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateGetRequest(version, acceptLanguage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultStockControlConfigurationApiModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApiResultStockControlConfigurationApiModel.DeserializeApiResultStockControlConfigurationApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePostRequest(string version, string stockControlConfiguration, Enum258? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/configuration/stockControl", false);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json");
            request.Headers.Add("Content-Type", "text/html");
            request.Content = new StringRequestContent(stockControlConfiguration);
            return message;
        }

        /// <summary> Sets the company stock control configuration. </summary>
        /// <param name="version"> The String to use. </param>
        /// <param name="stockControlConfiguration"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="stockControlConfiguration"/> is null. </exception>
        public async Task<Response<ApiResultStockControlConfigurationApiModel>> PostAsync(string version, string stockControlConfiguration, Enum258? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (stockControlConfiguration == null)
            {
                throw new ArgumentNullException(nameof(stockControlConfiguration));
            }

            using var message = CreatePostRequest(version, stockControlConfiguration, acceptLanguage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultStockControlConfigurationApiModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApiResultStockControlConfigurationApiModel.DeserializeApiResultStockControlConfigurationApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Sets the company stock control configuration. </summary>
        /// <param name="version"> The String to use. </param>
        /// <param name="stockControlConfiguration"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="stockControlConfiguration"/> is null. </exception>
        public Response<ApiResultStockControlConfigurationApiModel> Post(string version, string stockControlConfiguration, Enum258? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (stockControlConfiguration == null)
            {
                throw new ArgumentNullException(nameof(stockControlConfiguration));
            }

            using var message = CreatePostRequest(version, stockControlConfiguration, acceptLanguage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultStockControlConfigurationApiModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApiResultStockControlConfigurationApiModel.DeserializeApiResultStockControlConfigurationApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePostRequest(string version, StockControlRequestApiModel stockControlConfiguration, Enum258? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/configuration/stockControl", false);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(stockControlConfiguration);
            request.Content = content;
            return message;
        }

        /// <summary> Sets the company stock control configuration. </summary>
        /// <param name="version"> The String to use. </param>
        /// <param name="stockControlConfiguration"> The StockControlRequestApiModel to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="stockControlConfiguration"/> is null. </exception>
        public async Task<Response<ApiResultStockControlConfigurationApiModel>> PostAsync(string version, StockControlRequestApiModel stockControlConfiguration, Enum258? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (stockControlConfiguration == null)
            {
                throw new ArgumentNullException(nameof(stockControlConfiguration));
            }

            using var message = CreatePostRequest(version, stockControlConfiguration, acceptLanguage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultStockControlConfigurationApiModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApiResultStockControlConfigurationApiModel.DeserializeApiResultStockControlConfigurationApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Sets the company stock control configuration. </summary>
        /// <param name="version"> The String to use. </param>
        /// <param name="stockControlConfiguration"> The StockControlRequestApiModel to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="stockControlConfiguration"/> is null. </exception>
        public Response<ApiResultStockControlConfigurationApiModel> Post(string version, StockControlRequestApiModel stockControlConfiguration, Enum258? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (stockControlConfiguration == null)
            {
                throw new ArgumentNullException(nameof(stockControlConfiguration));
            }

            using var message = CreatePostRequest(version, stockControlConfiguration, acceptLanguage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultStockControlConfigurationApiModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApiResultStockControlConfigurationApiModel.DeserializeApiResultStockControlConfigurationApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetStockConfigurationForDocumentsAndProductsEnabledRequest(string version, Enum262? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/configuration/stockControl/stockConfigurationForDocumentsAndProducts", false);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json");
            return message;
        }

        /// <summary> Gets if the stock control for documents is configured and if exists products with stock control enabled for the current company. </summary>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public async Task<Response<ApiResultStockForDocumentsAndProductsEnabledApiModel>> GetStockConfigurationForDocumentsAndProductsEnabledAsync(string version, Enum262? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateGetStockConfigurationForDocumentsAndProductsEnabledRequest(version, acceptLanguage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultStockForDocumentsAndProductsEnabledApiModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApiResultStockForDocumentsAndProductsEnabledApiModel.DeserializeApiResultStockForDocumentsAndProductsEnabledApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets if the stock control for documents is configured and if exists products with stock control enabled for the current company. </summary>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public Response<ApiResultStockForDocumentsAndProductsEnabledApiModel> GetStockConfigurationForDocumentsAndProductsEnabled(string version, Enum262? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateGetStockConfigurationForDocumentsAndProductsEnabledRequest(version, acceptLanguage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultStockForDocumentsAndProductsEnabledApiModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApiResultStockForDocumentsAndProductsEnabledApiModel.DeserializeApiResultStockForDocumentsAndProductsEnabledApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
