using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using System.Net.Http;
using Directorio.CAD;

namespace ClientePruebaMVC.Controllers
{
    public class PersonaController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {
            return View(new Persona().Leer());
        }

        [HttpGet]
        public ActionResult CrearRegistro()
        {
            CargarViewBag();
            return View();
        }

        private void CargarViewBag()
        {
            ViewBag.Cargos = LeerCargos();
        }

        [HttpPost]
        public ActionResult CrearRegistro(Persona RegistroPersona)
        {
            if (ModelState.IsValid == false)
            {
                return View();
            }
            return View("Index");
        }

    }
}