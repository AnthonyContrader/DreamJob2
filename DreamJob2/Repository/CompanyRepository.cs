using DreamJob2.DBContexts;
using DreamJob2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DreamJob2.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly DreamJobContext _dbContext;
        public CompanyRepository(DreamJobContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteCompany(int id)
        {
            var company = _dbContext.Company.Find(id);
            _dbContext.Company.Remove(company);
            Save();
        }
        public Company GetCompanyById(int id)
        {
            return _dbContext.Company.Find(id);
        }
        public IEnumerable<Company> GetCompanies()
        {
            return _dbContext.Company.ToList();
        }

        public void InsertCompany(Company company)
        {
            _dbContext.Add(company);
            Save();
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
        public void UpdateCompany(Company company)
        {
            _dbContext.Entry(company).State = EntityState.Modified;
            Save();
        }
    }
}

