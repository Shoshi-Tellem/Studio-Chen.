using Microsoft.EntityFrameworkCore;
using Studio_Chen.Core.Entities;
using Studio_Chen.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly DataContext _context;
        public CourseRepository(DataContext context)
        {
            _context = context;
        }
        public List<Course> GetCourses() 
        { 
            return _context.courses.ToList();
        }
    }
}
