using FindJobOnWeb.Model.Entities;
using FindJobOnWeb.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobOnWeb.Service
{
        public class FeedbackService : IFeedbackService
        {
            private readonly IGenericRepository<Feedback> _repository;
            public FeedbackService(IGenericRepository<Feedback> repository)
            {
                _repository = repository;
            }
            public IEnumerable<Feedback> GetAllFeedback()
            {
                return _repository.GetAll();
            }
            public Feedback GetFeedback(int id)
            {
                return _repository.GetById(id);
            }
            public void InsertFeedback(Feedback feedback)
            {
                _repository.Insert(feedback);
            }
            public void UpdateFeedback(Feedback feedback)
            {
                _repository.Update(feedback);
            }
            public void DeleteFeedback(int id)
            {
                _repository.Delete(id);
            }

        public void DeleteFeedback(Feedback feedback)
        {
            throw new NotImplementedException();
        }
    }

    }

