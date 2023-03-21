using NETPC.ApiMercadoLibre.Core.Entities.Commons;
using Newtonsoft.Json;

namespace NETPC.ApiMercadoLibre.Core.Entities
{
    public class Metrics
    {
        public BaseMetric? Claims { get; set; }
        [JsonProperty("delayed_handling_time")]
        public BaseMetric? DelayedHandlingTime { get; set; }
        public BaseMetric? Cancellations { get; set; }
    }
}
