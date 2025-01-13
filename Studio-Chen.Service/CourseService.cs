using Microsoft.EntityFrameworkCore;
using Studio_Chen.Core.Entities;
using Studio_Chen.Core.Interfaces;
using Studio_Chen.Core.Services;

namespace Studio_Chen.Service
{
    public class CourseService : ICourseService
    {
        private readonly IRepository<Course> _repository;

        public CourseService(IRepository<Course> repository)
        {
            _repository = repository;
        }

        public List<Course> GetCourses()
        {
            Console.WriteLine("course service");
            return _repository.GetEntities().ToList();
        }

        public Course? GetCourse(int id)
        {
            return _repository.GetEntity(id);
        }

        public Course PostCourse(Course course)
        {
            return _repository.PostEntity(course);
        }

        public Course PutCourse(Course course)
        {
            return _repository.PutEntity(course);
        }

        public Course DeleteCourse(Course course)
        {
            return _repository.DeleteEntity(course);
        }
    }
}
