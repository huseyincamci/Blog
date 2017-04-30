using Blog.DAL.Data.Context;
using Blog.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Blog.BLL.BaseServices
{
    public class GenericRepository<T>: IRepository<T> where T : BaseEntity
    {
        protected ApplicationDbContext Context { get; private set; }

        public GenericRepository()
        {
            Context = new ApplicationDbContext();
        }

        public IEnumerable<T> GetList()
        {
            return Context.Set<T>().ToList();
        }

        public IEnumerable<T> GetList(Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().Where(predicate).ToList();
        }

        public T FirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().FirstOrDefault(predicate);
        }

        public T Add(T entity)
        {
            return Context.Set<T>().Add(entity);
        }

        public IEnumerable<T> AddRange(IEnumerable<T> entities)
        {
            return Context.Set<T>().AddRange(entities);
        }

        public T Remove(T entity)
        {
            return Context.Set<T>().Remove(entity);
        }

        public IEnumerable<T> RemoveRange(IEnumerable<T> entities)
        {
            return Context.Set<T>().RemoveRange(entities);
        }

        public int Save()
        {
            return Context.SaveChanges();
        }
    }
}