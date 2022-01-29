using System;
using System.Collections.Generic;

namespace Joylet.API.Domain.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string CartDetails { get; set; }
        public IList<CartItem> CartsItems { get; set; }
        public DeliveryFee DeliveryFees { get; set; }
    }
}
