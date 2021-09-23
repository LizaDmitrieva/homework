using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BundlesLibrary;
using System.IO;


namespace BundleUnitTests
{
    [TestClass]
    public class BundlesUnitTests
    {
        [TestMethod]
        public void ConstructorTestMethod()
        {
            var thousands = CreateTestBundle(); 

            Assert.AreEqual(1000, thousands.Banknote); 
            Assert.AreEqual(10, thousands.Count); 
            Assert.AreEqual(10000, thousands.Sum); 
        }

        [TestMethod] 
        public void ToStringTestMethod() 
        {
            var thousands = CreateTestBundle(); 
            Assert.AreEqual("10 x 1000 р.", thousands.ToString()); 
        }

        [TestMethod]
        public void DisplayTestMethod()
        { 
            var   thousands = CreateTestBundle();
            var   hundreds = new Bundle(100, 50);

            var consoleOut = new[]
            {
                "Структура 'Bundles', 10 x 1000 р.",
                "Структура 'Bundles', 50 x 100 р."
            };

            TextWriter oldOut = Console.Out; 

            StringWriter output = new  StringWriter(); 
            Console.SetOut(output); 

            thousands.Display();
            hundreds.Display();
            
            Console.SetOut(oldOut); 

            var   outputArray = output.ToString().Split(new  [] { "\r\n" },    
                StringSplitOptions.RemoveEmptyEntries);   
            
            Assert.AreEqual(2, outputArray.Length); 
            for   (var   i = 0; i < consoleOut.Length; i++)
                Assert.AreEqual(consoleOut[i], outputArray[i]); 
        }

        [TestMethod]
        public void EqualsTestMethod()
        {
            Bundle t1 = new Bundle(1000, 10);

            Bundle t2 = new Bundle(1000, 10);

            Assert.AreEqual(true, t1.Equals(t2));
        }

        [TestMethod]
        public void PlusTestMethod()
        {
            Bundle t1 = new Bundle(1000, 10);

            Bundle t2 = new Bundle(1000, 20);

            var t3 = t1 + t2;

            Assert.AreEqual("30 x 1000 р.", t3.ToString());
        }

        [TestMethod]
        public void MinusTestMethod()
        {
            Bundle t1 = new Bundle(1000, 20);

            Bundle t2 = new Bundle(1000, 10);

            var t3 = t1 - t2;

            Assert.AreEqual("10 x 1000 р.", t3.ToString());
        }

        private Bundle CreateTestBundle() 
        { 
            return new Bundle(1000, 10); 
        }
    }
}
