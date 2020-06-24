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
    /// Microsoft.Dynamics.CRM.sla
    /// </summary>
    public partial class MicrosoftDynamicsCRMsla
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMsla class.
        /// </summary>
        public MicrosoftDynamicsCRMsla()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMsla class.
        /// </summary>
        public MicrosoftDynamicsCRMsla(string solutionid = default(string), string _modifiedbyValue = default(string), string changedattributelist = default(string), string _businesshoursidValue = default(string), string _owningbusinessunitValue = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), bool? isdefault = default(bool?), string slaid = default(string), string _transactioncurrencyidValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? objecttypecode = default(int?), int? slatype = default(int?), string versionnumber = default(string), decimal? exchangerate = default(decimal?), bool? ismanaged = default(bool?), int? statecode = default(int?), int? applicablefrompicklist = default(int?), string _owninguserValue = default(string), string applicablefrom = default(string), string name = default(string), string description = default(string), string _workflowidValue = default(string), int? primaryentityotc = default(int?), string _owningteamValue = default(string), string _owneridValue = default(string), int? statuscode = default(int?), string _modifiedonbehalfbyValue = default(string), bool? allowpauseresume = default(bool?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string slaidunique = default(string), string _createdbyValue = default(string), int? componentstate = default(int?), IList<MicrosoftDynamicsCRMlead> manualslaLead = default(IList<MicrosoftDynamicsCRMlead>), IList<MicrosoftDynamicsCRMlead> slaLead = default(IList<MicrosoftDynamicsCRMlead>), IList<MicrosoftDynamicsCRMbulkoperation> bulkoperationSlaSlaid = default(IList<MicrosoftDynamicsCRMbulkoperation>), IList<MicrosoftDynamicsCRMbulkoperation> bulkoperationSlaSlainvokedid = default(IList<MicrosoftDynamicsCRMbulkoperation>), IList<MicrosoftDynamicsCRMcampaignactivity> campaignactivitySlaSlaid = default(IList<MicrosoftDynamicsCRMcampaignactivity>), IList<MicrosoftDynamicsCRMcampaignactivity> campaignactivitySlaSlainvokedid = default(IList<MicrosoftDynamicsCRMcampaignactivity>), IList<MicrosoftDynamicsCRMcampaignresponse> campaignresponseSlaSlaid = default(IList<MicrosoftDynamicsCRMcampaignresponse>), IList<MicrosoftDynamicsCRMcampaignresponse> campaignresponseSlaSlainvokedid = default(IList<MicrosoftDynamicsCRMcampaignresponse>), IList<MicrosoftDynamicsCRMincident> manualslaCases = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMincident> slaCases = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMincidentresolution> incidentresolutionSlaSlaid = default(IList<MicrosoftDynamicsCRMincidentresolution>), IList<MicrosoftDynamicsCRMincidentresolution> incidentresolutionSlaSlainvokedid = default(IList<MicrosoftDynamicsCRMincidentresolution>), IList<MicrosoftDynamicsCRMserviceappointment> manualslaServiceappointment = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMserviceappointment> slaServiceappointment = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMentitlement> slaEntitlement = default(IList<MicrosoftDynamicsCRMentitlement>), IList<MicrosoftDynamicsCRMentitlementtemplate> slaEntitlementtemplate = default(IList<MicrosoftDynamicsCRMentitlementtemplate>), IList<MicrosoftDynamicsCRMopportunityclose> opportunitycloseSlaSlaid = default(IList<MicrosoftDynamicsCRMopportunityclose>), IList<MicrosoftDynamicsCRMopportunityclose> opportunitycloseSlaSlainvokedid = default(IList<MicrosoftDynamicsCRMopportunityclose>), IList<MicrosoftDynamicsCRMorderclose> ordercloseSlaSlaid = default(IList<MicrosoftDynamicsCRMorderclose>), IList<MicrosoftDynamicsCRMorderclose> ordercloseSlaSlainvokedid = default(IList<MicrosoftDynamicsCRMorderclose>), IList<MicrosoftDynamicsCRMquoteclose> quotecloseSlaSlaid = default(IList<MicrosoftDynamicsCRMquoteclose>), IList<MicrosoftDynamicsCRMquoteclose> quotecloseSlaSlainvokedid = default(IList<MicrosoftDynamicsCRMquoteclose>), IList<MicrosoftDynamicsCRMinvoice> slaInvoice = default(IList<MicrosoftDynamicsCRMinvoice>), IList<MicrosoftDynamicsCRMsalesorder> manualslaSalesorder = default(IList<MicrosoftDynamicsCRMsalesorder>), IList<MicrosoftDynamicsCRMsalesorder> slaSalesorder = default(IList<MicrosoftDynamicsCRMsalesorder>), IList<MicrosoftDynamicsCRMquote> manualslaQuote = default(IList<MicrosoftDynamicsCRMquote>), IList<MicrosoftDynamicsCRMquote> slaQuote = default(IList<MicrosoftDynamicsCRMquote>), IList<MicrosoftDynamicsCRMopportunity> manualslaOpportunity = default(IList<MicrosoftDynamicsCRMopportunity>), IList<MicrosoftDynamicsCRMopportunity> slaOpportunity = default(IList<MicrosoftDynamicsCRMopportunity>), IList<MicrosoftDynamicsCRMinvoice> manualslaInvoice = default(IList<MicrosoftDynamicsCRMinvoice>), IList<MicrosoftDynamicsCRMspiceRequiredchecks> spiceRequiredchecksSlaSlaid = default(IList<MicrosoftDynamicsCRMspiceRequiredchecks>), IList<MicrosoftDynamicsCRMspiceRequiredchecks> spiceRequiredchecksSlaSlainvokedid = default(IList<MicrosoftDynamicsCRMspiceRequiredchecks>), MicrosoftDynamicsCRMworkflow workflowid = default(MicrosoftDynamicsCRMworkflow), IList<MicrosoftDynamicsCRMaccount> manualslaAccount = default(IList<MicrosoftDynamicsCRMaccount>), IList<MicrosoftDynamicsCRMtask> manualslaTask = default(IList<MicrosoftDynamicsCRMtask>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMcalendar businesshoursid = default(MicrosoftDynamicsCRMcalendar), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMemail> manualslaEmail = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMannotation> slaAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMsyncerror> sLASyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMphonecall> manualslaPhonecall = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMcontact> slaContact = default(IList<MicrosoftDynamicsCRMcontact>), IList<MicrosoftDynamicsCRMcontact> manualslaContact = default(IList<MicrosoftDynamicsCRMcontact>), IList<MicrosoftDynamicsCRMactivitypointer> manualslaActivitypointer = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMtask> slaTask = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMprocesssession> slabaseProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMfax> manualslaFax = default(IList<MicrosoftDynamicsCRMfax>), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMletter> slaLetter = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMemail> slaEmail = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMsocialactivity> manualslaSocialactivity = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMfax> slaFax = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMaccount> slaAccount = default(IList<MicrosoftDynamicsCRMaccount>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMasyncoperation> slabaseAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), IList<MicrosoftDynamicsCRMappointment> manualslaAppointment = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMphonecall> slaPhonecall = default(IList<MicrosoftDynamicsCRMphonecall>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsocialactivity> slaSocialactivity = default(IList<MicrosoftDynamicsCRMsocialactivity>), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMbulkdeletefailure> slabaseBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMappointment> slaAppointment = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMslaitem> slaSlaitemSlaId = default(IList<MicrosoftDynamicsCRMslaitem>), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMactivitypointer> slaActivitypointer = default(IList<MicrosoftDynamicsCRMactivitypointer>), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMletter> manualslaLetter = default(IList<MicrosoftDynamicsCRMletter>))
        {
            Solutionid = solutionid;
            this._modifiedbyValue = _modifiedbyValue;
            Changedattributelist = changedattributelist;
            this._businesshoursidValue = _businesshoursidValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Overwritetime = overwritetime;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Isdefault = isdefault;
            Slaid = slaid;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Modifiedon = modifiedon;
            Objecttypecode = objecttypecode;
            Slatype = slatype;
            Versionnumber = versionnumber;
            Exchangerate = exchangerate;
            Ismanaged = ismanaged;
            Statecode = statecode;
            Applicablefrompicklist = applicablefrompicklist;
            this._owninguserValue = _owninguserValue;
            Applicablefrom = applicablefrom;
            Name = name;
            Description = description;
            this._workflowidValue = _workflowidValue;
            Primaryentityotc = primaryentityotc;
            this._owningteamValue = _owningteamValue;
            this._owneridValue = _owneridValue;
            Statuscode = statuscode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Allowpauseresume = allowpauseresume;
            Createdon = createdon;
            Slaidunique = slaidunique;
            this._createdbyValue = _createdbyValue;
            Componentstate = componentstate;
            ManualslaLead = manualslaLead;
            SlaLead = slaLead;
            BulkoperationSlaSlaid = bulkoperationSlaSlaid;
            BulkoperationSlaSlainvokedid = bulkoperationSlaSlainvokedid;
            CampaignactivitySlaSlaid = campaignactivitySlaSlaid;
            CampaignactivitySlaSlainvokedid = campaignactivitySlaSlainvokedid;
            CampaignresponseSlaSlaid = campaignresponseSlaSlaid;
            CampaignresponseSlaSlainvokedid = campaignresponseSlaSlainvokedid;
            ManualslaCases = manualslaCases;
            SlaCases = slaCases;
            IncidentresolutionSlaSlaid = incidentresolutionSlaSlaid;
            IncidentresolutionSlaSlainvokedid = incidentresolutionSlaSlainvokedid;
            ManualslaServiceappointment = manualslaServiceappointment;
            SlaServiceappointment = slaServiceappointment;
            SlaEntitlement = slaEntitlement;
            SlaEntitlementtemplate = slaEntitlementtemplate;
            OpportunitycloseSlaSlaid = opportunitycloseSlaSlaid;
            OpportunitycloseSlaSlainvokedid = opportunitycloseSlaSlainvokedid;
            OrdercloseSlaSlaid = ordercloseSlaSlaid;
            OrdercloseSlaSlainvokedid = ordercloseSlaSlainvokedid;
            QuotecloseSlaSlaid = quotecloseSlaSlaid;
            QuotecloseSlaSlainvokedid = quotecloseSlaSlainvokedid;
            SlaInvoice = slaInvoice;
            ManualslaSalesorder = manualslaSalesorder;
            SlaSalesorder = slaSalesorder;
            ManualslaQuote = manualslaQuote;
            SlaQuote = slaQuote;
            ManualslaOpportunity = manualslaOpportunity;
            SlaOpportunity = slaOpportunity;
            ManualslaInvoice = manualslaInvoice;
            SpiceRequiredchecksSlaSlaid = spiceRequiredchecksSlaSlaid;
            SpiceRequiredchecksSlaSlainvokedid = spiceRequiredchecksSlaSlainvokedid;
            Workflowid = workflowid;
            ManualslaAccount = manualslaAccount;
            ManualslaTask = manualslaTask;
            Createdby = createdby;
            Businesshoursid = businesshoursid;
            Createdonbehalfby = createdonbehalfby;
            ManualslaEmail = manualslaEmail;
            SlaAnnotation = slaAnnotation;
            SLASyncErrors = sLASyncErrors;
            ManualslaPhonecall = manualslaPhonecall;
            SlaContact = slaContact;
            ManualslaContact = manualslaContact;
            ManualslaActivitypointer = manualslaActivitypointer;
            SlaTask = slaTask;
            SlabaseProcessSessions = slabaseProcessSessions;
            ManualslaFax = manualslaFax;
            Modifiedby = modifiedby;
            SlaLetter = slaLetter;
            SlaEmail = slaEmail;
            ManualslaSocialactivity = manualslaSocialactivity;
            SlaFax = slaFax;
            SlaAccount = slaAccount;
            Transactioncurrencyid = transactioncurrencyid;
            SlabaseAsyncOperations = slabaseAsyncOperations;
            Ownerid = ownerid;
            ManualslaAppointment = manualslaAppointment;
            SlaPhonecall = slaPhonecall;
            Modifiedonbehalfby = modifiedonbehalfby;
            SlaSocialactivity = slaSocialactivity;
            Owningteam = owningteam;
            SlabaseBulkDeleteFailures = slabaseBulkDeleteFailures;
            SlaAppointment = slaAppointment;
            SlaSlaitemSlaId = slaSlaitemSlaId;
            Owninguser = owninguser;
            SlaActivitypointer = slaActivitypointer;
            Owningbusinessunit = owningbusinessunit;
            ManualslaLetter = manualslaLetter;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "changedattributelist")]
        public string Changedattributelist { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_businesshoursid_value")]
        public string _businesshoursidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isdefault")]
        public bool? Isdefault { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slaid")]
        public string Slaid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objecttypecode")]
        public int? Objecttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slatype")]
        public int? Slatype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "applicablefrompicklist")]
        public int? Applicablefrompicklist { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "applicablefrom")]
        public string Applicablefrom { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_workflowid_value")]
        public string _workflowidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "primaryentityotc")]
        public int? Primaryentityotc { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "allowpauseresume")]
        public bool? Allowpauseresume { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slaidunique")]
        public string Slaidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_lead")]
        public IList<MicrosoftDynamicsCRMlead> ManualslaLead { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_lead")]
        public IList<MicrosoftDynamicsCRMlead> SlaLead { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bulkoperation_sla_slaid")]
        public IList<MicrosoftDynamicsCRMbulkoperation> BulkoperationSlaSlaid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bulkoperation_sla_slainvokedid")]
        public IList<MicrosoftDynamicsCRMbulkoperation> BulkoperationSlaSlainvokedid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignactivity_sla_slaid")]
        public IList<MicrosoftDynamicsCRMcampaignactivity> CampaignactivitySlaSlaid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignactivity_sla_slainvokedid")]
        public IList<MicrosoftDynamicsCRMcampaignactivity> CampaignactivitySlaSlainvokedid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignresponse_sla_slaid")]
        public IList<MicrosoftDynamicsCRMcampaignresponse> CampaignresponseSlaSlaid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignresponse_sla_slainvokedid")]
        public IList<MicrosoftDynamicsCRMcampaignresponse> CampaignresponseSlaSlainvokedid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_cases")]
        public IList<MicrosoftDynamicsCRMincident> ManualslaCases { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_cases")]
        public IList<MicrosoftDynamicsCRMincident> SlaCases { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incidentresolution_sla_slaid")]
        public IList<MicrosoftDynamicsCRMincidentresolution> IncidentresolutionSlaSlaid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incidentresolution_sla_slainvokedid")]
        public IList<MicrosoftDynamicsCRMincidentresolution> IncidentresolutionSlaSlainvokedid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_serviceappointment")]
        public IList<MicrosoftDynamicsCRMserviceappointment> ManualslaServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_serviceappointment")]
        public IList<MicrosoftDynamicsCRMserviceappointment> SlaServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_entitlement")]
        public IList<MicrosoftDynamicsCRMentitlement> SlaEntitlement { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_entitlementtemplate")]
        public IList<MicrosoftDynamicsCRMentitlementtemplate> SlaEntitlementtemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityclose_sla_slaid")]
        public IList<MicrosoftDynamicsCRMopportunityclose> OpportunitycloseSlaSlaid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityclose_sla_slainvokedid")]
        public IList<MicrosoftDynamicsCRMopportunityclose> OpportunitycloseSlaSlainvokedid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "orderclose_sla_slaid")]
        public IList<MicrosoftDynamicsCRMorderclose> OrdercloseSlaSlaid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "orderclose_sla_slainvokedid")]
        public IList<MicrosoftDynamicsCRMorderclose> OrdercloseSlaSlainvokedid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quoteclose_sla_slaid")]
        public IList<MicrosoftDynamicsCRMquoteclose> QuotecloseSlaSlaid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quoteclose_sla_slainvokedid")]
        public IList<MicrosoftDynamicsCRMquoteclose> QuotecloseSlaSlainvokedid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_invoice")]
        public IList<MicrosoftDynamicsCRMinvoice> SlaInvoice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_salesorder")]
        public IList<MicrosoftDynamicsCRMsalesorder> ManualslaSalesorder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_salesorder")]
        public IList<MicrosoftDynamicsCRMsalesorder> SlaSalesorder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_quote")]
        public IList<MicrosoftDynamicsCRMquote> ManualslaQuote { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_quote")]
        public IList<MicrosoftDynamicsCRMquote> SlaQuote { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_opportunity")]
        public IList<MicrosoftDynamicsCRMopportunity> ManualslaOpportunity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_opportunity")]
        public IList<MicrosoftDynamicsCRMopportunity> SlaOpportunity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_invoice")]
        public IList<MicrosoftDynamicsCRMinvoice> ManualslaInvoice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_requiredchecks_sla_slaid")]
        public IList<MicrosoftDynamicsCRMspiceRequiredchecks> SpiceRequiredchecksSlaSlaid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_requiredchecks_sla_slainvokedid")]
        public IList<MicrosoftDynamicsCRMspiceRequiredchecks> SpiceRequiredchecksSlaSlainvokedid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflowid")]
        public MicrosoftDynamicsCRMworkflow Workflowid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_account")]
        public IList<MicrosoftDynamicsCRMaccount> ManualslaAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_task")]
        public IList<MicrosoftDynamicsCRMtask> ManualslaTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businesshoursid")]
        public MicrosoftDynamicsCRMcalendar Businesshoursid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_email")]
        public IList<MicrosoftDynamicsCRMemail> ManualslaEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> SlaAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SLA_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SLASyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_phonecall")]
        public IList<MicrosoftDynamicsCRMphonecall> ManualslaPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_contact")]
        public IList<MicrosoftDynamicsCRMcontact> SlaContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_contact")]
        public IList<MicrosoftDynamicsCRMcontact> ManualslaContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_activitypointer")]
        public IList<MicrosoftDynamicsCRMactivitypointer> ManualslaActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_task")]
        public IList<MicrosoftDynamicsCRMtask> SlaTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slabase_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> SlabaseProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_fax")]
        public IList<MicrosoftDynamicsCRMfax> ManualslaFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_letter")]
        public IList<MicrosoftDynamicsCRMletter> SlaLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_email")]
        public IList<MicrosoftDynamicsCRMemail> SlaEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_socialactivity")]
        public IList<MicrosoftDynamicsCRMsocialactivity> ManualslaSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_fax")]
        public IList<MicrosoftDynamicsCRMfax> SlaFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_account")]
        public IList<MicrosoftDynamicsCRMaccount> SlaAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slabase_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SlabaseAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_appointment")]
        public IList<MicrosoftDynamicsCRMappointment> ManualslaAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_phonecall")]
        public IList<MicrosoftDynamicsCRMphonecall> SlaPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_socialactivity")]
        public IList<MicrosoftDynamicsCRMsocialactivity> SlaSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slabase_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SlabaseBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_appointment")]
        public IList<MicrosoftDynamicsCRMappointment> SlaAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_slaitem_slaId")]
        public IList<MicrosoftDynamicsCRMslaitem> SlaSlaitemSlaId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_activitypointer")]
        public IList<MicrosoftDynamicsCRMactivitypointer> SlaActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manualsla_letter")]
        public IList<MicrosoftDynamicsCRMletter> ManualslaLetter { get; set; }

    }
}
