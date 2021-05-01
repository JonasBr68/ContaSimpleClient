// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class AsyncTasksTaskStatusModel
    {
        internal static AsyncTasksTaskStatusModel DeserializeAsyncTasksTaskStatusModel(JsonElement element)
        {
            Optional<string> companyEmail = default;
            Optional<long> companyId = default;
            Optional<long> id = default;
            Optional<string> info = default;
            Optional<DateTimeOffset> lastAttempt = default;
            Optional<DateTimeOffset> queueTime = default;
            Optional<AsyncTasksTaskStatusModelStatus> status = default;
            Optional<AsyncTasksTaskStatusModelTask> task = default;
            Optional<string> userEmail = default;
            Optional<long> userId = default;
            Optional<string> waitingTime = default;
            Optional<string> workingTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("companyEmail"))
                {
                    companyEmail = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("companyId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    companyId = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    id = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("info"))
                {
                    info = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastAttempt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastAttempt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("queueTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    queueTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = new AsyncTasksTaskStatusModelStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("task"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    task = new AsyncTasksTaskStatusModelTask(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("userEmail"))
                {
                    userEmail = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    userId = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("waitingTime"))
                {
                    waitingTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workingTime"))
                {
                    workingTime = property.Value.GetString();
                    continue;
                }
            }
            return new AsyncTasksTaskStatusModel(companyEmail.Value, Optional.ToNullable(companyId), Optional.ToNullable(id), info.Value, Optional.ToNullable(lastAttempt), Optional.ToNullable(queueTime), Optional.ToNullable(status), Optional.ToNullable(task), userEmail.Value, Optional.ToNullable(userId), waitingTime.Value, workingTime.Value);
        }
    }
}