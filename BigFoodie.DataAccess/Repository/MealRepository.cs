using System;
using System.Collections.Generic;
using System.Linq;
using BigFoodie.DataAccess.Repository.Base;
using BigFoodie.Model;

namespace BigFoodie.DataAccess.Repository
{
    public interface IMealRepository : IDisposable
    {
        List<Shop> GetAllMeals();
    }

    public class MealRepository : IMealRepository
    {
        protected bool _disposed = false;
        private IEfRepository _efRepository;

        public MealRepository(IEfRepository efRepository)
        {
            _efRepository = efRepository;
        }

        public List<Shop> GetAllMeals()
        {
            var shops = _efRepository.GetAll<Shop>().Where(s => s.Shopid < 2000).ToList();
            return shops;
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
