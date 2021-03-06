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
    
    public partial class LopMonHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LopMonHoc()
        {
            this.LichDays = new HashSet<LichDay>();
            this.SinhViens = new HashSet<SinhVien>();
        }
    
        public int id { get; set; }
        public string manhom { get; set; }
        public string mato { get; set; }
        public string thoigian { get; set; }
        public Nullable<int> id_hocphan { get; set; }
        public Nullable<int> id_hocky { get; set; }
        public Nullable<int> id_nguoidung { get; set; }
    
        public virtual HocKy HocKy { get; set; }
        public virtual HocPhan HocPhan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichDay> LichDays { get; set; }
        public virtual NguoiDung NguoiDung { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SinhVien> SinhViens { get; set; }
    }
}
