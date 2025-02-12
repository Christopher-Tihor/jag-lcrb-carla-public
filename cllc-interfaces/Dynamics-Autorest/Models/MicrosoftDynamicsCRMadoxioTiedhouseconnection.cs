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
    /// Microsoft.Dynamics.CRM.adoxio_tiedhouseconnection
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioTiedhouseconnection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioTiedhouseconnection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioTiedhouseconnection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioTiedhouseconnection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioTiedhouseconnection(int? timezoneruleversionnumber = default(int?), string _modifiedonbehalfbyValue = default(string), int? adoxioCorpconnectionfederalproducer = default(int?), string adoxioAssociateconnectionfederalproducerdetails = default(string), string _owneridValue = default(string), string adoxioSharetype = default(string), int? adoxioPercentageofownership = default(int?), string _owningbusinessunitValue = default(string), int? adoxioFamilymemberfederalproducer = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), string _owninguserValue = default(string), string adoxioAdditionaldetails = default(string), int? adoxioMarketerconnectiontocrs = default(int?), string adoxioShare20plusfamilyconnectionproducerdetail = default(string), string adoxioShare20plusconnectionproducerdetails = default(string), int? adoxioAssociateconnectionfederalproducer = default(int?), string adoxioFederalproducername = default(string), string adoxioMarketerconnectiontocrsdetails = default(string), string _adoxioApplicationValue = default(string), int? adoxioSolepropconnectiontofederalproducer = default(int?), string _adoxioAccountidValue = default(string), int? statecode = default(int?), int? statuscode = default(int?), int? adoxioFederalproducerconnectiontocorp = default(int?), string _owningteamValue = default(string), int? adoxioCrsconnectiontomarketer = default(int?), string adoxioTiedhouseconnectionid = default(string), int? utcconversiontimezonecode = default(int?), int? adoxioConnectiontype = default(int?), string adoxioSocietyconnectionfederalproducerdetails = default(string), int? adoxioShare20plusconnectionproducer = default(int?), string adoxioFamilymemberfederalproducerdetails = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string adoxioCorpconnectionfederalproducerdetails = default(string), string versionnumber = default(string), string adoxioName = default(string), int? adoxioSocietyconnectionfederalproducer = default(int?), string adoxioFederalproducerconnectiontocorpdetails = default(string), string adoxioInconnectiontofederalproducerdetails = default(string), int? adoxioInconnectiontofederalproducer = default(int?), string adoxioPartnersconnectionfederalproducerdetails = default(string), int? adoxioIsconnection = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? adoxioPartnersconnectionfederalproducer = default(int?), string adoxioCrsconnectiontomarketerdetails = default(string), string _modifiedbyValue = default(string), string adoxioSolepropconnectiontofederalproducerdetail = default(string), string adoxioLiquorfinancialinterestdetails = default(string), string _adoxioContactidValue = default(string), int? adoxioShare20plusfamilyconnectionproducer = default(int?), string _adoxioTiedhouseValue = default(string), string _createdonbehalfbyValue = default(string), int? adoxioOwnershiptype = default(int?), string _createdbyValue = default(string), int? adoxioLiquorfinancialinterest = default(int?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioTiedhouseconnectionSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioTiedhouseconnectionDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioTiedhouseconnectionDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioTiedhouseconnectionAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> adoxioTiedhouseconnectionMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> adoxioTiedhouseconnectionProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioTiedhouseconnectionBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> adoxioTiedhouseconnectionPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMaccount adoxioAccountId = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMadoxioApplication adoxioApplication = default(MicrosoftDynamicsCRMadoxioApplication), MicrosoftDynamicsCRMcontact adoxioContactId = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMadoxioTiedhouseassociation adoxioTiedHouse = default(MicrosoftDynamicsCRMadoxioTiedhouseassociation))
        {
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            AdoxioCorpconnectionfederalproducer = adoxioCorpconnectionfederalproducer;
            AdoxioAssociateconnectionfederalproducerdetails = adoxioAssociateconnectionfederalproducerdetails;
            this._owneridValue = _owneridValue;
            AdoxioSharetype = adoxioSharetype;
            AdoxioPercentageofownership = adoxioPercentageofownership;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            AdoxioFamilymemberfederalproducer = adoxioFamilymemberfederalproducer;
            Modifiedon = modifiedon;
            Importsequencenumber = importsequencenumber;
            this._owninguserValue = _owninguserValue;
            AdoxioAdditionaldetails = adoxioAdditionaldetails;
            AdoxioMarketerconnectiontocrs = adoxioMarketerconnectiontocrs;
            AdoxioShare20plusfamilyconnectionproducerdetail = adoxioShare20plusfamilyconnectionproducerdetail;
            AdoxioShare20plusconnectionproducerdetails = adoxioShare20plusconnectionproducerdetails;
            AdoxioAssociateconnectionfederalproducer = adoxioAssociateconnectionfederalproducer;
            AdoxioFederalproducername = adoxioFederalproducername;
            AdoxioMarketerconnectiontocrsdetails = adoxioMarketerconnectiontocrsdetails;
            this._adoxioApplicationValue = _adoxioApplicationValue;
            AdoxioSolepropconnectiontofederalproducer = adoxioSolepropconnectiontofederalproducer;
            this._adoxioAccountidValue = _adoxioAccountidValue;
            Statecode = statecode;
            Statuscode = statuscode;
            AdoxioFederalproducerconnectiontocorp = adoxioFederalproducerconnectiontocorp;
            this._owningteamValue = _owningteamValue;
            AdoxioCrsconnectiontomarketer = adoxioCrsconnectiontomarketer;
            AdoxioTiedhouseconnectionid = adoxioTiedhouseconnectionid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            AdoxioConnectiontype = adoxioConnectiontype;
            AdoxioSocietyconnectionfederalproducerdetails = adoxioSocietyconnectionfederalproducerdetails;
            AdoxioShare20plusconnectionproducer = adoxioShare20plusconnectionproducer;
            AdoxioFamilymemberfederalproducerdetails = adoxioFamilymemberfederalproducerdetails;
            Createdon = createdon;
            AdoxioCorpconnectionfederalproducerdetails = adoxioCorpconnectionfederalproducerdetails;
            Versionnumber = versionnumber;
            AdoxioName = adoxioName;
            AdoxioSocietyconnectionfederalproducer = adoxioSocietyconnectionfederalproducer;
            AdoxioFederalproducerconnectiontocorpdetails = adoxioFederalproducerconnectiontocorpdetails;
            AdoxioInconnectiontofederalproducerdetails = adoxioInconnectiontofederalproducerdetails;
            AdoxioInconnectiontofederalproducer = adoxioInconnectiontofederalproducer;
            AdoxioPartnersconnectionfederalproducerdetails = adoxioPartnersconnectionfederalproducerdetails;
            AdoxioIsconnection = adoxioIsconnection;
            Overriddencreatedon = overriddencreatedon;
            AdoxioPartnersconnectionfederalproducer = adoxioPartnersconnectionfederalproducer;
            AdoxioCrsconnectiontomarketerdetails = adoxioCrsconnectiontomarketerdetails;
            this._modifiedbyValue = _modifiedbyValue;
            AdoxioSolepropconnectiontofederalproducerdetail = adoxioSolepropconnectiontofederalproducerdetail;
            AdoxioLiquorfinancialinterestdetails = adoxioLiquorfinancialinterestdetails;
            this._adoxioContactidValue = _adoxioContactidValue;
            AdoxioShare20plusfamilyconnectionproducer = adoxioShare20plusfamilyconnectionproducer;
            this._adoxioTiedhouseValue = _adoxioTiedhouseValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            AdoxioOwnershiptype = adoxioOwnershiptype;
            this._createdbyValue = _createdbyValue;
            AdoxioLiquorfinancialinterest = adoxioLiquorfinancialinterest;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioTiedhouseconnectionSyncErrors = adoxioTiedhouseconnectionSyncErrors;
            AdoxioTiedhouseconnectionDuplicateMatchingRecord = adoxioTiedhouseconnectionDuplicateMatchingRecord;
            AdoxioTiedhouseconnectionDuplicateBaseRecord = adoxioTiedhouseconnectionDuplicateBaseRecord;
            AdoxioTiedhouseconnectionAsyncOperations = adoxioTiedhouseconnectionAsyncOperations;
            AdoxioTiedhouseconnectionMailboxTrackingFolders = adoxioTiedhouseconnectionMailboxTrackingFolders;
            AdoxioTiedhouseconnectionProcessSession = adoxioTiedhouseconnectionProcessSession;
            AdoxioTiedhouseconnectionBulkDeleteFailures = adoxioTiedhouseconnectionBulkDeleteFailures;
            AdoxioTiedhouseconnectionPrincipalObjectAttributeAccesses = adoxioTiedhouseconnectionPrincipalObjectAttributeAccesses;
            AdoxioAccountId = adoxioAccountId;
            AdoxioApplication = adoxioApplication;
            AdoxioContactId = adoxioContactId;
            AdoxioTiedHouse = adoxioTiedHouse;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_corpconnectionfederalproducer")]
        public int? AdoxioCorpconnectionfederalproducer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_associateconnectionfederalproducerdetails")]
        public string AdoxioAssociateconnectionfederalproducerdetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_sharetype")]
        public string AdoxioSharetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_percentageofownership")]
        public int? AdoxioPercentageofownership { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_familymemberfederalproducer")]
        public int? AdoxioFamilymemberfederalproducer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_additionaldetails")]
        public string AdoxioAdditionaldetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_marketerconnectiontocrs")]
        public int? AdoxioMarketerconnectiontocrs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_share20plusfamilyconnectionproducerdetail")]
        public string AdoxioShare20plusfamilyconnectionproducerdetail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_share20plusconnectionproducerdetails")]
        public string AdoxioShare20plusconnectionproducerdetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_associateconnectionfederalproducer")]
        public int? AdoxioAssociateconnectionfederalproducer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_federalproducername")]
        public string AdoxioFederalproducername { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_marketerconnectiontocrsdetails")]
        public string AdoxioMarketerconnectiontocrsdetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_application_value")]
        public string _adoxioApplicationValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_solepropconnectiontofederalproducer")]
        public int? AdoxioSolepropconnectiontofederalproducer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_accountid_value")]
        public string _adoxioAccountidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_federalproducerconnectiontocorp")]
        public int? AdoxioFederalproducerconnectiontocorp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_crsconnectiontomarketer")]
        public int? AdoxioCrsconnectiontomarketer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_tiedhouseconnectionid")]
        public string AdoxioTiedhouseconnectionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_connectiontype")]
        public int? AdoxioConnectiontype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_societyconnectionfederalproducerdetails")]
        public string AdoxioSocietyconnectionfederalproducerdetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_share20plusconnectionproducer")]
        public int? AdoxioShare20plusconnectionproducer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_familymemberfederalproducerdetails")]
        public string AdoxioFamilymemberfederalproducerdetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_corpconnectionfederalproducerdetails")]
        public string AdoxioCorpconnectionfederalproducerdetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_societyconnectionfederalproducer")]
        public int? AdoxioSocietyconnectionfederalproducer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_federalproducerconnectiontocorpdetails")]
        public string AdoxioFederalproducerconnectiontocorpdetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_inconnectiontofederalproducerdetails")]
        public string AdoxioInconnectiontofederalproducerdetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_inconnectiontofederalproducer")]
        public int? AdoxioInconnectiontofederalproducer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_partnersconnectionfederalproducerdetails")]
        public string AdoxioPartnersconnectionfederalproducerdetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isconnection")]
        public int? AdoxioIsconnection { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_partnersconnectionfederalproducer")]
        public int? AdoxioPartnersconnectionfederalproducer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_crsconnectiontomarketerdetails")]
        public string AdoxioCrsconnectiontomarketerdetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_solepropconnectiontofederalproducerdetail")]
        public string AdoxioSolepropconnectiontofederalproducerdetail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_liquorfinancialinterestdetails")]
        public string AdoxioLiquorfinancialinterestdetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_contactid_value")]
        public string _adoxioContactidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_share20plusfamilyconnectionproducer")]
        public int? AdoxioShare20plusfamilyconnectionproducer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_tiedhouse_value")]
        public string _adoxioTiedhouseValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ownershiptype")]
        public int? AdoxioOwnershiptype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_liquorfinancialinterest")]
        public int? AdoxioLiquorfinancialinterest { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_tiedhouseconnection_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioTiedhouseconnectionSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_tiedhouseconnection_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioTiedhouseconnectionDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_tiedhouseconnection_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioTiedhouseconnectionDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_tiedhouseconnection_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioTiedhouseconnectionAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_tiedhouseconnection_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> AdoxioTiedhouseconnectionMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_tiedhouseconnection_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> AdoxioTiedhouseconnectionProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_tiedhouseconnection_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioTiedhouseconnectionBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_tiedhouseconnection_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> AdoxioTiedhouseconnectionPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_AccountId")]
        public MicrosoftDynamicsCRMaccount AdoxioAccountId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Application")]
        public MicrosoftDynamicsCRMadoxioApplication AdoxioApplication { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ContactId")]
        public MicrosoftDynamicsCRMcontact AdoxioContactId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_TiedHouse")]
        public MicrosoftDynamicsCRMadoxioTiedhouseassociation AdoxioTiedHouse { get; set; }

    }
}
