using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccessLayer.Concrete.Repository
{
    public interface IRepository<T> where T : class
    {
        List<T> List();
        void insert(T p);
        void Update(T p);
        void Delete(T p);

        List<T> List(Expression<Func<T, bool>> filter);
    }
}
