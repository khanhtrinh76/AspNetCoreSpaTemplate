using AspnetCoreSPATemplate.Models;
using AspnetCoreSPATemplate.Services;
using AspnetCoreSPATemplate.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AspnetCoreSPATemplate.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        IConfiguration _configuration;
        ICustomerServices _customerServices;
        private readonly string _dataPathFile;

        public CustomerController(IConfiguration configuration)
        {
            _configuration = configuration;
            _dataPathFile = Environment.CurrentDirectory + _configuration["DataFilePath"];

            ICsvReader csvReader = new CsvReader();
            _customerServices = new CustomerServices (csvReader);
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet("[action]")]
        public IEnumerable<Customer> GetAllCustomers()
        {
            return _customerServices.GetAllCustomersFromCsv(_dataPathFile);
        }

        [HttpGet("[action]")]
        public IEnumerable<Customer> Search(string term)
        {

            term = term != null ? term : string.Empty;
            return _customerServices.GetAllCustomersFromCsv(_dataPathFile)
                                          .Where(x => (x.FirstName != null && x.FirstName.ToLower().Contains(term.ToLower()))
                                                    || (x.LastName != null && x.LastName.ToLower().Contains(term.ToLower()))
                                                    || (x.CompanyName != null && x.CompanyName.ToLower().Contains(term.ToLower()))
                                                    || (x.Address != null && x.Address.ToLower().Contains(term.ToLower()))
                                                    || (x.City != null && x.City.ToLower().Contains(term.ToLower()))
                                                    || (x.State != null && x.State.ToLower().Contains(term.ToLower()))
                                                    || (x.Post != null && x.Post.ToLower().Contains(term.ToLower()))
                                                    || (x.Phone1 != null && x.Phone1.ToLower().Contains(term.ToLower()))
                                                    || (x.Phone2 != null && x.Phone2.ToLower().Contains(term.ToLower()))
                                                    || (x.Email != null && x.Email.ToLower().Contains(term.ToLower()))
                                                    || (x.Web != null && x.Web.ToLower().Contains(term.ToLower())));
        }
    }
}