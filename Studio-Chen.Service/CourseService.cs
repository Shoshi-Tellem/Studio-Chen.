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

        public async Task<Course> PostCourseAsync(Course course)
        {
            return await _repository.PostEntityAsync(course);
        }

        public async Task<Course> PutCourseAsync(Course course)
        {
            return await _repository.PutEntityAsync(course);
        }

        public async Task<Course> DeleteCourseAsync(Course course)
        {
            return await _repository.DeleteEntityAsync(course);
        }
    }
}
