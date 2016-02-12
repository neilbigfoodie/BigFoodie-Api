using BigFoodie.Meals.Service;
using System.Collections.Generic;
using System.Web.Http;
using BigFoodie.Model;

namespace BigFoodie.Api.Controllers
{
   
    public class MealsController : ApiController
    {
        private readonly IMealsService _mealsService;
        public MealsController(IMealsService mealsService)
        {
            _mealsService = mealsService;
        }


        [HttpGet]
        [Route("AllMeals")]
        public IEnumerable<Shop> GetAllMeals()
        {
            return _mealsService.GetAllMeals();
        }
    }
}
