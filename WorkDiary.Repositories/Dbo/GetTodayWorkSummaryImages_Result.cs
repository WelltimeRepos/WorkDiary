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
    
    public partial class GetTodayWorkSummaryImages_Result
    {
        public int IMAGE_ID { get; set; }
        public string WORKING_ON { get; set; }
        public string ACTIVE_WINDOW_TITLE { get; set; }
        public int KEY_STROKE_LEVEL { get; set; }
        public int MOUSE_CLICK { get; set; }
        public int WINDOWS_SWITCHED { get; set; }
        public Nullable<int> ACTIVITY_LEVEL { get; set; }
        public Nullable<int> IMAGE_BINARY { get; set; }
        public string START_TIME { get; set; }
        public string END_TIME { get; set; }
        public Nullable<int> TOTAL_MINUTES { get; set; }
        public Nullable<System.DateTime> CREATED_ON { get; set; }
        public string DISPLAY_TIME { get; set; }
    }
}
