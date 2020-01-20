using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

using RepertoireClient.Services;
using RepertoireClient.ViewModel;

namespace RepertoireClient.Controllers
{
    public class EntrepriseController : ApiController
    {
        // GET: api/Entreprise
        public List<ViewModel.Entreprise> GetAllEntreprise()
        {
            return Services.IO.getEntreprises(Services.IO.Document); ;
        }

        // GET: api/Entreprise/5
        public string GetEntreprise(int id)
        {
            return "value";
        }

        // POST: api/Entreprise
        public void Post([FromBody]ViewModel.Entreprise ent)
        {
            Services.IO.addEntreprise(ent, Services.IO.Document);
        }

        // PUT: api/Entreprise/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Entreprise/5
        public void Delete(int id)
        {
        }
    }
}
