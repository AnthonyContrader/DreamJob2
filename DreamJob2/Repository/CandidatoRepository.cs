using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DreamJob2.DBContexts;
using DreamJob2.Models;
using Microsoft.EntityFrameworkCore;

namespace DreamJob2.Repository
{
    public class CandidatoRepository : ICandidatoRepository
    {
        private readonly DreamJobContext _dbContext;
        public CandidatoRepository(DreamJobContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteCandidato(int id)
        {
            var candidato = _dbContext.Candidato.Find(id);
            _dbContext.Candidato.Remove(candidato);
            Save();
        }

        public IEnumerable<Candidato> GetCandidati()
        {
            return _dbContext.Candidato.ToList();
        }

        public Candidato GetCandidatoById(int id)
        {
            return _dbContext.Candidato.Find(id);
        }

        public void InsertCandidato(Candidato candidato)
        {
            _dbContext.Add(candidato);
            Save();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdateCandidato(Candidato candidato)
        {
            _dbContext.Entry(candidato).State = EntityState.Modified;
            Save();
        }
    }
}
