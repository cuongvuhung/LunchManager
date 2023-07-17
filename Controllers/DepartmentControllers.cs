using LunchManager.DTO;
using LunchManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace LunchManager.Controllers
{
    [ApiController]
    [Route("Departments")]
    public class DepartmentControllers : Controller
    {
        [HttpGet]
        public List<Department> SelectAllDepartments()
        {
            return (from Department in new LunchManageDBContext().Departments
                    select Department).ToList();
        }
        [HttpGet("{id}")]
        public List<Department> CfgSelectId(int id)
        {
            return (from Department in new LunchManageDBContext().Departments
                    where Department.Id == id
                    select Department).ToList();
        }
        [HttpPost()]
        public int CfgInsert(Department obj)
        {
            var context = new LunchManageDBContext();
            context.Departments.Add(obj);
            return context.SaveChanges();
        }
        [HttpPut("{id}")]
        public int CfgUpdate(int id, Department obj)
        {
            var context = new LunchManageDBContext();
            var item = (from Departments in context.Departments
                        where Departments.Id == id
                        select Departments).FirstOrDefault();
            if (item != null)
            {
                item.Name = obj.Name;
                item.Description = obj.Description;
            }
            else { return 0; }
            return context.SaveChanges();
        }
        [HttpDelete("{id}")]
        public int CfgDelete(int id)
        {
            var context = new LunchManageDBContext();
            var item = (from Department in context.Departments
                        where Department.Id == id
                        select Department).FirstOrDefault();
            if (item != null)
            {
                context.Departments.Remove(item);
            }
            else { return 0; }
            return context.SaveChanges();

        }
    }
}