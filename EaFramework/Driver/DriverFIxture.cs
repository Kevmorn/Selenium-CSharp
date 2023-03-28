using EaFramework.Config;
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
        private readonly TestSettings testSettings;

        public IWebDriver Driver { get; }
        
        public DriverFIxture(TestSettings testSettings)
        {
            
            Driver = GetWebDriver();
            Driver.Navigate().GoToUrl(testSettings.AplicationUrl);
            this.testSettings = testSettings;
        }

        private IWebDriver GetWebDriver()
        {
            return testSettings.BrowserType switch
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
