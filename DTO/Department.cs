using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LunchManager.DTO
{
    [Table("Departments")]
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Department(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public Department()
        {
        }
    }
}
