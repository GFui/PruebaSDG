using System.ComponentModel.DataAnnotations;

namespace PruebaSDG.Models
{
    public class CountryModel
    {
        [Key]
        public string Country { get; set; }
        public int Population { get; set; }
       
    }
}
