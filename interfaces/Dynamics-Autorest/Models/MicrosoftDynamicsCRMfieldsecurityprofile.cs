// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Spice.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.fieldsecurityprofile
    /// </summary>
    public partial class MicrosoftDynamicsCRMfieldsecurityprofile
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMfieldsecurityprofile class.
        /// </summary>
        public MicrosoftDynamicsCRMfieldsecurityprofile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMfieldsecurityprofile class.
        /// </summary>
        public MicrosoftDynamicsCRMfieldsecurityprofile(string _modifiedbyValue = default(string), string versionnumber = default(string), string name = default(string), string _modifiedonbehalfbyValue = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? componentstate = default(int?), string description = default(string), string _organizationidValue = default(string), bool? ismanaged = default(bool?), string solutionid = default(string), string fieldsecurityprofileidunique = default(string), string fieldsecurityprofileid = default(string), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsyncerror> fieldSecurityProfileSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsystemuser> systemuserprofilesAssociation = default(IList<MicrosoftDynamicsCRMsystemuser>), IList<MicrosoftDynamicsCRMfieldpermission> lkFieldpermissionFieldsecurityprofileid = default(IList<MicrosoftDynamicsCRMfieldpermission>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMteam> teamprofilesAssociation = default(IList<MicrosoftDynamicsCRMteam>), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser))
        {
            this._modifiedbyValue = _modifiedbyValue;
            Versionnumber = versionnumber;
            Name = name;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Overwritetime = overwritetime;
            Createdon = createdon;
            Modifiedon = modifiedon;
            Componentstate = componentstate;
            Description = description;
            this._organizationidValue = _organizationidValue;
            Ismanaged = ismanaged;
            Solutionid = solutionid;
            Fieldsecurityprofileidunique = fieldsecurityprofileidunique;
            Fieldsecurityprofileid = fieldsecurityprofileid;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Createdonbehalfby = createdonbehalfby;
            FieldSecurityProfileSyncErrors = fieldSecurityProfileSyncErrors;
            Organizationid = organizationid;
            SystemuserprofilesAssociation = systemuserprofilesAssociation;
            LkFieldpermissionFieldsecurityprofileid = lkFieldpermissionFieldsecurityprofileid;
            Modifiedonbehalfby = modifiedonbehalfby;
            TeamprofilesAssociation = teamprofilesAssociation;
            Modifiedby = modifiedby;
            Createdby = createdby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fieldsecurityprofileidunique")]
        public string Fieldsecurityprofileidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fieldsecurityprofileid")]
        public string Fieldsecurityprofileid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FieldSecurityProfile_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> FieldSecurityProfileSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "systemuserprofiles_association")]
        public IList<MicrosoftDynamicsCRMsystemuser> SystemuserprofilesAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lk_fieldpermission_fieldsecurityprofileid")]
        public IList<MicrosoftDynamicsCRMfieldpermission> LkFieldpermissionFieldsecurityprofileid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "teamprofiles_association")]
        public IList<MicrosoftDynamicsCRMteam> TeamprofilesAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

    }
}
