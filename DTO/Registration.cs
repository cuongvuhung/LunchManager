using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LunchManager.DTO
{
    [Table("Registrations")]
    public class Registration
    {
        [Key]
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string Date { get; set; }
        public int Quantity { get; set; }
        public int TypeReg { get; set; }
        public int StatusReg { get; set; }

        public Registration(int id, int accountId, string date, int quantity, int typeReg, int statusReg)
        {
            Id = id;
            AccountId = accountId;
            Date = date;
            Quantity = quantity;
            TypeReg = typeReg;
            StatusReg = statusReg;
        }

        public Registration()
        {
        }
    }
    
}

