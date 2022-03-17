using gantting.api.Models;
using Microsoft.EntityFrameworkCore;

namespace gantting.api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }
        public DbSet<Assignment> Assignments { get; set; }
    }
}