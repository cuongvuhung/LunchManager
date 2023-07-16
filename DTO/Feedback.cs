namespace LunchManager.DTO
{
    public class Feedback
    {
        public int Id { get; set; }
        public int RegistrationId { get; set; }
        public string Description { get; set; }
        public int Rate { get; set; }
        public Feedback(int id, int registrationId, string description,int rate)
        {
            Id = id;
            RegistrationId = registrationId;
            Description = description;
            Rate = rate;
        }
    }
}
