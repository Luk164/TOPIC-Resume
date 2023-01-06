namespace MainLib.Entities
{
    public class Education
    {
        public string institution { get; set; }
        public string url { get; set; }
        public string area { get; set; }
        public string studyType { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string score { get; set; }

        //Only supported in pgsql
        public IList<string> courses { get; set; }
    }

}