using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
namespace NUnitTestProject1
{
    public class UnitTest1
    {
        String u = "https://www.tutorialspoint.com/index.htm";
        IWebDriver d;
        [SetUp]
        public void Setup()
        {
            //creating object of FirefoxDriver
            d = new FirefoxDriver();
        }
        [Test]
        public void Test1()
        {
            //launching URL
            d.Navigate().GoToUrl(u);
            Console.WriteLine("Url launched");
        }
        [TearDown]
        public void close_Browser()
        {
            d.Quit();
        }
    }
}