using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using StepWise.Data.Models;

namespace StepWise.Data
{
    public class StepWiseDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public StepWiseDbContext(DbContextOptions<StepWiseDbContext> options)
            : base(options)
        {
        }

        public DbSet<CalendarTask> CalendarTasks { get; set; }

        public DbSet<CareerPath> CareerPaths { get; set; }

        public DbSet<CareerStep> CareerSteps { get; set; }

        public DbSet<Note> Notes { get; set; }

        public DbSet<Profession> Professions { get; set; }

        public DbSet<Skill> Skills { get; set; }
    }
}
