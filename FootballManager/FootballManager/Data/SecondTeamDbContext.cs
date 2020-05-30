using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Data
{
    public class SecondTeamDbContext : DbContext
    {
        public SecondTeamDbContext(DbContextOptions<SecondTeamDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<SecondTeamPlayer> Players { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SecondTeamPlayer>().HasData(GetPlayers());
            base.OnModelCreating(modelBuilder);
        }

        private SecondTeamPlayer[] GetPlayers()
        {
            return new SecondTeamPlayer[]
            {
            new SecondTeamPlayer { Id = 1, FirstName = "Jack", LastName = "Black", Position = "Goalkeeper", Birthday = DateTime.ParseExact("2019-09-01", "yyyy-MM-dd", CultureInfo.InvariantCulture)},
            new SecondTeamPlayer { Id = 2, FirstName = "John", LastName = "Smith", Position = "Striker", Birthday = DateTime.ParseExact("2019-09-02", "yyyy-MM-dd", CultureInfo.InvariantCulture)},
            new SecondTeamPlayer { Id = 3, FirstName = "Derek", LastName = "Poole", Position = "Full-backs", Birthday = DateTime.ParseExact("2019-09-03", "yyyy-MM-dd", CultureInfo.InvariantCulture)},
            new SecondTeamPlayer { Id = 4, FirstName = "Chris", LastName = "Fan", Position = "Full-backs", Birthday = DateTime.ParseExact("2019-09-04", "yyyy-MM-dd", CultureInfo.InvariantCulture)},
            };
        }
    }
}
