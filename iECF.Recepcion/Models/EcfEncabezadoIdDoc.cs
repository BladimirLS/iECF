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
    
    public partial class EcfEncabezadoIdDoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EcfEncabezadoIdDoc()
        {
            this.EcfEncabezadoes = new HashSet<EcfEncabezado>();
            this.EcfEncabezadoIdDocTablaFormasPagoFormaDePagoes = new HashSet<EcfEncabezadoIdDocTablaFormasPagoFormaDePago>();
            this.RecepcionResults = new HashSet<RecepcionResult>();
            this.AprobacionComercials = new HashSet<AprobacionComercial>();
        }
    
        public int Id { get; set; }
        public string TipoeCF { get; set; }
        public string ENCF { get; set; }
        public string FechaVencimientoSecuencia { get; set; }
        public int IndicadorEnvioDiferidoValue { get; set; }
        public bool IndicadorEnvioDiferidoValueSpecified { get; set; }
        public Nullable<int> IndicadorEnvioDiferido { get; set; }
        public int IndicadorMontoGravadoValue { get; set; }
        public bool IndicadorMontoGravadoValueSpecified { get; set; }
        public Nullable<int> IndicadorMontoGravado { get; set; }
        public string TipoIngresos { get; set; }
        public int TipoPago { get; set; }
        public string FechaLimitePago { get; set; }
        public string TerminoPago { get; set; }
        public int TipoCuentaPagoValue { get; set; }
        public bool TipoCuentaPagoValueSpecified { get; set; }
        public Nullable<int> TipoCuentaPago { get; set; }
        public string NumeroCuentaPago { get; set; }
        public string BancoPago { get; set; }
        public string FechaDesde { get; set; }
        public string FechaHasta { get; set; }
        public short TotalPaginasValue { get; set; }
        public bool TotalPaginasValueSpecified { get; set; }
        public Nullable<short> TotalPaginas { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EcfEncabezado> EcfEncabezadoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EcfEncabezadoIdDocTablaFormasPagoFormaDePago> EcfEncabezadoIdDocTablaFormasPagoFormaDePagoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecepcionResult> RecepcionResults { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AprobacionComercial> AprobacionComercials { get; set; }
    }
}