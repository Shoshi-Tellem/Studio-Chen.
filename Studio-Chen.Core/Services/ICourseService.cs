using Microsoft.EntityFrameworkCore;
using Studio_Chen.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Core.Services
{
    public interface ICourseService
    {
        IEnumerable<Course> GetCourses();

        Course? GetCourse(int id);

        Course PostCourse(Course course);

        Course PutCourse(Course course);

        Course DeleteCourse(Course course);
    }
}
