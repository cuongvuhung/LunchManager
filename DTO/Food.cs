using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LunchManager.DTO
{
    [Table("Foods")]
    public class Food
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public Food(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Food()
        {
        }
    }
}
