using System.Text.Json.Serialization;

namespace MainLib.Entities
{
    public class Resume
    {
        //TODO: Set json property names for all properties
        [JsonPropertyName("basics")]
        public Basics? Basics { get; set; }
        public virtual IList<Work>? work { get; set; }
        public IList<Volunteer>? volunteer { get; set; }
        public IList<Education>? education { get; set; }
        public virtual IList<Award>? awards { get; set; }
        public virtual IList<Certificate>? certificates { get; set; }
        public virtual IList<Publication>? publications { get; set; }
        public virtual IList<Skill>? skills { get; set; }
        public virtual IList<Language>? languages { get; set; }
        public virtual IList<Interest>? interests { get; set; }
        public virtual IList<Reference>? references { get; set; }
        public virtual IList<Project>? projects { get; set; }
    }
}