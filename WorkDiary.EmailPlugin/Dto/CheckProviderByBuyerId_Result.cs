//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace exampleOfHangfire.Dto
{
    using System;
    
    public partial class CheckProviderByBuyerId_Result
    {
        public int JOB_AWARDED_ID { get; set; }
        public Nullable<int> JOB_OFFER_ID { get; set; }
        public Nullable<int> JOB_ID { get; set; }
        public Nullable<int> BUYER_ID { get; set; }
        public Nullable<int> PROVIDER_ID { get; set; }
        public Nullable<int> CURRENCY_ID { get; set; }
        public Nullable<decimal> AMOUNT { get; set; }
        public Nullable<System.DateTime> DATE_AWARDED { get; set; }
        public Nullable<System.DateTime> DATE_COMPLETED { get; set; }
        public string BUYER_REVIEW { get; set; }
        public string PROVIDER_REVIEW { get; set; }
    }
}