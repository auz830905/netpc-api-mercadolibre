using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETPC.ApiMercadoLibre.Core.Entities
{
    public class Base
    {
        [JsonProperty("id")]
        public string Id { get; set; } = null!;
        [JsonProperty("name")]
        public string Name { get; set; } = null!;
    }
}
