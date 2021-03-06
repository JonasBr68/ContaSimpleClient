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
    internal partial class NotesRestClient
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of NotesRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public NotesRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            endpoint ??= new Uri("https://api.contasimple.com");

            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetRequest(string version, int? startIndex, int? numRows, Enum387? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/notes", false);
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

        /// <summary> Gets the list of notes for the current user. </summary>
        /// <param name="version"> The String to use. </param>
        /// <param name="startIndex"> The Integer to use. </param>
        /// <param name="numRows"> The Integer to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public async Task<Response<ApiListResultNoteApiModel>> GetAsync(string version, int? startIndex = null, int? numRows = null, Enum387? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateGetRequest(version, startIndex, numRows, acceptLanguage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiListResultNoteApiModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApiListResultNoteApiModel.DeserializeApiListResultNoteApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the list of notes for the current user. </summary>
        /// <param name="version"> The String to use. </param>
        /// <param name="startIndex"> The Integer to use. </param>
        /// <param name="numRows"> The Integer to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public Response<ApiListResultNoteApiModel> Get(string version, int? startIndex = null, int? numRows = null, Enum387? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateGetRequest(version, startIndex, numRows, acceptLanguage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiListResultNoteApiModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApiListResultNoteApiModel.DeserializeApiListResultNoteApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePostRequest(string version, string note, Enum388? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/notes", false);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json");
            request.Headers.Add("Content-Type", "text/html");
            request.Content = new StringRequestContent(note);
            return message;
        }

        /// <summary> Creates a new note. </summary>
        /// <param name="version"> The String to use. </param>
        /// <param name="note"> The information of the note to create. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="note"/> is null. </exception>
        public async Task<Response<ApiResultNoteApiModel>> PostAsync(string version, string note, Enum388? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (note == null)
            {
                throw new ArgumentNullException(nameof(note));
            }

            using var message = CreatePostRequest(version, note, acceptLanguage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultNoteApiModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApiResultNoteApiModel.DeserializeApiResultNoteApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates a new note. </summary>
        /// <param name="version"> The String to use. </param>
        /// <param name="note"> The information of the note to create. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="note"/> is null. </exception>
        public Response<ApiResultNoteApiModel> Post(string version, string note, Enum388? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (note == null)
            {
                throw new ArgumentNullException(nameof(note));
            }

            using var message = CreatePostRequest(version, note, acceptLanguage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultNoteApiModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApiResultNoteApiModel.DeserializeApiResultNoteApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePostRequest(string version, NoteApiModel note, Enum388? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/notes", false);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(note);
            request.Content = content;
            return message;
        }

        /// <summary> Creates a new note. </summary>
        /// <param name="version"> The String to use. </param>
        /// <param name="note"> The information of the note to create. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="note"/> is null. </exception>
        public async Task<Response<ApiResultNoteApiModel>> PostAsync(string version, NoteApiModel note, Enum388? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (note == null)
            {
                throw new ArgumentNullException(nameof(note));
            }

            using var message = CreatePostRequest(version, note, acceptLanguage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultNoteApiModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApiResultNoteApiModel.DeserializeApiResultNoteApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates a new note. </summary>
        /// <param name="version"> The String to use. </param>
        /// <param name="note"> The information of the note to create. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="note"/> is null. </exception>
        public Response<ApiResultNoteApiModel> Post(string version, NoteApiModel note, Enum388? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (note == null)
            {
                throw new ArgumentNullException(nameof(note));
            }

            using var message = CreatePostRequest(version, note, acceptLanguage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultNoteApiModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApiResultNoteApiModel.DeserializeApiResultNoteApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateSearchRequest(string version, string query, Enum389? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/notes/search", false);
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

        /// <summary> Gets the list of notes for the current user. </summary>
        /// <param name="version"> The String to use. </param>
        /// <param name="query"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public async Task<Response<ApiListResultNoteApiModel>> SearchAsync(string version, string query = null, Enum389? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateSearchRequest(version, query, acceptLanguage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiListResultNoteApiModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApiListResultNoteApiModel.DeserializeApiListResultNoteApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the list of notes for the current user. </summary>
        /// <param name="version"> The String to use. </param>
        /// <param name="query"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public Response<ApiListResultNoteApiModel> Search(string version, string query = null, Enum389? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateSearchRequest(version, query, acceptLanguage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiListResultNoteApiModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApiListResultNoteApiModel.DeserializeApiListResultNoteApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(long noteId, string version, Enum390? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/notes/", false);
            uri.AppendPath(noteId, true);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json");
            return message;
        }

        /// <summary> Removes the note with the given identifier. </summary>
        /// <param name="noteId"> The identifier of the note to remove. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public async Task<Response<ApiResultInt64>> DeleteAsync(long noteId, string version, Enum390? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateDeleteRequest(noteId, version, acceptLanguage);
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

        /// <summary> Removes the note with the given identifier. </summary>
        /// <param name="noteId"> The identifier of the note to remove. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public Response<ApiResultInt64> Delete(long noteId, string version, Enum390? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateDeleteRequest(noteId, version, acceptLanguage);
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

        internal HttpMessage CreateGetNoteRequest(long noteId, string version, Enum391? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/notes/", false);
            uri.AppendPath(noteId, true);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json");
            return message;
        }

        /// <summary> Gets the note information for the given note id. </summary>
        /// <param name="noteId"> The identifier of the note to retrieve. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public async Task<Response<ApiResultNoteApiModel>> GetNoteAsync(long noteId, string version, Enum391? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateGetNoteRequest(noteId, version, acceptLanguage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultNoteApiModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApiResultNoteApiModel.DeserializeApiResultNoteApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the note information for the given note id. </summary>
        /// <param name="noteId"> The identifier of the note to retrieve. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public Response<ApiResultNoteApiModel> GetNote(long noteId, string version, Enum391? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateGetNoteRequest(noteId, version, acceptLanguage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultNoteApiModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApiResultNoteApiModel.DeserializeApiResultNoteApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePutRequest(long noteId, string version, string note, Enum392? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/notes/", false);
            uri.AppendPath(noteId, true);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json");
            request.Headers.Add("Content-Type", "text/html");
            request.Content = new StringRequestContent(note);
            return message;
        }

        /// <summary> Updates the given note. </summary>
        /// <param name="noteId"> The identifier of the note to update. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="note"> The information of the note to update. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="note"/> is null. </exception>
        public async Task<Response<ApiResultNoteApiModel>> PutAsync(long noteId, string version, string note, Enum392? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (note == null)
            {
                throw new ArgumentNullException(nameof(note));
            }

            using var message = CreatePutRequest(noteId, version, note, acceptLanguage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultNoteApiModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApiResultNoteApiModel.DeserializeApiResultNoteApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Updates the given note. </summary>
        /// <param name="noteId"> The identifier of the note to update. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="note"> The information of the note to update. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="note"/> is null. </exception>
        public Response<ApiResultNoteApiModel> Put(long noteId, string version, string note, Enum392? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (note == null)
            {
                throw new ArgumentNullException(nameof(note));
            }

            using var message = CreatePutRequest(noteId, version, note, acceptLanguage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultNoteApiModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApiResultNoteApiModel.DeserializeApiResultNoteApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePutRequest(long noteId, string version, NoteApiModel note, Enum392? acceptLanguage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/api/v", false);
            uri.AppendPath(version, true);
            uri.AppendPath("/notes/", false);
            uri.AppendPath(noteId, true);
            request.Uri = uri;
            if (acceptLanguage != null)
            {
                request.Headers.Add("Accept-Language", acceptLanguage.Value.ToString());
            }
            request.Headers.Add("Accept", "application/json, text/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(note);
            request.Content = content;
            return message;
        }

        /// <summary> Updates the given note. </summary>
        /// <param name="noteId"> The identifier of the note to update. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="note"> The information of the note to update. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="note"/> is null. </exception>
        public async Task<Response<ApiResultNoteApiModel>> PutAsync(long noteId, string version, NoteApiModel note, Enum392? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (note == null)
            {
                throw new ArgumentNullException(nameof(note));
            }

            using var message = CreatePutRequest(noteId, version, note, acceptLanguage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultNoteApiModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApiResultNoteApiModel.DeserializeApiResultNoteApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Updates the given note. </summary>
        /// <param name="noteId"> The identifier of the note to update. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="note"> The information of the note to update. </param>
        /// <param name="acceptLanguage"> The request language. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="note"/> is null. </exception>
        public Response<ApiResultNoteApiModel> Put(long noteId, string version, NoteApiModel note, Enum392? acceptLanguage = null, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (note == null)
            {
                throw new ArgumentNullException(nameof(note));
            }

            using var message = CreatePutRequest(noteId, version, note, acceptLanguage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApiResultNoteApiModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApiResultNoteApiModel.DeserializeApiResultNoteApiModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
