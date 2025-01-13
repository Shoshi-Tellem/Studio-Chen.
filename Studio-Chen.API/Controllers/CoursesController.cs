using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Studio_Chen.API.Entities;
using Studio_Chen.Core;
using Studio_Chen.Core.DTOs;
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
        //private readonly Mapping _mapping;
        private readonly IMapper _mapper;

        public CoursesController(ICourseService courseService, IMapper mapper)
        {
            _courseService = courseService;
            _mapper = mapper;
        }

        // GET: api/<CoursesController>
        [HttpGet]
        public ActionResult/*IEnumerable<Course>*/ Get()
        {
            return Ok(_mapper.Map<List<CourseDto>>(_courseService.GetCourses()));
        }

        // GET api/<CoursesController>/5
        [HttpGet("{id}")]
        public ActionResult/*Course?*/ Get(int id)
        {
            return Ok(_mapper.Map<CourseDto>(_courseService.GetCourse(id)));
        }

        // POST api/<CoursesController>
        [HttpPost]
        public ActionResult/*Course*/ Post([FromBody] CoursePostPut coursePost)
        {
            Course course = new Course
            {
                MeetsNumber = coursePost.MeetsNumber,
                Type = coursePost.Type,
                StartDate = coursePost.StartDate,
                EndDate = coursePost.EndDate,
                TeacherId = coursePost.TeacherId,
                Equipment = coursePost.Equipment
            };
            return Ok(_courseService.PostCourse(course));
        }

        // PUT api/<CoursesController>/5
        [HttpPut("{id}")]
        public ActionResult/*Course*/ Put(int id, [FromBody] CoursePostPut coursePut)
        {
            Course course = new Course
            {
                MeetsNumber = coursePut.MeetsNumber,
                Type = coursePut.Type,
                StartDate = coursePut.StartDate,
                EndDate = coursePut.EndDate,
                TeacherId = coursePut.TeacherId,
                Equipment = coursePut.Equipment
            };
            return Ok(_courseService.PutCourse(course));
        }

        // DELETE api/<CoursesController>/5
        [HttpDelete("{id}")]
        public ActionResult/*Course*/ Delete(Course course)
        {
            return Ok(_courseService.DeleteCourse(course));
        }
    }
}
