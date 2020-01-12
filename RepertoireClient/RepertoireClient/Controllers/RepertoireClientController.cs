using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;

namespace RepertoireClient.Controllers
{
    public class RepertoireClientController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Entreprises()
        {
            ViewBag.Message = "Your contact page.";

            return View(Services.IO.getEntreprises(Services.IO.Document));
        }

        public ActionResult NouvelleEntreprise()
        {
            ViewBag.Message = "Your contact page.";


            return View();
        }

        public ActionResult Entreprise(int EntrepriseID = -1)
        {
            if (EntrepriseID == -1)
                return RedirectToAction("Entreprises", "RepertoireClient");

            ViewBag.Message = "Your contact page.";

            return View(Services.IO.getEntreprises(Services.IO.Document).Where(x => x.ID == EntrepriseID).SingleOrDefault());
        }
    }
}