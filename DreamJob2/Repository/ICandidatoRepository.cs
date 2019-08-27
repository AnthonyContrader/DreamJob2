using DreamJob2.Models;
using System.Collections.Generic;

namespace DreamJob2.Repository
{
    public interface ICandidatoRepository
    {
        IEnumerable<Candidato> GetCandidati();
        Candidato GetCandidatoById(int id);
        void InsertCandidato(Candidato candidato);
        void DeleteCandidato(int id);
        void UpdateCandidato(Candidato candidato);
        void Save();
    }
}
