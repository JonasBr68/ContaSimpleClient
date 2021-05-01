// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Xml.Linq;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class WorkHoursSummaryDayOverviewApiModel
    {
        internal static WorkHoursSummaryDayOverviewApiModel DeserializeWorkHoursSummaryDayOverviewApiModel(JsonElement element)
        {
            Optional<string> employeeName = default;
            Optional<IReadOnlyList<WorkingHoursApiModel>> entries = default;
            Optional<DateTimeOffset> firstStartTime = default;
            Optional<bool> firstStartTimeIsPreviousThanRequestedDate = default;
            Optional<DateTimeOffset> lastEndTime = default;
            Optional<bool> lastEndTimeIsLaterThanRequestedDate = default;
            Optional<DateTimeOffset> requestedDate = default;
            Optional<int> stopsNumber = default;
            Optional<double> totalWorkedTimeInMinutes = default;
            Optional<int> unclosedEntries = default;
            Optional<string> userEmail = default;
            Optional<long> userId = default;
            Optional<double> workedHours = default;
            Optional<double> workedMinutes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("employeeName"))
                {
                    employeeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("entries"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<WorkingHoursApiModel> array = new List<WorkingHoursApiModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WorkingHoursApiModel.DeserializeWorkingHoursApiModel(item));
                    }
                    entries = array;
                    continue;
                }
                if (property.NameEquals("firstStartTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    firstStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("firstStartTimeIsPreviousThanRequestedDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    firstStartTimeIsPreviousThanRequestedDate = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("lastEndTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastEndTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastEndTimeIsLaterThanRequestedDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastEndTimeIsLaterThanRequestedDate = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("requestedDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    requestedDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("stopsNumber"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    stopsNumber = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("totalWorkedTimeInMinutes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalWorkedTimeInMinutes = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("unclosedEntries"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    unclosedEntries = property.Value.GetInt32();
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
                if (property.NameEquals("workedHours"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    workedHours = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("workedMinutes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    workedMinutes = property.Value.GetDouble();
                    continue;
                }
            }
            return new WorkHoursSummaryDayOverviewApiModel(employeeName.Value, Optional.ToList(entries), Optional.ToNullable(firstStartTime), Optional.ToNullable(firstStartTimeIsPreviousThanRequestedDate), Optional.ToNullable(lastEndTime), Optional.ToNullable(lastEndTimeIsLaterThanRequestedDate), Optional.ToNullable(requestedDate), Optional.ToNullable(stopsNumber), Optional.ToNullable(totalWorkedTimeInMinutes), Optional.ToNullable(unclosedEntries), userEmail.Value, Optional.ToNullable(userId), Optional.ToNullable(workedHours), Optional.ToNullable(workedMinutes));
        }

        internal static WorkHoursSummaryDayOverviewApiModel DeserializeWorkHoursSummaryDayOverviewApiModel(XElement element)
        {
            string employeeName = default;
            DateTimeOffset? firstStartTime = default;
            bool? firstStartTimeIsPreviousThanRequestedDate = default;
            DateTimeOffset? lastEndTime = default;
            bool? lastEndTimeIsLaterThanRequestedDate = default;
            DateTimeOffset? requestedDate = default;
            int? stopsNumber = default;
            double? totalWorkedTimeInMinutes = default;
            int? unclosedEntries = default;
            string userEmail = default;
            long? userId = default;
            double? workedHours = default;
            double? workedMinutes = default;
            IReadOnlyList<WorkingHoursApiModel> entries = default;
            if (element.Element("employeeName") is XElement employeeNameElement)
            {
                employeeName = (string)employeeNameElement;
            }
            if (element.Element("firstStartTime") is XElement firstStartTimeElement)
            {
                firstStartTime = firstStartTimeElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("firstStartTimeIsPreviousThanRequestedDate") is XElement firstStartTimeIsPreviousThanRequestedDateElement)
            {
                firstStartTimeIsPreviousThanRequestedDate = (bool?)firstStartTimeIsPreviousThanRequestedDateElement;
            }
            if (element.Element("lastEndTime") is XElement lastEndTimeElement)
            {
                lastEndTime = lastEndTimeElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("lastEndTimeIsLaterThanRequestedDate") is XElement lastEndTimeIsLaterThanRequestedDateElement)
            {
                lastEndTimeIsLaterThanRequestedDate = (bool?)lastEndTimeIsLaterThanRequestedDateElement;
            }
            if (element.Element("requestedDate") is XElement requestedDateElement)
            {
                requestedDate = requestedDateElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("stopsNumber") is XElement stopsNumberElement)
            {
                stopsNumber = (int?)stopsNumberElement;
            }
            if (element.Element("totalWorkedTimeInMinutes") is XElement totalWorkedTimeInMinutesElement)
            {
                totalWorkedTimeInMinutes = (double?)totalWorkedTimeInMinutesElement;
            }
            if (element.Element("unclosedEntries") is XElement unclosedEntriesElement)
            {
                unclosedEntries = (int?)unclosedEntriesElement;
            }
            if (element.Element("userEmail") is XElement userEmailElement)
            {
                userEmail = (string)userEmailElement;
            }
            if (element.Element("userId") is XElement userIdElement)
            {
                userId = (long?)userIdElement;
            }
            if (element.Element("workedHours") is XElement workedHoursElement)
            {
                workedHours = (double?)workedHoursElement;
            }
            if (element.Element("workedMinutes") is XElement workedMinutesElement)
            {
                workedMinutes = (double?)workedMinutesElement;
            }
            var array = new List<WorkingHoursApiModel>();
            foreach (var e in element.Elements("WorkingHoursApiModel"))
            {
                array.Add(WorkingHoursApiModel.DeserializeWorkingHoursApiModel(e));
            }
            entries = array;
            return new WorkHoursSummaryDayOverviewApiModel(employeeName, entries, firstStartTime, firstStartTimeIsPreviousThanRequestedDate, lastEndTime, lastEndTimeIsLaterThanRequestedDate, requestedDate, stopsNumber, totalWorkedTimeInMinutes, unclosedEntries, userEmail, userId, workedHours, workedMinutes);
        }
    }
}