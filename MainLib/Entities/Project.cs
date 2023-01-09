namespace MainLib.Entities
{
    public class Project : BaseEntity
    {
        public string name { get; set; }
        public string description { get; set; }
        public string[] highlights { get; set; }
        public string[] keywords { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string url { get; set; }
        public string[] roles { get; set; }
        public string entity { get; set; }
        public string type { get; set; }
    }

}