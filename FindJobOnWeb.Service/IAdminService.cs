using FindJobOnWeb.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobOnWeb.Service
{
        public interface IAdminService
    {
        IEnumerable<Admin> GetAllAdmin();
        Admin GetAdmin(int id);
        void InsertAdmin(Admin admin);
        void UpdateAdmin(Admin admin);
        void DeleteAdmin(int id);
    }
}
