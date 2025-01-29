using Studio_Chen.Core.Entities;
using Studio_Chen.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Core.Repositories
{
    public interface IRepositoryManager
    {
        public IRepository<Course> Courses { get; }

        public IRepository<Gymnast> Gymnasts { get; }

        public IRepository<Lesson> Lessons { get; }

        public IRepository<Teacher> Teachers { get; }

        Task saveAsync();
    }
}
