using KickAround.Models.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace KickAround.Data
{
    public class KickAroundContext : DbContext
    {
        public static readonly LoggerFactory ConsoleLoggerFactory = new LoggerFactory(new[]
             {
                 new ConsoleLoggerProvider((category, level)
                     => category == DbLoggerCategory.Database.Command.Name
                 && level == LogLevel.Information, true)
             });

        public KickAroundContext(DbContextOptions<KickAroundContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(ConsoleLoggerFactory);
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<Match> Matches { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlayerGroup>()
                .HasKey(pg => new { pg.PlayerId, pg.GroupId });

            modelBuilder.Entity<AttendeeMatch>()
                .HasKey(am => new { am.AttendeeId, am.MatchId });
        }
    }
}
