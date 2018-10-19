//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tailor.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Material
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Material()
        {
            this.ClothesMaterials = new HashSet<ClothesMaterial>();
        }
    
        public int Id { get; set; }
        public string Description { get; set; }
        public Nullable<int> MeasurementId { get; set; }
        public Nullable<decimal> PriceIn { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClothesMaterial> ClothesMaterials { get; set; }
        public virtual Measurement Measurement { get; set; }
        public virtual MaterialStock MaterialStock { get; set; }
    }
}