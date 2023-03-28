using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using EaFramework.Driver;
using EaFramework.Config;

namespace EaApplicationTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()

        {
            var testSettings = new TestSettings()
            {
                BrowserType = BrowserType.Chrome,
                AplicationUrl = new Uri("http://www.localhost:8000"),
                TimeoutInterval = 30

            };    

                var driver = new DriverFIxture(testSettings);

            driver.Driver.FindElement(By.LinkText("Product")).Click();

            driver.Driver.FindElement(By.LinkText("Create")).Click();


            
        }
    }
}