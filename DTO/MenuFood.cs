using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LunchManager.DTO
{
    [Table("MenuFoods")]
    public class MenuFood
    {
        [Key]
        public int Id { get; set; }
        public int FoodId { get; set; }
        public int MenuId { get; set; }

        public MenuFood(int id, int foodId, int menuId)
        {
            Id = id;
            FoodId = foodId;
            MenuId = menuId;
        }

        public MenuFood()
        {
        }

    }
}
