
using API_CRUD_Operations.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_CRUD_Operations.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        public DbSet<Employee> Employees   { get; set; }

    }
        
    
}
