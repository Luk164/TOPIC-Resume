namespace MainLib.Entities
{
    public class Skill : BaseEntity
    {
        public string name { get; set; }
        public string level { get; set; }
        public string[] keywords { get; set; }
    }

}