namespace Joylet.API.Domain.Models
{
    public class Discount
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public decimal Value { get; set; }
        public bool IsActive { get; set; }
        public bool IsExpired { get; set; }

        public int ArticleId { get; set; }
        public Article Articles { get; set; }

    }
}
