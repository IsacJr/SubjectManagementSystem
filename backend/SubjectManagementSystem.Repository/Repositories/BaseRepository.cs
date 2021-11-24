using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Repository
{
    public abstract class BaseRepository <T> : IBaseRepository <T> where T : BaseEntity
    {
        protected const int PageSize = 10;
        protected readonly ApplicationDbContext dbContext;
        private DbSet<T> entities;
        public BaseRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.entities = dbContext.Set<T>();
        }

        public T Delete(int id)
        {
            T entity = entities.SingleOrDefault(s => s.Id == id);
            entities.Remove(entity);
            dbContext.SaveChanges();
            return entity;
        }

        public T Get(int id)
        {
            return entities.SingleOrDefault(s => s.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public T Insert(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");

            entities.Add(entity);
            dbContext.SaveChanges();
            return entity;
        }

        public T Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            dbContext.SaveChanges();
            return entity;
        }
    }
}