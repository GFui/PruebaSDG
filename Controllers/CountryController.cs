using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaSDG.Data;
using PruebaSDG.Mapper;
using PruebaSDG.Models;

namespace PruebaSDG.Controllers
{
    [ApiController]
    [Route("api/v1/country")]
    public class CountryController : Controller
    {
        private readonly CountryDAO countryDAO = new CountryDAO();
        private readonly CountryMapper countryMapper = new CountryMapper();
        private readonly CountryDbContext _context;

        public CountryController(CountryDbContext context)
        {
            _context = context; 
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            try
            {
                var dataFromAPI = await countryDAO.GetCountriesNameAndPopulation();

                if (dataFromAPI != null && dataFromAPI.Count > 0)
                {
                    var countryList = countryMapper.CountryRcToCountryList(dataFromAPI);

                    foreach (var country in countryList)
                    {

                        var existeCountry = await _context.CountryModel.FirstOrDefaultAsync(c => c.Country == country.Country);

                        if (existeCountry != null)
                        {
                            existeCountry.Population = country.Population;
                        }
                        else 
                        {
                            _context.CountryModel.Add(country);
                        }
                    }

                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                return Problem("Error insertado los países: " + ex.Message);
            }
            
            return Ok("Países insertados/actualizados con éxito");

        }

        [HttpGet]
        public IEnumerable<CountryModel> Get() { 
        
            var list = _context.CountryModel.ToList();

            return list;
        }
    }
}
