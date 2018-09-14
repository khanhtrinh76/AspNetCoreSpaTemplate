using AspnetCoreSPATemplate.Models;
using AspnetCoreSPATemplate.Utilities;
using System.Collections.Generic;

namespace AspnetCoreSPATemplate.Services
{
    public interface ICustomerServices
    {
        IEnumerable<Customer> GetAllCustomersFromCsv(string filePath);
    }

    public class CustomerServices : ICustomerServices
    {
        private ICsvReader _csvReader;
        public CustomerServices(ICsvReader csvReader)
        {
            _csvReader = csvReader;
        }

        public IEnumerable<Customer> GetAllCustomersFromCsv(string filePath)
        {
            return _csvReader.ProcessFile<Customer>(filePath);
        }
    }
}
