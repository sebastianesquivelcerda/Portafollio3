using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NoMasAccidentesNegocio;


namespace NoMasAccidentes.Controllers
{
    public class ContratoController : Controller
    {
        // GET: Contrato
        public ActionResult Index()
        {
            ViewBag.Contratos = new Contrato().ReadAll();
            return View();
        }

        // GET: Contrato/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Contrato/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contrato/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "fecha_Creacion,rut,fecha_Termino,,texto_contrato")]Contrato contrato)
        {
            try
            {
                // TODO: Add insert logic here
                contrato.Save();
                TempData["mensaje"] = "Guardado Correctamente";
                return RedirectToAction("Index");
            }
            catch
            {
                return View(contrato);
            }
        }

        // GET: Contrato/Edit/5
        public ActionResult Edit(int id)
        {


            Contrato p = new Contrato().find(id);

            if (p == null)
            {
                TempData["mensaje"] = "El Contrato no existe";
                return RedirectToAction("Index");
            }
            return View(p);
        }

        // POST: Contrato/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "ID_Contrato,fecha_Creacion,rut,fecha_Termino,,texto_contrato ")]Contrato contrato)
        {
            try
            {
                // TODO: Add update logic here
                contrato.Update();
                TempData["mensaje"] = "modificado correctamente";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Contrato/Delete/5
        public ActionResult Delete(int id)
        {

            if (new Contrato().find(id) == null)
            {
                TempData["mensaje"] = "no existe el producto";
                return RedirectToAction("Index");
            }

            if (new Contrato().Delete(id))
            {
                TempData["mensaje"] = "Eliminado Correctamente";
                return RedirectToAction("Index");
            }

            return View();
        }

        // POST: Contrato/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
