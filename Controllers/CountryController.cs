using Microsoft.AspNetCore.Mvc;
using PruebaSDG.Models;

namespace PruebaSDG.Controllers
{
    [ApiController]
    [Route("api/v1/country")]
    public class CountryController : Controller
    {
        [HttpPost]
        public void Post()
        {

        }

        [HttpGet]
        public IEnumerable<CountryModel> Get() { 
        
            var list = new List<CountryModel>();

            var a = new CountryModel { Country = "España", Population = 1241421 };
            list.Add(a);

            return list;
        }
    }
}
