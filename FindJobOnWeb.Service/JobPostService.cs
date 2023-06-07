
using FindJobOnWeb.Model.Entities;
using FindJobOnWeb.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobOnWeb.Service
{
    public class JobPostService : IJobPostService
    {
        private readonly IGenericRepository<JobPost> _repository;
        public JobPostService(IGenericRepository<JobPost> repository)
        {
            _repository = repository;
        }
        public IEnumerable<JobPost> GetAllJobPost()
        {
            return _repository.GetAll();
        }
        public JobPost GetJobPost(int id)
        {
            return _repository.GetById(id);
        }
        public void InsertJobPost(JobPost jobPost)
        {
            _repository.Insert(jobPost);
        }
        public void UpdateJobPost(JobPost jobPost)
        {
            _repository.Update(jobPost);
        }
        public void DeleteJobPost(int id)
        {
            _repository.Delete(id);
        }

    }
}
