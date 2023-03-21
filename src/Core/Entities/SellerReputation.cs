using Newtonsoft.Json;

namespace NETPC.ApiMercadoLibre.Core.Entities
{
    public class SellerReputation
    {
        [JsonProperty("level_id")]
        public string LevelId { get; set; } = null!;
        [JsonProperty("power_seller_status")]
        public string PowerSellerStatus { get; set; } = null!;
        public Transaction Transactions { get; set; } = null!;
        public Metrics? Metrics { get; set; }
    }
}
