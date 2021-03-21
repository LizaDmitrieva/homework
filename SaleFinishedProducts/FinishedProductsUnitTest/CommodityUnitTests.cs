using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinishedProductsLibrary;
using System.IO;

namespace FinishedProductsUnitTest
{
    [TestClass]
    public class CommodityUnitTests
    {
        [TestMethod]
        public void ConstructorTestMethod()
        {
            var cup = CreateTestCommodity();

            Assert.AreEqual("J1S45F", cup.VendorCode);
            Assert.AreEqual("Cup", cup.Name);
            Assert.AreEqual(339, cup.WholesalePrice);
            Assert.AreEqual(500, cup.RetailPrice);
            Assert.AreEqual(UnitOfGoods.Piece, cup.Goods);
        }

        [TestMethod] 
        public void ToStringTestMethod() 
        { 
            var cup = CreateTestCommodity(); 
            Assert.AreEqual("J1S45F Cup", cup.ToString()); 
        }

        [TestMethod]
        public void PrintInfoTestMethod()
        { 
            var   cup = CreateTestCommodity();
            var   tea = new Commodity("L8S13P", "Tea",  100, 120, UnitOfGoods.Package);
            
            var   consoleOut = new[]
            {
                "J1S45F Cup", 
                $"Оптовая цена: 339. Розничная цена: 500. Описание: Синяя, большая. В наличии: 5 шт." ,
                "L8S13P Tea",
                $"Оптовая цена: 100. Розничная цена: 120. Описание: Зелёный, с жасмином. В наличии: 10 уп." 
            };

            cup.Description = "Синяя, большая";
            cup.Availability = 5;
            tea.Description = "Зелёный, с жасмином";
            tea.Availability = 10;

            TextWriter oldOut = Console.Out;
            StringWriter output = new   StringWriter();
            Console.SetOut(output); 

            cup.PrintInfo();
            tea.PrintInfo();

            Console.SetOut(oldOut); 
            var outputArray = output.ToString().Split(new  [] { "\r\n" }, 
                StringSplitOptions.RemoveEmptyEntries); 

            Assert.AreEqual(4, outputArray.Length); 
            for   (var   i = 0; i < consoleOut.Length; i++) 
                Assert.AreEqual(consoleOut[i], outputArray[i]); 
        } 

        private Commodity CreateTestCommodity()
        {
            return new Commodity("J1S45F", "Cup", 339, 500, UnitOfGoods.Piece);
        }
    }
}
