using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LunchManager.DTO
{
    [Table("Accounts")]
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }
        public string Password { get; set; }

        public Account(int id, string name, int departmentID,string password)
        {
            Id = id;
            Name = name;
            DepartmentID = departmentID;
            Password = password;
        }

        public Account()
        {
        }
    }
}
    