using LunchManager.DTO;
using LunchManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace LunchManager.Controllers
{
    [ApiController]
    [Route("AccountRoles")]
    public class AccountRoleControllers : Controller
    {
        [HttpGet]
        public List<AccountRole> SelectAllAccountRoles()
        {
            return (from AccountRole in new LunchManageDBContext().AccountRoles
                    select AccountRole).ToList();
        }
        [HttpGet("{id}")]
        public List<AccountRole> AccSelectId(int id)
        {
            return (from AccountRole in new LunchManageDBContext().AccountRoles
                    where AccountRole.Id == id
                    select AccountRole).ToList();
        }
        [HttpPost()]
        public int AccInsert(AccountRole obj)
        {
            var context = new LunchManageDBContext();
            context.AccountRoles.Add(obj);
            return context.SaveChanges();
        }
        [HttpPut("{id}")]
        public int AccUpdate(int id, AccountRole obj)
        {
            var context = new LunchManageDBContext();
            var item = (from AccountRole in context.AccountRoles
                        where AccountRole.Id == id
                        select AccountRole).FirstOrDefault();
            if (item != null)
            {
                item.AccountId = obj.AccountId;
                item.RoleId = obj.RoleId;
            }
            else { return 0; }
            return context.SaveChanges();
        }
        [HttpDelete("{id}")]
        public int AccDelete(int id)
        {
            var context = new LunchManageDBContext();
            var item = (from AccountRole in context.AccountRoles
                        where AccountRole.Id == id
                        select AccountRole).FirstOrDefault();
            if (item != null)
            {
                context.AccountRoles.Remove(item);
            }
            else { return 0; }
            return context.SaveChanges();

        }
    }
}