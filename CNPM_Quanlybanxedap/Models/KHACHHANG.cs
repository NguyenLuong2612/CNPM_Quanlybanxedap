//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CNPM_Quanlybanxedap.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            this.BAOHANHs = new HashSet<BAOHANH>();
            this.HOADONs = new HashSet<HOADON>();
        }
    
        public int MaKH { get; set; }
        public string TenKH { get; set; }
        public string DiaChi { get; set; }
        public string TenDN { get; set; }
        public string Matkhau { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BAOHANH> BAOHANHs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }
    }
}
