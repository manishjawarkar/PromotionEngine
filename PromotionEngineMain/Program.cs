using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using PromotionEngine.Service;
using PromotionEngine.Interface;

namespace PromotionEngineMain
{
    class Program
    {
        static void Main(string[] args)
        {
            SKUService sKUService = new SKUService();
            ISku sku = sKUService;
            List<SKU> skus = new List<SKU>();

            Console.WriteLine("Total number of orders");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Enter the type of product:A,B,C or D");
                string type = Console.ReadLine();
                SKU p = new SKU(type);
                skus.Add(p);
                sku.GetPriceByType(p);
            }
            
            int totalPrice = sku.GetTotalPrice(skus);
            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }
    }
}
