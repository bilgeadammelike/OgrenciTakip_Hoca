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
    
    public partial class Uzmanlik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Uzmanlik()
        {
            this.OgretmenUzmanlik = new HashSet<OgretmenUzmanlik>();
        }
    
        public int UzmanlikID { get; set; }
        public string UzmanlikAdi { get; set; }
        public Nullable<bool> AktifMi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OgretmenUzmanlik> OgretmenUzmanlik { get; set; }
    }
}
