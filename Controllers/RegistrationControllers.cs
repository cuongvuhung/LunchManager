using LunchManager.DTO;
using LunchManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace LunchManager.Controllers
{
    [ApiController]
    [Route("Registrations")]
    public class RegistrationControllers : Controller
    {
        [HttpGet]
        public List<Registration> RegSelectAll()
        {
            return (from Registration in new LunchManageDBContext().Registrations
                    select Registration).ToList();
        }
        [HttpGet("{id}")]
        public List<Registration> RegSelectId(int id)
        {
            return (from Registration in new LunchManageDBContext().Registrations
                    where Registration.Id == id
                    select Registration).ToList();
        }
        [HttpPost()]
        public int RegInsert(Registration obj)
        {
            var context = new LunchManageDBContext();
            context.Registrations.Add(obj);
            return context.SaveChanges();
        }
        [HttpPut("{id}")]
        public int RegUpdate(int id, Registration obj)
        {
            var context = new LunchManageDBContext();
            var item = (from Registration in context.Registrations
                        where Registration.Id == id
                        select Registration).FirstOrDefault();
            if (item != null)
            {
                item.Date = obj.Date;
                item.StatusReg = obj.StatusReg;
                item.TypeReg    = obj.TypeReg;
                item.AccountId = obj.AccountId;
                item.Quantity = obj.Quantity;
            }
            else { return 0; }
            return context.SaveChanges();
        }
        [HttpDelete("{id}")]
        public int RegDelete(int id)
        {
            var context = new LunchManageDBContext();
            var item = (from Registration in context.Registrations
                        where Registration.Id == id
                        select Registration).FirstOrDefault();
            if (item != null)
            {
                context.Registrations.Remove((from Registration in context.Registrations
                                         where Registration.Id == id
                                         select Registration).FirstOrDefault());
            }
            else { return 0; }
            return context.SaveChanges();

        }
    }
}