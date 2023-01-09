namespace MainLib.Entities
{
    public class Volunteer : BaseEntity
    {
        public string organization { get; set; }
        public string position { get; set; }
        public string url { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string summary { get; set; }
        public string[] highlights { get; set; }
    }

}