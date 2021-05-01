// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The current status of the delivery note. </summary>
    public readonly partial struct DeliveryNoteApiModelStatus : IEquatable<DeliveryNoteApiModelStatus>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="DeliveryNoteApiModelStatus"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DeliveryNoteApiModelStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreadoValue = "Creado";
        private const string EnviadoValue = "Enviado";
        private const string AceptadoValue = "Aceptado";
        private const string RechazadoValue = "Rechazado";
        private const string ParcialValue = "Parcial";
        private const string FacturadoValue = "Facturado";
        private const string CerradoValue = "Cerrado";

        /// <summary> Creado. </summary>
        public static DeliveryNoteApiModelStatus Creado { get; } = new DeliveryNoteApiModelStatus(CreadoValue);
        /// <summary> Enviado. </summary>
        public static DeliveryNoteApiModelStatus Enviado { get; } = new DeliveryNoteApiModelStatus(EnviadoValue);
        /// <summary> Aceptado. </summary>
        public static DeliveryNoteApiModelStatus Aceptado { get; } = new DeliveryNoteApiModelStatus(AceptadoValue);
        /// <summary> Rechazado. </summary>
        public static DeliveryNoteApiModelStatus Rechazado { get; } = new DeliveryNoteApiModelStatus(RechazadoValue);
        /// <summary> Parcial. </summary>
        public static DeliveryNoteApiModelStatus Parcial { get; } = new DeliveryNoteApiModelStatus(ParcialValue);
        /// <summary> Facturado. </summary>
        public static DeliveryNoteApiModelStatus Facturado { get; } = new DeliveryNoteApiModelStatus(FacturadoValue);
        /// <summary> Cerrado. </summary>
        public static DeliveryNoteApiModelStatus Cerrado { get; } = new DeliveryNoteApiModelStatus(CerradoValue);
        /// <summary> Determines if two <see cref="DeliveryNoteApiModelStatus"/> values are the same. </summary>
        public static bool operator ==(DeliveryNoteApiModelStatus left, DeliveryNoteApiModelStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DeliveryNoteApiModelStatus"/> values are not the same. </summary>
        public static bool operator !=(DeliveryNoteApiModelStatus left, DeliveryNoteApiModelStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DeliveryNoteApiModelStatus"/>. </summary>
        public static implicit operator DeliveryNoteApiModelStatus(string value) => new DeliveryNoteApiModelStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DeliveryNoteApiModelStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DeliveryNoteApiModelStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}