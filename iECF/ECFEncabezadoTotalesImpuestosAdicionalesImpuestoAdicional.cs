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
    
    public partial class ECFEncabezadoTotalesImpuestosAdicionalesImpuestoAdicional
    {
        public int Id { get; set; }
        public int TipoImpuesto { get; set; }
        public decimal TasaImpuestoAdicional { get; set; }
        public decimal MontoImpuestoSelectivoConsumoEspecificoValue { get; set; }
        public bool MontoImpuestoSelectivoConsumoEspecificoValueSpecified { get; set; }
        public Nullable<decimal> MontoImpuestoSelectivoConsumoEspecifico { get; set; }
        public decimal MontoImpuestoSelectivoConsumoAdvaloremValue { get; set; }
        public bool MontoImpuestoSelectivoConsumoAdvaloremValueSpecified { get; set; }
        public Nullable<decimal> MontoImpuestoSelectivoConsumoAdvalorem { get; set; }
        public decimal OtrosImpuestosAdicionalesValue { get; set; }
        public bool OtrosImpuestosAdicionalesValueSpecified { get; set; }
        public Nullable<decimal> OtrosImpuestosAdicionales { get; set; }
        public Nullable<int> ECFEncabezadoTotalesId { get; set; }
        public Nullable<int> ECFEncabezadoTotalesImpuestosAdicionalesId { get; set; }
    
        public virtual EcfEncabezadoTotale EcfEncabezadoTotale { get; set; }
        public virtual EcfEncabezadoTotalesImpuestosAdicionalesEnumerable EcfEncabezadoTotalesImpuestosAdicionalesEnumerable { get; set; }
    }
}