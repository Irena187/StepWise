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
    }
}
