using LunchManager.DTO;
using LunchManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace LunchManager.Controllers
{
    [ApiController]
    [Route("Roles")]
    public class RoleControllers : Controller
    {
        [HttpGet]
        public List<Role> RleSelectAll()
        {
            return (from Role in new LunchManageDBContext().Roles
                    select Role).ToList();
        }
        [HttpGet("{id}")]
        public List<Role> RleSelectId(int id)
        {
            return (from Role in new LunchManageDBContext().Roles
                    where Role.Id == id
                    select Role).ToList();
        }
        [HttpPost()]
        public int RleInsert(Role obj)
        {
            var context = new LunchManageDBContext();
            context.Roles.Add(obj);
            return context.SaveChanges();
        }
        [HttpPut("{id}")]
        public int RleUpdate(int id, Role obj)
        {
            var context = new LunchManageDBContext();
            var item = (from Role in context.Roles
                        where Role.Id == id
                        select Role).FirstOrDefault();
            if (item != null)
            {
                item.Description = obj.Description;
                item.Name = obj.Name;
            }
            else { return 0; }
            return context.SaveChanges();
        }
        [HttpDelete("{id}")]
        public int RleDelete(int id)
        {
            var context = new LunchManageDBContext();
            var item = (from Role in context.Roles
                        where Role.Id == id
                        select Role).FirstOrDefault();
            if (item != null)
            {
                context.Roles.Remove((from Role in context.Roles
                                         where Role.Id == id
                                         select Role).FirstOrDefault());
            }
            else { return 0; }
            return context.SaveChanges();

        }
    }
}