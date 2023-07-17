using LunchManager.DTO;
using LunchManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace LunchManager.Controllers
{
    [ApiController]
    [Route("Configs")]
    public class ConfigControllers : Controller
    {
        [HttpGet]
        public List<Config> CfgSelectAll()
        {
            return (from Config in new LunchManageDBContext().Configs
                    select Config).ToList();
        }
        [HttpGet("{id}")]
        public List<Config> CfgSelectId(int id)
        {
            return (from Config in new LunchManageDBContext().Configs
                    where Config.Id == id
                    select Config).ToList();
        }
        [HttpPost()]
        public int CfgInsert(Config obj)
        {
            var context = new LunchManageDBContext();
            context.Configs.Add(obj);
            return context.SaveChanges();
        }
        [HttpPut("{id}")]
        public int CfgUpdate(int id, Config obj)
        {
            var context = new LunchManageDBContext();
            var item = (from Config in context.Configs
                        where Config.Id == id
                        select Config).FirstOrDefault();
            if (item != null)
            {
                item.Key = obj.Key;
                item.Value = obj.Value;
            }
            else { return 0; }
            return context.SaveChanges();
        }
        [HttpDelete("{id}")]
        public int CfgDelete(int id)
        {
            var context = new LunchManageDBContext();
            var item = (from Config in context.Configs
                        where Config.Id == id
                        select Config).FirstOrDefault();
            if (item != null)
            {
                context.Configs.Remove((from Config in context.Configs
                                         where Config.Id == id
                                         select Config).FirstOrDefault());
            }
            else { return 0; }
            return context.SaveChanges();

        }
    }
}