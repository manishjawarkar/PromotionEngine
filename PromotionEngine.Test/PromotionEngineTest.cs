using NUnit.Framework;
using PromotionEngine.Interface;
using PromotionEngine.Model;
using PromotionEngine.Service;
using System;
using System.Collections.Generic;

namespace PromotionEngine.Test
{
    [TestFixture]
    public class PromotionEngineTest
    {
        [Test]
        public void ScenarioA()
        {
            SKUService sKUService = new SKUService();
            ISku sku = sKUService;

            List<SKU> skuScenarioA = new List<SKU>
            {
                new SKU { Id = "a" },
                new SKU { Id = "b" },
                new SKU { Id = "c" }
            };

            foreach(SKU pr in skuScenarioA)
            {
                sku.GetPriceByType(pr);
            }

            int output = sku.GetTotalPrice(skuScenarioA);
            Assert.AreEqual(100, output);
        }
        [Test]
        public void ScenarioB()
        {
            SKUService sKUService = new SKUService();
            ISku sku = sKUService;

            List<SKU> skuScenarioB = new List<SKU>
            {
                new SKU {Id = "a"},
                new SKU {Id = "a"},
                new SKU {Id = "a"},
                new SKU {Id = "a"},
                new SKU {Id = "a"},
                new SKU {Id = "b"},
                new SKU {Id = "b"},
                new SKU {Id = "b"},
                new SKU {Id = "b"},
                new SKU {Id = "b"},
                new SKU {Id = "c"}
            };

            foreach (SKU pr in skuScenarioB)
            {
                sku.GetPriceByType(pr);
            }

            int output = sku.GetTotalPrice(skuScenarioB);
            Assert.AreEqual(370, output);
        }
        [Test]
        public void ScenarioC()
        {
            SKUService sKUService = new SKUService();
            ISku sku = sKUService;

            List<SKU> skuScenarioC = new List<SKU>
            {
                new SKU {Id = "a"},
                new SKU {Id = "a"},
                new SKU {Id = "a"},
                new SKU {Id = "b"},
                new SKU {Id = "b"},
                new SKU {Id = "b"},
                new SKU {Id = "b"},
                new SKU {Id = "b"},
                new SKU {Id = "c"},
                new SKU {Id = "d"}
            };

            foreach (SKU pr in skuScenarioC)
            {
                sku.GetPriceByType(pr);
            }

            int output = sku.GetTotalPrice(skuScenarioC);
            Assert.AreEqual(280, output);
        }
    }
}
