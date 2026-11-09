using Microsoft.EntityFrameworkCore;
using EFCore02.Models;
using EFCore02.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore02.Data
{
    public class EventDBContext : DbContext
    {
        //public  EventDBContext(DbContextOptions <EventDBContext> options) : base(options)
        //{
          
        //}
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Badge> Badges { get; set; }
        public DbSet<OrganizerProfile> OrganizerProfiles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new OrganizerProfileConfig());

            modelBuilder.Entity<Organizer>().HasMany(o => o.Events).WithOne(e => e.Organizer).HasForeignKey(e => e.OrganizerId);

            modelBuilder.Entity<Attendee>().HasOne(a => a.Badge).WithOne(b => b.Attendee).HasForeignKey<Badge>(b => b.AttendeeId);

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=EventDB;Trusted_Connection=True;TrustServerCertificate=true;");
        }

    }
}
