using FindJobOnWeb.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobOnWeb.Service
{
    public interface IJobPostService
    {
        IEnumerable<JobPost> GetAllJobPost();
        JobPost GetJobPost(int id);
        void InsertJobPost(JobPost jobPost);
        void UpdateJobPost(JobPost jobPost);
        void DeleteJobPost(int id);
    }
}
