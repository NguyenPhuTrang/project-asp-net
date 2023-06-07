using FindJobOnWeb.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobOnWeb.Service
{
    public interface IProfileSkillService
    {
        IEnumerable<ProfileSkill> GetAllProfileSkill();
        ProfileSkill GetProfileSkill(int id);
        void InsertProfileSkill(ProfileSkill profileskill);
        void UpdateProfileSkill(ProfileSkill profileskill);
        void DeleteProfileSkill(int id);
    }
}
