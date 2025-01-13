using AutoMapper;
using Studio_Chen.Core.DTOs;
using Studio_Chen.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Core
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Course, CourseDto>().ReverseMap();
        }
        //public CourseDto MapToCourseDto(Course course)
        //{
        //    return new CourseDto(course.Id, course.MeetsNumber, course.Type, course.StartDate, course.EndDate, course.Teacher);
        //}
    }
}
