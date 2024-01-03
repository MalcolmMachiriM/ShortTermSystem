using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ShortTerm.Data
{
    public class ApplicationDbContext : IdentityDbContext<Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<IndividualProduct> IndividualProducts { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<MaritalStatus> MaritalStatuses { get; set; }
        public DbSet<Policy> Policies { get; set; }
        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<Reassurer> Reassurers { get; set; }
        public DbSet<Religion> Religions { get; set; }
        public DbSet<Scheme> Schemes { get; set; }
    }
}