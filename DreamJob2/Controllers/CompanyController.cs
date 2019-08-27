using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using DreamJob2.Models;
using DreamJob2.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DreamJob2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepository _companyRepository;
        public CompanyController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }
        public IActionResult Get()
        {
            var companies = _companyRepository.GetCompanies();
            return new OkObjectResult(companies);
        }

        // GET: api/Company/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var company = _companyRepository.GetCompanyById(id);
            return new OkObjectResult(company);
        }

        // POST: api/Company
        [HttpPost]
        public IActionResult Post([FromBody] Company company)
        {
            using (var scope = new TransactionScope())
            {
                _companyRepository.InsertCompany(company);
                scope.Complete();
                return CreatedAtAction(nameof(Get), new { id = company.id }, company);
            }
        }

        // PUT: api/Company/5
        [HttpPut]
        public IActionResult Put([FromBody] Company company)
        {
            if (company != null)
            {
                using (var scope = new TransactionScope())
                {
                    _companyRepository.UpdateCompany(company);
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
            _companyRepository.DeleteCompany(id);
            return new OkResult();
        }
    }
}
