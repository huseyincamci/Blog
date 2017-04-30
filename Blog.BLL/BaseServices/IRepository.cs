using Blog.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Blog.BLL.BaseServices
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetList();
        IEnumerable<T> GetList(Expression<Func<T, bool>> predicate);
        T FirstOrDefault(Expression<Func<T, bool>> predicate);  
        T Add(T entity);      
        IEnumerable<T> AddRange(IEnumerable<T> entities);
        T Remove(T entity);
        IEnumerable<T> RemoveRange(IEnumerable<T> entities);
        int Save();
    }
}