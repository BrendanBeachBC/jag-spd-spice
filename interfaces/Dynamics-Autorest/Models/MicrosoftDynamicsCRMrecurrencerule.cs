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
    /// Microsoft.Dynamics.CRM.recurrencerule
    /// </summary>
    public partial class MicrosoftDynamicsCRMrecurrencerule
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMrecurrencerule class.
        /// </summary>
        public MicrosoftDynamicsCRMrecurrencerule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMrecurrencerule class.
        /// </summary>
        public MicrosoftDynamicsCRMrecurrencerule(System.DateTimeOffset? patternenddate = default(System.DateTimeOffset?), string _objectidValue = default(string), int? dayofmonth = default(int?), string _createdbyValue = default(string), int? monthofyear = default(int?), int? instance = default(int?), string _owninguserValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.DateTimeOffset? starttime = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), bool? isnthmonthly = default(bool?), bool? isnthyearly = default(bool?), int? occurrences = default(int?), int? duration = default(int?), int? patternendtype = default(int?), string _owningteamValue = default(string), bool? isregenerate = default(bool?), bool? isweekdaypattern = default(bool?), string _createdonbehalfbyValue = default(string), int? daysofweekmask = default(int?), int? interval = default(int?), System.DateTimeOffset? effectivestartdate = default(System.DateTimeOffset?), System.DateTimeOffset? endtime = default(System.DateTimeOffset?), string versionnumber = default(string), string _owningbusinessunitValue = default(string), System.DateTimeOffset? patternstartdate = default(System.DateTimeOffset?), int? firstdayofweek = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? recurrencepatterntype = default(int?), string _modifiedonbehalfbyValue = default(string), string _owneridValue = default(string), string ruleid = default(string), System.DateTimeOffset? effectiveenddate = default(System.DateTimeOffset?), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> recurrenceruleRecurringappointmentmaster = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), MicrosoftDynamicsCRMactivitypointer objectid = default(MicrosoftDynamicsCRMactivitypointer))
        {
            Patternenddate = patternenddate;
            this._objectidValue = _objectidValue;
            Dayofmonth = dayofmonth;
            this._createdbyValue = _createdbyValue;
            Monthofyear = monthofyear;
            Instance = instance;
            this._owninguserValue = _owninguserValue;
            Createdon = createdon;
            Starttime = starttime;
            this._modifiedbyValue = _modifiedbyValue;
            Isnthmonthly = isnthmonthly;
            Isnthyearly = isnthyearly;
            Occurrences = occurrences;
            Duration = duration;
            Patternendtype = patternendtype;
            this._owningteamValue = _owningteamValue;
            Isregenerate = isregenerate;
            Isweekdaypattern = isweekdaypattern;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Daysofweekmask = daysofweekmask;
            Interval = interval;
            Effectivestartdate = effectivestartdate;
            Endtime = endtime;
            Versionnumber = versionnumber;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Patternstartdate = patternstartdate;
            Firstdayofweek = firstdayofweek;
            Modifiedon = modifiedon;
            Recurrencepatterntype = recurrencepatterntype;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owneridValue = _owneridValue;
            Ruleid = ruleid;
            Effectiveenddate = effectiveenddate;
            Owningbusinessunit = owningbusinessunit;
            Createdonbehalfby = createdonbehalfby;
            Ownerid = ownerid;
            Modifiedonbehalfby = modifiedonbehalfby;
            Modifiedby = modifiedby;
            Createdby = createdby;
            RecurrenceruleRecurringappointmentmaster = recurrenceruleRecurringappointmentmaster;
            Objectid = objectid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "patternenddate")]
        public System.DateTimeOffset? Patternenddate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_objectid_value")]
        public string _objectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dayofmonth")]
        public int? Dayofmonth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "monthofyear")]
        public int? Monthofyear { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "instance")]
        public int? Instance { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "starttime")]
        public System.DateTimeOffset? Starttime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isnthmonthly")]
        public bool? Isnthmonthly { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isnthyearly")]
        public bool? Isnthyearly { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "occurrences")]
        public int? Occurrences { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "patternendtype")]
        public int? Patternendtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isregenerate")]
        public bool? Isregenerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isweekdaypattern")]
        public bool? Isweekdaypattern { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "daysofweekmask")]
        public int? Daysofweekmask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "interval")]
        public int? Interval { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "effectivestartdate")]
        public System.DateTimeOffset? Effectivestartdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "endtime")]
        public System.DateTimeOffset? Endtime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "patternstartdate")]
        public System.DateTimeOffset? Patternstartdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "firstdayofweek")]
        public int? Firstdayofweek { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recurrencepatterntype")]
        public int? Recurrencepatterntype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ruleid")]
        public string Ruleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "effectiveenddate")]
        public System.DateTimeOffset? Effectiveenddate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recurrencerule_recurringappointmentmaster")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> RecurrenceruleRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid")]
        public MicrosoftDynamicsCRMactivitypointer Objectid { get; set; }

    }
}
