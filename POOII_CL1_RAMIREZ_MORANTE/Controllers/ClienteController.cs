using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using POOII_CL1_RAMIREZ_MORANTE.Models;

namespace POOII_CL1_RAMIREZ_MORANTE.Controllers
{
    // GLOBLAL
    
    public class ClienteController : Controller
    {


        static List<Cliente> aclientes = new List<Cliente>();
        static int n;
        public ActionResult Index()
        {
            return View();
        }

        List<String> listaIntervalos()
        {
            List<string> aIntervalos = new List<string>()
            {
                "Personal","Corporativo","Personaje Ilustre","Other"
            };
            return aIntervalos;
        }


        //Nuevo Cliente

        public ActionResult nuevoCliente() 
        {
            n++;
            ViewBag.n = "CLI-" + n.ToString("0000");
            ViewBag.intervalo = new  SelectList( listaIntervalos());
            return View();
        }
        [HttpPost]

        public ActionResult nuevoCliente(Cliente objC)
        {
            if (!ModelState.IsValid)
            {
               
                ViewBag.n = "CLI-" + n.ToString("0000");
                ViewBag.intervalo = new SelectList(listaIntervalos());

                return View(objC);
            }
            aclientes.Add(objC);
            return RedirectToAction("listadoClientes");

        }

        public ActionResult listadoClientes()
        {
            ViewData["info"] = aclientes.ToList();
            return View();
        }

        public  ActionResult detalleCliente (string id)
        {
            Cliente objC = aclientes.Where(s => s.Codigo == id).FirstOrDefault();
            return View(objC);
        }


        public ActionResult modificarCliente (string id)
        {
            Cliente objC = aclientes.Where(s => s.Codigo == id).FirstOrDefault();
            return View(objC);

        }
        [HttpPost]

        public ActionResult modificarCliente(Cliente objC)
        {
            if (!ModelState.IsValid)
            {
                return View(objC);

            }
            var fila = aclientes.Where(s => s.Codigo == objC.Codigo).FirstOrDefault();

            fila.Nombres = objC.Nombres;
            fila.Telefonos = objC.Telefonos;
            fila.TipoCliente = objC.TipoCliente;
            fila.correo = objC.correo;
            return RedirectToAction("listadoClientes");
        }


        public ActionResult eliminarCliente(string id)
        {
            Cliente objC = aclientes.Where(s => s.Codigo == id).FirstOrDefault();
            aclientes.Remove(objC);
            return RedirectToAction("listadoClientes");
        }
    }
}