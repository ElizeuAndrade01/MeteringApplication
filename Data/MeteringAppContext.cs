using MeteringApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace MeteringApplication.Data
{
    public class MeteringAppContext : DbContext
    {
        public MeteringAppContext(DbContextOptions<MeteringAppContext> opt) : base(opt)
        {
            
        }

        public DbSet<Command> Commands { get; set; }
        public DbSet<Meter> Meters {get; set;}
        public DbSet<User> Users { get; set; }
    }
}