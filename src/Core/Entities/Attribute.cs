using Newtonsoft.Json;

namespace NETPC.ApiMercadoLibre.Core.Entities
{
	public class Attribute : Base
	{
		[JsonProperty("value_id")]
		public string ValueId { get; set; } = null!;
        [JsonProperty("value_name")]
        public string ValueName { get; set; } = null!;
        [JsonProperty("attribute_group_id")]
        public string AttributeGroupId { get; set; } = null!;
        [JsonProperty("attribute_group_name")]
        public string AttributeGroupName { get; set; } = null!;
    }
}

