using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using iECF.Recepcion.Models;

namespace iECF.Recepcion.Controllers
{
    public class AprobacionComercialsController : Controller
    {
        private Comp_ElectronicosEntities db = new Comp_ElectronicosEntities();

        // GET: AprobacionComercials
        public ActionResult Index()
        {
            var aprobacionComercials = db.AprobacionComercials.Include(a => a.EcfEncabezadoEmisor).Include(a => a.EcfEncabezadoIdDoc).Include(a => a.EcfEncabezadoTotale).Include(a => a.EstadoEnvio).Include(a => a.RecepcionResult);
            return View(aprobacionComercials.ToList());
        }

        // GET: AprobacionComercials/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AprobacionComercial aprobacionComercial = db.AprobacionComercials.Find(id);
            if (aprobacionComercial == null)
            {
                return HttpNotFound();
            }
            return View(aprobacionComercial);
        }

        // GET: AprobacionComercials/Create
        public ActionResult Create()
        {
            ViewBag.Id = new SelectList(db.EcfEncabezadoEmisors, "Id", "RNCEmisor");
            ViewBag.IdDoc = new SelectList(db.EcfEncabezadoIdDocs, "Id", "TipoeCF");
            ViewBag.IdTotal = new SelectList(db.EcfEncabezadoTotales, "Id", "Id");
            ViewBag.IdEstadoEnvios = new SelectList(db.EstadoEnvios, "Id", "trackId");
            ViewBag.IdRecepcionResult = new SelectList(db.RecepcionResults, "Id", "trackId");
            return View();
        }

        // POST: AprobacionComercials/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdEmisor,IdDoc,IdTotal,IdRecepcionResult,IdEstadoEnvios")] AprobacionComercial aprobacionComercial)
        {
            if (ModelState.IsValid)
            {
                db.AprobacionComercials.Add(aprobacionComercial);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id = new SelectList(db.EcfEncabezadoEmisors, "Id", "RNCEmisor", aprobacionComercial.Id);
            ViewBag.IdDoc = new SelectList(db.EcfEncabezadoIdDocs, "Id", "TipoeCF", aprobacionComercial.IdDoc);
            ViewBag.IdTotal = new SelectList(db.EcfEncabezadoTotales, "Id", "Id", aprobacionComercial.IdTotal);
            ViewBag.IdEstadoEnvios = new SelectList(db.EstadoEnvios, "Id", "trackId", aprobacionComercial.IdEstadoEnvios);
            ViewBag.IdRecepcionResult = new SelectList(db.RecepcionResults, "Id", "trackId", aprobacionComercial.IdRecepcionResult);
            return View(aprobacionComercial);
        }

        // GET: AprobacionComercials/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AprobacionComercial aprobacionComercial = db.AprobacionComercials.Find(id);
            if (aprobacionComercial == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id = new SelectList(db.EcfEncabezadoEmisors, "Id", "RNCEmisor", aprobacionComercial.Id);
            ViewBag.IdDoc = new SelectList(db.EcfEncabezadoIdDocs, "Id", "TipoeCF", aprobacionComercial.IdDoc);
            ViewBag.IdTotal = new SelectList(db.EcfEncabezadoTotales, "Id", "Id", aprobacionComercial.IdTotal);
            ViewBag.IdEstadoEnvios = new SelectList(db.EstadoEnvios, "Id", "trackId", aprobacionComercial.IdEstadoEnvios);
            ViewBag.IdRecepcionResult = new SelectList(db.RecepcionResults, "Id", "trackId", aprobacionComercial.IdRecepcionResult);
            return View(aprobacionComercial);
        }

        // POST: AprobacionComercials/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdEmisor,IdDoc,IdTotal,IdRecepcionResult,IdEstadoEnvios")] AprobacionComercial aprobacionComercial)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aprobacionComercial).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id = new SelectList(db.EcfEncabezadoEmisors, "Id", "RNCEmisor", aprobacionComercial.Id);
            ViewBag.IdDoc = new SelectList(db.EcfEncabezadoIdDocs, "Id", "TipoeCF", aprobacionComercial.IdDoc);
            ViewBag.IdTotal = new SelectList(db.EcfEncabezadoTotales, "Id", "Id", aprobacionComercial.IdTotal);
            ViewBag.IdEstadoEnvios = new SelectList(db.EstadoEnvios, "Id", "trackId", aprobacionComercial.IdEstadoEnvios);
            ViewBag.IdRecepcionResult = new SelectList(db.RecepcionResults, "Id", "trackId", aprobacionComercial.IdRecepcionResult);
            return View(aprobacionComercial);
        }

        // GET: AprobacionComercials/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AprobacionComercial aprobacionComercial = db.AprobacionComercials.Find(id);
            if (aprobacionComercial == null)
            {
                return HttpNotFound();
            }
            return View(aprobacionComercial);
        }

        // POST: AprobacionComercials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AprobacionComercial aprobacionComercial = db.AprobacionComercials.Find(id);
            db.AprobacionComercials.Remove(aprobacionComercial);
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
