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



        public ActionResult VistaGet(String Dato)
        {
            //Usamos ViewBag
            ViewBag.Mensaje = "Información recibida: " +Dato;
            return View();
        }


        public ActionResult VistaPost()//Con esto muestro la vista
        {//La primera vez no recibimos ningun dato
            //Usamos ViewBag
            return View();
        }

        //[HttpPost]//Recibe los datos
        //public ActionResult VistaPost(String nombre, String apellido)
        //{
        //    //Usamos ViewBag
        //    ViewBag.Mensaje = "Información recibida: " + nombre  +  ", " + apellido;
        //    return View();
        //}

        [HttpPost]//Recibe los datos
        public ActionResult VistaPost(Persona persona)
        {
            //Usamos ViewBag
            ViewBag.Mensaje = "Información recibida: " + persona.Nombre + ", " + persona.Apellidos;
            return View();
        }
    }
}