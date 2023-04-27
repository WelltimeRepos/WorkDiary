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
    
    public partial class UserGetAll_sp_Result
    {
        public Nullable<long> Row { get; set; }
        public int USER_ID { get; set; }
        public int ROLE_ID { get; set; }
        public string ROLE_NAME { get; set; }
        public string USER_NAME { get; set; }
        public string PASSWORD { get; set; }
        public Nullable<bool> IS_LOGGED_IN { get; set; }
        public System.DateTime CREATED_ON { get; set; }
        public string CREATED_ON_DISPLAY { get; set; }
        public Nullable<System.DateTime> LAST_LOGIN_DATE { get; set; }
        public string LAST_LOGIN_DATE_DISPLAY { get; set; }
        public int CONTACT_ID { get; set; }
        public int CONTACT_TYPE_ID { get; set; }
        public string BUSINESS_NAME { get; set; }
        public string BUSINESS_LOGO { get; set; }
        public string USER_FULL_NAME { get; set; }
        public string FULL_NAME { get; set; }
        public string FNAME { get; set; }
        public string LNAME { get; set; }
        public string MNAME { get; set; }
        public string DISPLAY_NAME { get; set; }
        public string BUSINESS_CONTACT_NAME { get; set; }
        public string PAYPAL_ACCOUNT_ID { get; set; }
        public string EMAIL { get; set; }
        public string ADDRESS1 { get; set; }
        public string ADDRESS2 { get; set; }
        public int CITY_ID { get; set; }
        public int STATE_ID { get; set; }
        public int COUNTRY_ID { get; set; }
        public string COUNTRY_NAME { get; set; }
        public string STATE_NAME { get; set; }
        public string CITY_NAME { get; set; }
        public string COMPLETE_ADDRESS { get; set; }
        public string ZIP_POSTAL { get; set; }
        public string PRIMARY_PHONE { get; set; }
        public string SECONDARY_PHONE { get; set; }
        public string OTHER_PHONE { get; set; }
        public string WEBSITE_URL { get; set; }
        public string FACEBOOK_ID { get; set; }
        public string TWITTER_ID { get; set; }
        public string GOOGLE_ID { get; set; }
        public string NOTES { get; set; }
        public string ABOUT_ME { get; set; }
        public bool IS_BUSINESS_NAME_PUBLIC { get; set; }
        public bool IS_PERSONAL_INFO_PUBLIC { get; set; }
        public bool IS_ADDRESS_PUBLIC { get; set; }
        public string CONTACT_TYPE_NAME { get; set; }
        public string CONTACT_TYPE_ICON_CLASS { get; set; }
        public string MESSENGER_LIST { get; set; }
        public string CONTACT_CLASS_IDS { get; set; }
        public string CONTACT_SKILLS { get; set; }
        public string CONTACT_CATEGORIES { get; set; }
        public Nullable<int> CONTACT_RATE_ID { get; set; }
        public Nullable<decimal> RATE { get; set; }
        public Nullable<decimal> CURRENT_SERVICE_FEE { get; set; }
        public string CURRENCY_NAME { get; set; }
        public string RATE_TYPE_NAME { get; set; }
        public string DISPLAY_RATE { get; set; }
        public string FEEDBACK_SCORE { get; set; }
        public string FEEDBACK_PERCENTAGE { get; set; }
        public Nullable<int> CONTRACT_COMPLETED_COUNT { get; set; }
        public Nullable<int> CONTRACT_AWARDED_COUNT { get; set; }
        public Nullable<int> OFFERS_SUBMITTED_COUNT { get; set; }
        public Nullable<int> RESPONSE_RATING { get; set; }
    }
}
