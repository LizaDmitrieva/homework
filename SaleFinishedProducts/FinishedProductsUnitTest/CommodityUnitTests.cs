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

    [TestClass]
    public class FragileGoodsUnitTest
    { 
        [TestMethod] 
        public void ConstructorFGTestMethod() 
        { 
            var cup = GetTestFragileGoods(); 
            Assert.AreEqual(100, cup.MaxInStack); 
        } 

        [TestMethod] 
        public void PrintInfoFGTestMethod() 
        { 
            var cup = GetTestFragileGoods(); 
            var lines = new  []  
            {
                "J1S45F Cup", 
                "Оптовая цена: 339. Розничная цена: 500. Описание: Синяя, большая. В наличии: 5 шт.",
                "Максимальное количество единиц товара в стопке: 100 шт."
            };

            cup.Description = "Синяя, большая";
            cup.Availability = 5;

            TextWriter oldOut = Console.Out; 

            using (FileStream file = new   FileStream("test.txt", FileMode.Create)) 
            { 
                using (TextWriter writer = new   StreamWriter(file)) 
                { 
                    Console.SetOut(writer); cup.PrintInfo(); 
                } 
            } 

            Console.SetOut(oldOut);

            using (FileStream file = new   FileStream("test.txt", FileMode.Open)) 
            { 
                using (TextReader reader = new   StreamReader(file)) 
                { 
                    var   i = 0; while (!(reader as StreamReader).EndOfStream) 
                    Assert.AreEqual(lines[i++], reader.ReadLine()); 
                    Assert.AreEqual(lines.Length, i); 
                } 
            } 

            File.Delete("test.txt"); 
        } 
        private FragileGoods GetTestFragileGoods() 
        { 
            var goods = new FragileGoods("J1S45F", "Cup", 339, 500, UnitOfGoods.Piece, 100);
            return goods;
        } 
    }

    [TestClass]
    public class PerishableGoodsUnitTest
    {
        [TestMethod]
        public void ConstructorPGTestMethod()
        {
            var milk = GetTestPerishableGoods();
            Assert.AreEqual(5, milk.MaxShelfLife);
        }

        [TestMethod]
        public void PrintInfoPGTestMethod()
        {
            var milk = GetTestPerishableGoods();
            var lines = new[]
            {
                "K1K45F Milk",
                "Оптовая цена: 30. Розничная цена: 45. Описание: Коровье, пастеризованное. В наличии: 10 шт.",
                "Максимальный срок хранения: 5 дн."
            };

            milk.Description = "Коровье, пастеризованное";
            milk.Availability = 10;

            TextWriter oldOut = Console.Out;

            using (FileStream file = new FileStream("test.txt", FileMode.Create))
            {
                using (TextWriter writer = new StreamWriter(file))
                {
                    Console.SetOut(writer); milk.PrintInfo();
                }
            }

            Console.SetOut(oldOut);

            using (FileStream file = new FileStream("test.txt", FileMode.Open))
            {
                using (TextReader reader = new StreamReader(file))
                {
                    var i = 0; while (!(reader as StreamReader).EndOfStream)
                    Assert.AreEqual(lines[i++], reader.ReadLine());
                    Assert.AreEqual(lines.Length, i);
                }
            }

            File.Delete("test.txt");
        }
        private PerishableGoods GetTestPerishableGoods()
        {
            var goods = new PerishableGoods("K1K45F", "Milk", 30, 45, UnitOfGoods.Piece, 5);
            return goods;
        }
    }

    [TestClass]
    public class DimensionalGoodsUnitTest
    {
        [TestMethod]
        public void ConstructorDGTestMethod()
        {
            var table = GetTestDimensionalGoods();
            Assert.AreEqual(150, table.Length);
            Assert.AreEqual(70, table.Width);
            Assert.AreEqual(100, table.Heigth);
        }

        [TestMethod]
        public void PrintInfoDGTestMethod()
        {
            var table = GetTestDimensionalGoods();
            var lines = new[]
            {
                "T2M34K Table",
                "Оптовая цена: 5000. Розничная цена: 6500. Описание: Деревянный, раздвижной. В наличии: 2 шт.",
                "Длина: 150,00 см., ширина: 70,00 см., высота: 100,00 см."
            };

            table.Description = "Деревянный, раздвижной";
            table.Availability = 2;

            TextWriter oldOut = Console.Out;

            using (FileStream file = new FileStream("test.txt", FileMode.Create))
            {
                using (TextWriter writer = new StreamWriter(file))
                {
                    Console.SetOut(writer); table.PrintInfo();
                }
            }

            Console.SetOut(oldOut);

            using (FileStream file = new FileStream("test.txt", FileMode.Open))
            {
                using (TextReader reader = new StreamReader(file))
                {
                    var i = 0; while (!(reader as StreamReader).EndOfStream)
                    Assert.AreEqual(lines[i++], reader.ReadLine());
                    Assert.AreEqual(lines.Length, i);
                }
            }

            File.Delete("test.txt");
        }
        private DimensionalGoods GetTestDimensionalGoods()
        {
            var goods = new DimensionalGoods("T2M34K", "Table", 5000, 6500, UnitOfGoods.Piece, 150, 70, 100);
            return goods;
        }
    }
}
