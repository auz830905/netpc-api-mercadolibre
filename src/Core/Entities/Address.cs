using Newtonsoft.Json;

namespace NETPC.ApiMercadoLibre.Core.Entities
{
	public class Address
	{
        [JsonProperty("state_id")]
		public string StateId { get; set; } = null!;
        [JsonProperty("state_name")]
        public string StateName { get; set; } = null!;
        [JsonProperty("city_id")]
        public string CityId { get; set; } = null!;
        [JsonProperty("city_name")]
        public string CityName { get; set; } = null!;
    }
}

