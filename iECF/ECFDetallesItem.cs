//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iECF
{
    using System;
    using System.Collections.Generic;
    
    public partial class ECFDetallesItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ECFDetallesItem()
        {
            this.ECFDetallesItemsItems = new HashSet<ECFDetallesItemsItem>();
        }
    
        public int Id { get; set; }
        public Nullable<int> IndicadorFacturacion { get; set; }
        public Nullable<int> IndicadorBienoServicio { get; set; }
        public string NombreItem { get; set; }
        public Nullable<int> CantidadItem { get; set; }
        public Nullable<double> PrecioUnitarioItem { get; set; }
        public Nullable<double> MontoItem { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ECFDetallesItemsItem> ECFDetallesItemsItems { get; set; }
    }
}
