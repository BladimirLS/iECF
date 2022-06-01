﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Comp_ElectronicosEntities : DbContext
    {
        public Comp_ElectronicosEntities()
            : base("name=Comp_ElectronicosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__EFMigrationsHistory> C__EFMigrationsHistory { get; set; }
        public virtual DbSet<Compradore> Compradores { get; set; }
        public virtual DbSet<DgiiToken> DgiiTokens { get; set; }
        public virtual DbSet<ECFDescuentosORecargo> ECFDescuentosORecargos { get; set; }
        public virtual DbSet<ECFDescuentosORecargosDescuentosORecargo> ECFDescuentosORecargosDescuentosORecargoes { get; set; }
        public virtual DbSet<ECFDetallesItem> ECFDetallesItems { get; set; }
        public virtual DbSet<ECFDetallesItemsItem> ECFDetallesItemsItems { get; set; }
        public virtual DbSet<ECFDetallesItemsItemOtraMonedaDetalle> ECFDetallesItemsItemOtraMonedaDetalles { get; set; }
        public virtual DbSet<ECFDetallesItemsItemRetencion> ECFDetallesItemsItemRetencions { get; set; }
        public virtual DbSet<ECFDetallesItemsItemTablaCodigosItem> ECFDetallesItemsItemTablaCodigosItems { get; set; }
        public virtual DbSet<EcfDetallesItemsItemTablaCodigosItemCodigosItem> EcfDetallesItemsItemTablaCodigosItemCodigosItems { get; set; }
        public virtual DbSet<ECFDetallesItemsItemTablaImpuestoAdicional> ECFDetallesItemsItemTablaImpuestoAdicionals { get; set; }
        public virtual DbSet<EcfDetallesItemsItemTablaImpuestoAdicionalImpuestoAdicional> EcfDetallesItemsItemTablaImpuestoAdicionalImpuestoAdicionals { get; set; }
        public virtual DbSet<EcfDetallesItemsItemTablaSubcantidad> EcfDetallesItemsItemTablaSubcantidads { get; set; }
        public virtual DbSet<EcfDetallesItemsItemTablaSubcantidadSubcantidadItem> EcfDetallesItemsItemTablaSubcantidadSubcantidadItems { get; set; }
        public virtual DbSet<EcfDetallesItemsItemTablaSubDescuento> EcfDetallesItemsItemTablaSubDescuentos { get; set; }
        public virtual DbSet<EcfDetallesItemsItemTablaSubDescuentoSubDescuento> EcfDetallesItemsItemTablaSubDescuentoSubDescuentos { get; set; }
        public virtual DbSet<EcfDetallesItemsItemTablaSubRecargo> EcfDetallesItemsItemTablaSubRecargos { get; set; }
        public virtual DbSet<EcfDetallesItemsItemTablaSubRecargoSubRecargo> EcfDetallesItemsItemTablaSubRecargoSubRecargos { get; set; }
        public virtual DbSet<EcfEncabezado> EcfEncabezadoes { get; set; }
        public virtual DbSet<EcfEncabezadoComprador> EcfEncabezadoCompradors { get; set; }
        public virtual DbSet<EcfEncabezadoEmisor> EcfEncabezadoEmisors { get; set; }
        public virtual DbSet<EcfEncabezadoIdDoc> EcfEncabezadoIdDocs { get; set; }
        public virtual DbSet<EcfEncabezadoIdDocTablaFormasPagoFormaDePago> EcfEncabezadoIdDocTablaFormasPagoFormaDePagoes { get; set; }
        public virtual DbSet<EcfEncabezadoIdDocTablaFormasPago> EcfEncabezadoIdDocTablaFormasPagos { get; set; }
        public virtual DbSet<EcfEncabezadoInformacionale> EcfEncabezadoInformacionales { get; set; }
        public virtual DbSet<EcfEncabezadoOtraMonedaImpuestosAdicionalesOtraMonedaImpuestoAdicionalOtraMoneda> EcfEncabezadoOtraMonedaImpuestosAdicionalesOtraMonedaImpuestoAdicionalOtraMonedas { get; set; }
        public virtual DbSet<EcfEncabezadoOtraMonedasImpuestosAdicionale> EcfEncabezadoOtraMonedasImpuestosAdicionales { get; set; }
        public virtual DbSet<EcfEncabezadoTotale> EcfEncabezadoTotales { get; set; }
        public virtual DbSet<EcfEncabezadoTotalesImpuestosAdicionalesEnumerable> EcfEncabezadoTotalesImpuestosAdicionalesEnumerables { get; set; }
        public virtual DbSet<ECFEncabezadoTotalesImpuestosAdicionalesImpuestoAdicional> ECFEncabezadoTotalesImpuestosAdicionalesImpuestoAdicionals { get; set; }
        public virtual DbSet<EcfEncabezadoTransporte> EcfEncabezadoTransportes { get; set; }
        public virtual DbSet<ECFSubtotalesSubtotal> ECFSubtotalesSubtotals { get; set; }
        public virtual DbSet<EfEcfSubtotalesEnumerable> EfEcfSubtotalesEnumerables { get; set; }
        public virtual DbSet<Emisore> Emisores { get; set; }
        public virtual DbSet<EncabezadoOtraMoneda> EncabezadoOtraMonedas { get; set; }
        public virtual DbSet<EstadoEnvio> EstadoEnvios { get; set; }
        public virtual DbSet<ExInformacionReferencia> ExInformacionReferencias { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Mensaje> Mensajes { get; set; }
        public virtual DbSet<MensajeEnvio> MensajeEnvios { get; set; }
        public virtual DbSet<RecepcionResult> RecepcionResults { get; set; }
        public virtual DbSet<Totale> Totales { get; set; }
        public virtual DbSet<XZ> XZs { get; set; }
        public virtual DbSet<comp_elec> comp_elec { get; set; }
        public virtual DbSet<firma_comp> firma_comp { get; set; }
        public virtual DbSet<firma_comp_elec> firma_comp_elec { get; set; }
        public virtual DbSet<AprobacionComercial> AprobacionComercials { get; set; }
    }
}
