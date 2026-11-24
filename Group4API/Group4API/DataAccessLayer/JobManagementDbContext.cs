using Group4API.Models;
using Microsoft.EntityFrameworkCore;

namespace Group4API.DataAccessLayer
{
    public class JobManagementDbContext : DbContext
    {
        public JobManagementDbContext(DbContextOptions<JobManagementDbContext> options) 
            : base(options) { } 

        public DbSet<Client> Clients { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<FieldReport> FieldReports {  get; set; }

        public DbSet<Job> Jobs { get; set; }

        public DbSet<Material> Materials { get; set; }
        
        public DbSet<Payment> Payments { get; set; }

        public DbSet<Schedule> Schedules { get; set; }

        public DbSet<Tools> Tools { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<Warehouse> Warehouses { get; set; }
    }
}
