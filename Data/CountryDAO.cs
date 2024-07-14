namespace PruebaSDG.Data
{
    /// <summary>
    /// Country Data Access Object
    /// </summary>
    public class CountryDAO
    {
        private static string apiUrl = "https://restcountries.com/v3.1";

        public async void getCountriesNameAndPopulation()
        {
            HttpClient httpClient = new HttpClient();

            try
            {
                var URL = apiUrl + "/all?fields=name,capital,currencies";

                var response = await httpClient.GetAsync(URL);

                response.EnsureSuccessStatusCode();


            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
