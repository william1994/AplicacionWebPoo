using AplicacionWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacionWeb.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult PersonaVista() {


            return View();
        }

        [HttpPost]
        public ActionResult PersonaVista(Persona p)
        {

            Console.WriteLine(p.Nombre);

            return View();
        }


        [HttpGet]
        public ActionResult ClaseHtml() {

            return View();
        }
        [HttpPost]
        public ActionResult ClaseHtml(Persona p)
        {
            _ = p;

            if (p.Nombre.Equals("William") && p.Contr.Equals("123")) {

                return Redirect("Welcome");
            }
        
            return View();
        }

        [HttpGet]
        public ActionResult Welcome() {

            return View();
        }



    }
}