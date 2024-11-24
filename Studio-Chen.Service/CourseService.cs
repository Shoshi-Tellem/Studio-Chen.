using Studio_Chen.Core.Entities;
using Studio_Chen.Core.Interfaces;
using Studio_Chen.Core.Services;

namespace Studio_Chen.Service
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public List<Course> GetCourses()
        {
            return _courseRepository.GetCourses();
        }
    }
}
