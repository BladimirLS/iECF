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
    
    public partial class EcfEncabezadoIdDocTablaFormasPagoFormaDePago
    {
        public int Id { get; set; }
        public int FormaPago { get; set; }
        public decimal MontoPago { get; set; }
        public Nullable<int> ECFEncabezadoIdDocId { get; set; }
        public Nullable<int> ECFEncabezadoIdDocTablaFormasPagoId { get; set; }
    
        public virtual EcfEncabezadoIdDoc EcfEncabezadoIdDoc { get; set; }
        public virtual EcfEncabezadoIdDocTablaFormasPago EcfEncabezadoIdDocTablaFormasPago { get; set; }
    }
}
