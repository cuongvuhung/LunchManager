using LunchManager.DTO;
using LunchManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace LunchManager.Controllers
{
    [ApiController]
    [Route("Foods")]
    public class FoodControllers : Controller
    {
        [HttpGet]
        public List<Food> FoodSelectAll()
        {
            return (from Food in new LunchManageDBContext().Foods
                    select Food).ToList();
        }
        [HttpGet("{id}")]
        public List<Food> FoodSelectId(int id)
        {
            return (from Food in new LunchManageDBContext().Foods
                    where Food.Id == id
                    select Food).ToList();
        }
        [HttpPost()]
        public int FoodInsert(Food obj)
        {
            var context = new LunchManageDBContext();
            context.Foods.Add(obj);
            return context.SaveChanges();
        }
        [HttpPut("{id}")]
        public int FoodUpdate(int id, Food obj)
        {
            var context = new LunchManageDBContext();
            var item = (from Food in context.Foods
                        where Food.Id == id
                        select Food).FirstOrDefault();
            if (item != null)
            {
                item.Name = obj.Name;
            }
            else { return 0; }
            return context.SaveChanges();
        }
        [HttpDelete("{id}")]
        public int FoodDelete(int id)
        {
            var context = new LunchManageDBContext();
            var item = (from Food in context.Foods
                        where Food.Id == id
                        select Food).FirstOrDefault();
            if (item != null)
            {
                context.Foods.Remove((from Food in context.Foods
                                         where Food.Id == id
                                         select Food).FirstOrDefault());
            }
            else { return 0; }
            return context.SaveChanges();

        }
    }
}