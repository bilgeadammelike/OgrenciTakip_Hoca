//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OgrenciTakip.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sinif
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sinif()
        {
            this.SinifOgrenci = new HashSet<SinifOgrenci>();
            this.SinifUzmanlik = new HashSet<SinifUzmanlik>();
        }
    
        public int SinifID { get; set; }
        public string SinifAdi { get; set; }
        public Nullable<bool> AktifMi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SinifOgrenci> SinifOgrenci { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SinifUzmanlik> SinifUzmanlik { get; set; }
    }
}
