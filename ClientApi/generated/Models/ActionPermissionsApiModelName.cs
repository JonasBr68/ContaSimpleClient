// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The name of the current action. </summary>
    public readonly partial struct ActionPermissionsApiModelName : IEquatable<ActionPermissionsApiModelName>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ActionPermissionsApiModelName"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ActionPermissionsApiModelName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "Default";
        private const string CreateValue = "Create";
        private const string EditValue = "Edit";
        private const string DeleteValue = "Delete";
        private const string ListValue = "List";
        private const string ViewValue = "View";
        private const string SendValue = "Send";

        /// <summary> Default. </summary>
        public static ActionPermissionsApiModelName Default { get; } = new ActionPermissionsApiModelName(DefaultValue);
        /// <summary> Create. </summary>
        public static ActionPermissionsApiModelName Create { get; } = new ActionPermissionsApiModelName(CreateValue);
        /// <summary> Edit. </summary>
        public static ActionPermissionsApiModelName Edit { get; } = new ActionPermissionsApiModelName(EditValue);
        /// <summary> Delete. </summary>
        public static ActionPermissionsApiModelName Delete { get; } = new ActionPermissionsApiModelName(DeleteValue);
        /// <summary> List. </summary>
        public static ActionPermissionsApiModelName List { get; } = new ActionPermissionsApiModelName(ListValue);
        /// <summary> View. </summary>
        public static ActionPermissionsApiModelName View { get; } = new ActionPermissionsApiModelName(ViewValue);
        /// <summary> Send. </summary>
        public static ActionPermissionsApiModelName Send { get; } = new ActionPermissionsApiModelName(SendValue);
        /// <summary> Determines if two <see cref="ActionPermissionsApiModelName"/> values are the same. </summary>
        public static bool operator ==(ActionPermissionsApiModelName left, ActionPermissionsApiModelName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ActionPermissionsApiModelName"/> values are not the same. </summary>
        public static bool operator !=(ActionPermissionsApiModelName left, ActionPermissionsApiModelName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ActionPermissionsApiModelName"/>. </summary>
        public static implicit operator ActionPermissionsApiModelName(string value) => new ActionPermissionsApiModelName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ActionPermissionsApiModelName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ActionPermissionsApiModelName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}