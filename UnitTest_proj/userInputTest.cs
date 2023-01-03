using LT_consoleApp.Controller;
using LT_consoleApp.Model;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing.Printing;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace UnitTest_proj
{
    public class userInputTest : IDisposable
    {
        private StringWriter stringWriter;
        private TextWriter originalOutput;
        private string url = Constants.BaseUrl;

         
        public userInputTest()
        {
            
            stringWriter = new StringWriter();
            originalOutput = Console.Out;
            Console.SetOut(stringWriter);
        }

        [Fact]
        public void Test1()
        {
            //if user input is any string of letters instead of a string of numbers
            string input = "invalidInput";
            string actual = "The album id input range is 1-100";

            var consoleResponse = Console.Out;

            HttpClientRequestHandler albums = new HttpClientRequestHandler();

            using (var UnitTest_proj = new userInputTest())
            {
                input = albums.GetAlbumsById(url, input);
                Assert.AreEqual(actual, UnitTest_proj.GetOuput());
            }

            Assert.AreEqual(consoleResponse, Console.Out);

        }

        [Fact]
        public void Test2()
        {
            //negative test:  if user input is not within the range of album ids
            string input = "200";
            string actual = "The album id input range is 1-100";

            var consoleResponse = Console.Out;

            HttpClientRequestHandler albums = new HttpClientRequestHandler();

            using (var UnitTest_proj = new userInputTest())
            {
                input = albums.GetAlbumsById(url,input);

                Assert.AreEqual(actual, UnitTest_proj.GetOuput());
            }

            Assert.AreEqual(consoleResponse, Console.Out);
        }
        [Fact]
        public void Test3()
        {
            //negative test:  if user input is empty string
            string input = "";
            string actual = "The album id input range is 1-100";

            var consoleResponse = Console.Out;

            HttpClientRequestHandler albums = new HttpClientRequestHandler();

            using (var UnitTest_proj = new userInputTest())
            {
                input = albums.GetAlbumsById(url, input);

                Assert.AreEqual(actual, UnitTest_proj.GetOuput());
            }

            Assert.AreEqual(consoleResponse, Console.Out);
        }
        [Fact]
        public void Test4()
        {
            //positive test
            string input = "5";
            string actual = "The album id input range is 1-100";

            var consoleResponse = Console.Out;

            HttpClientRequestHandler albums = new HttpClientRequestHandler();

            using (var UnitTest_proj = new userInputTest())
            {
                input = albums.GetAlbumsById(url, input);

                Assert.AreEqual(actual, UnitTest_proj.GetOuput());
            }

            Assert.AreEqual(consoleResponse, Console.Out);
        }
        [Fact]
        public void Test6()
        {
            //negative test: if user input is null
            string input = null;
            string actual = "The album id input range is 1-100";

            var consoleResponse = Console.Out;

            HttpClientRequestHandler album = new HttpClientRequestHandler();

            using (var UnitTest_proj = new userInputTest())
            {
                input = album.GetAlbumsById(url, input);

                Assert.AreEqual(actual, UnitTest_proj.GetOuput());
            }

            Assert.AreEqual(consoleResponse, Console.Out);
        }


        public string GetOuput()
        {
            return stringWriter.ToString();
        }
        public void Dispose()
        {
            Console.SetOut(originalOutput);
            stringWriter.Dispose();
        }
    }
   
}