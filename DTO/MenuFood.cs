namespace LunchManager.DTO
{
    public class MenuFood
    {
        public int Id { get; set; }
        public int FoodId { get; set; }
        public int MenuId { get; set; }

        public MenuFood(int id, int foodId, int menuId)
        {
            Id = id;
            FoodId = foodId;
            MenuId = menuId;
        }
    }
}
