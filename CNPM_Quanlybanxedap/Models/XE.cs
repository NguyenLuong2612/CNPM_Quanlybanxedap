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
    
    public partial class XE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public XE()
        {
            this.BAOHANHs = new HashSet<BAOHANH>();
            this.BAOTRIs = new HashSet<BAOTRI>();
            this.CHITIETHOADONs = new HashSet<CHITIETHOADON>();
            this.CHITIETPHIEUNHAPs = new HashSet<CHITIETPHIEUNHAP>();
            this.DANGKYBAOTRIs = new HashSet<DANGKYBAOTRI>();
        }
    
        public int MaXe { get; set; }
        public string TenXe { get; set; }
        public string MoTa { get; set; }
        public Nullable<double> GiaBan { get; set; }
        public string XuatXu { get; set; }
        public string MauSac { get; set; }
        public string CDBaoHanh { get; set; }
        public Nullable<int> MaNCC { get; set; }
        public string HinhAnh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BAOHANH> BAOHANHs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BAOTRI> BAOTRIs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADON> CHITIETHOADONs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETPHIEUNHAP> CHITIETPHIEUNHAPs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANGKYBAOTRI> DANGKYBAOTRIs { get; set; }
        public virtual NHACUNGCAP NHACUNGCAP { get; set; }
        public virtual TONKHO TONKHO { get; set; }
    }
}
