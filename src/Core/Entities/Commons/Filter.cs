using Newtonsoft.Json;

namespace NETPC.ApiMercadoLibre.Core.Entities.Commons
{
	public class Filter : Base
	{
        [JsonProperty("type")]
        public string Type { get; set; } = null!;
		[JsonProperty("values")]
		public IList<ValueFilter> Values = new List<ValueFilter>();
	}
}

