using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace StepWise.Data
{
    public class StepWiseDbContext : IdentityDbContext
    {
        public StepWiseDbContext(DbContextOptions<StepWiseDbContext> options)
            : base(options)
        {
        }
    }
}
