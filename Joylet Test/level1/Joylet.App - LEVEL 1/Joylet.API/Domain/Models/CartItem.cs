using System.Text.Json.Serialization;

namespace Joylet.API.Domain.Models
{
    public class CartItem
    {
        public int Quantity { get; set; }
        public int CartId { get; set; }
        public int ArticleId { get; set; }
        [JsonIgnore]
        public Article Articles { get; set; }
        [JsonIgnore]
        public Cart Carts { get; set; }

    }
}
