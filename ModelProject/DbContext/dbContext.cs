using Microsoft.EntityFrameworkCore;
using ModelProject.Models;

namespace ModelProject
{
    public class dbContext : DbContext
    {   
        public dbContext(DbContextOptions<dbContext> options) : base(options) { }

        public DbSet<UserInfo> Users { get; set; }
        public DbSet<LoginDetail> Login { get; set; }
        public DbSet<Filehandling> FileStore { get; set; }
    }
}
