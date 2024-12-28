//using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Studio_Chen.Core.Entities;
using System.Diagnostics;

namespace Studio_Chen.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Course> courses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Studio-Chen_db");
            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }
        //public DataContext()
        //{
        //    courses = new DbSet<Course>()
        //    { 
        //        new Course()
        //    };
        //}
    }
}
