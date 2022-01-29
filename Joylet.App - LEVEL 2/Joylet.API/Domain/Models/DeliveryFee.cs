namespace Joylet.API.Domain.Models
{
    public class DeliveryFee
    {
        public int Id { get; set; }
        public decimal MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public decimal DeliveryPrice { get; set; }
        public bool IsActive { get; set; }
        public bool IsExpired { get; set; }
    }
}
