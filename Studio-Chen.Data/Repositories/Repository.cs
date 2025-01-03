using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Studio_Chen.Core.Entities;
using Studio_Chen.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> _dbSet;

        public Repository(DataContext context)
        {
            _dbSet = context.Set<T>();
        }

        public IEnumerable<T> GetEntities()
        {
            Console.WriteLine("repository");
            Console.WriteLine(_dbSet);
            return _dbSet.ToList();
        }

        public T? GetEntity(int id)
        {
            return _dbSet.Find(id);
        }

        public T PostEntity(T entity)
        {
            _dbSet.Add(entity);
            return entity;
        }

        public T PutEntity(T entity)
        {
            _dbSet.Update(entity);
            return entity;
        }

        public T DeleteEntity(T entity)
        {
            _dbSet.Remove(entity);
            return entity;
        }
    }
}
