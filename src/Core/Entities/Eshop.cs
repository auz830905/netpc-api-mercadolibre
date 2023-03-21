
using Newtonsoft.Json;

namespace NETPC.ApiMercadoLibre.Core.Entities
{
    public class Eshop
    {        
        [JsonProperty("eshop_id")]
        public int EshopId { get; set; }
        public int Seller { get; set; }
        [JsonProperty("nick_name")]
        public string NickName { get; set; } = null!;
        [JsonProperty("eshop_status_id")]
        public int EshopStatusId { get; set; }
        [JsonProperty("site_id")]
        public string SiteId { get; set; } = null!;
        [JsonProperty("eshop_experience")]
        public int EshopExperience { get; set; }
        [JsonProperty("eshop_logo_url")]
        public Uri? EshopLogoUrl { get; set; }
    }
}
