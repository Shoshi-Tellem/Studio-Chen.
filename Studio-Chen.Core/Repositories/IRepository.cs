using Microsoft.EntityFrameworkCore;
using Studio_Chen.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Core.Interfaces
{
    public interface IRepository<T>
    {
        List<T> GetEntities();

        T? GetEntity(int id);

        T PostEntity(T Entity);

        T PutEntity(T Entity);

        T DeleteEntity(T entity);
    }
}
