using DockerCompoisedDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace DockerCompoisedDemo.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }

    }
}
