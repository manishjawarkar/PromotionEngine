using System;

namespace PromotionEngine.Model
{
    public class SKU
    {
        public SKU()
        {
        }
        public SKU(string type)
        {
            Id = type;
        }
        public string Id { get; set; }
        public decimal Price { get; set; }
    }
}
