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
    
    public partial class ECFDetallesItemsItemTablaCodigosItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ECFDetallesItemsItemTablaCodigosItem()
        {
            this.EcfDetallesItemsItemTablaCodigosItemCodigosItems = new HashSet<EcfDetallesItemsItemTablaCodigosItemCodigosItem>();
        }
    
        public int Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EcfDetallesItemsItemTablaCodigosItemCodigosItem> EcfDetallesItemsItemTablaCodigosItemCodigosItems { get; set; }
    }
}
