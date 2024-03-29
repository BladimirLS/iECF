//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iECF.Recepcion.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ECFDetallesItemsItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ECFDetallesItemsItem()
        {
            this.EcfDetallesItemsItemTablaCodigosItemCodigosItems = new HashSet<EcfDetallesItemsItemTablaCodigosItemCodigosItem>();
            this.EcfDetallesItemsItemTablaImpuestoAdicionalImpuestoAdicionals = new HashSet<EcfDetallesItemsItemTablaImpuestoAdicionalImpuestoAdicional>();
            this.EcfDetallesItemsItemTablaSubcantidadSubcantidadItems = new HashSet<EcfDetallesItemsItemTablaSubcantidadSubcantidadItem>();
            this.EcfDetallesItemsItemTablaSubDescuentoSubDescuentos = new HashSet<EcfDetallesItemsItemTablaSubDescuentoSubDescuento>();
            this.EcfDetallesItemsItemTablaSubRecargoSubRecargos = new HashSet<EcfDetallesItemsItemTablaSubRecargoSubRecargo>();
            this.EcfEncabezadoes = new HashSet<EcfEncabezado>();
        }
    
        public int Id { get; set; }
        public Nullable<short> NumeroLinea { get; set; }
        public Nullable<int> IndicadorFacturacion { get; set; }
        public Nullable<int> RetencionId { get; set; }
        public string NombreItem { get; set; }
        public Nullable<int> IndicadorBienoServicio { get; set; }
        public string DescripcionItem { get; set; }
        public Nullable<decimal> CantidadItem { get; set; }
        public Nullable<int> UnidadMedidaValue { get; set; }
        public Nullable<bool> UnidadMedidaValueSpecified { get; set; }
        public Nullable<int> UnidadMedida { get; set; }
        public Nullable<decimal> CantidadReferenciaValue { get; set; }
        public Nullable<bool> CantidadReferenciaValueSpecified { get; set; }
        public Nullable<decimal> CantidadReferencia { get; set; }
        public Nullable<int> UnidadReferenciaValue { get; set; }
        public Nullable<bool> UnidadReferenciaValueSpecified { get; set; }
        public Nullable<int> UnidadReferencia { get; set; }
        public Nullable<decimal> GradosAlcoholValue { get; set; }
        public Nullable<bool> GradosAlcoholValueSpecified { get; set; }
        public Nullable<decimal> GradosAlcohol { get; set; }
        public Nullable<decimal> PrecioUnitarioReferenciaValue { get; set; }
        public Nullable<bool> PrecioUnitarioReferenciaValueSpecified { get; set; }
        public Nullable<decimal> PrecioUnitarioReferencia { get; set; }
        public string FechaElaboracion { get; set; }
        public string FechaVencimientoItem { get; set; }
        public Nullable<decimal> PrecioUnitarioItem { get; set; }
        public Nullable<decimal> DescuentoMontoValue { get; set; }
        public Nullable<bool> DescuentoMontoValueSpecified { get; set; }
        public Nullable<decimal> DescuentoMonto { get; set; }
        public Nullable<decimal> RecargoMontoValue { get; set; }
        public Nullable<bool> RecargoMontoValueSpecified { get; set; }
        public Nullable<decimal> RecargoMonto { get; set; }
        public Nullable<int> OtraMonedaDetalleId { get; set; }
        public Nullable<decimal> MontoItem { get; set; }
        public Nullable<int> ECFDetallesItemsId { get; set; }
    
        public virtual ECFDetallesItem ECFDetallesItem { get; set; }
        public virtual ECFDetallesItemsItemOtraMonedaDetalle ECFDetallesItemsItemOtraMonedaDetalle { get; set; }
        public virtual ECFDetallesItemsItemRetencion ECFDetallesItemsItemRetencion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EcfDetallesItemsItemTablaCodigosItemCodigosItem> EcfDetallesItemsItemTablaCodigosItemCodigosItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EcfDetallesItemsItemTablaImpuestoAdicionalImpuestoAdicional> EcfDetallesItemsItemTablaImpuestoAdicionalImpuestoAdicionals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EcfDetallesItemsItemTablaSubcantidadSubcantidadItem> EcfDetallesItemsItemTablaSubcantidadSubcantidadItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EcfDetallesItemsItemTablaSubDescuentoSubDescuento> EcfDetallesItemsItemTablaSubDescuentoSubDescuentos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EcfDetallesItemsItemTablaSubRecargoSubRecargo> EcfDetallesItemsItemTablaSubRecargoSubRecargos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EcfEncabezado> EcfEncabezadoes { get; set; }
    }
}
