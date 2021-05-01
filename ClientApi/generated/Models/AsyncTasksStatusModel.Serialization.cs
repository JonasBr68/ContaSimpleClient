// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class AsyncTasksStatusModel
    {
        internal static AsyncTasksStatusModel DeserializeAsyncTasksStatusModel(JsonElement element)
        {
            Optional<long> waitingCount = default;
            Optional<IReadOnlyList<AsyncTasksTaskStatusModel>> waitingTasks = default;
            Optional<IReadOnlyList<AsyncTasksTaskStatusModel>> workingTasks = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("waitingCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    waitingCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("waitingTasks"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AsyncTasksTaskStatusModel> array = new List<AsyncTasksTaskStatusModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AsyncTasksTaskStatusModel.DeserializeAsyncTasksTaskStatusModel(item));
                    }
                    waitingTasks = array;
                    continue;
                }
                if (property.NameEquals("workingTasks"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AsyncTasksTaskStatusModel> array = new List<AsyncTasksTaskStatusModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AsyncTasksTaskStatusModel.DeserializeAsyncTasksTaskStatusModel(item));
                    }
                    workingTasks = array;
                    continue;
                }
            }
            return new AsyncTasksStatusModel(Optional.ToNullable(waitingCount), Optional.ToList(waitingTasks), Optional.ToList(workingTasks));
        }
    }
}