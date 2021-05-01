// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace ContasimpleAPI.Models
{
    /// <summary> Defines the information for a product. </summary>
    public partial class WorkingHoursApiModel
    {
        /// <summary> Initializes a new instance of WorkingHoursApiModel. </summary>
        internal WorkingHoursApiModel()
        {
        }

        /// <summary> Initializes a new instance of WorkingHoursApiModel. </summary>
        /// <param name="companyId"> The company under which working hour has been registered. </param>
        /// <param name="deletedByUserId"> The user that marked the time entry as deleted. </param>
        /// <param name="deletedTime"> The time when the entry was marked for deletion. </param>
        /// <param name="description"> The working hour description. </param>
        /// <param name="employeeName"> This should return the user name and surname. If the user has not filled his or her personal data yet, it will return the contact email. </param>
        /// <param name="endTime"> The local time time when a user ends a working period. </param>
        /// <param name="endTimeLogTime"> The time when a user logs the end of a working period. </param>
        /// <param name="endTimeLoggedByUserId"> The user that logs the end of a working period. Not necessarily the same user that actually worked. </param>
        /// <param name="id"> The identifier of the working hour entry. </param>
        /// <param name="isDeleted"> Whether this entry is deleted or not at the logical level. </param>
        /// <param name="minutesWorkedPerDay">
        /// The minutes worked during the whole day (relative to the date part of the startTime field).
        /// 
        /// If you need the hours worked instead, just do the transformation on the client side.
        /// </param>
        /// <param name="startTime"> The local time time when a user starts a working period. </param>
        /// <param name="startTimeLogTime"> The time when a user logs the start of a working period. </param>
        /// <param name="startTimeLoggedByUserId"> The user that logs the start of a working period. Not necessarily the same user that actually worked. </param>
        /// <param name="userId"> The user (conceptually an &quot;Employee&quot;) that worked a certain start-to-end working time period (under a certain company). </param>
        /// <param name="utcEndTime"> The UTC time when a user ends a working period. </param>
        /// <param name="utcStartTime"> The UTC time when a user starts a working period. </param>
        internal WorkingHoursApiModel(long? companyId, long? deletedByUserId, DateTimeOffset? deletedTime, string description, string employeeName, DateTimeOffset? endTime, DateTimeOffset? endTimeLogTime, long? endTimeLoggedByUserId, long? id, bool? isDeleted, long? minutesWorkedPerDay, DateTimeOffset? startTime, DateTimeOffset? startTimeLogTime, long? startTimeLoggedByUserId, long? userId, DateTimeOffset? utcEndTime, DateTimeOffset? utcStartTime)
        {
            CompanyId = companyId;
            DeletedByUserId = deletedByUserId;
            DeletedTime = deletedTime;
            Description = description;
            EmployeeName = employeeName;
            EndTime = endTime;
            EndTimeLogTime = endTimeLogTime;
            EndTimeLoggedByUserId = endTimeLoggedByUserId;
            Id = id;
            IsDeleted = isDeleted;
            MinutesWorkedPerDay = minutesWorkedPerDay;
            StartTime = startTime;
            StartTimeLogTime = startTimeLogTime;
            StartTimeLoggedByUserId = startTimeLoggedByUserId;
            UserId = userId;
            UtcEndTime = utcEndTime;
            UtcStartTime = utcStartTime;
        }

        /// <summary> The company under which working hour has been registered. </summary>
        public long? CompanyId { get; }
        /// <summary> The user that marked the time entry as deleted. </summary>
        public long? DeletedByUserId { get; }
        /// <summary> The time when the entry was marked for deletion. </summary>
        public DateTimeOffset? DeletedTime { get; }
        /// <summary> The working hour description. </summary>
        public string Description { get; }
        /// <summary> This should return the user name and surname. If the user has not filled his or her personal data yet, it will return the contact email. </summary>
        public string EmployeeName { get; }
        /// <summary> The local time time when a user ends a working period. </summary>
        public DateTimeOffset? EndTime { get; }
        /// <summary> The time when a user logs the end of a working period. </summary>
        public DateTimeOffset? EndTimeLogTime { get; }
        /// <summary> The user that logs the end of a working period. Not necessarily the same user that actually worked. </summary>
        public long? EndTimeLoggedByUserId { get; }
        /// <summary> The identifier of the working hour entry. </summary>
        public long? Id { get; }
        /// <summary> Whether this entry is deleted or not at the logical level. </summary>
        public bool? IsDeleted { get; }
        /// <summary>
        /// The minutes worked during the whole day (relative to the date part of the startTime field).
        /// 
        /// If you need the hours worked instead, just do the transformation on the client side.
        /// </summary>
        public long? MinutesWorkedPerDay { get; }
        /// <summary> The local time time when a user starts a working period. </summary>
        public DateTimeOffset? StartTime { get; }
        /// <summary> The time when a user logs the start of a working period. </summary>
        public DateTimeOffset? StartTimeLogTime { get; }
        /// <summary> The user that logs the start of a working period. Not necessarily the same user that actually worked. </summary>
        public long? StartTimeLoggedByUserId { get; }
        /// <summary> The user (conceptually an &quot;Employee&quot;) that worked a certain start-to-end working time period (under a certain company). </summary>
        public long? UserId { get; }
        /// <summary> The UTC time when a user ends a working period. </summary>
        public DateTimeOffset? UtcEndTime { get; }
        /// <summary> The UTC time when a user starts a working period. </summary>
        public DateTimeOffset? UtcStartTime { get; }
    }
}