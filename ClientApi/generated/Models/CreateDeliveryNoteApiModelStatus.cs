// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The current status of the delivery note. </summary>
    public readonly partial struct CreateDeliveryNoteApiModelStatus : IEquatable<CreateDeliveryNoteApiModelStatus>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="CreateDeliveryNoteApiModelStatus"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CreateDeliveryNoteApiModelStatus(string value)
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
        public static CreateDeliveryNoteApiModelStatus Creado { get; } = new CreateDeliveryNoteApiModelStatus(CreadoValue);
        /// <summary> Enviado. </summary>
        public static CreateDeliveryNoteApiModelStatus Enviado { get; } = new CreateDeliveryNoteApiModelStatus(EnviadoValue);
        /// <summary> Aceptado. </summary>
        public static CreateDeliveryNoteApiModelStatus Aceptado { get; } = new CreateDeliveryNoteApiModelStatus(AceptadoValue);
        /// <summary> Rechazado. </summary>
        public static CreateDeliveryNoteApiModelStatus Rechazado { get; } = new CreateDeliveryNoteApiModelStatus(RechazadoValue);
        /// <summary> Parcial. </summary>
        public static CreateDeliveryNoteApiModelStatus Parcial { get; } = new CreateDeliveryNoteApiModelStatus(ParcialValue);
        /// <summary> Facturado. </summary>
        public static CreateDeliveryNoteApiModelStatus Facturado { get; } = new CreateDeliveryNoteApiModelStatus(FacturadoValue);
        /// <summary> Cerrado. </summary>
        public static CreateDeliveryNoteApiModelStatus Cerrado { get; } = new CreateDeliveryNoteApiModelStatus(CerradoValue);
        /// <summary> Determines if two <see cref="CreateDeliveryNoteApiModelStatus"/> values are the same. </summary>
        public static bool operator ==(CreateDeliveryNoteApiModelStatus left, CreateDeliveryNoteApiModelStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CreateDeliveryNoteApiModelStatus"/> values are not the same. </summary>
        public static bool operator !=(CreateDeliveryNoteApiModelStatus left, CreateDeliveryNoteApiModelStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CreateDeliveryNoteApiModelStatus"/>. </summary>
        public static implicit operator CreateDeliveryNoteApiModelStatus(string value) => new CreateDeliveryNoteApiModelStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CreateDeliveryNoteApiModelStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CreateDeliveryNoteApiModelStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
