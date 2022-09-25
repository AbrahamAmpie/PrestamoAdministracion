﻿using administracionPrestamo.Contracts.Sistema.Tablas;
using administracionPrestamo.Modelos.Sistema.Tablas.Catalogo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace administracionPrestamo.Controllers
{
    public class CatalogoController : Controller
    {
        private IRepositorioWrapper _repositorioWrapper;
        private IConfiguration _configuracion;

        public CatalogoController(IRepositorioWrapper repositorioWrapper, IConfiguration configuracion)
        {
            _repositorioWrapper = repositorioWrapper;
            _configuracion = configuracion;
        }

        public ActionResult Paises()
        {
            List<Paises> ListaPaises = new List<Paises>();

            ListaPaises = _repositorioWrapper.RepositorioPaises.BuscarPorCondicion(x => x.Estado).ToList();

            return View(ListaPaises);
        }

        // GET: CatalogoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CatalogoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CatalogoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CatalogoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CatalogoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CatalogoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CatalogoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CatalogoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
