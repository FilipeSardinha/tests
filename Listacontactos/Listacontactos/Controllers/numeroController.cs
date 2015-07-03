using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Listacontactos.Models;

namespace Listacontactos.Controllers
{
    public class numeroController : Controller
    {
        private numeroDBcontext db = new numeroDBcontext();

        // GET: /numero/
        public ActionResult Index()
        {
            return View(db.numero.ToList());
        }

        // GET: /numero/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            numeros numeros = db.numero.Find(id);
            if (numeros == null)
            {
                return HttpNotFound();
            }
            return View(numeros);
        }

        // GET: /numero/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /numero/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Nome,Apelido,Tipo,Numero")] numeros numeros)
        {
            if (ModelState.IsValid)
            {
                db.numero.Add(numeros);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(numeros);
        }

        // GET: /numero/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            numeros numeros = db.numero.Find(id);
            if (numeros == null)
            {
                return HttpNotFound();
            }
            return View(numeros);
        }

        // POST: /numero/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Nome,Apelido,Tipo,Numero")] numeros numeros)
        {
            if (ModelState.IsValid)
            {
                db.Entry(numeros).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(numeros);
        }

        // GET: /numero/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            numeros numeros = db.numero.Find(id);
            if (numeros == null)
            {
                return HttpNotFound();
            }
            return View(numeros);
        }

        // POST: /numero/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            numeros numeros = db.numero.Find(id);
            db.numero.Remove(numeros);
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
