using LunchManager.DTO;
using LunchManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace LunchManager.Controllers
{
    [ApiController]
    [Route("MenuFoods")]
    public class MenuFoodControllers : Controller
    {
        [HttpGet]
        public List<MenuFood> MnFoSelectAll()
        {
            return (from MenuFood in new LunchManageDBContext().MenuFoods
                    select MenuFood).ToList();
        }
        [HttpGet("{id}")]
        public List<MenuFood> MnFoSelectId(int id)
        {
            return (from MenuFood in new LunchManageDBContext().MenuFoods
                    where MenuFood.Id == id
                    select MenuFood).ToList();
        }
        [HttpPost()]
        public int MnFoInsert(MenuFood obj)
        {
            var context = new LunchManageDBContext();
            context.MenuFoods.Add(obj);
            return context.SaveChanges();
        }
        [HttpPut("{id}")]
        public int MnFoUpdate(int id, MenuFood obj)
        {
            var context = new LunchManageDBContext();
            var item = (from MenuFood in context.MenuFoods
                        where MenuFood.Id == id
                        select MenuFood).FirstOrDefault();
            if (item != null)
            {
                item.MenuId = obj.MenuId;
                item.FoodId = obj.FoodId;
            }
            else { return 0; }
            return context.SaveChanges();
        }
        [HttpDelete("{id}")]
        public int MnFoDelete(int id)
        {
            var context = new LunchManageDBContext();
            var item = (from MenuFood in context.MenuFoods
                        where MenuFood.Id == id
                        select MenuFood).FirstOrDefault();
            if (item != null)
            {
                context.MenuFoods.Remove((from MenuFood in context.MenuFoods
                                         where MenuFood.Id == id
                                         select MenuFood).FirstOrDefault());
            }
            else { return 0; }
            return context.SaveChanges();

        }
    }
}