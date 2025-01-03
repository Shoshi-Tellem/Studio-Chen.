using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Core.Entities
{
    public enum ECourseType { pilates, toning, Aerobics, floor_exercise, ballet, dance }
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public int MeetsNumber { get; set; }
        public ECourseType Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Teacher Teacher { get; set; }
        public List<string> Equipment { get; set; }
        public List<Gymnast> Gymnasts { get; set; }
        List<Lesson> Lessons { get; set; }
        public override string ToString()
        {
            return $"{Id} {Gymnasts.ToString}";
        }
    }
}
