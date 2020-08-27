using PromotionEngine.Interface;
using PromotionEngine.Model;
using System.Collections.Generic;

namespace PromotionEngine.Service
{
    public class SKUService : ISku
    {
        public void GetPriceByType(SKU sku)
        {
            sku.Price = sku.Id switch
            {
                var x when x == "A" || x == "a" => 50m,
                var y when y == "B" || y == "b" => 30m,
                var z when z == "C" || z == "c" => 20m,
                var a when a == "D" || a == "d" => 15m,
                _ => sku.Price
            };
        }
        public int GetTotalPrice(List<SKU> sKUs)
        {
            int countA = 0, countB = 0, countC = 0, countD = 0;
            decimal priceOfA = 0m, priceOfB = 0m, priceOfC = 0m, priceOfD = 0m;

            foreach (SKU pr in sKUs)
            {
                switch (pr.Id)
                {
                    case "A":
                    case "a":
                        countA += 1;
                        priceOfA = pr.Price;
                        break;
                    case "B":
                    case "b":
                        countB += 1;
                        priceOfB = pr.Price;
                        break;
                    case "C":
                    case "c":
                        countC += 1;
                        priceOfC = pr.Price;
                        break;
                    case "D":
                    case "d":
                        countD += 1;
                        priceOfD = pr.Price;
                        break;
                }
            }
            decimal totalPriceOfA = countA / 3 * 130 + countA % 3 * priceOfA;
            decimal totalPriceOfB = countB / 2 * 45 + countB % 2 * priceOfB;
            decimal totalPriceOfC = 0m;
            decimal totalPriceOfD;
            if (countC == 1 && countD == 1)
            {
                totalPriceOfD = 30;
            }
            else
            {
                totalPriceOfC = (countC * priceOfC);
                totalPriceOfD = (countD * priceOfD);
            }

            return (int)(totalPriceOfA + totalPriceOfB + totalPriceOfC + totalPriceOfD);
        }
    }
}
