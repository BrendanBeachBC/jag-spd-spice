// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Spice.Interfaces.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.mailbox
    /// </summary>
    public partial class MicrosoftDynamicsCRMmailbox
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMmailbox
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMmailbox()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMmailbox
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMmailbox(int? testemailconfigurationretrycount = default(int?), int? noactcount = default(int?), System.DateTimeOffset? processemailreceivedafter = default(System.DateTimeOffset?), string exchangesyncstatexml = default(string), bool? isforwardmailbox = default(bool?), string _emailserverprofileValue = default(string), bool? isemailaddressapprovedbyo365admin = default(bool?), string credentialinfo = default(string), int? actdeliverymethod = default(int?), int? mailboxprocessingcontext = default(int?), string dataencryptionkey = default(string), string folderhierarchy = default(string), string mailboxid = default(string), int? outgoingemaildeliverymethod = default(int?), int? exchangecontactsimportstatus = default(int?), System.DateTimeOffset? exchangecontactsimportcompletedon = default(System.DateTimeOffset?), bool? officeappsdeploymentscheduled = default(bool?), string entityimageid = default(string), int? timezoneruleversionnumber = default(int?), int? incomingemaildeliverymethod = default(int?), string _owneridValue = default(string), string _modifiedbyValue = default(string), System.DateTimeOffset? lastsuccessfulsynccompletedon = default(System.DateTimeOffset?), int? averagetotalduration = default(int?), string _owninguserValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string lastsyncerror = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), bool? isdataencryptionkeyset = default(bool?), string versionnumber = default(string), bool? isserviceaccount = default(bool?), int? lastduration = default(int?), bool? testemailconfigurationscheduled = default(bool?), bool? processanddeleteemails = default(bool?), System.DateTimeOffset? receivingpostponeduntil = default(System.DateTimeOffset?), int? itemsfailedforlastsync = default(int?), string officeappsdeploymenterror = default(string), bool? enabledforact = default(bool?), int? outgoingemailstatus = default(int?), System.DateTimeOffset? postponemailboxprocessinguntil = default(System.DateTimeOffset?), int? lastsyncerrorcount = default(int?), string emailaddress = default(string), System.DateTimeOffset? lastsyncstartedon = default(System.DateTimeOffset?), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? lastsyncerroroccurredon = default(System.DateTimeOffset?), System.DateTimeOffset? postponeofficeappsdeploymentuntil = default(System.DateTimeOffset?), byte[] entityimage = default(byte[]), bool? allowemailconnectortousecredentials = default(bool?), int? itemsprocessedforlastsync = default(int?), long? entityimageTimestamp = default(long?), System.DateTimeOffset? officeappsdeploymentcompleteon = default(System.DateTimeOffset?), System.DateTimeOffset? processinglastattemptedon = default(System.DateTimeOffset?), string username = default(string), string _modifiedonbehalfbyValue = default(string), int? officeappsdeploymentstatus = default(int?), System.DateTimeOffset? postponesendinguntil = default(System.DateTimeOffset?), System.DateTimeOffset? postponetestemailconfigurationuntil = default(System.DateTimeOffset?), int? actstatus = default(int?), int? statuscode = default(int?), int? forcedunlockcount = default(int?), System.DateTimeOffset? receivingpostponeduntilforact = default(System.DateTimeOffset?), int? processedtimes = default(int?), bool? ispasswordset = default(bool?), string _createdbyValue = default(string), string _owningteamValue = default(string), bool? orgmarkedasprimaryforexchangesync = default(bool?), string lastsyncerrormachinename = default(string), string ewsurl = default(string), int? processingstatecode = default(int?), int? lastsyncerrorcode = default(int?), string _organizationidValue = default(string), string _createdonbehalfbyValue = default(string), int? emailrouteraccessapproval = default(int?), int? mailboxstatus = default(int?), int? noemailcount = default(int?), int? incomingemailstatus = default(int?), bool? enabledforoutgoingemail = default(bool?), string password = default(string), bool? enabledforincomingemail = default(bool?), bool? isexchangecontactsimportscheduled = default(bool?), int? transientfailurecount = default(int?), string _owningbusinessunitValue = default(string), string name = default(string), System.DateTimeOffset? lastautodiscoveredon = default(System.DateTimeOffset?), System.DateTimeOffset? testmailboxaccesscompletedon = default(System.DateTimeOffset?), string entityimageUrl = default(string), string _regardingobjectidValue = default(string), string undeliverablefolder = default(string), System.DateTimeOffset? lastmailboxforcedunlockoccurredon = default(System.DateTimeOffset?), bool? isactsyncorgflagset = default(bool?), int? verboseloggingenabled = default(int?), int? statecode = default(int?), string hostid = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMsystemuser regardingobjectid = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMemailserverprofile emailserverprofile = default(MicrosoftDynamicsCRMemailserverprofile), IList<MicrosoftDynamicsCRMsystemuser> systemuserDefaultmailboxMailbox = default(IList<MicrosoftDynamicsCRMsystemuser>), IList<MicrosoftDynamicsCRMqueue> queueDefaultmailboxMailbox = default(IList<MicrosoftDynamicsCRMqueue>), IList<MicrosoftDynamicsCRMbulkoperation> bulkoperationMailboxSendermailboxid = default(IList<MicrosoftDynamicsCRMbulkoperation>), IList<MicrosoftDynamicsCRMcampaignactivity> campaignactivityMailboxSendermailboxid = default(IList<MicrosoftDynamicsCRMcampaignactivity>), IList<MicrosoftDynamicsCRMcampaignresponse> campaignresponseMailboxSendermailboxid = default(IList<MicrosoftDynamicsCRMcampaignresponse>), IList<MicrosoftDynamicsCRMincidentresolution> incidentresolutionMailboxSendermailboxid = default(IList<MicrosoftDynamicsCRMincidentresolution>), IList<MicrosoftDynamicsCRMserviceappointment> serviceappointmentMailboxSendermailboxid = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMopportunityclose> opportunitycloseMailboxSendermailboxid = default(IList<MicrosoftDynamicsCRMopportunityclose>), IList<MicrosoftDynamicsCRMorderclose> ordercloseMailboxSendermailboxid = default(IList<MicrosoftDynamicsCRMorderclose>), IList<MicrosoftDynamicsCRMquoteclose> quotecloseMailboxSendermailboxid = default(IList<MicrosoftDynamicsCRMquoteclose>), IList<MicrosoftDynamicsCRMspiceRequiredchecks> spiceRequiredchecksMailboxSendermailboxid = default(IList<MicrosoftDynamicsCRMspiceRequiredchecks>), IList<MicrosoftDynamicsCRMtracelog> tracelogMailbox = default(IList<MicrosoftDynamicsCRMtracelog>), IList<MicrosoftDynamicsCRMactivitypointer> activitypointerSendermailboxidMailbox = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMasyncoperation> mailboxAsyncoperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMqueue regardingobjectidQueue = default(MicrosoftDynamicsCRMqueue), IList<MicrosoftDynamicsCRMemail> emailSendermailboxidMailbox = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMsyncerror> mailboxSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMannotation> mailboxAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> mailboxMailboxTrackingFolder = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMprocesssession> mailboxProcesssessions = default(IList<MicrosoftDynamicsCRMprocesssession>))
        {
            Testemailconfigurationretrycount = testemailconfigurationretrycount;
            Noactcount = noactcount;
            Processemailreceivedafter = processemailreceivedafter;
            Exchangesyncstatexml = exchangesyncstatexml;
            Isforwardmailbox = isforwardmailbox;
            this._emailserverprofileValue = _emailserverprofileValue;
            Isemailaddressapprovedbyo365admin = isemailaddressapprovedbyo365admin;
            Credentialinfo = credentialinfo;
            Actdeliverymethod = actdeliverymethod;
            Mailboxprocessingcontext = mailboxprocessingcontext;
            Dataencryptionkey = dataencryptionkey;
            Folderhierarchy = folderhierarchy;
            Mailboxid = mailboxid;
            Outgoingemaildeliverymethod = outgoingemaildeliverymethod;
            Exchangecontactsimportstatus = exchangecontactsimportstatus;
            Exchangecontactsimportcompletedon = exchangecontactsimportcompletedon;
            Officeappsdeploymentscheduled = officeappsdeploymentscheduled;
            Entityimageid = entityimageid;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Incomingemaildeliverymethod = incomingemaildeliverymethod;
            this._owneridValue = _owneridValue;
            this._modifiedbyValue = _modifiedbyValue;
            Lastsuccessfulsynccompletedon = lastsuccessfulsynccompletedon;
            Averagetotalduration = averagetotalduration;
            this._owninguserValue = _owninguserValue;
            Modifiedon = modifiedon;
            Lastsyncerror = lastsyncerror;
            Createdon = createdon;
            Isdataencryptionkeyset = isdataencryptionkeyset;
            Versionnumber = versionnumber;
            Isserviceaccount = isserviceaccount;
            Lastduration = lastduration;
            Testemailconfigurationscheduled = testemailconfigurationscheduled;
            Processanddeleteemails = processanddeleteemails;
            Receivingpostponeduntil = receivingpostponeduntil;
            Itemsfailedforlastsync = itemsfailedforlastsync;
            Officeappsdeploymenterror = officeappsdeploymenterror;
            Enabledforact = enabledforact;
            Outgoingemailstatus = outgoingemailstatus;
            Postponemailboxprocessinguntil = postponemailboxprocessinguntil;
            Lastsyncerrorcount = lastsyncerrorcount;
            Emailaddress = emailaddress;
            Lastsyncstartedon = lastsyncstartedon;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Lastsyncerroroccurredon = lastsyncerroroccurredon;
            Postponeofficeappsdeploymentuntil = postponeofficeappsdeploymentuntil;
            Entityimage = entityimage;
            Allowemailconnectortousecredentials = allowemailconnectortousecredentials;
            Itemsprocessedforlastsync = itemsprocessedforlastsync;
            EntityimageTimestamp = entityimageTimestamp;
            Officeappsdeploymentcompleteon = officeappsdeploymentcompleteon;
            Processinglastattemptedon = processinglastattemptedon;
            Username = username;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Officeappsdeploymentstatus = officeappsdeploymentstatus;
            Postponesendinguntil = postponesendinguntil;
            Postponetestemailconfigurationuntil = postponetestemailconfigurationuntil;
            Actstatus = actstatus;
            Statuscode = statuscode;
            Forcedunlockcount = forcedunlockcount;
            Receivingpostponeduntilforact = receivingpostponeduntilforact;
            Processedtimes = processedtimes;
            Ispasswordset = ispasswordset;
            this._createdbyValue = _createdbyValue;
            this._owningteamValue = _owningteamValue;
            Orgmarkedasprimaryforexchangesync = orgmarkedasprimaryforexchangesync;
            Lastsyncerrormachinename = lastsyncerrormachinename;
            Ewsurl = ewsurl;
            Processingstatecode = processingstatecode;
            Lastsyncerrorcode = lastsyncerrorcode;
            this._organizationidValue = _organizationidValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Emailrouteraccessapproval = emailrouteraccessapproval;
            Mailboxstatus = mailboxstatus;
            Noemailcount = noemailcount;
            Incomingemailstatus = incomingemailstatus;
            Enabledforoutgoingemail = enabledforoutgoingemail;
            Password = password;
            Enabledforincomingemail = enabledforincomingemail;
            Isexchangecontactsimportscheduled = isexchangecontactsimportscheduled;
            Transientfailurecount = transientfailurecount;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Name = name;
            Lastautodiscoveredon = lastautodiscoveredon;
            Testmailboxaccesscompletedon = testmailboxaccesscompletedon;
            EntityimageUrl = entityimageUrl;
            this._regardingobjectidValue = _regardingobjectidValue;
            Undeliverablefolder = undeliverablefolder;
            Lastmailboxforcedunlockoccurredon = lastmailboxforcedunlockoccurredon;
            Isactsyncorgflagset = isactsyncorgflagset;
            Verboseloggingenabled = verboseloggingenabled;
            Statecode = statecode;
            Hostid = hostid;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            Regardingobjectid = regardingobjectid;
            Emailserverprofile = emailserverprofile;
            SystemuserDefaultmailboxMailbox = systemuserDefaultmailboxMailbox;
            QueueDefaultmailboxMailbox = queueDefaultmailboxMailbox;
            BulkoperationMailboxSendermailboxid = bulkoperationMailboxSendermailboxid;
            CampaignactivityMailboxSendermailboxid = campaignactivityMailboxSendermailboxid;
            CampaignresponseMailboxSendermailboxid = campaignresponseMailboxSendermailboxid;
            IncidentresolutionMailboxSendermailboxid = incidentresolutionMailboxSendermailboxid;
            ServiceappointmentMailboxSendermailboxid = serviceappointmentMailboxSendermailboxid;
            OpportunitycloseMailboxSendermailboxid = opportunitycloseMailboxSendermailboxid;
            OrdercloseMailboxSendermailboxid = ordercloseMailboxSendermailboxid;
            QuotecloseMailboxSendermailboxid = quotecloseMailboxSendermailboxid;
            SpiceRequiredchecksMailboxSendermailboxid = spiceRequiredchecksMailboxSendermailboxid;
            TracelogMailbox = tracelogMailbox;
            ActivitypointerSendermailboxidMailbox = activitypointerSendermailboxidMailbox;
            MailboxAsyncoperations = mailboxAsyncoperations;
            RegardingobjectidQueue = regardingobjectidQueue;
            EmailSendermailboxidMailbox = emailSendermailboxidMailbox;
            MailboxSyncErrors = mailboxSyncErrors;
            MailboxAnnotation = mailboxAnnotation;
            MailboxMailboxTrackingFolder = mailboxMailboxTrackingFolder;
            Organizationid = organizationid;
            MailboxProcesssessions = mailboxProcesssessions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "testemailconfigurationretrycount")]
        public int? Testemailconfigurationretrycount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "noactcount")]
        public int? Noactcount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processemailreceivedafter")]
        public System.DateTimeOffset? Processemailreceivedafter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangesyncstatexml")]
        public string Exchangesyncstatexml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isforwardmailbox")]
        public bool? Isforwardmailbox { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_emailserverprofile_value")]
        public string _emailserverprofileValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isemailaddressapprovedbyo365admin")]
        public bool? Isemailaddressapprovedbyo365admin { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "credentialinfo")]
        public string Credentialinfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "actdeliverymethod")]
        public int? Actdeliverymethod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mailboxprocessingcontext")]
        public int? Mailboxprocessingcontext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dataencryptionkey")]
        public string Dataencryptionkey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "folderhierarchy")]
        public string Folderhierarchy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mailboxid")]
        public string Mailboxid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "outgoingemaildeliverymethod")]
        public int? Outgoingemaildeliverymethod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangecontactsimportstatus")]
        public int? Exchangecontactsimportstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangecontactsimportcompletedon")]
        public System.DateTimeOffset? Exchangecontactsimportcompletedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "officeappsdeploymentscheduled")]
        public bool? Officeappsdeploymentscheduled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimageid")]
        public string Entityimageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incomingemaildeliverymethod")]
        public int? Incomingemaildeliverymethod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastsuccessfulsynccompletedon")]
        public System.DateTimeOffset? Lastsuccessfulsynccompletedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "averagetotalduration")]
        public int? Averagetotalduration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastsyncerror")]
        public string Lastsyncerror { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isdataencryptionkeyset")]
        public bool? Isdataencryptionkeyset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isserviceaccount")]
        public bool? Isserviceaccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastduration")]
        public int? Lastduration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "testemailconfigurationscheduled")]
        public bool? Testemailconfigurationscheduled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processanddeleteemails")]
        public bool? Processanddeleteemails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "receivingpostponeduntil")]
        public System.DateTimeOffset? Receivingpostponeduntil { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "itemsfailedforlastsync")]
        public int? Itemsfailedforlastsync { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "officeappsdeploymenterror")]
        public string Officeappsdeploymenterror { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "enabledforact")]
        public bool? Enabledforact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "outgoingemailstatus")]
        public int? Outgoingemailstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postponemailboxprocessinguntil")]
        public System.DateTimeOffset? Postponemailboxprocessinguntil { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastsyncerrorcount")]
        public int? Lastsyncerrorcount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailaddress")]
        public string Emailaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastsyncstartedon")]
        public System.DateTimeOffset? Lastsyncstartedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastsyncerroroccurredon")]
        public System.DateTimeOffset? Lastsyncerroroccurredon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postponeofficeappsdeploymentuntil")]
        public System.DateTimeOffset? Postponeofficeappsdeploymentuntil { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(Base64UrlJsonConverter))]
        [JsonProperty(PropertyName = "entityimage")]
        public byte[] Entityimage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "allowemailconnectortousecredentials")]
        public bool? Allowemailconnectortousecredentials { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "itemsprocessedforlastsync")]
        public int? Itemsprocessedforlastsync { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_timestamp")]
        public long? EntityimageTimestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "officeappsdeploymentcompleteon")]
        public System.DateTimeOffset? Officeappsdeploymentcompleteon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processinglastattemptedon")]
        public System.DateTimeOffset? Processinglastattemptedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "officeappsdeploymentstatus")]
        public int? Officeappsdeploymentstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postponesendinguntil")]
        public System.DateTimeOffset? Postponesendinguntil { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postponetestemailconfigurationuntil")]
        public System.DateTimeOffset? Postponetestemailconfigurationuntil { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "actstatus")]
        public int? Actstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "forcedunlockcount")]
        public int? Forcedunlockcount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "receivingpostponeduntilforact")]
        public System.DateTimeOffset? Receivingpostponeduntilforact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processedtimes")]
        public int? Processedtimes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ispasswordset")]
        public bool? Ispasswordset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "orgmarkedasprimaryforexchangesync")]
        public bool? Orgmarkedasprimaryforexchangesync { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastsyncerrormachinename")]
        public string Lastsyncerrormachinename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ewsurl")]
        public string Ewsurl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processingstatecode")]
        public int? Processingstatecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastsyncerrorcode")]
        public int? Lastsyncerrorcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailrouteraccessapproval")]
        public int? Emailrouteraccessapproval { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mailboxstatus")]
        public int? Mailboxstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "noemailcount")]
        public int? Noemailcount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incomingemailstatus")]
        public int? Incomingemailstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "enabledforoutgoingemail")]
        public bool? Enabledforoutgoingemail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "enabledforincomingemail")]
        public bool? Enabledforincomingemail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isexchangecontactsimportscheduled")]
        public bool? Isexchangecontactsimportscheduled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transientfailurecount")]
        public int? Transientfailurecount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastautodiscoveredon")]
        public System.DateTimeOffset? Lastautodiscoveredon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "testmailboxaccesscompletedon")]
        public System.DateTimeOffset? Testmailboxaccesscompletedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_url")]
        public string EntityimageUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectid_value")]
        public string _regardingobjectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "undeliverablefolder")]
        public string Undeliverablefolder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastmailboxforcedunlockoccurredon")]
        public System.DateTimeOffset? Lastmailboxforcedunlockoccurredon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isactsyncorgflagset")]
        public bool? Isactsyncorgflagset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "verboseloggingenabled")]
        public int? Verboseloggingenabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hostid")]
        public string Hostid { get; set; }

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
        [JsonProperty(PropertyName = "regardingobjectid")]
        public MicrosoftDynamicsCRMsystemuser Regardingobjectid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailserverprofile")]
        public MicrosoftDynamicsCRMemailserverprofile Emailserverprofile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "systemuser_defaultmailbox_mailbox")]
        public IList<MicrosoftDynamicsCRMsystemuser> SystemuserDefaultmailboxMailbox { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "queue_defaultmailbox_mailbox")]
        public IList<MicrosoftDynamicsCRMqueue> QueueDefaultmailboxMailbox { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bulkoperation_mailbox_sendermailboxid")]
        public IList<MicrosoftDynamicsCRMbulkoperation> BulkoperationMailboxSendermailboxid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignactivity_mailbox_sendermailboxid")]
        public IList<MicrosoftDynamicsCRMcampaignactivity> CampaignactivityMailboxSendermailboxid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignresponse_mailbox_sendermailboxid")]
        public IList<MicrosoftDynamicsCRMcampaignresponse> CampaignresponseMailboxSendermailboxid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incidentresolution_mailbox_sendermailboxid")]
        public IList<MicrosoftDynamicsCRMincidentresolution> IncidentresolutionMailboxSendermailboxid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceappointment_mailbox_sendermailboxid")]
        public IList<MicrosoftDynamicsCRMserviceappointment> ServiceappointmentMailboxSendermailboxid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityclose_mailbox_sendermailboxid")]
        public IList<MicrosoftDynamicsCRMopportunityclose> OpportunitycloseMailboxSendermailboxid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "orderclose_mailbox_sendermailboxid")]
        public IList<MicrosoftDynamicsCRMorderclose> OrdercloseMailboxSendermailboxid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quoteclose_mailbox_sendermailboxid")]
        public IList<MicrosoftDynamicsCRMquoteclose> QuotecloseMailboxSendermailboxid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_requiredchecks_mailbox_sendermailboxid")]
        public IList<MicrosoftDynamicsCRMspiceRequiredchecks> SpiceRequiredchecksMailboxSendermailboxid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tracelog_Mailbox")]
        public IList<MicrosoftDynamicsCRMtracelog> TracelogMailbox { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activitypointer_sendermailboxid_mailbox")]
        public IList<MicrosoftDynamicsCRMactivitypointer> ActivitypointerSendermailboxidMailbox { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mailbox_asyncoperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> MailboxAsyncoperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_queue")]
        public MicrosoftDynamicsCRMqueue RegardingobjectidQueue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "email_sendermailboxid_mailbox")]
        public IList<MicrosoftDynamicsCRMemail> EmailSendermailboxidMailbox { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Mailbox_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> MailboxSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Mailbox_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> MailboxAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Mailbox_MailboxTrackingFolder")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> MailboxMailboxTrackingFolder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mailbox_processsessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> MailboxProcesssessions { get; set; }

    }
}
