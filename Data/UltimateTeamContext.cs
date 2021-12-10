using EFCoreSecondLevelCacheInterceptorPG.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSecondLevelCacheInterceptorPG.Data
{
    public class UltimateTeamContext: DbContext
    {
        public UltimateTeamContext(DbContextOptions<UltimateTeamContext> options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Card> Cards { get; set; }


        // this method can be used to specify the name of the table in the DB
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Player>().ToTable("Player"); // rather than Players
            //modelBuilder.Entity<Card>().ToTable("Card");
        }
    }
}
