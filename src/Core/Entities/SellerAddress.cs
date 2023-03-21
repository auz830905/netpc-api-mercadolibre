using Newtonsoft.Json;

namespace NETPC.ApiMercadoLibre.Core.Entities
{
	public class SellerAddress
	{
		public string Comment { get; set; } = String.Empty;
		[JsonProperty("address_line")]
		public string AddressLine { get; set; } = string.Empty;
        [JsonProperty("zip_code")]
        public string ZipCode { get; set; } = string.Empty;
		public Base? Country { get; set; }
        public Base? State { get; set; }
        public Base? City { get; set; }
    }
}

