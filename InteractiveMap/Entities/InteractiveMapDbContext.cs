using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveMap.Entities
{
    public class InteractiveMapDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Marker> Markers { get; set; }
        public DbSet<Comment> Comments { get; set; }

        private string _conectionString = @"Server=localhost\SQLEXPRESS;Database=InteractiveMapDb;Trusted_Connection=True;";

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u => u.FirstName)
                .IsRequired()
                .HasMaxLength(255);
            modelBuilder.Entity<User>()
                .Property(u => u.LastName)
                .IsRequired()
                .HasMaxLength(255);
            modelBuilder.Entity<User>()
                .Property(u => u.Login)
                .IsRequired()
                .HasMaxLength(255);
            modelBuilder.Entity<User>()
                .Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(255);

            modelBuilder.Entity<Marker>()
                .Property(m => m.Latitude)
                .IsRequired();
            modelBuilder.Entity<Marker>()
                .Property(m => m.Longitude)
                .IsRequired();
            modelBuilder.Entity<Marker>()
                .Property(m => m.PointName)
                .HasMaxLength(255)
                .IsRequired();

            modelBuilder.Entity<Comment>()
                .Property(c => c.Content)
                .IsRequired();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_conectionString);
        }

    }
}
