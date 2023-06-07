using FindJobOnWeb.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobOnWeb.Service
{
    public interface ICompanyService
    {
        IEnumerable<Company> GetAllCompany();
        Company GetCompany(int id);
        void InsertCompany(Company company);
        void UpdateCompany(Company company);
        void DeleteCompany(int id);
    }
}
