//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace tieuluan_ban_giay.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Giay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Giay()
        {
            this.CT_DatHang = new HashSet<CT_DatHang>();
        }
    
        public int Ma_Giay { get; set; }
        public string Ten_Giay { get; set; }
        public string DonViTinh { get; set; }
        public Nullable<decimal> DonGia { get; set; }
        public string MoTa { get; set; }
        public string HinhMinhHoa { get; set; }
        public Nullable<int> Ma_TheLoai { get; set; }
        public Nullable<int> Ma_NSX { get; set; }
        public Nullable<System.DateTime> NgayCapNhat { get; set; }
        public Nullable<int> SoLuongBan { get; set; }
        public Nullable<int> Ma_Khuyen_Mai { get; set; }
        public Nullable<decimal> Gia_Goc { get; set; }
        public string Hinh_1 { get; set; }
        public string Hinh_2 { get; set; }
        public string Hinh_3 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_DatHang> CT_DatHang { get; set; }
        public virtual Khuyen_Mai Khuyen_Mai { get; set; }
        public virtual The_Loai The_Loai { get; set; }
    }
}
