using PruebaSDG.Models;

namespace PruebaSDG.Mapper
{
    public class CountryMapper
    {
        public CountryModel CountryRcToCountryModel(CountryRC countryRc)
        {
            var country = new CountryModel();

            try
            {
                country.Country = countryRc.Name.Common;
                country.Population = countryRc.Population;
            }
            catch(Exception e) 
            {
                throw new Exception("Error al mapear: " + e.Message);
            }

            return country;
        }

        public List<CountryModel> CountryRcToCountryList(List<CountryRC> listCountryRC) 
        {
            var list = new List<CountryModel>();

            try
            {
                foreach(var country in listCountryRC)
                {
                    list.Add(CountryRcToCountryModel(country));
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al convertir la lista de países: " + e.Message);
            }

            return list;    
        }
    }
}
