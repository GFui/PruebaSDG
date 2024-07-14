namespace PruebaSDG.Models
{
    /// <summary>
    /// Clase que define el objeto que se recupera de la API externa restcountries.es
    /// </summary>
    public class CountryRC
    {
        public int Population { get; set; }
        public NameRC Name { get; set; }
    }
}
