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
    
    public partial class PROJECT_TEAM
    {
        public int PROJECT_TEAM_ID { get; set; }
        public int JOB_ID { get; set; }
        public int DESIGNATION_ID { get; set; }
        public string NAME { get; set; }
        public string EMAIL { get; set; }
        public Nullable<bool> IS_DAILY_REPORT_ENABLED { get; set; }
        public Nullable<bool> IS_WEEKLY_REPORT_ENABLED { get; set; }
        public Nullable<bool> IS_MONTHLY_REPORT_ENABLED { get; set; }
    
        public virtual DESIGNATION DESIGNATION { get; set; }
        public virtual JOB JOB { get; set; }
    }
}
