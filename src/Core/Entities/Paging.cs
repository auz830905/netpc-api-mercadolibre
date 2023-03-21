using Newtonsoft.Json;

namespace NETPC.ApiMercadoLibre.Core.Entities
{
	public class Paging
	{
		public int Total { get; set; }
        public int Offset { get; set; }
        public int Limit { get; set; }
        [JsonProperty("primary_results")]
        public int PrimaryResults { get; set; }
    }
}

