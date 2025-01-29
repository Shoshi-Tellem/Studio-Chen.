using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Studio_Chen.Core.Entities;
using Studio_Chen.Core.Interfaces;
using Studio_Chen.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly IRepositoryManager _manager;
        private readonly DbSet<T> _dbSet;

        public Repository(IRepositoryManager manager, DataContext context)
        {
            _manager = manager;
            _dbSet = context.Set<T>();
        }

        public List<T> GetEntities()
        {
            Console.WriteLine("repository");
            Console.WriteLine(_dbSet);
            return _dbSet.ToList();
        }

        public T? GetEntity(int id)
        {
            return _dbSet.Find(id);
        }

        public async Task<T> PostEntityAsync(T entity)
        {
            _dbSet.Add(entity);
            await _manager.saveAsync();
            return entity;
        }

        public async Task<T> PutEntityAsync(T entity)
        {
            _dbSet.Update(entity);
            await _manager.saveAsync();
            return entity;
        }

        public async Task<T> DeleteEntityAsync(T entity)
        {
            _dbSet.Remove(entity);
            await _manager.saveAsync();
            return entity;
        }

    }
}
