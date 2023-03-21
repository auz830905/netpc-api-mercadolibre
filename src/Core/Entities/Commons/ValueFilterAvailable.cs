using Newtonsoft.Json;

namespace NETPC.ApiMercadoLibre.Core.Entities.Commons
{
	public class ValueFilterAvailable : Base
	{
		[JsonProperty("results")]
		public int Results { get; set; }
	}
}

