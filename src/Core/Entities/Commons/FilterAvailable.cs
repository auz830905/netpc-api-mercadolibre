using Newtonsoft.Json;

namespace NETPC.ApiMercadoLibre.Core.Entities.Commons
{
	public class FilterAvailable : Base
	{
        [JsonProperty("type")]
        public string Type { get; set; } = null!;
		[JsonProperty("values")]
		public IList<ValueFilterAvailable> Values { get; set; } = new List<ValueFilterAvailable>();
	}
}

