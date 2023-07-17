using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LunchManager.DTO
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        public int Id { get; set; }
        public string Date { get; set; }

        public Menu(int id, string date)
        {
            Id = id;
            Date = date;
        }

        public Menu()
        {
        }
    }
}
