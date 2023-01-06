namespace MainLib.Entities
{
    public class Skill
    {
        public string name { get; set; }
        public string level { get; set; }
        public IList<string> keywords { get; set; }
    }

}