using Microsoft.EntityFrameworkCore;
using PollingSystem.Application.ModelConfiguration;
using PollingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PollingSystem.Application
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        }

        public DbSet<Poll> Polls { get; set; }

        public DbSet<PollAnswer> Answers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Poll>(new PollModelConfiguration());
            modelBuilder.ApplyConfiguration<PollAnswer>(new PollAnswerModelConfiguration());
        }
    }
}
