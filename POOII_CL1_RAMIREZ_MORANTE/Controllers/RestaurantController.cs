using POOII_CL1_RAMIREZ_MORANTE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POOII_CL1_RAMIREZ_MORANTE.Controllers
{
    public class RestaurantController : Controller
    {
        // GET: Restaurant
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListadoServicios()
        {
            List<Servicio> aServicio = new List<Servicio>();
            aServicio.Add(new Servicio
            {
                representante= "Buffet",
                ciudad= "Lima",
                telefono= 985963258,
                contacto= "servicio_buffet@restaurant.pe",

            });
            aServicio.Add(new Servicio
            {
                representante = "Celebraciones",
                ciudad = "Trujillo",
                telefono = 936369785,
                contacto = "celebra_buffet@restaurant.pe",

            });
            aServicio.Add(new Servicio
            {
                representante = "Almuerzos Empresariales",
                ciudad = "Arequipa",
                telefono = 984265548,
                contacto = "almuer_buffet@restaurant.pe",

            });
            ViewData["datos"] = aServicio;

            List<String> fotosServ = new List<string>()
            {
                "imgServ1","imgServ2","imgServ3"
            };
            ViewData["fotos"] = fotosServ;

            return View();      
        }
    }
}