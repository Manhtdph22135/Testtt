using Microsoft.EntityFrameworkCore;
using Testtt.Models;

namespace Testtt.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) 
        {
        }
        public DbSet<Movies> Movies { get; set; }
    }
}
