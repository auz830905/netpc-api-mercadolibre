using Newtonsoft.Json;

namespace NETPC.ApiMercadoLibre.Core.Entities
{
    public class Domain : Base
    {
        [JsonProperty("site_id")]
        public string SiteId { get; set; } = null!;
    }
}
