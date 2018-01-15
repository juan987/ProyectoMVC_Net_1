using ProyectoMVC_Net_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoMVC_Net_1.Controllers
{
    public class InformacionController : Controller
    {
        // GET: Informacion
        public ActionResult ControladorVistas()
        {
            //Usamos ViewBag
            ViewBag.Nombre = "Visual Studio .NET";
            //Enviamos el modelo Persona
            Persona p = new Persona();
            p.Nombre = "Juan";
            p.Apellidos = "Navarro";

            //Hay que poner el modelo en el return, solo un modelo por cada vista
            return View( p );
        }
    }
}