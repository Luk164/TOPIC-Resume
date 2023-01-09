using Blazorise;
using MainLib.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TOPIC_Resume.Entities;

namespace TOPIC_Resume.Data
{
    public class ApplicationDbContext : IdentityDbContext<CustomIdentityUser>
    {
        public virtual DbSet<Resume>? Resumes => Set<Resume>();
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Resume>().OwnsOne(
                resume => resume.Basics, ownedNavigationBuilder =>
                {
                    ownedNavigationBuilder.ToJson();
                    ownedNavigationBuilder.OwnsOne(basics => basics.location);
                    ownedNavigationBuilder.OwnsMany(basics => basics.profiles);
                });
        }
    }
}