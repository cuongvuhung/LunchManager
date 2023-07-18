using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LunchManager.DTO
{
    [Table("Configs")]
    public class Config
    {
        [Key]
        public int Id { get; set; }
        public string Ke { get; set; }
        public string Val { get; set; }

        public Config(int id, string ke, string val)
        {
            Id = id;
            Ke = ke;
            Val = val;
        }

        public Config()
        {
        }
    }
}
