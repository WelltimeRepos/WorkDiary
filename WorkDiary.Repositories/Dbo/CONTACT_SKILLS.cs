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
    
    public partial class CONTACT_SKILLS
    {
        public int CONTACT_SKILL_ID { get; set; }
        public int CONTACT_ID { get; set; }
        public Nullable<int> CONTACT_CAT_ID { get; set; }
        public int SKILL_ID { get; set; }
        public Nullable<bool> IS_ARCHIVED { get; set; }
    
        public virtual CONTACT CONTACT { get; set; }
        public virtual CONTACT_CATEGORY CONTACT_CATEGORY { get; set; }
        public virtual SKILL SKILL { get; set; }
    }
}
