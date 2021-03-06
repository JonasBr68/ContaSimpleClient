// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ContasimpleAPI.Models
{
    /// <summary> The name of the current module. </summary>
    public readonly partial struct ModulePermissionsApiModelName : IEquatable<ModulePermissionsApiModelName>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ModulePermissionsApiModelName"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ModulePermissionsApiModelName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "Default";
        private const string HelpValue = "Help";
        private const string NotesValue = "Notes";
        private const string MessagesValue = "Messages";
        private const string ConfigurationValue = "Configuration";
        private const string CompaniesValue = "Companies";
        private const string NewsValue = "News";
        private const string EntitiesValue = "Entities";
        private const string AccountingValue = "Accounting";
        private const string AccountingIssuedInvoicesValue = "AccountingIssuedInvoices";
        private const string AccountingReceivedInvoicesValue = "AccountingReceivedInvoices";
        private const string AccountingCostsValue = "AccountingCosts";
        private const string AccountingRedeemableCostsValue = "AccountingRedeemableCosts";
        private const string AccountingNewInvoiceValue = "AccountingNewInvoice";
        private const string AccountingResumeValue = "AccountingResume";
        private const string AccountingPresupuestoValue = "AccountingPresupuesto";
        private const string AccountingDeliveryNoteValue = "AccountingDeliveryNote";
        private const string TaxesValue = "Taxes";
        private const string TaxesIvaValue = "TaxesIva";
        private const string TaxesIrpfValue = "TaxesIrpf";
        private const string TaxesRetencionesValue = "TaxesRetenciones";
        private const string TaxesRetencionAlquileresValue = "TaxesRetencionAlquileres";
        private const string TaxesThirdPartyOperationsValue = "TaxesThirdPartyOperations";
        private const string TaxesOperacionesIntracomunitariasValue = "TaxesOperacionesIntracomunitarias";
        private const string TaxesResumeValue = "TaxesResume";
        private const string InitialConfigurationValue = "InitialConfiguration";
        private const string AdministrationValue = "Administration";
        private const string AdministrationVentasValue = "AdministrationVentas";
        private const string AdministrationStatisticsValue = "AdministrationStatistics";
        private const string BanersValue = "Baners";
        private const string ExportUserDataValue = "ExportUserData";
        private const string AccountingTransferValue = "AccountingTransfer";
        private const string CatalogoValue = "Catalogo";
        private const string TutorialValue = "Tutorial";
        private const string VirtualDiskValue = "VirtualDisk";
        private const string BanksValue = "Banks";
        private const string TreasuryValue = "Treasury";
        private const string ReportsValue = "Reports";
        private const string ImportSingleInvoiceValue = "ImportSingleInvoice";
        private const string UserPromotionsValue = "UserPromotions";
        private const string LimboValue = "Limbo";
        private const string PasarelaValue = "Pasarela";
        private const string ManagerDashboardValue = "ManagerDashboard";
        private const string DomiciliacionesValue = "Domiciliaciones";
        private const string AccountingPeriodMaintenanceValue = "AccountingPeriodMaintenance";
        private const string AdministratorDashboardValue = "AdministratorDashboard";
        private const string DocumentCertificationValue = "DocumentCertification";
        private const string WorkHoursRegisterValue = "WorkHoursRegister";
        private const string UsersValue = "Users";
        private const string EInformaValue = "EInforma";
        private const string PersonalInformationValue = "PersonalInformation";
        private const string AuthenticationValue = "Authentication";
        private const string EmptyLogoutValue = "EmptyLogout";
        private const string CoreValue = "Core";
        private const string AdministrationImpersonationValue = "AdministrationImpersonation";
        private const string CompanyInvitationValue = "CompanyInvitation";
        private const string AdministrationPromocodesValue = "AdministrationPromocodes";

        /// <summary> Default. </summary>
        public static ModulePermissionsApiModelName Default { get; } = new ModulePermissionsApiModelName(DefaultValue);
        /// <summary> Help. </summary>
        public static ModulePermissionsApiModelName Help { get; } = new ModulePermissionsApiModelName(HelpValue);
        /// <summary> Notes. </summary>
        public static ModulePermissionsApiModelName Notes { get; } = new ModulePermissionsApiModelName(NotesValue);
        /// <summary> Messages. </summary>
        public static ModulePermissionsApiModelName Messages { get; } = new ModulePermissionsApiModelName(MessagesValue);
        /// <summary> Configuration. </summary>
        public static ModulePermissionsApiModelName Configuration { get; } = new ModulePermissionsApiModelName(ConfigurationValue);
        /// <summary> Companies. </summary>
        public static ModulePermissionsApiModelName Companies { get; } = new ModulePermissionsApiModelName(CompaniesValue);
        /// <summary> News. </summary>
        public static ModulePermissionsApiModelName News { get; } = new ModulePermissionsApiModelName(NewsValue);
        /// <summary> Entities. </summary>
        public static ModulePermissionsApiModelName Entities { get; } = new ModulePermissionsApiModelName(EntitiesValue);
        /// <summary> Accounting. </summary>
        public static ModulePermissionsApiModelName Accounting { get; } = new ModulePermissionsApiModelName(AccountingValue);
        /// <summary> AccountingIssuedInvoices. </summary>
        public static ModulePermissionsApiModelName AccountingIssuedInvoices { get; } = new ModulePermissionsApiModelName(AccountingIssuedInvoicesValue);
        /// <summary> AccountingReceivedInvoices. </summary>
        public static ModulePermissionsApiModelName AccountingReceivedInvoices { get; } = new ModulePermissionsApiModelName(AccountingReceivedInvoicesValue);
        /// <summary> AccountingCosts. </summary>
        public static ModulePermissionsApiModelName AccountingCosts { get; } = new ModulePermissionsApiModelName(AccountingCostsValue);
        /// <summary> AccountingRedeemableCosts. </summary>
        public static ModulePermissionsApiModelName AccountingRedeemableCosts { get; } = new ModulePermissionsApiModelName(AccountingRedeemableCostsValue);
        /// <summary> AccountingNewInvoice. </summary>
        public static ModulePermissionsApiModelName AccountingNewInvoice { get; } = new ModulePermissionsApiModelName(AccountingNewInvoiceValue);
        /// <summary> AccountingResume. </summary>
        public static ModulePermissionsApiModelName AccountingResume { get; } = new ModulePermissionsApiModelName(AccountingResumeValue);
        /// <summary> AccountingPresupuesto. </summary>
        public static ModulePermissionsApiModelName AccountingPresupuesto { get; } = new ModulePermissionsApiModelName(AccountingPresupuestoValue);
        /// <summary> AccountingDeliveryNote. </summary>
        public static ModulePermissionsApiModelName AccountingDeliveryNote { get; } = new ModulePermissionsApiModelName(AccountingDeliveryNoteValue);
        /// <summary> Taxes. </summary>
        public static ModulePermissionsApiModelName Taxes { get; } = new ModulePermissionsApiModelName(TaxesValue);
        /// <summary> TaxesIva. </summary>
        public static ModulePermissionsApiModelName TaxesIva { get; } = new ModulePermissionsApiModelName(TaxesIvaValue);
        /// <summary> TaxesIrpf. </summary>
        public static ModulePermissionsApiModelName TaxesIrpf { get; } = new ModulePermissionsApiModelName(TaxesIrpfValue);
        /// <summary> TaxesRetenciones. </summary>
        public static ModulePermissionsApiModelName TaxesRetenciones { get; } = new ModulePermissionsApiModelName(TaxesRetencionesValue);
        /// <summary> TaxesRetencionAlquileres. </summary>
        public static ModulePermissionsApiModelName TaxesRetencionAlquileres { get; } = new ModulePermissionsApiModelName(TaxesRetencionAlquileresValue);
        /// <summary> TaxesThirdPartyOperations. </summary>
        public static ModulePermissionsApiModelName TaxesThirdPartyOperations { get; } = new ModulePermissionsApiModelName(TaxesThirdPartyOperationsValue);
        /// <summary> TaxesOperacionesIntracomunitarias. </summary>
        public static ModulePermissionsApiModelName TaxesOperacionesIntracomunitarias { get; } = new ModulePermissionsApiModelName(TaxesOperacionesIntracomunitariasValue);
        /// <summary> TaxesResume. </summary>
        public static ModulePermissionsApiModelName TaxesResume { get; } = new ModulePermissionsApiModelName(TaxesResumeValue);
        /// <summary> InitialConfiguration. </summary>
        public static ModulePermissionsApiModelName InitialConfiguration { get; } = new ModulePermissionsApiModelName(InitialConfigurationValue);
        /// <summary> Administration. </summary>
        public static ModulePermissionsApiModelName Administration { get; } = new ModulePermissionsApiModelName(AdministrationValue);
        /// <summary> AdministrationVentas. </summary>
        public static ModulePermissionsApiModelName AdministrationVentas { get; } = new ModulePermissionsApiModelName(AdministrationVentasValue);
        /// <summary> AdministrationStatistics. </summary>
        public static ModulePermissionsApiModelName AdministrationStatistics { get; } = new ModulePermissionsApiModelName(AdministrationStatisticsValue);
        /// <summary> Baners. </summary>
        public static ModulePermissionsApiModelName Baners { get; } = new ModulePermissionsApiModelName(BanersValue);
        /// <summary> ExportUserData. </summary>
        public static ModulePermissionsApiModelName ExportUserData { get; } = new ModulePermissionsApiModelName(ExportUserDataValue);
        /// <summary> AccountingTransfer. </summary>
        public static ModulePermissionsApiModelName AccountingTransfer { get; } = new ModulePermissionsApiModelName(AccountingTransferValue);
        /// <summary> Catalogo. </summary>
        public static ModulePermissionsApiModelName Catalogo { get; } = new ModulePermissionsApiModelName(CatalogoValue);
        /// <summary> Tutorial. </summary>
        public static ModulePermissionsApiModelName Tutorial { get; } = new ModulePermissionsApiModelName(TutorialValue);
        /// <summary> VirtualDisk. </summary>
        public static ModulePermissionsApiModelName VirtualDisk { get; } = new ModulePermissionsApiModelName(VirtualDiskValue);
        /// <summary> Banks. </summary>
        public static ModulePermissionsApiModelName Banks { get; } = new ModulePermissionsApiModelName(BanksValue);
        /// <summary> Treasury. </summary>
        public static ModulePermissionsApiModelName Treasury { get; } = new ModulePermissionsApiModelName(TreasuryValue);
        /// <summary> Reports. </summary>
        public static ModulePermissionsApiModelName Reports { get; } = new ModulePermissionsApiModelName(ReportsValue);
        /// <summary> ImportSingleInvoice. </summary>
        public static ModulePermissionsApiModelName ImportSingleInvoice { get; } = new ModulePermissionsApiModelName(ImportSingleInvoiceValue);
        /// <summary> UserPromotions. </summary>
        public static ModulePermissionsApiModelName UserPromotions { get; } = new ModulePermissionsApiModelName(UserPromotionsValue);
        /// <summary> Limbo. </summary>
        public static ModulePermissionsApiModelName Limbo { get; } = new ModulePermissionsApiModelName(LimboValue);
        /// <summary> Pasarela. </summary>
        public static ModulePermissionsApiModelName Pasarela { get; } = new ModulePermissionsApiModelName(PasarelaValue);
        /// <summary> ManagerDashboard. </summary>
        public static ModulePermissionsApiModelName ManagerDashboard { get; } = new ModulePermissionsApiModelName(ManagerDashboardValue);
        /// <summary> Domiciliaciones. </summary>
        public static ModulePermissionsApiModelName Domiciliaciones { get; } = new ModulePermissionsApiModelName(DomiciliacionesValue);
        /// <summary> AccountingPeriodMaintenance. </summary>
        public static ModulePermissionsApiModelName AccountingPeriodMaintenance { get; } = new ModulePermissionsApiModelName(AccountingPeriodMaintenanceValue);
        /// <summary> AdministratorDashboard. </summary>
        public static ModulePermissionsApiModelName AdministratorDashboard { get; } = new ModulePermissionsApiModelName(AdministratorDashboardValue);
        /// <summary> DocumentCertification. </summary>
        public static ModulePermissionsApiModelName DocumentCertification { get; } = new ModulePermissionsApiModelName(DocumentCertificationValue);
        /// <summary> WorkHoursRegister. </summary>
        public static ModulePermissionsApiModelName WorkHoursRegister { get; } = new ModulePermissionsApiModelName(WorkHoursRegisterValue);
        /// <summary> Users. </summary>
        public static ModulePermissionsApiModelName Users { get; } = new ModulePermissionsApiModelName(UsersValue);
        /// <summary> EInforma. </summary>
        public static ModulePermissionsApiModelName EInforma { get; } = new ModulePermissionsApiModelName(EInformaValue);
        /// <summary> PersonalInformation. </summary>
        public static ModulePermissionsApiModelName PersonalInformation { get; } = new ModulePermissionsApiModelName(PersonalInformationValue);
        /// <summary> Authentication. </summary>
        public static ModulePermissionsApiModelName Authentication { get; } = new ModulePermissionsApiModelName(AuthenticationValue);
        /// <summary> EmptyLogout. </summary>
        public static ModulePermissionsApiModelName EmptyLogout { get; } = new ModulePermissionsApiModelName(EmptyLogoutValue);
        /// <summary> Core. </summary>
        public static ModulePermissionsApiModelName Core { get; } = new ModulePermissionsApiModelName(CoreValue);
        /// <summary> AdministrationImpersonation. </summary>
        public static ModulePermissionsApiModelName AdministrationImpersonation { get; } = new ModulePermissionsApiModelName(AdministrationImpersonationValue);
        /// <summary> CompanyInvitation. </summary>
        public static ModulePermissionsApiModelName CompanyInvitation { get; } = new ModulePermissionsApiModelName(CompanyInvitationValue);
        /// <summary> AdministrationPromocodes. </summary>
        public static ModulePermissionsApiModelName AdministrationPromocodes { get; } = new ModulePermissionsApiModelName(AdministrationPromocodesValue);
        /// <summary> Determines if two <see cref="ModulePermissionsApiModelName"/> values are the same. </summary>
        public static bool operator ==(ModulePermissionsApiModelName left, ModulePermissionsApiModelName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ModulePermissionsApiModelName"/> values are not the same. </summary>
        public static bool operator !=(ModulePermissionsApiModelName left, ModulePermissionsApiModelName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ModulePermissionsApiModelName"/>. </summary>
        public static implicit operator ModulePermissionsApiModelName(string value) => new ModulePermissionsApiModelName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ModulePermissionsApiModelName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ModulePermissionsApiModelName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
