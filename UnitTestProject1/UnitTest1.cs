using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Checkout client = new Checkout();
        product tea = new product("FR1", "FruitTea", 3.11);
        product strawberries = new product("SR1", "Strawberries", 5.00);
        product coffee = new product("CF1", "Coffee", 11.23);


        [TestMethod]
        public void test1()
        {
            Double Expected = 22.45;

            client.scan(tea);
            client.scan(strawberries);
            client.scan(tea);
            client.scan(tea);
            client.scan(coffee);

            Double Actual = client.Total();

            Assert.AreEqual(Actual, Expected);
        }

        [TestMethod]
        public void test2()
        {
            Double Expected = 3.11;

            client.scan(tea);
            client.scan(tea);

            Double Actual = client.Total();

            Assert.AreEqual(Actual, Expected);
        }

        [TestMethod]
        public void test3()
        {
            Double Expected = 16.61;

            client.scan(strawberries);
            client.scan(strawberries);
            client.scan(tea);
            client.scan(strawberries);

            Double Actual = client.Total();

            Assert.AreEqual(Expected, Actual);
        }
    }
}
