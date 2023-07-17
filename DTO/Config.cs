using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LunchManager.DTO
{
    [Table("Configs")]
    public class Config
    {
        [Key]
        public int Id { get; set; }
        public string Key1 { get; set; }
        public string Value { get; set; }

        public Config(int id, string key1, string value)
        {
            Id = id;
            Key1 = key1;
            Value = value;
        }

        public Config()
        {
        }
    }
}
