// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.adoxio_cannabismonthlyreport
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioCannabismonthlyreport
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioCannabismonthlyreport class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioCannabismonthlyreport()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioCannabismonthlyreport class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioCannabismonthlyreport(int? adoxioEmployeesother = default(int?), string adoxioCannabismonthlyreportid = default(string), string _modifiedonbehalfbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? timezoneruleversionnumber = default(int?), System.DateTimeOffset? adoxioCsvexportdate = default(System.DateTimeOffset?), int? adoxioEmployeessales = default(int?), int? adoxioEmployeesmanagement = default(int?), int? utcconversiontimezonecode = default(int?), int? adoxioEmployeesadministrative = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? adoxioRetailerdistributor = default(int?), string adoxioLicenseenametext = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string adoxioName = default(string), string _owningbusinessunitValue = default(string), string adoxioSiteidnumber = default(string), int? adoxioCsvexportid = default(int?), string _modifiedbyValue = default(string), int? adoxioEmployeesproduction = default(int?), string adoxioReportingperiodyear = default(string), string _createdbyValue = default(string), int? statuscode = default(int?), string _owneridValue = default(string), string _adoxioLicenceidValue = default(string), string adoxioCity = default(string), string _owningteamValue = default(string), string _adoxioLicenseeidValue = default(string), bool? adoxioIsexportnow = default(bool?), string adoxioLicencenumber = default(string), string _adoxioEstablishmentidValue = default(string), string adoxioEstablishmentnametext = default(string), int? importsequencenumber = default(int?), string _owninguserValue = default(string), string _createdonbehalfbyValue = default(string), string adoxioPostalcode = default(string), string versionnumber = default(string), int? statecode = default(int?), string _adoxioFederalreportexportidValue = default(string), string adoxioReportingperiodmonth = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioCannabismonthlyreportSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioCannabismonthlyreportDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioCannabismonthlyreportDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioCannabismonthlyreportAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> adoxioCannabismonthlyreportMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> adoxioCannabismonthlyreportProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioCannabismonthlyreportBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> adoxioCannabismonthlyreportPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMadoxioLicences adoxioLicenceId = default(MicrosoftDynamicsCRMadoxioLicences), MicrosoftDynamicsCRMadoxioEstablishment adoxioEstablishmentId = default(MicrosoftDynamicsCRMadoxioEstablishment), MicrosoftDynamicsCRMaccount adoxioLicenseeId = default(MicrosoftDynamicsCRMaccount), IList<MicrosoftDynamicsCRMadoxioCannabisinventoryreport> adoxioCannabismonthlyreportInventoryreports = default(IList<MicrosoftDynamicsCRMadoxioCannabisinventoryreport>), MicrosoftDynamicsCRMadoxioFederalreportexport adoxioFederalReportExportId = default(MicrosoftDynamicsCRMadoxioFederalreportexport))
        {
            AdoxioEmployeesother = adoxioEmployeesother;
            AdoxioCannabismonthlyreportid = adoxioCannabismonthlyreportid;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Createdon = createdon;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            AdoxioCsvexportdate = adoxioCsvexportdate;
            AdoxioEmployeessales = adoxioEmployeessales;
            AdoxioEmployeesmanagement = adoxioEmployeesmanagement;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            AdoxioEmployeesadministrative = adoxioEmployeesadministrative;
            Overriddencreatedon = overriddencreatedon;
            AdoxioRetailerdistributor = adoxioRetailerdistributor;
            AdoxioLicenseenametext = adoxioLicenseenametext;
            Modifiedon = modifiedon;
            AdoxioName = adoxioName;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            AdoxioSiteidnumber = adoxioSiteidnumber;
            AdoxioCsvexportid = adoxioCsvexportid;
            this._modifiedbyValue = _modifiedbyValue;
            AdoxioEmployeesproduction = adoxioEmployeesproduction;
            AdoxioReportingperiodyear = adoxioReportingperiodyear;
            this._createdbyValue = _createdbyValue;
            Statuscode = statuscode;
            this._owneridValue = _owneridValue;
            this._adoxioLicenceidValue = _adoxioLicenceidValue;
            AdoxioCity = adoxioCity;
            this._owningteamValue = _owningteamValue;
            this._adoxioLicenseeidValue = _adoxioLicenseeidValue;
            AdoxioIsexportnow = adoxioIsexportnow;
            AdoxioLicencenumber = adoxioLicencenumber;
            this._adoxioEstablishmentidValue = _adoxioEstablishmentidValue;
            AdoxioEstablishmentnametext = adoxioEstablishmentnametext;
            Importsequencenumber = importsequencenumber;
            this._owninguserValue = _owninguserValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            AdoxioPostalcode = adoxioPostalcode;
            Versionnumber = versionnumber;
            Statecode = statecode;
            this._adoxioFederalreportexportidValue = _adoxioFederalreportexportidValue;
            AdoxioReportingperiodmonth = adoxioReportingperiodmonth;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioCannabismonthlyreportSyncErrors = adoxioCannabismonthlyreportSyncErrors;
            AdoxioCannabismonthlyreportDuplicateMatchingRecord = adoxioCannabismonthlyreportDuplicateMatchingRecord;
            AdoxioCannabismonthlyreportDuplicateBaseRecord = adoxioCannabismonthlyreportDuplicateBaseRecord;
            AdoxioCannabismonthlyreportAsyncOperations = adoxioCannabismonthlyreportAsyncOperations;
            AdoxioCannabismonthlyreportMailboxTrackingFolders = adoxioCannabismonthlyreportMailboxTrackingFolders;
            AdoxioCannabismonthlyreportProcessSession = adoxioCannabismonthlyreportProcessSession;
            AdoxioCannabismonthlyreportBulkDeleteFailures = adoxioCannabismonthlyreportBulkDeleteFailures;
            AdoxioCannabismonthlyreportPrincipalObjectAttributeAccesses = adoxioCannabismonthlyreportPrincipalObjectAttributeAccesses;
            AdoxioLicenceId = adoxioLicenceId;
            AdoxioEstablishmentId = adoxioEstablishmentId;
            AdoxioLicenseeId = adoxioLicenseeId;
            AdoxioCannabismonthlyreportInventoryreports = adoxioCannabismonthlyreportInventoryreports;
            AdoxioFederalReportExportId = adoxioFederalReportExportId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_employeesother")]
        public int? AdoxioEmployeesother { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_cannabismonthlyreportid")]
        public string AdoxioCannabismonthlyreportid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_csvexportdate")]
        public System.DateTimeOffset? AdoxioCsvexportdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_employeessales")]
        public int? AdoxioEmployeessales { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_employeesmanagement")]
        public int? AdoxioEmployeesmanagement { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_employeesadministrative")]
        public int? AdoxioEmployeesadministrative { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_retailerdistributor")]
        public int? AdoxioRetailerdistributor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licenseenametext")]
        public string AdoxioLicenseenametext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_siteidnumber")]
        public string AdoxioSiteidnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_csvexportid")]
        public int? AdoxioCsvexportid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_employeesproduction")]
        public int? AdoxioEmployeesproduction { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_reportingperiodyear")]
        public string AdoxioReportingperiodyear { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_licenceid_value")]
        public string _adoxioLicenceidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_city")]
        public string AdoxioCity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_licenseeid_value")]
        public string _adoxioLicenseeidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isexportnow")]
        public bool? AdoxioIsexportnow { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencenumber")]
        public string AdoxioLicencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_establishmentid_value")]
        public string _adoxioEstablishmentidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_establishmentnametext")]
        public string AdoxioEstablishmentnametext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_postalcode")]
        public string AdoxioPostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_federalreportexportid_value")]
        public string _adoxioFederalreportexportidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_reportingperiodmonth")]
        public string AdoxioReportingperiodmonth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_cannabismonthlyreport_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioCannabismonthlyreportSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_cannabismonthlyreport_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioCannabismonthlyreportDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_cannabismonthlyreport_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioCannabismonthlyreportDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_cannabismonthlyreport_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioCannabismonthlyreportAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_cannabismonthlyreport_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> AdoxioCannabismonthlyreportMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_cannabismonthlyreport_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> AdoxioCannabismonthlyreportProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_cannabismonthlyreport_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioCannabismonthlyreportBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_cannabismonthlyreport_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> AdoxioCannabismonthlyreportPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_LicenceId")]
        public MicrosoftDynamicsCRMadoxioLicences AdoxioLicenceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_EstablishmentId")]
        public MicrosoftDynamicsCRMadoxioEstablishment AdoxioEstablishmentId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_LicenseeId")]
        public MicrosoftDynamicsCRMaccount AdoxioLicenseeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_cannabismonthlyreport_inventoryreports")]
        public IList<MicrosoftDynamicsCRMadoxioCannabisinventoryreport> AdoxioCannabismonthlyreportInventoryreports { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_FederalReportExportId")]
        public MicrosoftDynamicsCRMadoxioFederalreportexport AdoxioFederalReportExportId { get; set; }

    }
}
