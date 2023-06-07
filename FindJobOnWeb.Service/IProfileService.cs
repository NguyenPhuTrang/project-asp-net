using FindJobOnWeb.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobOnWeb.Service
{
    public interface IProfileService
    {
        IEnumerable<Profile> GetAllProfile();
        Profile GetProfile(int id);
        void InsertProfile(Profile profile);
        void UpdateProfile(Profile profile);
        void DeleteProfile(int id);
    }
}
