// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using System.Xml.Linq;
using Azure.Core;

namespace ContasimpleAPI.Models
{
    public partial class CompanyExtraInformationApiModel
    {
        internal static CompanyExtraInformationApiModel DeserializeCompanyExtraInformationApiModel(JsonElement element)
        {
            Optional<string> companyIdentifierName = default;
            Optional<string> currencySymbol = default;
            Optional<bool> currencySymbolIsSuffix = default;
            Optional<string> customAutoNumberFormat = default;
            Optional<string> customDeliveryNoteAutoNumberFormat = default;
            Optional<string> customEntityField1Name = default;
            Optional<string> customEntityField2Name = default;
            Optional<string> customEstimateAutoNumberFormat = default;
            Optional<string> deliveryNoteCulture = default;
            Optional<bool> enablePaginationInLists = default;
            Optional<EntityApiModel> entity = default;
            Optional<string> estimateCulture = default;
            Optional<long> id = default;
            Optional<bool> importDeliveryNoteLineByLine = default;
            Optional<string> invoiceCulture = default;
            Optional<bool> invoiceDataFilled = default;
            Optional<string> reName = default;
            Optional<IReadOnlyList<ReTypeApiModel>> reTypes = default;
            Optional<string> retentionName = default;
            Optional<IReadOnlyList<RetentionTypeApiModel>> retentionTypes = default;
            Optional<CompanyExtraInformationApiModelSignElectronicInvoices> signElectronicInvoices = default;
            Optional<CompanyExtraInformationApiModelSignPDFDeliveryNotes> signPDFDeliveryNotes = default;
            Optional<CompanyExtraInformationApiModelSignPDFEstimates> signPDFEstimates = default;
            Optional<CompanyExtraInformationApiModelSignPDFInvoices> signPDFInvoices = default;
            Optional<CompanyExtraInformationApiModelSignVirtualDriveFiles> signVirtualDriveFiles = default;
            Optional<string> vatName = default;
            Optional<IReadOnlyList<VatTypeApiModel>> vatTypes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("companyIdentifierName"))
                {
                    companyIdentifierName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("currencySymbol"))
                {
                    currencySymbol = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("currencySymbolIsSuffix"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    currencySymbolIsSuffix = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("customAutoNumberFormat"))
                {
                    customAutoNumberFormat = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customDeliveryNoteAutoNumberFormat"))
                {
                    customDeliveryNoteAutoNumberFormat = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customEntityField1Name"))
                {
                    customEntityField1Name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customEntityField2Name"))
                {
                    customEntityField2Name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customEstimateAutoNumberFormat"))
                {
                    customEstimateAutoNumberFormat = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deliveryNoteCulture"))
                {
                    deliveryNoteCulture = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enablePaginationInLists"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enablePaginationInLists = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("entity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    entity = EntityApiModel.DeserializeEntityApiModel(property.Value);
                    continue;
                }
                if (property.NameEquals("estimateCulture"))
                {
                    estimateCulture = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    id = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("importDeliveryNoteLineByLine"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    importDeliveryNoteLineByLine = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("invoiceCulture"))
                {
                    invoiceCulture = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("invoiceDataFilled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    invoiceDataFilled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("reName"))
                {
                    reName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reTypes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ReTypeApiModel> array = new List<ReTypeApiModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReTypeApiModel.DeserializeReTypeApiModel(item));
                    }
                    reTypes = array;
                    continue;
                }
                if (property.NameEquals("retentionName"))
                {
                    retentionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("retentionTypes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<RetentionTypeApiModel> array = new List<RetentionTypeApiModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RetentionTypeApiModel.DeserializeRetentionTypeApiModel(item));
                    }
                    retentionTypes = array;
                    continue;
                }
                if (property.NameEquals("signElectronicInvoices"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    signElectronicInvoices = new CompanyExtraInformationApiModelSignElectronicInvoices(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("signPDFDeliveryNotes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    signPDFDeliveryNotes = new CompanyExtraInformationApiModelSignPDFDeliveryNotes(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("signPDFEstimates"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    signPDFEstimates = new CompanyExtraInformationApiModelSignPDFEstimates(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("signPDFInvoices"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    signPDFInvoices = new CompanyExtraInformationApiModelSignPDFInvoices(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("signVirtualDriveFiles"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    signVirtualDriveFiles = new CompanyExtraInformationApiModelSignVirtualDriveFiles(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vatName"))
                {
                    vatName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vatTypes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<VatTypeApiModel> array = new List<VatTypeApiModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VatTypeApiModel.DeserializeVatTypeApiModel(item));
                    }
                    vatTypes = array;
                    continue;
                }
            }
            return new CompanyExtraInformationApiModel(companyIdentifierName.Value, currencySymbol.Value, Optional.ToNullable(currencySymbolIsSuffix), customAutoNumberFormat.Value, customDeliveryNoteAutoNumberFormat.Value, customEntityField1Name.Value, customEntityField2Name.Value, customEstimateAutoNumberFormat.Value, deliveryNoteCulture.Value, Optional.ToNullable(enablePaginationInLists), entity.Value, estimateCulture.Value, Optional.ToNullable(id), Optional.ToNullable(importDeliveryNoteLineByLine), invoiceCulture.Value, Optional.ToNullable(invoiceDataFilled), reName.Value, Optional.ToList(reTypes), retentionName.Value, Optional.ToList(retentionTypes), Optional.ToNullable(signElectronicInvoices), Optional.ToNullable(signPDFDeliveryNotes), Optional.ToNullable(signPDFEstimates), Optional.ToNullable(signPDFInvoices), Optional.ToNullable(signVirtualDriveFiles), vatName.Value, Optional.ToList(vatTypes));
        }

        internal static CompanyExtraInformationApiModel DeserializeCompanyExtraInformationApiModel(XElement element)
        {
            string companyIdentifierName = default;
            string currencySymbol = default;
            bool? currencySymbolIsSuffix = default;
            string customAutoNumberFormat = default;
            string customDeliveryNoteAutoNumberFormat = default;
            string customEntityField1Name = default;
            string customEntityField2Name = default;
            string customEstimateAutoNumberFormat = default;
            string deliveryNoteCulture = default;
            bool? enablePaginationInLists = default;
            EntityApiModel entity = default;
            string estimateCulture = default;
            long? id = default;
            bool? importDeliveryNoteLineByLine = default;
            string invoiceCulture = default;
            bool? invoiceDataFilled = default;
            string reName = default;
            string retentionName = default;
            CompanyExtraInformationApiModelSignElectronicInvoices? signElectronicInvoices = default;
            CompanyExtraInformationApiModelSignPDFDeliveryNotes? signPDFDeliveryNotes = default;
            CompanyExtraInformationApiModelSignPDFEstimates? signPDFEstimates = default;
            CompanyExtraInformationApiModelSignPDFInvoices? signPDFInvoices = default;
            CompanyExtraInformationApiModelSignVirtualDriveFiles? signVirtualDriveFiles = default;
            string vatName = default;
            IReadOnlyList<ReTypeApiModel> reTypes = default;
            IReadOnlyList<RetentionTypeApiModel> retentionTypes = default;
            IReadOnlyList<VatTypeApiModel> vatTypes = default;
            if (element.Element("companyIdentifierName") is XElement companyIdentifierNameElement)
            {
                companyIdentifierName = (string)companyIdentifierNameElement;
            }
            if (element.Element("currencySymbol") is XElement currencySymbolElement)
            {
                currencySymbol = (string)currencySymbolElement;
            }
            if (element.Element("currencySymbolIsSuffix") is XElement currencySymbolIsSuffixElement)
            {
                currencySymbolIsSuffix = (bool?)currencySymbolIsSuffixElement;
            }
            if (element.Element("customAutoNumberFormat") is XElement customAutoNumberFormatElement)
            {
                customAutoNumberFormat = (string)customAutoNumberFormatElement;
            }
            if (element.Element("customDeliveryNoteAutoNumberFormat") is XElement customDeliveryNoteAutoNumberFormatElement)
            {
                customDeliveryNoteAutoNumberFormat = (string)customDeliveryNoteAutoNumberFormatElement;
            }
            if (element.Element("customEntityField1Name") is XElement customEntityField1NameElement)
            {
                customEntityField1Name = (string)customEntityField1NameElement;
            }
            if (element.Element("customEntityField2Name") is XElement customEntityField2NameElement)
            {
                customEntityField2Name = (string)customEntityField2NameElement;
            }
            if (element.Element("customEstimateAutoNumberFormat") is XElement customEstimateAutoNumberFormatElement)
            {
                customEstimateAutoNumberFormat = (string)customEstimateAutoNumberFormatElement;
            }
            if (element.Element("deliveryNoteCulture") is XElement deliveryNoteCultureElement)
            {
                deliveryNoteCulture = (string)deliveryNoteCultureElement;
            }
            if (element.Element("enablePaginationInLists") is XElement enablePaginationInListsElement)
            {
                enablePaginationInLists = (bool?)enablePaginationInListsElement;
            }
            if (element.Element("entity") is XElement entityElement)
            {
                entity = EntityApiModel.DeserializeEntityApiModel(entityElement);
            }
            if (element.Element("estimateCulture") is XElement estimateCultureElement)
            {
                estimateCulture = (string)estimateCultureElement;
            }
            if (element.Element("id") is XElement idElement)
            {
                id = (long?)idElement;
            }
            if (element.Element("importDeliveryNoteLineByLine") is XElement importDeliveryNoteLineByLineElement)
            {
                importDeliveryNoteLineByLine = (bool?)importDeliveryNoteLineByLineElement;
            }
            if (element.Element("invoiceCulture") is XElement invoiceCultureElement)
            {
                invoiceCulture = (string)invoiceCultureElement;
            }
            if (element.Element("invoiceDataFilled") is XElement invoiceDataFilledElement)
            {
                invoiceDataFilled = (bool?)invoiceDataFilledElement;
            }
            if (element.Element("reName") is XElement reNameElement)
            {
                reName = (string)reNameElement;
            }
            if (element.Element("retentionName") is XElement retentionNameElement)
            {
                retentionName = (string)retentionNameElement;
            }
            if (element.Element("signElectronicInvoices") is XElement signElectronicInvoicesElement)
            {
                signElectronicInvoices = new CompanyExtraInformationApiModelSignElectronicInvoices(signElectronicInvoicesElement.Value);
            }
            if (element.Element("signPDFDeliveryNotes") is XElement signPDFDeliveryNotesElement)
            {
                signPDFDeliveryNotes = new CompanyExtraInformationApiModelSignPDFDeliveryNotes(signPDFDeliveryNotesElement.Value);
            }
            if (element.Element("signPDFEstimates") is XElement signPDFEstimatesElement)
            {
                signPDFEstimates = new CompanyExtraInformationApiModelSignPDFEstimates(signPDFEstimatesElement.Value);
            }
            if (element.Element("signPDFInvoices") is XElement signPDFInvoicesElement)
            {
                signPDFInvoices = new CompanyExtraInformationApiModelSignPDFInvoices(signPDFInvoicesElement.Value);
            }
            if (element.Element("signVirtualDriveFiles") is XElement signVirtualDriveFilesElement)
            {
                signVirtualDriveFiles = new CompanyExtraInformationApiModelSignVirtualDriveFiles(signVirtualDriveFilesElement.Value);
            }
            if (element.Element("vatName") is XElement vatNameElement)
            {
                vatName = (string)vatNameElement;
            }
            var array = new List<ReTypeApiModel>();
            foreach (var e in element.Elements("ReTypeApiModel"))
            {
                array.Add(ReTypeApiModel.DeserializeReTypeApiModel(e));
            }
            reTypes = array;
            var array0 = new List<RetentionTypeApiModel>();
            foreach (var e in element.Elements("RetentionTypeApiModel"))
            {
                array0.Add(RetentionTypeApiModel.DeserializeRetentionTypeApiModel(e));
            }
            retentionTypes = array0;
            var array1 = new List<VatTypeApiModel>();
            foreach (var e in element.Elements("VatTypeApiModel"))
            {
                array1.Add(VatTypeApiModel.DeserializeVatTypeApiModel(e));
            }
            vatTypes = array1;
            return new CompanyExtraInformationApiModel(companyIdentifierName, currencySymbol, currencySymbolIsSuffix, customAutoNumberFormat, customDeliveryNoteAutoNumberFormat, customEntityField1Name, customEntityField2Name, customEstimateAutoNumberFormat, deliveryNoteCulture, enablePaginationInLists, entity, estimateCulture, id, importDeliveryNoteLineByLine, invoiceCulture, invoiceDataFilled, reName, reTypes, retentionName, retentionTypes, signElectronicInvoices, signPDFDeliveryNotes, signPDFEstimates, signPDFInvoices, signVirtualDriveFiles, vatName, vatTypes);
        }
    }
}
