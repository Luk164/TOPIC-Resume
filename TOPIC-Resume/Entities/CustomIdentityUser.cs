using Microsoft.AspNetCore.Identity;

namespace TOPIC_Resume.Entities
{
    public class CustomIdentityUser : IdentityUser
    {
        public string? Experiment { get; set; }
    }
}
