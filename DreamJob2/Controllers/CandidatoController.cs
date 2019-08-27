using System.Transactions;
using DreamJob2.Models;
using DreamJob2.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DreamJob2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatoController : ControllerBase
    {
        private readonly ICandidatoRepository _candidatoRepository;
        public CandidatoController(ICandidatoRepository candidatoRepository)
        {
            _candidatoRepository = candidatoRepository;
        }

        // GET: api/Candidato
        [HttpGet]
        public IActionResult Get()
        {
            var candidati = _candidatoRepository.GetCandidati();
            return new OkObjectResult(candidati);
        }

        // GET: api/Candidato/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var candidato = _candidatoRepository.GetCandidatoById(id);
            return new OkObjectResult(candidato);
        }

        // POST: api/Candidato
        [HttpPost]
        public IActionResult Post([FromBody] Candidato candidato)
        {
            using (var scope = new TransactionScope())
            {
                _candidatoRepository.InsertCandidato(candidato);
                scope.Complete();
                return CreatedAtAction(nameof(Get), new { id = candidato.id }, candidato);
            }
        }

        // PUT: api/Candidato/5
        [HttpPut]
        public IActionResult Put([FromBody] Candidato candidato)
        {
            if (candidato != null)
            {
                using (var scope = new TransactionScope())
                {
                    _candidatoRepository.UpdateCandidato(candidato);
                    scope.Complete();
                    return new OkResult();
                }
            }
            return new NoContentResult();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _candidatoRepository.DeleteCandidato(id);
            return new OkResult();
        }
    }
}
