using LunchManager.DTO;
using LunchManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace LunchManager.Controllers
{
    [ApiController]
    [Route("Accounts")]
    public class AccountControllers : Controller
    {
        [HttpGet]
        public List<Account> SelectAllAccounts()
        {
            return (from Account in new LunchManageDBContext().Accounts
                    select Account).ToList();
        }
        [HttpGet("{id}")]
        public List<Account> AccSelectId(int id)
        {
            return (from Account in new LunchManageDBContext().Accounts
                    where Account.Id == id
                    select Account).ToList();
        }
        [HttpPost()]
        public int AccInsert(Account Acc)
        {
            var context = new LunchManageDBContext();
            context.Accounts.Add(Acc);
            return context.SaveChanges();
        }
        [HttpPut("{id}")]
        public int AccUpdate(int id, Account Acc)
        {
            var context = new LunchManageDBContext();
            var item = (from Account in context.Accounts
                        where Account.Id == id
                        select Account).FirstOrDefault();
            if (item != null)
            {
                item.Name = Acc.Name;
                item.DepartmentID = Acc.DepartmentID;
                item.Password = Acc.Password;
            }
            else { return 0; }
            return context.SaveChanges();
        }
        [HttpDelete("{id}")]
        public int AccDelete(int id)
        {
            var context = new LunchManageDBContext();
            var item = (from Account in context.Accounts
                        where Account.Id == id
                        select Account).FirstOrDefault();
            if (item != null)
            {
                context.Accounts.Remove(item);
            }
            else { return 0; }
            return context.SaveChanges();

        }
    }
}