using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1.Util
{
    public static class Util
    {
        [SetUp]
        public static IWebDriver Init()
        {
            ChromeOptions chrome = new ChromeOptions();
            chrome.AddArgument("start-maximized");
            chrome.AddArgument("enable-automation");
            chrome.PageLoadStrategy = PageLoadStrategy.Normal;
            return new ChromeDriver(chrome);
        }
        public static void final(IWebDriver driver)
        {
            driver.Quit();
        }
    }
}
