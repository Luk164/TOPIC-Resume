namespace MainLib.Entities
{
    public class Certificate : BaseEntity
    {
        public string name { get; set; }
        public string date { get; set; }
        public string issuer { get; set; }
        public string url { get; set; }
    }

}