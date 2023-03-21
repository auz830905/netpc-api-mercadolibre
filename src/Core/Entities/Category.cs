using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETPC.ApiMercadoLibre.Core.Entities
{
    public class Category
    {
        public IList<Product> Results { get; set; } = new List<Product>();
    }
}
