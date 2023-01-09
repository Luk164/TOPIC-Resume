namespace MainLib.Entities
{
    public class Publication : BaseEntity
    {
        public string name { get; set; }
        public string publisher { get; set; }
        public string releaseDate { get; set; }
        public string url { get; set; }
        public string summary { get; set; }
    }

}