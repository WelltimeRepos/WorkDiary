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
    
    public partial class ScreenLogsInsert_sp_Result
    {
        public int ID { get; set; }
        public Nullable<int> SCREEN_CAT_ID { get; set; }
        public string SCREEN_TITLE { get; set; }
        public string SCREEN_CODE { get; set; }
        public Nullable<int> PROVIDER_ID { get; set; }
        public Nullable<int> JOB_ID { get; set; }
        public Nullable<int> TIME_SHEET_ID { get; set; }
        public Nullable<double> TIME_SPENT { get; set; }
        public Nullable<System.DateTime> CREATED_ON { get; set; }
        public Nullable<System.DateTime> START_ON { get; set; }
        public Nullable<System.DateTime> END_ON { get; set; }
        public Nullable<int> IMAGE_ID { get; set; }
    }
}
