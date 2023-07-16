namespace LunchManager.DTO
{
    public class Menu
    {
        public int Id { get; set; }
        public string Date { get; set; }

        public Menu(int id, string date)
        {
            Id = id;
            Date = date;
        }
    }
}
