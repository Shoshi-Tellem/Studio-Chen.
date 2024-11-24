using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Core.Entities
{
    public enum ETypeOfCourse { pilates, design_and_toning, Aerobics_band_dynamic_design, floor_exercise, ballet, dance }
    public class Course
    {
        public int Identity { get; set; }
        public int MeetsNumber { get; set; }
        public ETypeOfCourse Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Teacher Teacher { get; set; }
        public List<string> Equipment { get; set; }
        public List<Gymnast> Gymnasts { get; set; }
        List<Lesson> lessons { get; set; }
        public override string ToString()
        {
            return $"{Identity} {Gymnasts.ToString}";
        }
    }
}
