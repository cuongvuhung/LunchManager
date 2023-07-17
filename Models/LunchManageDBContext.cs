
using Microsoft.EntityFrameworkCore;
using LunchManager.DTO;
namespace LunchManager.Models
{
    public class LunchManageDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(new DatabaseConfig().conStr);
        }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountRole> AccountRoles { get; set; }
        public virtual DbSet<Config> Configs { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<Holyday> Holydays { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<MenuFood> MenuFoods { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<Role> Roles { get; set; }

    }
}
