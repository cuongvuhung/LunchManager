using LunchManager.DTO;
using LunchManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace LunchManager.Controllers
{
    [ApiController]
    [Route("Menus")]
    public class MenuControllers : Controller
    {
        [HttpGet]
        public List<Menu> MnuSelectAll()
        {
            return (from Menu in new LunchManageDBContext().Menus
                    select Menu).ToList();
        }
        [HttpGet("{id}")]
        public List<Menu> MnuSelectId(int id)
        {
            return (from Menu in new LunchManageDBContext().Menus
                    where Menu.Id == id
                    select Menu).ToList();
        }
        [HttpPost()]
        public int MnuInsert(Menu obj)
        {
            var context = new LunchManageDBContext();
            context.Menus.Add(obj);
            return context.SaveChanges();
        }
        [HttpPut("{id}")]
        public int MnuUpdate(int id, Menu obj)
        {
            var context = new LunchManageDBContext();
            var item = (from Menu in context.Menus
                        where Menu.Id == id
                        select Menu).FirstOrDefault();
            if (item != null)
            {
                item.Date = obj.Date;
            }
            else { return 0; }
            return context.SaveChanges();
        }
        [HttpDelete("{id}")]
        public int MnuDelete(int id)
        {
            var context = new LunchManageDBContext();
            var item = (from Menu in context.Menus
                        where Menu.Id == id
                        select Menu).FirstOrDefault();
            if (item != null)
            {
                context.Menus.Remove((from Menu in context.Menus
                                         where Menu.Id == id
                                         select Menu).FirstOrDefault());
            }
            else { return 0; }
            return context.SaveChanges();

        }
    }
}