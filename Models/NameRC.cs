using System.Text.Json.Serialization;

namespace PruebaSDG.Models
{
    public class NameRC
    {
        [JsonPropertyName("common")]
        public string Common { get; set; }
    }
}
