//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorkDiaryRepository.Dbo
{
    using System;
    using System.Collections.Generic;
    
    public partial class JOB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JOB()
        {
            this.JOB_AWARDED = new HashSet<JOB_AWARDED>();
            this.JOB_FOLDER = new HashSet<JOB_FOLDER>();
            this.JOB_OFFER = new HashSet<JOB_OFFER>();
            this.JOB_SKILL = new HashSet<JOB_SKILL>();
            this.PROJECT_TEAM = new HashSet<PROJECT_TEAM>();
        }
    
        public int JOB_ID { get; set; }
        public Nullable<int> USER_ID { get; set; }
        public Nullable<int> JOB_TYPE_ID { get; set; }
        public Nullable<int> JOB_STATUS_ID { get; set; }
        public Nullable<int> CLASS_ID { get; set; }
        public string JOB_TITLE { get; set; }
        public string DESCRIPTION { get; set; }
        public string APPROXIMATE_DURATION { get; set; }
        public Nullable<decimal> APPROXIMATE_BUDGET { get; set; }
        public string DURATION { get; set; }
        public Nullable<decimal> HOURLY_RATE { get; set; }
        public Nullable<double> HOURS_PER_WEEK { get; set; }
        public Nullable<int> CURRENCY_ID { get; set; }
        public Nullable<int> RATE_TYPE_ID { get; set; }
        public Nullable<decimal> RATE { get; set; }
        public Nullable<bool> ON_SITE_WORK { get; set; }
        public Nullable<int> SITE_LOCATION_COUNTRY_ID { get; set; }
        public Nullable<int> SITE_LOCATION_REGION_ID { get; set; }
        public Nullable<int> SITE_LOCATION_CITY_ID { get; set; }
        public string SITE_LOCATION_POSTCODE { get; set; }
        public Nullable<int> OFFER_SUBMIT_DAYS { get; set; }
        public string WORK_START { get; set; }
        public Nullable<bool> WORK_START_IMMIDIATELY { get; set; }
        public Nullable<System.DateTime> WORK_START_ON_DATE { get; set; }
        public Nullable<bool> JOB_VIEW_IS_PUBLIC { get; set; }
        public Nullable<bool> OFFER_AMOUNT_IS_PUBLIC { get; set; }
        public Nullable<System.DateTime> CREATED_ON { get; set; }
        public Nullable<int> CREATED_BY { get; set; }
        public Nullable<System.DateTime> MODIFIED_ON { get; set; }
        public Nullable<int> MODIFIED_BY { get; set; }
        public Nullable<bool> IS_ARCHIVED { get; set; }
        public Nullable<System.DateTime> ARCHIVED_ON { get; set; }
        public Nullable<int> ARCHIVED_BY { get; set; }
        public string MATTERMOST_TEAM_ID { get; set; }
        public string MATTERMOST_TEAM_NAME { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JOB_AWARDED> JOB_AWARDED { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JOB_FOLDER> JOB_FOLDER { get; set; }
        public virtual JOB_STATUS JOB_STATUS { get; set; }
        public virtual JOB_TYPE JOB_TYPE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JOB_OFFER> JOB_OFFER { get; set; }
        public virtual RATE_TYPE RATE_TYPE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JOB_SKILL> JOB_SKILL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROJECT_TEAM> PROJECT_TEAM { get; set; }
    }
}
