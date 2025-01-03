using Microsoft.AspNetCore.Mvc;
using Studio_Chen.Core.Entities;
using Studio_Chen.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Studio_Chen.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        // GET: api/<CoursesController>
        [HttpGet]
        public IEnumerable<Course> Get()
        {
            Console.WriteLine("course controller");
            return _courseService.GetCourses();
        }

        // GET api/<CoursesController>/5
        [HttpGet("{id}")]
        public Course? Get(int id)
        {
            return _courseService.GetCourse(id);
        }

        // POST api/<CoursesController>
        [HttpPost]
        public Course Post([FromBody] Course course)
        {
            return _courseService.PostCourse(course);
        }

        // PUT api/<CoursesController>/5
        [HttpPut("{id}")]
        public Course Put(int id, [FromBody] Course course)
        {
            return _courseService.PutCourse(course);
        }

        // DELETE api/<CoursesController>/5
        [HttpDelete("{id}")]
        public Course Delete(Course course)
        {
            return _courseService.DeleteCourse(course);
        }
    }
}
