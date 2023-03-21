
using Newtonsoft.Json;

namespace NETPC.ApiMercadoLibre.Core.Entities
{
    public class Seller
    {
        public int Id { get; set; }
        public string NickName { get; set; } = null!;
        [JsonProperty("car_dealer")]
        public bool CarDealer { get; set; }
        [JsonProperty("real_estate_agency")]
        public bool RealEstateAgency { get; set; }
        [JsonProperty("registration_date")]
        public DateTime RegistrationDate { get; set; }
        public IList<string> Tags { get; set; } = new List<string>();
        [JsonProperty("car_dealer_logo")]
        public string CarDealerLogo { get; set; } = null!;       
        public Uri Permalink { get; set; } = null!;
        [JsonProperty("seller_reputation")]
        public SellerReputation SellerReputation { get; set; } = null!;
        public Eshop Eshop  { get; set; } = null!;
    }
}
