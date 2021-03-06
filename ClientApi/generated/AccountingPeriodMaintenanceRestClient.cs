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
    internal partial class AccountingPeriodMaintenanceRestClient
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of AccountingPeriodMaintenanceRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public AccountingPeriodMaintenanceRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            endpoint ??= new Uri("https://api.contasimple.com");

            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateListRequest(string version, int? startIndex, int? numRows, string sort, Enum13? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/accounting/accountingPeriodMaintenance", false);
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

        /// <summary> Gets the list of expenses for the current company. </summary>
        /// <param name="version"> The String to use. </param>
        /// <param name="startIndex"> The Integer to use. </param>
        /// <param name="numRows"> The Integer to use. </param>
        /// <param name="sort"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public async Task<Response<ApiListResultAccountingPeriodMaintenanceApiModel>> ListAsync(string version, int? startIndex = null, int? numRows = null, string sort = null, Enum13? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateListRequest(version, startIndex, numRows, sort, acceptLanguage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiListResultAccountingPeriodMaintenanceApiModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApiListResultAccountingPeriodMaintenanceApiModel.DeserializeApiListResultAccountingPeriodMaintenanceApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the list of expenses for the current company. </summary>
        /// <param name="version"> The String to use. </param>
        /// <param name="startIndex"> The Integer to use. </param>
        /// <param name="numRows"> The Integer to use. </param>
        /// <param name="sort"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public Response<ApiListResultAccountingPeriodMaintenanceApiModel> List(string version, int? startIndex = null, int? numRows = null, string sort = null, Enum13? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateListRequest(version, startIndex, numRows, sort, acceptLanguage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiListResultAccountingPeriodMaintenanceApiModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApiListResultAccountingPeriodMaintenanceApiModel.DeserializeApiListResultAccountingPeriodMaintenanceApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string period, string version, Enum14? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/accounting/accountingPeriodMaintenance/", false);
            uri.AppendPath(period, true);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json");
            return message;
        }

        /// <summary> Gets the information of the given period. </summary>
        /// <param name="period"> The period to retrieve. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="period"/> or <paramref name="version"/> is null. </exception>
        public async Task<Response<ApiResultAccountingPeriodMaintenanceApiModel>> GetAsync(string period, string version, Enum14? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (period == null)
            {
                throw new ArgumentNullException(nameof(period));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateGetRequest(period, version, acceptLanguage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultAccountingPeriodMaintenanceApiModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApiResultAccountingPeriodMaintenanceApiModel.DeserializeApiResultAccountingPeriodMaintenanceApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the information of the given period. </summary>
        /// <param name="period"> The period to retrieve. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="period"/> or <paramref name="version"/> is null. </exception>
        public Response<ApiResultAccountingPeriodMaintenanceApiModel> Get(string period, string version, Enum14? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (period == null)
            {
                throw new ArgumentNullException(nameof(period));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateGetRequest(period, version, acceptLanguage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultAccountingPeriodMaintenanceApiModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApiResultAccountingPeriodMaintenanceApiModel.DeserializeApiResultAccountingPeriodMaintenanceApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateClosePeriodRequest(string period, string version, Enum15? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/accounting/accountingPeriodMaintenance/", false);
            uri.AppendPath(period, true);
            uri.AppendPath("/close", false);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json, application/xml, text/xml");
            return message;
        }

        /// <summary> Closes the given period. </summary>
        /// <param name="period"> The period to close. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="period"/> or <paramref name="version"/> is null. </exception>
        public async Task<Response<ApiListResultAccountingPeriodMaintenanceApiModel>> ClosePeriodAsync(string period, string version, Enum15? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (period == null)
            {
                throw new ArgumentNullException(nameof(period));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateClosePeriodRequest(period, version, acceptLanguage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiListResultAccountingPeriodMaintenanceApiModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApiListResultAccountingPeriodMaintenanceApiModel.DeserializeApiListResultAccountingPeriodMaintenanceApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Closes the given period. </summary>
        /// <param name="period"> The period to close. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="period"/> or <paramref name="version"/> is null. </exception>
        public Response<ApiListResultAccountingPeriodMaintenanceApiModel> ClosePeriod(string period, string version, Enum15? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (period == null)
            {
                throw new ArgumentNullException(nameof(period));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateClosePeriodRequest(period, version, acceptLanguage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiListResultAccountingPeriodMaintenanceApiModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApiListResultAccountingPeriodMaintenanceApiModel.DeserializeApiListResultAccountingPeriodMaintenanceApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateOpenPeriodRequest(string period, string version, Enum16? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/accounting/accountingPeriodMaintenance/", false);
            uri.AppendPath(period, true);
            uri.AppendPath("/open", false);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json");
            return message;
        }

        /// <summary> Opens the given period. </summary>
        /// <param name="period"> The period to open. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="period"/> or <paramref name="version"/> is null. </exception>
        public async Task<Response<ApiResultString>> OpenPeriodAsync(string period, string version, Enum16? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (period == null)
            {
                throw new ArgumentNullException(nameof(period));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateOpenPeriodRequest(period, version, acceptLanguage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultString value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApiResultString.DeserializeApiResultString(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Opens the given period. </summary>
        /// <param name="period"> The period to open. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="period"/> or <paramref name="version"/> is null. </exception>
        public Response<ApiResultString> OpenPeriod(string period, string version, Enum16? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (period == null)
            {
                throw new ArgumentNullException(nameof(period));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateOpenPeriodRequest(period, version, acceptLanguage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultString value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApiResultString.DeserializeApiResultString(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
