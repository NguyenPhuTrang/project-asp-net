using FindJobOnWeb.Model.Entities;
using FindJobOnWeb.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobOnWeb.Service
{
    class ProfileSkillService : IProfileSkillService
    {
        private readonly IGenericRepository<ProfileSkill> _repository;
        public ProfileSkillService(IGenericRepository<ProfileSkill> repository)
        {
            _repository = repository;
        }
        public IEnumerable<ProfileSkill> GetAllProfileSkill()
        {
            return _repository.GetAll();
        }
        public ProfileSkill GetProfileSkill(int id)
        {
            return _repository.GetById(id);
        }
        public void InsertProfileSkill(ProfileSkill profileskill)
        {
            _repository.Insert(profileskill);
        }
        public void UpdateProfileSkill(ProfileSkill profileskill)
        {
            _repository.Update(profileskill);
        }
        public void DeleteProfileSkill(int id)
        {
            _repository.Delete(id);
        }

    }
}
