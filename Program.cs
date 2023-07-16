using LunchManager.DTO;
using LunchManager.Models;
using System.Data;

namespace LunchManager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");
            //ACCOUNTS
            app.MapPost("/Accounts", (Account item) =>
            {
                item.Password = Utils.Hash(item.Password);
                string str = $"Insert,accounts,{item.Name},{item.DepartmentID},{item.Password}";
                int result = DAL.SQLExecute(str);
                return $"{result} rows effected";
            });
            app.MapPut("/Accounts", (Account item) =>
            {
                item.Password = Utils.Hash(item.Password);
                string str = $"Update,accounts,{item.Id},name,{item.Name},departmentid,{item.DepartmentID},password,{item.Password}";
                int result = DAL.SQLExecute(str);
                return $"{result} rows effected";
            });            
            //ACCOUNTROLES
            app.MapPost("/AccountRoles", (AccountRole item) =>
            {               
                string str = $"Insert,accountsroles,{item.AcountId},{item.RoleId}";
                int result = DAL.SQLExecute(str);
                return $"{result} rows effected";
            });
            app.MapPut("/AccountRoles", (AccountRole item) =>
            {
                string str = $"Update,accountsroles,{item.Id},accountid,{item.AcountId},roleid,{item.RoleId}";
                int result = DAL.SQLExecute(str);
                return $"{result} rows effected";
            });

            //DEPARTMENTS
            app.MapPost("/Departments", (Department item) =>
            {
                string str = $"Insert,departments,{item.Name},{item.Description}";
                int result = DAL.SQLExecute(str);
                return $"{result} rows effected";
            });
            app.MapPut("/Departments", (Department item) =>
            {
                string str = $"Update,departments,{item.Id},name,{item.Name},description,{item.Description}";
                int result = DAL.SQLExecute(str);
                return $"{result} rows effected";
            });

            //FEEDBACKS
            app.MapPost("/Feedbacks", (Feedback item) =>
            {
                string str = $"Insert,feedbacks,{item.RegistrationId},{item.Description},{item.Rate}";
                int result = DAL.SQLExecute(str);
                return $"{result} rows effected";
            });
            app.MapPut("/Feedbacks", (Feedback item) =>
            {
                string str = $"Update,feedbacks,{item.Id},registrationid,{item.RegistrationId},description,{item.Description},rate,{item.Rate}";
                int result = DAL.SQLExecute(str);
                return $"{result} rows effected";
            });
            //FOODS
            app.MapPost("/Foods", (Food item) =>
            {
                string str = $"Insert,foods,{item.Name}";
                int result = DAL.SQLExecute(str);
                return $"{result} rows effected";
            });
            app.MapPut("/Foods", (Food item) =>
            {
                string str = $"Update,foods,{item.Id},name,{item.Name}";
                int result = DAL.SQLExecute(str);
                return $"{result} rows effected";
            });
            //HOLYDAYS
            app.MapPost("/Holidays", (Holiday item) =>
            {
                string str = $"Insert,foods,{item.Name},{item.Date},{item.Description}";
                int result = DAL.SQLExecute(str);
                return $"{result} rows effected";
            });
            app.MapPut("/Holidays", (Holiday item) =>
            {
                string str = $"Update,foods,{item.Id},name,{item.Name},date,{item.Date},description,{item.Description}";
                int result = DAL.SQLExecute(str);
                return $"{result} rows effected";
            });
            //MENUS
            app.MapPost("/Menus", (Menu item) =>
            {
                string str = $"Insert,menus,{item.Date}";
                int result = DAL.SQLExecute(str);
                return $"{result} rows effected";
            });
            app.MapPut("/Menus", (Menu item) =>
            {
                string str = $"Update,menus,{item.Id},date,{item.Date}";
                int result = DAL.SQLExecute(str);
                return $"{result} rows effected";
            });
            //MENUFOODS
            app.MapPost("/Menufoods", (MenuFood item) =>
            {
                string str = $"Insert,menufoods,{item.FoodId},{item.MenuId}";
                int result = DAL.SQLExecute(str);
                return $"{result} rows effected";
            });
            app.MapPut("/Menufoods", (MenuFood item) =>
            {
                string str = $"Update,menufoods,{item.Id},foodid,{item.FoodId},menuid,{item.MenuId}";
                int result = DAL.SQLExecute(str);
                return $"{result} rows effected";
            });

            //REGISTRATIONS
            app.MapPost("/Registrations", (Registration item) =>
            {
                string str = $"Insert,menufoods,{item.AcountId},{item.Date},{item.Quantity},{item.TypeReg},{item.StatusReg}";
                int result = DAL.SQLExecute(str);
                return $"{result} rows effected";
            });
            app.MapPut("/Registrations", (Registration item) =>
            {
                string str = $"Update,menufoods,{item.Id},accountid,{item.AcountId},date,{item.Date},quantity,{item.Quantity},typereg,{item.TypeReg},statusreg,{item.StatusReg}";
                int result = DAL.SQLExecute(str);
                return $"{result} rows effected";
            });

            //ROLES
            app.MapPost("/Roles", (Role item) =>
            {
                string str = $"Insert,menufoods,{item.Name},{item.Description}";
                int result = DAL.SQLExecute(str);
                return $"{result} rows effected";
            });
            app.MapPut("/Roles", (Role item) =>
            {
                string str = $"Update,menufoods,{item.Id},name,{item.Name},description,{item.Description}";
                int result = DAL.SQLExecute(str);
                return $"{result} rows effected";
            });

            //DELETE FOR ALL
            app.MapDelete("/{table}/{id}", (string table, int id) =>
            {
                string str = $"Delete,{table},id,{id}";
                int result = DAL.SQLExecute(str);
                return $"{result} rows effected";
            });
            app.Run();
        }
    }
}