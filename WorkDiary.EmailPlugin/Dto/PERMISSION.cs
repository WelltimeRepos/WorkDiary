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
    using System.Collections.Generic;
    
    public partial class PERMISSION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PERMISSION()
        {
            this.MENUs = new HashSet<MENU>();
            this.ROLE_PERMISSION = new HashSet<ROLE_PERMISSION>();
        }
    
        public int PERMISSION_ID { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MENU> MENUs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROLE_PERMISSION> ROLE_PERMISSION { get; set; }
    }
}