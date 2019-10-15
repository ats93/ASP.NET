using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacion.BO;
using Aplicacion.DAO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PaisesController : Controller
    {
        List<Pais> paises;
        List<Ciudad> ciudades;
        PaisView view;
        // GET: Ciudades
        public ActionResult Index()
        {
            IPaisDAO dao = new PaisDAO();
            paises = new List<Pais>();
            ciudades = new List<Ciudad>();
            paises = dao.GetPaises();
            view = new PaisView();
            view.paises = paises;
            return View(view);
        }

        [HttpGet]
        public ActionResult GetCiudades(int id)
        {
            ICiudadDAO dao = new CiudadDAO();
            IPaisDAO pDao = new PaisDAO();
            ciudades = dao.GetCiudades().Where(o => o.PaisId == id).ToList();
            view = new PaisView();
            paises = pDao.GetPaises();
            view.paises = paises;
            view.ciudades = ciudades;
            return View("DropDownPartial",view);
        }

        // GET: Ciudades/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Ciudades/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ciudades/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Ciudades/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Ciudades/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Ciudades/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ciudades/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}