using NETPC.ApiMercadoLibre.Core.Entities.Commons;
using Newtonsoft.Json;

namespace NETPC.ApiMercadoLibre.Core.Entities
{
    public class Category
    {
        [JsonProperty("site_id")]
        public string SiteId { get; set; } = null!;
        [JsonProperty("country_default_time_zone")]
        public string CountryDefaultTimeZone { get; set; } = null!;
        public Paging Paging { get; set; } = null!;
        public IList<Product> Results { get; set; } = new List<Product>();
        public Base Sort { get; set; } = null!;
        [JsonProperty("available_sorts")]
        public IList<Base> AvailableSorts { get; set; } = new List<Base>();
        [JsonProperty("filters")]
        public IList<Filter> Filters { get; set; } = new List<Filter>();
        [JsonProperty("available_filters")]
        public IList<FilterAvailable> AvailableFilters { get; set; } = new List<FilterAvailable>();
    }
}
