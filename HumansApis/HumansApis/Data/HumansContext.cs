using HumansApis.Models.Domain;
using HumansApis.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace HumansApis.Data
{
    public class HumansContext : DbContext
    {
        public HumansContext(DbContextOptions<HumansContext> options) : base(options)
        {
                      
        }
        public DbSet<humans> Humans { get; set; }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Humans>().HasKey(am => am.Id);

        }
        */
    }
}
