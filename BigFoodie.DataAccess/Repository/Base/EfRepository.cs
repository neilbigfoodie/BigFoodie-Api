using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace BigFoodie.DataAccess.Repository.Base
{
    public class EfRepository : IEfRepository
    {
        protected DbContext _context;
        private readonly Dictionary<Type, string> _storedProcedureMapForFind;
        private readonly Dictionary<Type, string> _storedProcedureMapForCall;
        private DbContextTransaction _contextTransaction;

        public EfRepository(DbContext context)
        {
            _context = context;
            _storedProcedureMapForCall = new Dictionary<Type, string>();
            _storedProcedureMapForFind = new Dictionary<Type, string>();
        }

        public virtual IQueryable<T> GetAll<T>() where T : class
        {
            return _context.Set<T>();
        }

        public virtual IQueryable<T> GetAll<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return _context.Set<T>().Where(predicate);
        }

        public virtual IEnumerable<T> SqlFind<T>(params object[] parameters) where T : class
        {
            string storedProc;
            if (_storedProcedureMapForFind.TryGetValue(typeof (T), out storedProc))
            {
                return _context.Database.SqlQuery<T>(storedProc, parameters);
            }
            return new List<T>();
        }

        public virtual bool Add<T>(T entity, out T savedEntity) where T : class
        {
            try
            {
                _context.Set<T>().Add(entity);
                _context.SaveChanges();
                savedEntity = entity;
                return true;
            }
            catch (Exception ex)
            {
                _context.Set<T>().Remove(entity);
                throw ex;
            }
        }

        public virtual bool Add<T>(T entity) where T: class
        {
            try
            {
                _context.Set<T>().Add(entity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _context.Set<T>().Remove(entity);
                throw ex;
            }
        }

        public virtual bool Update<T>(T entity) where T : class
        {
            try
            {
                _context.Entry<T>(entity).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _context.Entry<T>(entity).Reload();
                throw ex;
            }
        }
        
        public virtual bool Remove<T>(T entity) where T : class
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
            return true;
        }

        #region transaction

        public void BeginTransaction()
        {
            _contextTransaction = _context.Database.BeginTransaction();
        }

        public bool CommitTransaction()
        {
            try
            {
                if (_contextTransaction != null)
                {
                    _contextTransaction.Commit();
                    _contextTransaction.Dispose();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool RollBackTransaction()
        {
            try
            {
                if (_contextTransaction != null)
                {
                    _contextTransaction.Rollback();
                    _contextTransaction.Dispose();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        #endregion

        #region IDisposable

        public void Dispose()
        {
            _context.Dispose();
        }

        #endregion

    }
}
