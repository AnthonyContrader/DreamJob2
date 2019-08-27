using DreamJob2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DreamJob2.Repository
{
    interface ICandidatoRepository
    {
        IEnumerable<Candidato> GetCandidati();
        Candidato GetCandidatoById(int id);
        void InsertCandidato(Candidato candidato);
        void DeleteCandidato(int id);
        void UpdateCandidato(Candidato candidato);
        void Save();
    }
}
