using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using iECF.Recepcion;
using iECF.Recepcion.Models;

namespace iECF.Recepcion.Controllers
{
    public class EcfEncabezadoesController : Controller
    {
        private Comp_ElectronicosEntities db = new Comp_ElectronicosEntities();

        // GET: EcfEncabezadoes
        public ActionResult Index()
        {
            var ecfEncabezadoes = db.EcfEncabezadoes.Include(e => e.EcfEncabezadoComprador).Include(e => e.EcfEncabezadoEmisor).Include(e => e.EcfEncabezadoIdDoc).Include(e => e.EcfEncabezadoTotale);
            return View(ecfEncabezadoes.ToList());
        }

        // GET: EcfEncabezadoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EcfEncabezado ecfEncabezado = db.EcfEncabezadoes.Find(id);
            if (ecfEncabezado == null)
            {
                return HttpNotFound();
            }
            return View(ecfEncabezado);
        }

        // GET: EcfEncabezadoes/Create
        public ActionResult Create()
        {
            ViewBag.IdItem = new SelectList(db.ECFDetallesItemsItems, "Id", "NombreItem");
            ViewBag.Id = new SelectList(db.EcfEncabezadoes, "Id", "Id");
            ViewBag.Id = new SelectList(db.EcfEncabezadoes, "Id", "Id");
            ViewBag.CompradorId = new SelectList(db.EcfEncabezadoCompradors, "Id", "RNCComprador");
            ViewBag.EmisorId = new SelectList(db.EcfEncabezadoEmisors, "Id", "RNCEmisor");
            ViewBag.IdDocId = new SelectList(db.EcfEncabezadoIdDocs, "Id", "TipoeCF");
            ViewBag.InformacionesAdicionalesId = new SelectList(db.EcfEncabezadoInformacionales, "Id", "FechaEmbarque");
            ViewBag.TotalesId = new SelectList(db.EcfEncabezadoTotales, "Id", "Id");
            ViewBag.TransporteId = new SelectList(db.EcfEncabezadoTransportes, "Id", "Conductor");
            ViewBag.OtraMonedaId = new SelectList(db.EncabezadoOtraMonedas, "Id", "Id");
            return View();
        }

        // POST: EcfEncabezadoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Version,IdDocId,EmisorId,CompradorId,InformacionesAdicionalesId,TransporteId,TotalesId,OtraMonedaId,IdItem")] EcfEncabezado ecfEncabezado)
        {
            if (ModelState.IsValid)
            {
                db.EcfEncabezadoes.Add(ecfEncabezado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdItem = new SelectList(db.ECFDetallesItemsItems, "Id", "NombreItem", ecfEncabezado.IdItem);
            ViewBag.Id = new SelectList(db.EcfEncabezadoes, "Id", "Id", ecfEncabezado.Id);
            ViewBag.Id = new SelectList(db.EcfEncabezadoes, "Id", "Id", ecfEncabezado.Id);
            ViewBag.CompradorId = new SelectList(db.EcfEncabezadoCompradors, "Id", "RNCComprador", ecfEncabezado.CompradorId);
            ViewBag.EmisorId = new SelectList(db.EcfEncabezadoEmisors, "Id", "RNCEmisor", ecfEncabezado.EmisorId);
            ViewBag.IdDocId = new SelectList(db.EcfEncabezadoIdDocs, "Id", "TipoeCF", ecfEncabezado.IdDocId);
            ViewBag.InformacionesAdicionalesId = new SelectList(db.EcfEncabezadoInformacionales, "Id", "FechaEmbarque", ecfEncabezado.InformacionesAdicionalesId);
            ViewBag.TotalesId = new SelectList(db.EcfEncabezadoTotales, "Id", "Id", ecfEncabezado.TotalesId);
            ViewBag.TransporteId = new SelectList(db.EcfEncabezadoTransportes, "Id", "Conductor", ecfEncabezado.TransporteId);
            ViewBag.OtraMonedaId = new SelectList(db.EncabezadoOtraMonedas, "Id", "Id", ecfEncabezado.OtraMonedaId);
            return View(ecfEncabezado);
        }

        // GET: EcfEncabezadoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EcfEncabezado ecfEncabezado = db.EcfEncabezadoes.Find(id);
            if (ecfEncabezado == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdItem = new SelectList(db.ECFDetallesItemsItems, "Id", "NombreItem", ecfEncabezado.IdItem);
            ViewBag.Id = new SelectList(db.EcfEncabezadoes, "Id", "Id", ecfEncabezado.Id);
            ViewBag.Id = new SelectList(db.EcfEncabezadoes, "Id", "Id", ecfEncabezado.Id);
            ViewBag.CompradorId = new SelectList(db.EcfEncabezadoCompradors, "Id", "RNCComprador", ecfEncabezado.CompradorId);
            ViewBag.EmisorId = new SelectList(db.EcfEncabezadoEmisors, "Id", "RNCEmisor", ecfEncabezado.EmisorId);
            ViewBag.IdDocId = new SelectList(db.EcfEncabezadoIdDocs, "Id", "TipoeCF", ecfEncabezado.IdDocId);
            ViewBag.InformacionesAdicionalesId = new SelectList(db.EcfEncabezadoInformacionales, "Id", "FechaEmbarque", ecfEncabezado.InformacionesAdicionalesId);
            ViewBag.TotalesId = new SelectList(db.EcfEncabezadoTotales, "Id", "Id", ecfEncabezado.TotalesId);
            ViewBag.TransporteId = new SelectList(db.EcfEncabezadoTransportes, "Id", "Conductor", ecfEncabezado.TransporteId);
            ViewBag.OtraMonedaId = new SelectList(db.EncabezadoOtraMonedas, "Id", "Id", ecfEncabezado.OtraMonedaId);
            return View(ecfEncabezado);
        }

        // POST: EcfEncabezadoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Version,IdDocId,EmisorId,CompradorId,InformacionesAdicionalesId,TransporteId,TotalesId,OtraMonedaId,IdItem")] EcfEncabezado ecfEncabezado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ecfEncabezado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdItem = new SelectList(db.ECFDetallesItemsItems, "Id", "NombreItem", ecfEncabezado.IdItem);
            ViewBag.Id = new SelectList(db.EcfEncabezadoes, "Id", "Id", ecfEncabezado.Id);
            ViewBag.Id = new SelectList(db.EcfEncabezadoes, "Id", "Id", ecfEncabezado.Id);
            ViewBag.CompradorId = new SelectList(db.EcfEncabezadoCompradors, "Id", "RNCComprador", ecfEncabezado.CompradorId);
            ViewBag.EmisorId = new SelectList(db.EcfEncabezadoEmisors, "Id", "RNCEmisor", ecfEncabezado.EmisorId);
            ViewBag.IdDocId = new SelectList(db.EcfEncabezadoIdDocs, "Id", "TipoeCF", ecfEncabezado.IdDocId);
            ViewBag.InformacionesAdicionalesId = new SelectList(db.EcfEncabezadoInformacionales, "Id", "FechaEmbarque", ecfEncabezado.InformacionesAdicionalesId);
            ViewBag.TotalesId = new SelectList(db.EcfEncabezadoTotales, "Id", "Id", ecfEncabezado.TotalesId);
            ViewBag.TransporteId = new SelectList(db.EcfEncabezadoTransportes, "Id", "Conductor", ecfEncabezado.TransporteId);
            ViewBag.OtraMonedaId = new SelectList(db.EncabezadoOtraMonedas, "Id", "Id", ecfEncabezado.OtraMonedaId);
            return View(ecfEncabezado);
        }

        // GET: EcfEncabezadoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EcfEncabezado ecfEncabezado = db.EcfEncabezadoes.Find(id);
            if (ecfEncabezado == null)
            {
                return HttpNotFound();
            }
            return View(ecfEncabezado);
        }

        // POST: EcfEncabezadoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EcfEncabezado ecfEncabezado = db.EcfEncabezadoes.Find(id);
            db.EcfEncabezadoes.Remove(ecfEncabezado);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
