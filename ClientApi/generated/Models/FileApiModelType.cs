// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The type of element. </summary>
    public readonly partial struct FileApiModelType : IEquatable<FileApiModelType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="FileApiModelType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FileApiModelType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FileValue = "File";
        private const string FolderValue = "Folder";

        /// <summary> File. </summary>
        public static FileApiModelType File { get; } = new FileApiModelType(FileValue);
        /// <summary> Folder. </summary>
        public static FileApiModelType Folder { get; } = new FileApiModelType(FolderValue);
        /// <summary> Determines if two <see cref="FileApiModelType"/> values are the same. </summary>
        public static bool operator ==(FileApiModelType left, FileApiModelType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FileApiModelType"/> values are not the same. </summary>
        public static bool operator !=(FileApiModelType left, FileApiModelType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FileApiModelType"/>. </summary>
        public static implicit operator FileApiModelType(string value) => new FileApiModelType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FileApiModelType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FileApiModelType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
