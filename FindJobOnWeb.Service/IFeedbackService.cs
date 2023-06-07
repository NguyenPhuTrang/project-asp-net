using FindJobOnWeb.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobOnWeb.Service
{
        public interface IFeedbackService
    {
        IEnumerable<Feedback> GetAllFeedback();
        Feedback GetFeedback(int id);
        void InsertFeedback(Feedback feedback);
        void UpdateFeedback(Feedback feedback);
        void DeleteFeedback(int id);
    }
}
