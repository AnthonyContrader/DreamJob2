using DreamJob2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DreamJob2.Repository
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetCompanies();
        Company GetCompanyById(int id);
        void InsertCompany(Company company);
        void DeleteCompany(int id);
        void UpdateCompany(Company company);
        void Save();
    }
}
