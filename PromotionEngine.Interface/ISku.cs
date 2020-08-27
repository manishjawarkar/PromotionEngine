using PromotionEngine.Model;
using System;
using System.Collections.Generic;

namespace PromotionEngine.Interface
{
    public interface ISku
    {
        void GetPriceByType(SKU sku);
        int GetTotalPrice(List<SKU> sKUs);
    }
}
