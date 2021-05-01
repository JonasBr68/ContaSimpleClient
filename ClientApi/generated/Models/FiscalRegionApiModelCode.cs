// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The code of the fiscal region. </summary>
    public readonly partial struct FiscalRegionApiModelCode : IEquatable<FiscalRegionApiModelCode>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="FiscalRegionApiModelCode"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FiscalRegionApiModelCode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EsPeninsulaValue = "es_Peninsula";
        private const string EsCanariasValue = "es_Canarias";
        private const string EsCeutaYMelillaValue = "es_CeutaYMelilla";
        private const string EsNavarraValue = "es_Navarra";
        private const string EsAlabaValue = "es_Alaba";
        private const string EsBizcayaValue = "es_Bizcaya";
        private const string EsGuipuzcoaValue = "es_Guipuzcoa";
        private const string MxValue = "mx";
        private const string ArValue = "ar";
        private const string CoValue = "co";
        private const string ClValue = "cl";
        private const string PeValue = "pe";
        private const string VeValue = "ve";
        private const string EcValue = "ec";
        private const string HnValue = "hn";
        private const string UsValue = "us";
        private const string UkValue = "uk";
        private const string IeValue = "ie";
        private const string OtraValue = "otra";

        /// <summary> es_Peninsula. </summary>
        public static FiscalRegionApiModelCode EsPeninsula { get; } = new FiscalRegionApiModelCode(EsPeninsulaValue);
        /// <summary> es_Canarias. </summary>
        public static FiscalRegionApiModelCode EsCanarias { get; } = new FiscalRegionApiModelCode(EsCanariasValue);
        /// <summary> es_CeutaYMelilla. </summary>
        public static FiscalRegionApiModelCode EsCeutaYMelilla { get; } = new FiscalRegionApiModelCode(EsCeutaYMelillaValue);
        /// <summary> es_Navarra. </summary>
        public static FiscalRegionApiModelCode EsNavarra { get; } = new FiscalRegionApiModelCode(EsNavarraValue);
        /// <summary> es_Alaba. </summary>
        public static FiscalRegionApiModelCode EsAlaba { get; } = new FiscalRegionApiModelCode(EsAlabaValue);
        /// <summary> es_Bizcaya. </summary>
        public static FiscalRegionApiModelCode EsBizcaya { get; } = new FiscalRegionApiModelCode(EsBizcayaValue);
        /// <summary> es_Guipuzcoa. </summary>
        public static FiscalRegionApiModelCode EsGuipuzcoa { get; } = new FiscalRegionApiModelCode(EsGuipuzcoaValue);
        /// <summary> mx. </summary>
        public static FiscalRegionApiModelCode Mx { get; } = new FiscalRegionApiModelCode(MxValue);
        /// <summary> ar. </summary>
        public static FiscalRegionApiModelCode Ar { get; } = new FiscalRegionApiModelCode(ArValue);
        /// <summary> co. </summary>
        public static FiscalRegionApiModelCode Co { get; } = new FiscalRegionApiModelCode(CoValue);
        /// <summary> cl. </summary>
        public static FiscalRegionApiModelCode Cl { get; } = new FiscalRegionApiModelCode(ClValue);
        /// <summary> pe. </summary>
        public static FiscalRegionApiModelCode Pe { get; } = new FiscalRegionApiModelCode(PeValue);
        /// <summary> ve. </summary>
        public static FiscalRegionApiModelCode Ve { get; } = new FiscalRegionApiModelCode(VeValue);
        /// <summary> ec. </summary>
        public static FiscalRegionApiModelCode Ec { get; } = new FiscalRegionApiModelCode(EcValue);
        /// <summary> hn. </summary>
        public static FiscalRegionApiModelCode Hn { get; } = new FiscalRegionApiModelCode(HnValue);
        /// <summary> us. </summary>
        public static FiscalRegionApiModelCode Us { get; } = new FiscalRegionApiModelCode(UsValue);
        /// <summary> uk. </summary>
        public static FiscalRegionApiModelCode Uk { get; } = new FiscalRegionApiModelCode(UkValue);
        /// <summary> ie. </summary>
        public static FiscalRegionApiModelCode Ie { get; } = new FiscalRegionApiModelCode(IeValue);
        /// <summary> otra. </summary>
        public static FiscalRegionApiModelCode Otra { get; } = new FiscalRegionApiModelCode(OtraValue);
        /// <summary> Determines if two <see cref="FiscalRegionApiModelCode"/> values are the same. </summary>
        public static bool operator ==(FiscalRegionApiModelCode left, FiscalRegionApiModelCode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FiscalRegionApiModelCode"/> values are not the same. </summary>
        public static bool operator !=(FiscalRegionApiModelCode left, FiscalRegionApiModelCode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FiscalRegionApiModelCode"/>. </summary>
        public static implicit operator FiscalRegionApiModelCode(string value) => new FiscalRegionApiModelCode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FiscalRegionApiModelCode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FiscalRegionApiModelCode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
