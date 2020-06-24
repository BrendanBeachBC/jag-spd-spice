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
    /// Microsoft.Dynamics.CRM.knowledgearticle
    /// </summary>
    public partial class MicrosoftDynamicsCRMknowledgearticle
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMknowledgearticle class.
        /// </summary>
        public MicrosoftDynamicsCRMknowledgearticle()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMknowledgearticle class.
        /// </summary>
        public MicrosoftDynamicsCRMknowledgearticle(int? review = default(int?), string knowledgearticleid = default(string), int? publishstatusid = default(int?), int? expiredreviewoptions = default(int?), string _modifiedbyValue = default(string), System.DateTimeOffset? knowledgearticleviewsDate = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), string description = default(string), string versionnumber = default(string), string content = default(string), string _modifiedonbehalfbyValue = default(string), System.DateTimeOffset? ratingDate = default(System.DateTimeOffset?), int? ratingState = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _parentarticlecontentidValue = default(string), int? knowledgearticleviews = default(int?), string _owningbusinessunitValue = default(string), int? timezoneruleversionnumber = default(int?), string keywords = default(string), bool? isprimary = default(bool?), string _primaryauthoridValue = default(string), string _owneridValue = default(string), string _owningteamValue = default(string), decimal? exchangerate = default(decimal?), bool? updatecontent = default(bool?), string _languagelocaleidValue = default(string), int? expirationstateid = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? knowledgearticleviewsState = default(int?), int? minorversionnumber = default(int?), string stageid = default(string), decimal? ratingSum = default(decimal?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? expirationstatusid = default(int?), int? statecode = default(int?), bool? isrootarticle = default(bool?), string _subjectidValue = default(string), int? utcconversiontimezonecode = default(int?), int? ratingCount = default(int?), bool? setproductassociations = default(bool?), bool? islatestversion = default(bool?), System.DateTimeOffset? publishon = default(System.DateTimeOffset?), string processid = default(string), string _createdbyValue = default(string), int? scheduledstatusid = default(int?), string _previousarticlecontentidValue = default(string), string _transactioncurrencyidValue = default(string), string _createdonbehalfbyValue = default(string), int? majorversionnumber = default(int?), string articlepublicnumber = default(string), string traversedpath = default(string), int? statuscode = default(int?), System.DateTimeOffset? expirationdate = default(System.DateTimeOffset?), string _rootarticleidValue = default(string), string _owninguserValue = default(string), decimal? rating = default(decimal?), string title = default(string), bool? readyforreview = default(bool?), bool? isinternal = default(bool?), bool? setcategoryassociations = default(bool?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMconnection> knowledgearticleConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> knowledgearticleConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMduplicaterecord> knowledgearticleDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> knowledgearticleDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMsharepointdocumentlocation> knowledgearticleSharePointDocumentLocations = default(IList<MicrosoftDynamicsCRMsharepointdocumentlocation>), IList<MicrosoftDynamicsCRMqueueitem> knowledgearticleQueueItems = default(IList<MicrosoftDynamicsCRMqueueitem>), IList<MicrosoftDynamicsCRMannotation> knowledgearticleAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMteam> knowledgearticleTeams = default(IList<MicrosoftDynamicsCRMteam>), IList<MicrosoftDynamicsCRMasyncoperation> knowledgearticleAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMprocesssession> knowledgearticleProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> knowledgearticleBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> knowledgearticlePrincipalObjectAttributeAccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMprocessstage stageidProcessstage = default(MicrosoftDynamicsCRMprocessstage), IList<MicrosoftDynamicsCRMbulkoperation> knowledgearticleBulkOperations = default(IList<MicrosoftDynamicsCRMbulkoperation>), IList<MicrosoftDynamicsCRMcampaignresponse> knowledgearticleCampaignResponses = default(IList<MicrosoftDynamicsCRMcampaignresponse>), IList<MicrosoftDynamicsCRMincidentresolution> knowledgearticleIncidentResolutions = default(IList<MicrosoftDynamicsCRMincidentresolution>), IList<MicrosoftDynamicsCRMserviceappointment> knowledgeArticleServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMknowledgearticleincident> incidentKnowledgearticles = default(IList<MicrosoftDynamicsCRMknowledgearticleincident>), IList<MicrosoftDynamicsCRMopportunityclose> knowledgearticleOpportunityCloses = default(IList<MicrosoftDynamicsCRMopportunityclose>), IList<MicrosoftDynamicsCRMorderclose> knowledgearticleOrderCloses = default(IList<MicrosoftDynamicsCRMorderclose>), IList<MicrosoftDynamicsCRMquoteclose> knowledgearticleQuoteCloses = default(IList<MicrosoftDynamicsCRMquoteclose>), IList<MicrosoftDynamicsCRMspiceRequiredchecks> knowledgearticleSpiceRequiredcheckses = default(IList<MicrosoftDynamicsCRMspiceRequiredchecks>), IList<MicrosoftDynamicsCRMexpiredprocess> knowledgearticleExpiredprocess = default(IList<MicrosoftDynamicsCRMexpiredprocess>), IList<MicrosoftDynamicsCRMtranslationprocess> knowledgearticleTranslationprocess = default(IList<MicrosoftDynamicsCRMtranslationprocess>), IList<MicrosoftDynamicsCRMsyncerror> knowledgeArticleSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMlanguagelocale languagelocaleid = default(MicrosoftDynamicsCRMlanguagelocale), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> knowledgeArticleRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMletter> knowledgeArticleLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMsocialactivity> knowledgeArticleSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMactivitypointer> knowledgeArticleActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMnewprocess> knowledgearticleNewprocess = default(IList<MicrosoftDynamicsCRMnewprocess>), IList<MicrosoftDynamicsCRMfax> knowledgeArticleFaxes = default(IList<MicrosoftDynamicsCRMfax>), MicrosoftDynamicsCRMknowledgearticle previousArticleContentId = default(MicrosoftDynamicsCRMknowledgearticle), IList<MicrosoftDynamicsCRMknowledgearticle> knowledgearticlePreviousarticleContentid = default(IList<MicrosoftDynamicsCRMknowledgearticle>), MicrosoftDynamicsCRMknowledgearticle rootArticleId = default(MicrosoftDynamicsCRMknowledgearticle), IList<MicrosoftDynamicsCRMknowledgearticle> knowledgearticleRootarticleId = default(IList<MicrosoftDynamicsCRMknowledgearticle>), IList<MicrosoftDynamicsCRMknowledgearticleviews> knowledgearticleViews = default(IList<MicrosoftDynamicsCRMknowledgearticleviews>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMphonecall> knowledgeArticlePhonecalls = default(IList<MicrosoftDynamicsCRMphonecall>), MicrosoftDynamicsCRMknowledgearticle parentArticleContentId = default(MicrosoftDynamicsCRMknowledgearticle), IList<MicrosoftDynamicsCRMknowledgearticle> knowledgearticleParentarticleContentid = default(IList<MicrosoftDynamicsCRMknowledgearticle>), IList<MicrosoftDynamicsCRMcategory> knowledgearticleCategory = default(IList<MicrosoftDynamicsCRMcategory>), IList<MicrosoftDynamicsCRMactivityparty> knowledgearticleActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMemail> knowledgeArticleEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMtask> knowledgeArticleTasks = default(IList<MicrosoftDynamicsCRMtask>), MicrosoftDynamicsCRMsystemuser primaryauthorid = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMappointment> knowledgeArticleAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMpostregarding> knowledgearticlePostRegardings = default(IList<MicrosoftDynamicsCRMpostregarding>), IList<MicrosoftDynamicsCRMpostfollow> knowledgearticlePostFollows = default(IList<MicrosoftDynamicsCRMpostfollow>), IList<MicrosoftDynamicsCRMfeedback> knowledgeArticleFeedback = default(IList<MicrosoftDynamicsCRMfeedback>), MicrosoftDynamicsCRMsubject subjectid = default(MicrosoftDynamicsCRMsubject))
        {
            Review = review;
            Knowledgearticleid = knowledgearticleid;
            Publishstatusid = publishstatusid;
            Expiredreviewoptions = expiredreviewoptions;
            this._modifiedbyValue = _modifiedbyValue;
            KnowledgearticleviewsDate = knowledgearticleviewsDate;
            Importsequencenumber = importsequencenumber;
            Description = description;
            Versionnumber = versionnumber;
            Content = content;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            RatingDate = ratingDate;
            RatingState = ratingState;
            Overriddencreatedon = overriddencreatedon;
            this._parentarticlecontentidValue = _parentarticlecontentidValue;
            Knowledgearticleviews = knowledgearticleviews;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Keywords = keywords;
            Isprimary = isprimary;
            this._primaryauthoridValue = _primaryauthoridValue;
            this._owneridValue = _owneridValue;
            this._owningteamValue = _owningteamValue;
            Exchangerate = exchangerate;
            Updatecontent = updatecontent;
            this._languagelocaleidValue = _languagelocaleidValue;
            Expirationstateid = expirationstateid;
            Modifiedon = modifiedon;
            KnowledgearticleviewsState = knowledgearticleviewsState;
            Minorversionnumber = minorversionnumber;
            Stageid = stageid;
            RatingSum = ratingSum;
            Createdon = createdon;
            Expirationstatusid = expirationstatusid;
            Statecode = statecode;
            Isrootarticle = isrootarticle;
            this._subjectidValue = _subjectidValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            RatingCount = ratingCount;
            Setproductassociations = setproductassociations;
            Islatestversion = islatestversion;
            Publishon = publishon;
            Processid = processid;
            this._createdbyValue = _createdbyValue;
            Scheduledstatusid = scheduledstatusid;
            this._previousarticlecontentidValue = _previousarticlecontentidValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Majorversionnumber = majorversionnumber;
            Articlepublicnumber = articlepublicnumber;
            Traversedpath = traversedpath;
            Statuscode = statuscode;
            Expirationdate = expirationdate;
            this._rootarticleidValue = _rootarticleidValue;
            this._owninguserValue = _owninguserValue;
            Rating = rating;
            Title = title;
            Readyforreview = readyforreview;
            Isinternal = isinternal;
            Setcategoryassociations = setcategoryassociations;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            KnowledgearticleConnections1 = knowledgearticleConnections1;
            KnowledgearticleConnections2 = knowledgearticleConnections2;
            KnowledgearticleDuplicateMatchingRecord = knowledgearticleDuplicateMatchingRecord;
            KnowledgearticleDuplicateBaseRecord = knowledgearticleDuplicateBaseRecord;
            KnowledgearticleSharePointDocumentLocations = knowledgearticleSharePointDocumentLocations;
            KnowledgearticleQueueItems = knowledgearticleQueueItems;
            KnowledgearticleAnnotations = knowledgearticleAnnotations;
            KnowledgearticleTeams = knowledgearticleTeams;
            KnowledgearticleAsyncOperations = knowledgearticleAsyncOperations;
            KnowledgearticleProcessSession = knowledgearticleProcessSession;
            KnowledgearticleBulkDeleteFailures = knowledgearticleBulkDeleteFailures;
            KnowledgearticlePrincipalObjectAttributeAccess = knowledgearticlePrincipalObjectAttributeAccess;
            StageidProcessstage = stageidProcessstage;
            KnowledgearticleBulkOperations = knowledgearticleBulkOperations;
            KnowledgearticleCampaignResponses = knowledgearticleCampaignResponses;
            KnowledgearticleIncidentResolutions = knowledgearticleIncidentResolutions;
            KnowledgeArticleServiceAppointments = knowledgeArticleServiceAppointments;
            IncidentKnowledgearticles = incidentKnowledgearticles;
            KnowledgearticleOpportunityCloses = knowledgearticleOpportunityCloses;
            KnowledgearticleOrderCloses = knowledgearticleOrderCloses;
            KnowledgearticleQuoteCloses = knowledgearticleQuoteCloses;
            KnowledgearticleSpiceRequiredcheckses = knowledgearticleSpiceRequiredcheckses;
            KnowledgearticleExpiredprocess = knowledgearticleExpiredprocess;
            KnowledgearticleTranslationprocess = knowledgearticleTranslationprocess;
            KnowledgeArticleSyncErrors = knowledgeArticleSyncErrors;
            Languagelocaleid = languagelocaleid;
            KnowledgeArticleRecurringAppointmentMasters = knowledgeArticleRecurringAppointmentMasters;
            KnowledgeArticleLetters = knowledgeArticleLetters;
            KnowledgeArticleSocialActivities = knowledgeArticleSocialActivities;
            KnowledgeArticleActivityPointers = knowledgeArticleActivityPointers;
            KnowledgearticleNewprocess = knowledgearticleNewprocess;
            KnowledgeArticleFaxes = knowledgeArticleFaxes;
            PreviousArticleContentId = previousArticleContentId;
            KnowledgearticlePreviousarticleContentid = knowledgearticlePreviousarticleContentid;
            RootArticleId = rootArticleId;
            KnowledgearticleRootarticleId = knowledgearticleRootarticleId;
            KnowledgearticleViews = knowledgearticleViews;
            Transactioncurrencyid = transactioncurrencyid;
            KnowledgeArticlePhonecalls = knowledgeArticlePhonecalls;
            ParentArticleContentId = parentArticleContentId;
            KnowledgearticleParentarticleContentid = knowledgearticleParentarticleContentid;
            KnowledgearticleCategory = knowledgearticleCategory;
            KnowledgearticleActivityParties = knowledgearticleActivityParties;
            KnowledgeArticleEmails = knowledgeArticleEmails;
            KnowledgeArticleTasks = knowledgeArticleTasks;
            Primaryauthorid = primaryauthorid;
            KnowledgeArticleAppointments = knowledgeArticleAppointments;
            KnowledgearticlePostRegardings = knowledgearticlePostRegardings;
            KnowledgearticlePostFollows = knowledgearticlePostFollows;
            KnowledgeArticleFeedback = knowledgeArticleFeedback;
            Subjectid = subjectid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "review")]
        public int? Review { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticleid")]
        public string Knowledgearticleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "publishstatusid")]
        public int? Publishstatusid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "expiredreviewoptions")]
        public int? Expiredreviewoptions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticleviews_date")]
        public System.DateTimeOffset? KnowledgearticleviewsDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rating_date")]
        public System.DateTimeOffset? RatingDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rating_state")]
        public int? RatingState { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_parentarticlecontentid_value")]
        public string _parentarticlecontentidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticleviews")]
        public int? Knowledgearticleviews { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "keywords")]
        public string Keywords { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isprimary")]
        public bool? Isprimary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_primaryauthorid_value")]
        public string _primaryauthoridValue { get; set; }

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
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "updatecontent")]
        public bool? Updatecontent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_languagelocaleid_value")]
        public string _languagelocaleidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "expirationstateid")]
        public int? Expirationstateid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticleviews_state")]
        public int? KnowledgearticleviewsState { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "minorversionnumber")]
        public int? Minorversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid")]
        public string Stageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rating_sum")]
        public decimal? RatingSum { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "expirationstatusid")]
        public int? Expirationstatusid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isrootarticle")]
        public bool? Isrootarticle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_subjectid_value")]
        public string _subjectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rating_count")]
        public int? RatingCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "setproductassociations")]
        public bool? Setproductassociations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "islatestversion")]
        public bool? Islatestversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "publishon")]
        public System.DateTimeOffset? Publishon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public string Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "scheduledstatusid")]
        public int? Scheduledstatusid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_previousarticlecontentid_value")]
        public string _previousarticlecontentidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "majorversionnumber")]
        public int? Majorversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "articlepublicnumber")]
        public string Articlepublicnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "expirationdate")]
        public System.DateTimeOffset? Expirationdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_rootarticleid_value")]
        public string _rootarticleidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rating")]
        public decimal? Rating { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "readyforreview")]
        public bool? Readyforreview { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isinternal")]
        public bool? Isinternal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "setcategoryassociations")]
        public bool? Setcategoryassociations { get; set; }

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
        [JsonProperty(PropertyName = "knowledgearticle_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> KnowledgearticleConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticle_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> KnowledgearticleConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticle_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> KnowledgearticleDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticle_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> KnowledgearticleDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticle_SharePointDocumentLocations")]
        public IList<MicrosoftDynamicsCRMsharepointdocumentlocation> KnowledgearticleSharePointDocumentLocations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticle_QueueItems")]
        public IList<MicrosoftDynamicsCRMqueueitem> KnowledgearticleQueueItems { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticle_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> KnowledgearticleAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticle_Teams")]
        public IList<MicrosoftDynamicsCRMteam> KnowledgearticleTeams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticle_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> KnowledgearticleAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticle_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> KnowledgearticleProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticle_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> KnowledgearticleBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticle_PrincipalObjectAttributeAccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> KnowledgearticlePrincipalObjectAttributeAccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid_processstage")]
        public MicrosoftDynamicsCRMprocessstage StageidProcessstage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticle_BulkOperations")]
        public IList<MicrosoftDynamicsCRMbulkoperation> KnowledgearticleBulkOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticle_CampaignResponses")]
        public IList<MicrosoftDynamicsCRMcampaignresponse> KnowledgearticleCampaignResponses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticle_IncidentResolutions")]
        public IList<MicrosoftDynamicsCRMincidentresolution> KnowledgearticleIncidentResolutions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeArticle_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> KnowledgeArticleServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incident_knowledgearticles")]
        public IList<MicrosoftDynamicsCRMknowledgearticleincident> IncidentKnowledgearticles { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticle_OpportunityCloses")]
        public IList<MicrosoftDynamicsCRMopportunityclose> KnowledgearticleOpportunityCloses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticle_OrderCloses")]
        public IList<MicrosoftDynamicsCRMorderclose> KnowledgearticleOrderCloses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticle_QuoteCloses")]
        public IList<MicrosoftDynamicsCRMquoteclose> KnowledgearticleQuoteCloses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticle_spice_requiredcheckses")]
        public IList<MicrosoftDynamicsCRMspiceRequiredchecks> KnowledgearticleSpiceRequiredcheckses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticle_expiredprocess")]
        public IList<MicrosoftDynamicsCRMexpiredprocess> KnowledgearticleExpiredprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticle_translationprocess")]
        public IList<MicrosoftDynamicsCRMtranslationprocess> KnowledgearticleTranslationprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeArticle_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> KnowledgeArticleSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "languagelocaleid")]
        public MicrosoftDynamicsCRMlanguagelocale Languagelocaleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeArticle_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> KnowledgeArticleRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeArticle_Letters")]
        public IList<MicrosoftDynamicsCRMletter> KnowledgeArticleLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeArticle_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> KnowledgeArticleSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeArticle_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> KnowledgeArticleActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticle_newprocess")]
        public IList<MicrosoftDynamicsCRMnewprocess> KnowledgearticleNewprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeArticle_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> KnowledgeArticleFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PreviousArticleContentId")]
        public MicrosoftDynamicsCRMknowledgearticle PreviousArticleContentId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticle_previousarticle_contentid")]
        public IList<MicrosoftDynamicsCRMknowledgearticle> KnowledgearticlePreviousarticleContentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RootArticleId")]
        public MicrosoftDynamicsCRMknowledgearticle RootArticleId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticle_rootarticle_id")]
        public IList<MicrosoftDynamicsCRMknowledgearticle> KnowledgearticleRootarticleId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticle_views")]
        public IList<MicrosoftDynamicsCRMknowledgearticleviews> KnowledgearticleViews { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeArticle_Phonecalls")]
        public IList<MicrosoftDynamicsCRMphonecall> KnowledgeArticlePhonecalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ParentArticleContentId")]
        public MicrosoftDynamicsCRMknowledgearticle ParentArticleContentId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticle_parentarticle_contentid")]
        public IList<MicrosoftDynamicsCRMknowledgearticle> KnowledgearticleParentarticleContentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticle_category")]
        public IList<MicrosoftDynamicsCRMcategory> KnowledgearticleCategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticle_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> KnowledgearticleActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeArticle_Emails")]
        public IList<MicrosoftDynamicsCRMemail> KnowledgeArticleEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeArticle_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> KnowledgeArticleTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "primaryauthorid")]
        public MicrosoftDynamicsCRMsystemuser Primaryauthorid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeArticle_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> KnowledgeArticleAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticle_PostRegardings")]
        public IList<MicrosoftDynamicsCRMpostregarding> KnowledgearticlePostRegardings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticle_PostFollows")]
        public IList<MicrosoftDynamicsCRMpostfollow> KnowledgearticlePostFollows { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeArticle_Feedback")]
        public IList<MicrosoftDynamicsCRMfeedback> KnowledgeArticleFeedback { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subjectid")]
        public MicrosoftDynamicsCRMsubject Subjectid { get; set; }

    }
}
