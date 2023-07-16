namespace LunchManager.DTO
{
    public class Holiday
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Description { get; set;}

        public Holiday(int id, string name, string date, string description)
        {
            Id = id;
            Name = name;
            Date = date;
            Description = description;
        }
    }
}
