using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium
{
    public class SeleniumAutomation
    {
        private IWebDriver Driver;

        public SeleniumAutomation(IWebDriver driver)
        {
            Driver = driver;
        }

        public void Search(string keyword)
        {
            Driver.Navigate().GoToUrl("https://www.google.com");
            IWebElement searchBox = Driver.FindElement(By.Name("q"));
            searchBox.SendKeys(keyword);
            searchBox.SendKeys(Keys.Return);
        }

    }

}
