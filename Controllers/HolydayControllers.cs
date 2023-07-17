using LunchManager.DTO;
using LunchManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace LunchManager.Controllers
{
    [ApiController]
    [Route("Holydays")]
    public class HolydayControllers : Controller
    {
        [HttpGet]
        public List<Holyday> HldSelectAll()
        {
            return (from Holyday in new LunchManageDBContext().Holydays
                    select Holyday).ToList();
        }
        [HttpGet("{id}")]
        public List<Holyday> HldSelectId(int id)
        {
            return (from Holyday in new LunchManageDBContext().Holydays
                    where Holyday.Id == id
                    select Holyday).ToList();
        }
        [HttpPost()]
        public int HldInsert(Holyday obj)
        {
            var context = new LunchManageDBContext();
            context.Add(obj);
            return context.SaveChanges();
        }
        [HttpPut("{id}")]
        public int HldUpdate(int id, Holyday obj)
        {
            var context = new LunchManageDBContext();
            var item = (from Holyday in context.Holydays
                        where Holyday.Id == id
                        select Holyday).FirstOrDefault();
            if (item != null)
            {
                item.Description = obj.Description;
                item.Date = obj.Date;
            }
            else { return 0; }
            return context.SaveChanges();
        }
        [HttpDelete("{id}")]
        public int HldDelete(int id)
        {
            var context = new LunchManageDBContext();
            var item = (from Holyday in context.Holydays
                        where Holyday.Id == id
                        select Holyday).FirstOrDefault();
            if (item != null)
            {
                context.Holydays.Remove((from Holyday in context.Holydays
                                         where Holyday.Id == id
                                         select Holyday).FirstOrDefault());
            }
            else { return 0; }
            return context.SaveChanges();

        }
    }
}