using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var stringReader = new StringReader("Hello World");
            Console.SetIn(stringReader);

            var line1 = Console.ReadLine();
            Assert.AreEqual("Hello World", line1);

        }

    }
}
