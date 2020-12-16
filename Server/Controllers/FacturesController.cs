using Facturations.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facturations.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FacturesController : ControllerBase
    {
        private readonly ILogger<FacturesController> _logger;
        private readonly IBusinessData _data;

        public FacturesController(ILogger<FacturesController> logger, IBusinessData data)
        {
            _logger = logger;
            _data = data;
        }

        [HttpGet]
        public IEnumerable<Facture> Get()
        {
             return _data.AllFactures;
        }

        [HttpGet("{reference}")]
        public ActionResult<Facture> Get(string reference)
        {
            var facture = _data.AllFactures.Where(fact => fact.NumeroFacture == reference).FirstOrDefault();

            if(facture != null)
            {
                return facture;
            }
            else
            {
                return NotFound();
            }

        }

        [HttpPost]
        public ActionResult<Facture> Post([FromBody] Facture newFacture)
        {
            if (ModelState.IsValid)
            {
                // TODO : Ajouter la nouvelle facture à la collection
                newFacture.Created = DateTime.Now;
                newFacture.Expected = newFacture.Created + TimeSpan.FromDays(30);               
                _data.ajouterFacture(newFacture);
                return Created($"factures/{newFacture.NumeroFacture}", newFacture);
            }
            else
            {
                return BadRequest(ModelState.Values);
            }
        }
    }
}
