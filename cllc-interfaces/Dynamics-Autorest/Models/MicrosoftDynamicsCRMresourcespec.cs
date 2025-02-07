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
    /// Microsoft.Dynamics.CRM.resourcespec
    /// </summary>
    public partial class MicrosoftDynamicsCRMresourcespec
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMresourcespec
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMresourcespec()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMresourcespec
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMresourcespec(System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string description = default(string), string groupobjectid = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string resourcespecid = default(string), string name = default(string), bool? samesite = default(bool?), string _createdonbehalfbyValue = default(string), int? timezoneruleversionnumber = default(int?), int? importsequencenumber = default(int?), string _modifiedbyValue = default(string), decimal? effortrequired = default(decimal?), string objectiveexpression = default(string), int? requiredcount = default(int?), int? utcconversiontimezonecode = default(int?), string _modifiedonbehalfbyValue = default(string), string constraints = default(string), string _organizationidValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _businessunitidValue = default(string), string _createdbyValue = default(string), string objecttypecode = default(string), string versionnumber = default(string), IList<MicrosoftDynamicsCRMsyncerror> resourcespecSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMteam> resourcespecTeams = default(IList<MicrosoftDynamicsCRMteam>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> resourcespecMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> resourcespecPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMconstraintbasedgroup groupobjectidConstraintbasedgroup = default(MicrosoftDynamicsCRMconstraintbasedgroup), MicrosoftDynamicsCRMbusinessunit businessunitid = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMactivityparty> activityPartyResourceSpec = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMbulkdeletefailure> resourceSpecBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMteam groupobjectidTeam = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMresource> resourcespecResources = default(IList<MicrosoftDynamicsCRMresource>), IList<MicrosoftDynamicsCRMannotation> resourceSpecAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMservice> resourceSpecServices = default(IList<MicrosoftDynamicsCRMservice>), IList<MicrosoftDynamicsCRMasyncoperation> resourceSpecAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>))
        {
            Modifiedon = modifiedon;
            Description = description;
            Groupobjectid = groupobjectid;
            Overriddencreatedon = overriddencreatedon;
            Resourcespecid = resourcespecid;
            Name = name;
            Samesite = samesite;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Importsequencenumber = importsequencenumber;
            this._modifiedbyValue = _modifiedbyValue;
            Effortrequired = effortrequired;
            Objectiveexpression = objectiveexpression;
            Requiredcount = requiredcount;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Constraints = constraints;
            this._organizationidValue = _organizationidValue;
            Createdon = createdon;
            this._businessunitidValue = _businessunitidValue;
            this._createdbyValue = _createdbyValue;
            Objecttypecode = objecttypecode;
            Versionnumber = versionnumber;
            ResourcespecSyncErrors = resourcespecSyncErrors;
            ResourcespecTeams = resourcespecTeams;
            ResourcespecMailboxTrackingFolders = resourcespecMailboxTrackingFolders;
            ResourcespecPrincipalObjectAttributeAccesses = resourcespecPrincipalObjectAttributeAccesses;
            Organizationid = organizationid;
            Modifiedonbehalfby = modifiedonbehalfby;
            Createdonbehalfby = createdonbehalfby;
            GroupobjectidConstraintbasedgroup = groupobjectidConstraintbasedgroup;
            Businessunitid = businessunitid;
            Createdby = createdby;
            Modifiedby = modifiedby;
            ActivityPartyResourceSpec = activityPartyResourceSpec;
            ResourceSpecBulkDeleteFailures = resourceSpecBulkDeleteFailures;
            GroupobjectidTeam = groupobjectidTeam;
            ResourcespecResources = resourcespecResources;
            ResourceSpecAnnotation = resourceSpecAnnotation;
            ResourceSpecServices = resourceSpecServices;
            ResourceSpecAsyncOperations = resourceSpecAsyncOperations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "groupobjectid")]
        public string Groupobjectid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourcespecid")]
        public string Resourcespecid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "samesite")]
        public bool? Samesite { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "effortrequired")]
        public decimal? Effortrequired { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectiveexpression")]
        public string Objectiveexpression { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requiredcount")]
        public int? Requiredcount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "constraints")]
        public string Constraints { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_businessunitid_value")]
        public string _businessunitidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objecttypecode")]
        public string Objecttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourcespec_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> ResourcespecSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourcespec_Teams")]
        public IList<MicrosoftDynamicsCRMteam> ResourcespecTeams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourcespec_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ResourcespecMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourcespec_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ResourcespecPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "groupobjectid_constraintbasedgroup")]
        public MicrosoftDynamicsCRMconstraintbasedgroup GroupobjectidConstraintbasedgroup { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businessunitid")]
        public MicrosoftDynamicsCRMbusinessunit Businessunitid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ActivityPartyResourceSpec")]
        public IList<MicrosoftDynamicsCRMactivityparty> ActivityPartyResourceSpec { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResourceSpec_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ResourceSpecBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "groupobjectid_team")]
        public MicrosoftDynamicsCRMteam GroupobjectidTeam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourcespec_resources")]
        public IList<MicrosoftDynamicsCRMresource> ResourcespecResources { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResourceSpec_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> ResourceSpecAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resource_spec_services")]
        public IList<MicrosoftDynamicsCRMservice> ResourceSpecServices { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResourceSpec_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ResourceSpecAsyncOperations { get; set; }

    }
}
