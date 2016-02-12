using System;
using System.Collections.Generic;
using BigFoodie.DataAccess.Repository;
using BigFoodie.Model;

namespace BigFoodie.Meals.Service
{

    public interface IMealsService : IDisposable
    {
        List<Shop> GetAllMeals();
    }

    public class MealsService : IMealsService
    {
        private IMealRepository _mealRepository;
        protected bool _disposed = false;
        public MealsService(IMealRepository mealRepository)
        {
            _mealRepository = mealRepository;
        }

        public List<Shop> GetAllMeals()
        {
            return _mealRepository.GetAllMeals();
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
