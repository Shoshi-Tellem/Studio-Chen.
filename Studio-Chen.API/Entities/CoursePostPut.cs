using Studio_Chen.Core.Entities;

namespace Studio_Chen.API.Entities
{
    public class CoursePostPut
    {
        public int MeetsNumber { get; set; }
        public ECourseType Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TeacherId { get; set; }
        public List<string> Equipment { get; set; }
    }
}
