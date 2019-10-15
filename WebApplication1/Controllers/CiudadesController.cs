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
    public class CiudadesController : Controller
    {
        // GET: Ciudades
        public ActionResult Index()
        {
            ICiudadDAO dao = new CiudadDAO();
            List<Ciudad> ciudades = dao.GetCiudades();
            CiudadView cv = new CiudadView();
            cv.ciudades = ciudades;
            return View(cv);
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