using System.Collections.Generic;
using System.Linq;
using Domain.Entities.Common;
using Domain.Repositories;

namespace Infrastructure.Persistence
{
    public class EFRepository<T> : IRepository<T> where T : class, IAggregateRoot
    {
        protected readonly MovieContext context;

        public EFRepository(MovieContext context)
        {
            this.context = context;
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T GetBy(int id)
        {
            return context.Set<T>().Find(id);
        }

        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }
    }
}