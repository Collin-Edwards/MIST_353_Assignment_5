using MW_Assignment_4.Entities;
using Microsoft.EntityFrameworkCore;


namespace MW_Assignment_4.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options) 
        { }
        public DbSet<Airports> Airports { get; set; }
    }
}
