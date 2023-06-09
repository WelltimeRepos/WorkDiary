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
    
    public partial class JOB_OFFER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JOB_OFFER()
        {
            this.JOB_OFFER_FOLDER = new HashSet<JOB_OFFER_FOLDER>();
        }
    
        public int JOB_OFFER_ID { get; set; }
        public Nullable<int> JOB_ID { get; set; }
        public Nullable<int> PROVIDER_ID { get; set; }
        public Nullable<int> BUYER_ID { get; set; }
        public Nullable<int> CURRENCY_ID { get; set; }
        public Nullable<decimal> OFFER_AMOUNT { get; set; }
        public Nullable<decimal> SERVICE_FEE { get; set; }
        public Nullable<decimal> CLIENT_CHARGED { get; set; }
        public Nullable<decimal> UPFRONT_PAYMENT { get; set; }
        public string TIME_REQUIRED { get; set; }
        public Nullable<bool> IS_FIRST_OFFER { get; set; }
        public Nullable<bool> IS_OFFER_BY_BUYER { get; set; }
        public Nullable<bool> IS_AWARDED { get; set; }
        public string DESCRIPTION { get; set; }
        public string TERMS { get; set; }
        public Nullable<System.DateTime> CREATED_ON { get; set; }
        public Nullable<int> CREATED_BY { get; set; }
        public Nullable<System.DateTime> MODIFIED_ON { get; set; }
        public Nullable<int> MODIFIED_BY { get; set; }
        public Nullable<bool> IS_VIEWED { get; set; }
        public Nullable<bool> IS_ARCHIVED { get; set; }
        public string TERMS_AND_CONDITIONS { get; set; }
        public Nullable<bool> IS_REJECTED { get; set; }
        public Nullable<bool> OFFER_WITH_DRAWN { get; set; }
        public Nullable<bool> OFFER_WITH_DRAWN_BY_PROVIDER { get; set; }
        public Nullable<int> OFFER_WITH_DRAWN_USER_ID { get; set; }
        public Nullable<System.DateTime> OFFER_WITH_DRAWN_DATE { get; set; }
    
        public virtual JOB JOB { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JOB_OFFER_FOLDER> JOB_OFFER_FOLDER { get; set; }
    }
}
