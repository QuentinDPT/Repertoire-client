using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RepertoireClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntrepriseController : ControllerBase
    {
        // GET: api/Entreprise
        [HttpGet]
        public IEnumerable<ViewModel.Entreprise> Get()
        {
            return Services.IO.getEntreprises(Services.IO.Document);
        }

        // GET: api/Entreprise/5
        [HttpGet("{id}", Name = "Get")]
        public ViewModel.Entreprise Get(int id)
        {
            return Services.IO.getEntreprises(Services.IO.Document).Where(x => x.ID == id).SingleOrDefault();
        }

        // POST: api/Entreprise
        [HttpPost]
        public void Post([FromBody] ViewModel.Entreprise entreprise)
        {
            Services.IO.addEntreprise(entreprise, Services.IO.Document);
        }

        // PUT: api/Entreprise/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ViewModel.Entreprise entreprise)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Services.IO.removeEntreprise(id, Services.IO.Document);
        }
    }
}
