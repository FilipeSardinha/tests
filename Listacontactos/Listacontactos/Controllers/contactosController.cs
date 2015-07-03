using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Listacontactos.Controllers
{
    public class contactosController : Controller
    {
        //
        // GET: /contactos/
        public ActionResult Index()
        {
            //return HttpUtility.HtmlEncode("Olá " + name + ", bem vindo a sua Lista de Contactos");
            return View();
        }

        public ActionResult adicionar(string Nome, int n = 0) 
        {
            ViewBag.Message = "Novo contacto - " + Nome + " - "+ n;

            return View();
        }
	}
}