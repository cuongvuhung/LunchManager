namespace LunchManager.DTO
{
    public class Registration
    {
        public int Id { get; set; }
        public int AcountId { get; set; }
        public string Date { get; set; }
        public int Quantity { get; set; }
        public int TypeReg { get; set; }
        public int StatusReg { get; set; }

        public Registration(int id, int acountId, string date, int quantity, int typeReg, int statusReg)
        {
            Id = id;
            AcountId = acountId;
            Date = date;
            Quantity = quantity;
            TypeReg = typeReg;
            StatusReg = statusReg;
        }
    }
    
}

