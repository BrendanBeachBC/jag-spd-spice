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
    /// Microsoft.Dynamics.CRM.list
    /// </summary>
    public partial class MicrosoftDynamicsCRMlist
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMlist class.
        /// </summary>
        public MicrosoftDynamicsCRMlist()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMlist class.
        /// </summary>
        public MicrosoftDynamicsCRMlist(System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.DateTimeOffset? lastusedon = default(System.DateTimeOffset?), int? timezoneruleversionnumber = default(int?), int? membertype = default(int?), string listname = default(string), string _modifiedonbehalfbyValue = default(string), string _owninguserValue = default(string), int? createdfromcode = default(int?), string _createdbyValue = default(string), decimal? exchangerate = default(decimal?), string _owneridValue = default(string), string _owningteamValue = default(string), string processid = default(string), string _owningbusinessunitValue = default(string), bool? lockstatus = default(bool?), int? statuscode = default(int?), int? importsequencenumber = default(int?), int? statecode = default(int?), string traversedpath = default(string), decimal? costBase = default(decimal?), string _modifiedbyValue = default(string), bool? donotsendonoptout = default(bool?), string versionnumber = default(string), string query = default(string), string listid = default(string), decimal? cost = default(decimal?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string stageid = default(string), string _createdonbehalfbyValue = default(string), int? membercount = default(int?), string description = default(string), string purpose = default(string), int? utcconversiontimezonecode = default(int?), string source = default(string), bool? ignoreinactivelistmembers = default(bool?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _transactioncurrencyidValue = default(string), bool? type = default(bool?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> listSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> listDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> listDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> listAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> listMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> listProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> listBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> listPrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMprocessstage stageidProcessstage = default(MicrosoftDynamicsCRMprocessstage), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMconnection> listConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> listConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMannotation> listAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMcampaignactivity> campaignactivitylistAssociation = default(IList<MicrosoftDynamicsCRMcampaignactivity>), IList<MicrosoftDynamicsCRMaccount> listaccountAssociation = default(IList<MicrosoftDynamicsCRMaccount>), IList<MicrosoftDynamicsCRMbulkoperation> listBulkOperations = default(IList<MicrosoftDynamicsCRMbulkoperation>), IList<MicrosoftDynamicsCRMcampaign> campaignlistAssociation = default(IList<MicrosoftDynamicsCRMcampaign>), IList<MicrosoftDynamicsCRMlead> listleadAssociation = default(IList<MicrosoftDynamicsCRMlead>), IList<MicrosoftDynamicsCRMcontact> listcontactAssociation = default(IList<MicrosoftDynamicsCRMcontact>))
        {
            Overriddencreatedon = overriddencreatedon;
            Lastusedon = lastusedon;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Membertype = membertype;
            Listname = listname;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owninguserValue = _owninguserValue;
            Createdfromcode = createdfromcode;
            this._createdbyValue = _createdbyValue;
            Exchangerate = exchangerate;
            this._owneridValue = _owneridValue;
            this._owningteamValue = _owningteamValue;
            Processid = processid;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Lockstatus = lockstatus;
            Statuscode = statuscode;
            Importsequencenumber = importsequencenumber;
            Statecode = statecode;
            Traversedpath = traversedpath;
            CostBase = costBase;
            this._modifiedbyValue = _modifiedbyValue;
            Donotsendonoptout = donotsendonoptout;
            Versionnumber = versionnumber;
            Query = query;
            Listid = listid;
            Cost = cost;
            Createdon = createdon;
            Stageid = stageid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Membercount = membercount;
            Description = description;
            Purpose = purpose;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Source = source;
            Ignoreinactivelistmembers = ignoreinactivelistmembers;
            Modifiedon = modifiedon;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Type = type;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            ListSyncErrors = listSyncErrors;
            ListDuplicateMatchingRecord = listDuplicateMatchingRecord;
            ListDuplicateBaseRecord = listDuplicateBaseRecord;
            ListAsyncOperations = listAsyncOperations;
            ListMailboxTrackingFolders = listMailboxTrackingFolders;
            ListProcessSessions = listProcessSessions;
            ListBulkDeleteFailures = listBulkDeleteFailures;
            ListPrincipalobjectattributeaccess = listPrincipalobjectattributeaccess;
            StageidProcessstage = stageidProcessstage;
            Transactioncurrencyid = transactioncurrencyid;
            ListConnections1 = listConnections1;
            ListConnections2 = listConnections2;
            ListAnnotation = listAnnotation;
            CampaignactivitylistAssociation = campaignactivitylistAssociation;
            ListaccountAssociation = listaccountAssociation;
            ListBulkOperations = listBulkOperations;
            CampaignlistAssociation = campaignlistAssociation;
            ListleadAssociation = listleadAssociation;
            ListcontactAssociation = listcontactAssociation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastusedon")]
        public System.DateTimeOffset? Lastusedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "membertype")]
        public int? Membertype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "listname")]
        public string Listname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdfromcode")]
        public int? Createdfromcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public string Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lockstatus")]
        public bool? Lockstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cost_base")]
        public decimal? CostBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "donotsendonoptout")]
        public bool? Donotsendonoptout { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "listid")]
        public string Listid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cost")]
        public decimal? Cost { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid")]
        public string Stageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "membercount")]
        public int? Membercount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "purpose")]
        public string Purpose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ignoreinactivelistmembers")]
        public bool? Ignoreinactivelistmembers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public bool? Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

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
        [JsonProperty(PropertyName = "List_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> ListSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "List_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> ListDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "List_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> ListDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "List_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ListAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "list_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ListMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "List_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> ListProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "List_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ListBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "list_principalobjectattributeaccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ListPrincipalobjectattributeaccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid_processstage")]
        public MicrosoftDynamicsCRMprocessstage StageidProcessstage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "list_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> ListConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "list_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> ListConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "List_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> ListAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignactivitylist_association")]
        public IList<MicrosoftDynamicsCRMcampaignactivity> CampaignactivitylistAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "listaccount_association")]
        public IList<MicrosoftDynamicsCRMaccount> ListaccountAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "List_BulkOperations")]
        public IList<MicrosoftDynamicsCRMbulkoperation> ListBulkOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignlist_association")]
        public IList<MicrosoftDynamicsCRMcampaign> CampaignlistAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "listlead_association")]
        public IList<MicrosoftDynamicsCRMlead> ListleadAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "listcontact_association")]
        public IList<MicrosoftDynamicsCRMcontact> ListcontactAssociation { get; set; }

    }
}
