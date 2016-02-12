using System;
using System.Collections.Generic;
using System.Linq;
using BigFoodie.DataAccess.Repository.Base;
using BigFoodie.Model;

namespace BigFoodie.DataAccess.Repository
{
    public interface IMealsRepository : IDisposable
    {
        List<Shop> GetAllMeals();
    }

    public class MealsRepository : IMealsRepository
    {
        protected bool _disposed = false;
        private IEfRepository _efRepository;

        public MealsRepository(IEfRepository efRepository)
        {
            _efRepository = efRepository;
        }

        public List<Shop> GetAllMeals()
        {
            var meals = _efRepository.GetAll<Shop>().Where(s=>s.Shopid <2000).ToList();
            return meals;
        }

        #region IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    
                }
                _disposed = true;
            }
        }

        #endregion

    }
}
