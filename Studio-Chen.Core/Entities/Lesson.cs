using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Core.Entities
{
    internal class Lesson
    {
        public int Identity { get; set; }
        public int CourseIdentity { get; set; }
        public int MeetNumber { get; set; }
        public DateTime Date { get; set; }
        public TimeOnly StartHour { get; set; }
        public TimeOnly EndHour { get; set; }
    }
}
