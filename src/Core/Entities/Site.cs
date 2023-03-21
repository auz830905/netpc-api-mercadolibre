using Newtonsoft.Json;

namespace NETPC.ApiMercadoLibre.Core.Entities
{
    public class Site : Base
    {
        [JsonProperty("default_currency_id")]
        public string DefaultCurrencyId { get; set; } = null!;        
    }
}
