// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The current status of the estimate. </summary>
    public readonly partial struct UpdateEstimateApiModelStatus : IEquatable<UpdateEstimateApiModelStatus>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="UpdateEstimateApiModelStatus"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public UpdateEstimateApiModelStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreadoValue = "Creado";
        private const string EnviadoValue = "Enviado";
        private const string AceptadoValue = "Aceptado";
        private const string RechazadoValue = "Rechazado";
        private const string ParcialValue = "Parcial";
        private const string FacturadoValue = "Facturado";
        private const string ParcialAlbaranadoValue = "ParcialAlbaranado";
        private const string AlbaranadoValue = "Albaranado";
        private const string CerradoValue = "Cerrado";

        /// <summary> Creado. </summary>
        public static UpdateEstimateApiModelStatus Creado { get; } = new UpdateEstimateApiModelStatus(CreadoValue);
        /// <summary> Enviado. </summary>
        public static UpdateEstimateApiModelStatus Enviado { get; } = new UpdateEstimateApiModelStatus(EnviadoValue);
        /// <summary> Aceptado. </summary>
        public static UpdateEstimateApiModelStatus Aceptado { get; } = new UpdateEstimateApiModelStatus(AceptadoValue);
        /// <summary> Rechazado. </summary>
        public static UpdateEstimateApiModelStatus Rechazado { get; } = new UpdateEstimateApiModelStatus(RechazadoValue);
        /// <summary> Parcial. </summary>
        public static UpdateEstimateApiModelStatus Parcial { get; } = new UpdateEstimateApiModelStatus(ParcialValue);
        /// <summary> Facturado. </summary>
        public static UpdateEstimateApiModelStatus Facturado { get; } = new UpdateEstimateApiModelStatus(FacturadoValue);
        /// <summary> ParcialAlbaranado. </summary>
        public static UpdateEstimateApiModelStatus ParcialAlbaranado { get; } = new UpdateEstimateApiModelStatus(ParcialAlbaranadoValue);
        /// <summary> Albaranado. </summary>
        public static UpdateEstimateApiModelStatus Albaranado { get; } = new UpdateEstimateApiModelStatus(AlbaranadoValue);
        /// <summary> Cerrado. </summary>
        public static UpdateEstimateApiModelStatus Cerrado { get; } = new UpdateEstimateApiModelStatus(CerradoValue);
        /// <summary> Determines if two <see cref="UpdateEstimateApiModelStatus"/> values are the same. </summary>
        public static bool operator ==(UpdateEstimateApiModelStatus left, UpdateEstimateApiModelStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="UpdateEstimateApiModelStatus"/> values are not the same. </summary>
        public static bool operator !=(UpdateEstimateApiModelStatus left, UpdateEstimateApiModelStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="UpdateEstimateApiModelStatus"/>. </summary>
        public static implicit operator UpdateEstimateApiModelStatus(string value) => new UpdateEstimateApiModelStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is UpdateEstimateApiModelStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(UpdateEstimateApiModelStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
