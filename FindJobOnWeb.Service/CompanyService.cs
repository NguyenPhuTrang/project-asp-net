using FindJobOnWeb.Model.Entities;
using FindJobOnWeb.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobOnWeb.Service
{
    public class CompanyService : ICompanyService
    {
        private readonly IGenericRepository<Company> _repository;
        public CompanyService(IGenericRepository<Company> repository)
        {
            _repository = repository;
        }
        public IEnumerable<Company> GetAllCompany()
        {
            return _repository.GetAll();
        }
        public Company GetCompany(int id)
        {
            return _repository.GetById(id);
        }
        public void InsertCompany(Company company)
        {
            _repository.Insert(company);
        }
        public void UpdateCompany(Company company)
        {
            _repository.Update(company);
        }
        public void DeleteCompany(int id)
        {
            _repository.Delete(id);
        }

    }
}
