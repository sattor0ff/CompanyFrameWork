using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CompanyController:ControllerBase
{
   
        private readonly CompanyService _companyService;

        public CompanyController(CompanyService companyService)
        {
                _companyService = companyService;
        }

        [HttpGet]
        public List<CompanyDto> GetCompanies()
        {
                return _companyService.GetCompanies();
        }
        
        
        [HttpGet("SearchCompany")]
        public List<CompanyDto> GetCompanies([FromQuery] string name)
        {
                return _companyService.GetCompanyByName(name);
        }
        

        [HttpPost]
        public bool AddCompany(AddCompanyDto company)
        {
                _companyService.AddCompany(company);
                return true;
        }
        
        
}