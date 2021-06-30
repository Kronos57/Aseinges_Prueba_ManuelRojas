using Business;
using Entities;
using System.Collections.Generic;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    public class PersonasController : Controller
    {
        public ActionResult Consultar(FormCollection formCollection)
        {
            string documento = null;

            if (!string.IsNullOrEmpty(formCollection["txtDocumento"]))
            {
                documento = formCollection["txtDocumento"];
            }

            PersonaBL personaBL = new PersonaBL();
            List<Persona> personas = personaBL.Consulta(documento);

            return View(personas);
        }
    }
}