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
    
    public partial class USER_PERMISSION
    {
        public int Id { get; set; }
        public int USER_ID { get; set; }
        public int PERMISSION_ID { get; set; }
        public bool CAN_ADD { get; set; }
        public bool CAN_EDIT { get; set; }
        public bool CAN_VIEW { get; set; }
    }
}
