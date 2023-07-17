using LunchManager.DTO;
using LunchManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace LunchManager.Controllers
{
    [ApiController]
    [Route("Feedbacks")]
    public class FeedbackControllers : Controller
    {
        [HttpGet]
        public List<Feedback> FBSelectAll()
        {
            return (from Feedback in new LunchManageDBContext().Feedbacks
                    select Feedback).ToList();
        }
        [HttpGet("{id}")]
        public List<Feedback> FBSelectId(int id)
        {
            return (from Feedback in new LunchManageDBContext().Feedbacks
                    where Feedback.Id == id
                    select Feedback).ToList();
        }
        [HttpPost()]
        public int FBInsert(Feedback obj)
        {
            var context = new LunchManageDBContext();
            context.Feedbacks.Add(obj);
            return context.SaveChanges();
        }
        [HttpPut("{id}")]
        public int FBUpdate(int id, Feedback obj)
        {
            var context = new LunchManageDBContext();
            var item = (from Feedback in context.Feedbacks
                        where Feedback.Id == id
                        select Feedback).FirstOrDefault();
            if (item != null)
            {
                item.RegistrationId = obj.RegistrationId;
                item.Description = obj.Description;
                item.Rate = obj.Rate;
            }
            else { return 0; }
            return context.SaveChanges();
        }
        [HttpDelete("{id}")]
        public int FBDelete(int id)
        {
            var context = new LunchManageDBContext();
            var item = (from Feedback in context.Feedbacks
                        where Feedback.Id == id
                        select Feedback).FirstOrDefault();
            if (item != null)
            {
                context.Feedbacks.Remove((from Feedback in context.Feedbacks
                                         where Feedback.Id == id
                                         select Feedback).FirstOrDefault());
            }
            else { return 0; }
            return context.SaveChanges();

        }
    }
}