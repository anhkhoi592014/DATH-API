//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnTongHop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HocPhan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HocPhan()
        {
            this.LopMonHocs = new HashSet<LopMonHoc>();
        }
    
        public int id { get; set; }
        public string mahocphan { get; set; }
        public string tenhocphan { get; set; }
        public Nullable<int> sotinchi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LopMonHoc> LopMonHocs { get; set; }
    }
}
