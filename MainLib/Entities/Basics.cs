namespace MainLib.Entities
{
    public class Basics
    {
        public string name { get; set; }
        public string label { get; set; }
        public string image { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string url { get; set; }
        public string summary { get; set; }
        public Location? location { get; set; }
        public virtual IList<Profile> profiles { get; set; }
    }

}