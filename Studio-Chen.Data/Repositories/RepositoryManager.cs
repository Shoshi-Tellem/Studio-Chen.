using Studio_Chen.Core.Entities;
using Studio_Chen.Core.Interfaces;
using Studio_Chen.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Data.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly DataContext _context;

        public IRepository<Course> Courses { get; }

        public IRepository<Gymnast> Gymnasts { get; }

        public IRepository<Lesson> Lessons { get; }

        public IRepository<Teacher> Teachers { get; }
        public RepositoryManager(DataContext context, IRepository<Course> courses, IRepository<Gymnast> gymnasts, IRepository<Lesson> lessons, IRepository<Teacher> teachers)
        {
            _context = context;
            Courses = courses;
            Gymnasts = gymnasts;
            Lessons = lessons;
            Teachers = teachers;
        }

        public async Task saveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
