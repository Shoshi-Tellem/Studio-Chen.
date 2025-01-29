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
        List<Course> GetCourses();

        Course? GetCourse(int id);

        Task<Course> PostCourseAsync(Course course);

        Task<Course> PutCourseAsync(Course course);

        Task<Course> DeleteCourseAsync(Course course);
    }
}
