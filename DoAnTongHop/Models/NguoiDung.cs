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
    
    public partial class NguoiDung
    {
    
        public int id { get; set; }
        public string mataikhoan { get; set; }
        public string tennguoidung { get; set; }
        public string matkhau { get; set; }
        public string hovaten { get; set; }
        public string sdt { get; set; }
        public string email { get; set; }
        public string hinhdaidien { get; set; }
        public Nullable<int> id_chucvu { get; set; }
    
        public virtual ChucVu ChucVu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LopMonHoc> LopMonHocs { get; set; }
    }
}
