using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BigFoodie.DataAccess.Repository.Base
{
    public interface IEfRepository
    {
        IQueryable<T> GetAll<T>() where T : class;
        IQueryable<T> GetAll<T>(Expression<Func<T, bool>> predicate) where T : class;
        IEnumerable<T> SqlFind<T>(params object[] parameters) where T : class;
        bool Add<T>(T entity, out T savedEntity) where T : class;
        bool Add<T>(T entity) where T: class;
        bool Update<T>(T entity) where T : class;
        bool Remove<T>(T entity) where T : class;
        void BeginTransaction();
        bool CommitTransaction();
        bool RollBackTransaction();
        void Dispose();
    }
}