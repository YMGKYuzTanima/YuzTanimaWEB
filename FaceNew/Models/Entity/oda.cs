//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FaceNew.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class oda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public oda()
        {
            this.personel = new HashSet<personel>();
            this.rapor = new HashSet<rapor>();
        }
    
        public short oda_ID { get; set; }
        public Nullable<short> oda_birimid { get; set; }
        public Nullable<short> oda_konum_mesafe { get; set; }
        public string oda_yol_haritası { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<personel> personel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rapor> rapor { get; set; }
    }
}
