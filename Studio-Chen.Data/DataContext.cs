using Studio_Chen.Core.Entities;

namespace Studio_Chen.Data
{
    public class DataContext
    {
        public List<Course> courses { get; set; }
        public DataContext()
        {
            courses = new List<Course>()
            { 
                new Course()
            };
        }
    }
}
