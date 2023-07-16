namespace LunchManager.DTO
{
    public class Config
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }

        public Config(int id, string keyConfig, string valueConfig)
        {
            Id = id;
            Key = keyConfig;
            Value = valueConfig;
        }
    }
}
