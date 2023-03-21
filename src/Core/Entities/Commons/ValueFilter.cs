using Newtonsoft.Json;

namespace NETPC.ApiMercadoLibre.Core.Entities.Commons
{
	public class ValueFilter : Base
	{
		[JsonProperty("path_from_root")]
		public IList<FilterBase> PathFromRoot { get; set; } = new List<FilterBase>();
	}

	public class FilterBase : Base
	{
	}
}

