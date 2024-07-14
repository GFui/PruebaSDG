using System.Text.Json.Serialization;

namespace PruebaSDG.Models
{
    /// <summary>
    /// Clase que define el objeto que se recupera de la API externa restcountries.es
    /// </summary>
    public class CountryRC
    {
        [JsonPropertyName("population")]
        public int Population { get; set; }
        [JsonPropertyName("name")]
        public NameRC Name { get; set; }
    }
}
