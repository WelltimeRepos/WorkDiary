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
    
    public partial class Web_ScreenShotsByProviderAndJob_Result
    {
        public Nullable<System.DateTime> SessionStart { get; set; }
        public Nullable<System.DateTime> SessionEnd { get; set; }
        public Nullable<int> Hour { get; set; }
        public Nullable<int> ProviderID { get; set; }
        public Nullable<int> KeyStrokes { get; set; }
        public Nullable<int> MouseClicks { get; set; }
        public Nullable<int> WindowsSwitched { get; set; }
        public string AggregatedImageIds { get; set; }
    }
}