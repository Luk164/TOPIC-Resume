namespace MainLib.Entities
{
    public class Award : BaseEntity
    {
        public string title { get; set; }
        public string date { get; set; }
        public string awarder { get; set; }
        public string summary { get; set; }
    }
}