using Newtonsoft.Json;

namespace NETPC.ApiMercadoLibre.Core.Entities
{
    public class Shipping
    {
        [JsonProperty("logistic_type")]
        public string LogisticType { get; set; } = null!;
        public string Mode { get; set; } = null!;
        [JsonProperty("store_pick_up")]
        public bool StorePickUp { get; set; }
        [JsonProperty("free_shipping")]
        public bool FreeShipping { get; set; }
        public IList<string> Tags { get; set; } = new List<string>();
    }
}
