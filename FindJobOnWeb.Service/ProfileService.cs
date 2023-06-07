using FindJobOnWeb.Model.Entities;
using FindJobOnWeb.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobOnWeb.Service
{
    public class ProfileService : IProfileService
    {
        private readonly IGenericRepository<Profile> _repository;
        public ProfileService(IGenericRepository<Profile> repository)
        {
            _repository = repository;
        }
        public IEnumerable<Profile> GetAllProfile()
        {
            return _repository.GetAll();
        }
        public Profile GetProfile(int id)
        {
            return _repository.GetById(id);
        }
        public void InsertProfile(Profile profile)
        {
            _repository.Insert(profile);
        }
        public void UpdateProfile(Profile profile)
        {
            _repository.Update(profile);
        }
        public void DeleteProfile(int id)
        {
            _repository.Delete(id);
        }

    }
}
