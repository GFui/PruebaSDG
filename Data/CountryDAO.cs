using PruebaSDG.Models;
using System.Text.Json;

namespace PruebaSDG.Data
{
    /// <summary>
    /// Country Data Access Object
    /// </summary>
    public class CountryDAO
    {
        private static string apiUrl = "https://restcountries.com/v3.1";

        public async Task<List<CountryRC>?> GetCountriesNameAndPopulation()
        {
            HttpClient httpClient = new HttpClient();
            var dataList = new List<CountryRC>();
            try
            {
                var URL = apiUrl + "/all?fields=name,population";

                var response = await httpClient.GetAsync(URL);

                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                dataList = JsonSerializer.Deserialize<List<CountryRC>>(responseBody);
            }

            catch (Exception ex)
            {
                throw new Exception("Error al recuperar los datos de la API externa: " + ex.Message);
            }

            return dataList;
        }
    }
}
