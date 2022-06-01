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
    
    public partial class EcfEncabezado
    {
        public int Id { get; set; }
        public int Version { get; set; }
        public Nullable<int> IdDocId { get; set; }
        public Nullable<int> EmisorId { get; set; }
        public Nullable<int> CompradorId { get; set; }
        public Nullable<int> InformacionesAdicionalesId { get; set; }
        public Nullable<int> TransporteId { get; set; }
        public Nullable<int> TotalesId { get; set; }
        public Nullable<int> OtraMonedaId { get; set; }
        public int IdItem { get; set; }
    
        public virtual ECFDetallesItemsItem ECFDetallesItemsItem { get; set; }
        public virtual EcfEncabezado EcfEncabezado1 { get; set; }
        public virtual EcfEncabezado EcfEncabezado2 { get; set; }
        public virtual EcfEncabezadoComprador EcfEncabezadoComprador { get; set; }
        public virtual EcfEncabezadoEmisor EcfEncabezadoEmisor { get; set; }
        public virtual EcfEncabezadoIdDoc EcfEncabezadoIdDoc { get; set; }
        public virtual EcfEncabezadoInformacionale EcfEncabezadoInformacionale { get; set; }
        public virtual EcfEncabezadoTotale EcfEncabezadoTotale { get; set; }
        public virtual EcfEncabezadoTransporte EcfEncabezadoTransporte { get; set; }
        public virtual EncabezadoOtraMoneda EncabezadoOtraMoneda { get; set; }
    }
}
