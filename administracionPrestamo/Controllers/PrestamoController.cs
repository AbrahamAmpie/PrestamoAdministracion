using administracionPrestamo.Contracts.Sistema.Tablas;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace administracionPrestamo.Controllers
{
    public class PrestamoController : Controller
    {
        private IRepositorioWrapper _repositorioWrapper;
        private IConfiguration _configuracion;

        public PrestamoController(IRepositorioWrapper repositorioWrapper, IConfiguration configuracion)
        {
            _repositorioWrapper = repositorioWrapper;
            _configuracion = configuracion;
        }

        // GET: PrestamoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PrestamoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PrestamoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PrestamoController/Create
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

        // GET: PrestamoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PrestamoController/Edit/5
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

        // GET: PrestamoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PrestamoController/Delete/5
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
