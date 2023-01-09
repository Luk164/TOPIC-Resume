namespace MainLib.Entities
{
    public class Education : BaseEntity
    {
        public string institution { get; set; }
        public string url { get; set; }
        public string area { get; set; }
        public string studyType { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string score { get; set; }

        //Only supported directly in pgsql, needs converter otherwise
        public string[] courses { get; set; }
    }
}