using Studio_Chen.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Core.DTOs
{
    public class CourseDto
    {
        public int Id { get; set; }
        public int MeetsNumber { get; set; }
        public ECourseType Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Teacher Teacher { get; set; }

        public CourseDto(int id, int meetsNumber, ECourseType type, DateTime startDate, DateTime endDate, Teacher teacher)
        {
            Id = id;
            MeetsNumber = meetsNumber;
            Type = type;
            StartDate = startDate;
            EndDate = endDate;
            Teacher = teacher;
        }
    }
}
