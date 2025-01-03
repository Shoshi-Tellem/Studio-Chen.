using Microsoft.EntityFrameworkCore;
using Studio_Chen.Core.Classes;
using Studio_Chen.Core.Entities;
using System.Diagnostics;

namespace Studio_Chen.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Gymnast> Gymnasts { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Studio-Chen_db");
            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }
    }
}
