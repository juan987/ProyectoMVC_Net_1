using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoMVC_Net_1.Controllers
{
    public class EjemplosController : Controller
    {
        // GET: Ejemplos
        public ActionResult Index()
        {
            return View();
        }

        //GET: SumarNumeros
        public ActionResult SumarNumeros()
        {
            return View();
        }

        //POST: SumarNumeros
        [HttpPost]
        public ActionResult SumarNumeros(int numero1, int numero2)
        {
            int suma = numero1 + numero2;
            ViewBag.Suma = suma;
            return View();
        }

    }
}