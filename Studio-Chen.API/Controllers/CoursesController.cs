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
        //private readonly IMsgService _msgService;


        //public CoursesController(IMsgService service)
        //{
        //    _msgService = service;
        //}


        private IEnumerable<Course> courses;
        // GET: api/<CoursesController>
        [HttpGet]
        public IEnumerable<Course> Get()
        {
            return _courseService.GetCourses();
        }

        // GET api/<CoursesController>/5
        [HttpGet("{id}")]
        public Course Get(int id)
        {
            try
            { return courses.First(c => c.Identity == id); }
            catch (Exception ex)
            { throw new Exception("the id isnot valid"); }
        }

        // POST api/<CoursesController>
        [HttpPost]
        public OkObjectResult Post([FromBody] Course course)
        {
            return Ok(courses = courses.Concat(new List<Course> { course }));
        }

        // PUT api/<CoursesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Course course)
        {
            int index = courses.Find(c => c.Identity == id);
            courses[index] = course;
        }

        // DELETE api/<CoursesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            courses = courses.Where(c => c.Identity != id);
        }
    }
}
