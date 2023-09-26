using KontoretAb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace KontoretAb.Data
{
    public class KontoretABContext : DbContext
    {
        public KontoretABContext(DbContextOptions<KontoretABContext> options) : base(options)
        {
             
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectList> ProjectLists { get; set; }
    }
}
