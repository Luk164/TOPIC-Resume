namespace MainLib.Entities
{
    public class Work : BaseEntity
    {
        public string name { get; set; }
        public string position { get; set; }
        public string url { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string summary { get; set; }
        public string[] highlights { get; set; }
    }

}