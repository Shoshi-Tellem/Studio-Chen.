using Studio_Chen.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Core.Interfaces
{
    public interface ICourseRepository
    {
        List<Course> GetCourses();
    }
}
