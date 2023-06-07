using FindJobOnWeb.Model.Entities;
using FindJobOnWeb.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobOnWeb.Service
{
        public class AdminService : IAdminService
    {
        private readonly IGenericRepository<Admin> _repository;
        public AdminService(IGenericRepository<Admin> repository)
        {
            _repository = repository;
        }
        public IEnumerable<Admin> GetAllAdmin()
        {
            return _repository.GetAll();
        }
        public Admin GetAdmin(int id)
        {
            return _repository.GetById(id);
        }
        public void InsertAdmin(Admin admin)
        {
            _repository.Insert(admin);
        }
        public void UpdateAdmin(Admin admin)
        {
            _repository.Update(admin);
        }
        public void DeleteAdmin(int id)
        {
            _repository.Delete(id);
        }

    }
}
