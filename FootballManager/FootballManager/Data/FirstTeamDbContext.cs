using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Data
{
    public class FirstTeamDbContext : DbContext
    {
        public FirstTeamDbContext(DbContextOptions<FirstTeamDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<FirstTeamPlayer> Players { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FirstTeamPlayer>().HasData(GetPlayers());
            base.OnModelCreating(modelBuilder);
        }

        private FirstTeamPlayer[] GetPlayers()
        {
            return new FirstTeamPlayer[]
            {
            new FirstTeamPlayer { Id = 1, FirstName = "Nino", LastName = "Olivieri", Position = "Goalkeeper", Birthday = DateTime.ParseExact("2019-09-01", "yyyy-MM-dd", CultureInfo.InvariantCulture)},
            new FirstTeamPlayer { Id = 2, FirstName = "Matt", LastName = "Doe", Position = "Striker", Birthday = DateTime.ParseExact("2019-09-02", "yyyy-MM-dd", CultureInfo.InvariantCulture)},
            new FirstTeamPlayer { Id = 3, FirstName = "Scott", LastName = "Nelson", Position = "Full-backs", Birthday = DateTime.ParseExact("2019-09-03", "yyyy-MM-dd", CultureInfo.InvariantCulture)},
            new FirstTeamPlayer { Id = 4, FirstName = "Pike", LastName = "Red", Position = "Full-backs", Birthday = DateTime.ParseExact("2019-09-04", "yyyy-MM-dd", CultureInfo.InvariantCulture)},
            };
        }
    }
}
