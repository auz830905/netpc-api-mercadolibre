using NETPC.ApiMercadoLibre.Core.Entities.Commons;

namespace NETPC.ApiMercadoLibre.Core.Entities
{
    public class Transaction : PeriodBase
    {
        public int Canceled { get; set; }
        public int Completed { get; set; }
        public Rating? Ratings { get; set; }
        public int Total { get; set; }
    }
}
