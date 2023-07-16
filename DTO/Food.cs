namespace LunchManager.DTO
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Food(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
