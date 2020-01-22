using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RepertoireClient.Controllers
{
    public class arg
    {
        public string Document;
        public string Delimitter;
    }
    public class RepertoireClientController : Controller
    {
        // GET: RepertoireClient
        public ActionResult Index()
        {
            return View(new arg() { Document = Services.IO.Document, Delimitter = Services.IO.Delimitter.ToString() });
        }

        // GET: RepertoireClient/Details/5
        public ActionResult Entreprises()
        {
            return View(Services.IO.getEntreprises(Services.IO.Document));
        }

        public ActionResult NouvelleEntreprise()
        {
            return View();
        }

        public ActionResult Entreprise(int EntrepriseID = -1)
        {
            if (EntrepriseID == -1)
                return RedirectToAction("Entreprises", "RepertoireClient");

            ViewBag.Message = "Your contact page.";

            return View(Services.IO.getEntreprises(Services.IO.Document).Where(x => x.ID == EntrepriseID).SingleOrDefault());
        }

        // GET: RepertoireClient/Edit/5
        public ActionResult Edit(int EntrepriseID = -1)
        {
            if (EntrepriseID == -1)
                return RedirectToAction("Entreprises", "RepertoireClient");

            return View(Services.IO.getEntreprises(Services.IO.Document).Where(x => x.ID == EntrepriseID).SingleOrDefault());
        }


        #region API

        // POST: RepertoireClient/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: RepertoireClient/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: RepertoireClient/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        #endregion
    }
}