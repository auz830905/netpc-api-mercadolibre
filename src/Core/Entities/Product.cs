using Newtonsoft.Json;

namespace NETPC.ApiMercadoLibre.Core.Entities
{
    public class Product
    {
        [JsonProperty("id")]
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Condition { get; set; } = null!;
        [JsonProperty("thumbnail_id")]
        public string ThumbnailId { get; set; } = null!;
        [JsonProperty("listing_type_id")]
        public string ListingTypeId { get; set; } = null!;       
        public Uri PermaLink { get; set; } = null!;
        [JsonProperty("buying_mode")]
        public string BuyingMode { get; set; } = null!;
        [JsonProperty("site_id")]
        public string SiteId { get; set; } = null!;
        [JsonProperty("category_id")]
        public string CategoryId { get; set; } = null!;
        [JsonProperty("domain_id")]
        public string DomainId { get; set; } = null!;        
        public Uri Thumbnail { get; set; } = null!;
        [JsonProperty("currency_id")]
        public string CurrencyId { get; set; } = null!;
        [JsonProperty("order_backend")]
        public int OrderBackend { get; set; }
        public decimal Price { get; set; }
        [JsonProperty("original_price")]
        public decimal? OriginalPrice { get; set; }
        [JsonProperty("available_quantity")]
        public int AvailableQuantity { get; set; }
        [JsonProperty("use_thumbnail_id")]
        public bool UseThumbnailId { get; set; }
        [JsonProperty("accepts_mercadopago")]
        public bool AcceptsMercadopago { get; set; }
        [JsonProperty("tags")]
        public IList<string> Tags { get; set; } = new List<string>();
        [JsonProperty("variation_filters")]
        public IList<string> VariationFilters { get; set; } = new List<string>();
        public Shipping? Shipping { get; set; }
        [JsonProperty("stop_time")]
        public DateTime StopTime { get; set; }
        public Seller Seller  { get; set; } = null!;

    }
}
