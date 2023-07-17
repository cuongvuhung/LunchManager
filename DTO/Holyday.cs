using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LunchManager.DTO
{
    [Table("Holydays")]
    public class Holyday
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Description { get; set;}

        public Holyday(int id, string name, string date, string description)
        {
            Id = id;
            Name = name;
            Date = date;
            Description = description;
        }

        public Holyday()
        {
        }
    }
}
