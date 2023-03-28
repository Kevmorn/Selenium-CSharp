using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EaFramework.Driver
{
    public class DriverFIxture
    {
        public IWebDriver Driver { get; }
        
        public DriverFIxture(BrowserType browserType)
        {
            Driver = GetWebDriver(browserType);
            Driver.Navigate().GoToUrl("http://localhost:8000");
        }

        private IWebDriver GetWebDriver(BrowserType browserType)
        {
            return BrowserType switch
            {
                BrowserType.Chrome => new ChromeDriver(),
              //  BrowserType.FireFox => new FirefoxDriver(),
               // BrowserType.FireFox => new SafariDriver(),
                _ => new ChromeDriver(),
            };


        }
    }

   public enum BrowserType
    {
        Chrome,
        Firefox,
        Safari,
        EdgeChromium
    }
}
