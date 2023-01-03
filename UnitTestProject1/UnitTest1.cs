using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LT_Submission.Controller;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1 : IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TestMethod1()
        {
            string text = "a";
            string actual = "Sorry, we only accept Integers or cash!\r\n";

            var currentConsoleOut = Console.Out;

            HttpClientRequestHandler cu = new HttpClientRequestHandler();

            using (var consoleOutput = new ConsoleOutput())
            {
                text = cu.getAlbums(text);

                Assert.AreEqual(actual, consoleOutput.GetOuput());
            }

            Assert.AreEqual(currentConsoleOut, Console.Out);
        }

        
    }
}
