using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using EaFramework.Driver;
using EaFramework.Config;

namespace EaApplicationTest
{
    public class UnitTest1 : IClassFixture
    {

        private IDriverFIxture _driverFIxture;

        public UnitTest1()
        {
            var testSettings = new TestSettings()
            {
                BrowserType = BrowserType.Chrome,
                AplicationUrl = new Uri("http://www.localhost:8000"),
                TimeoutInterval = 30

            };

            _driverFIxture = new DriverFIxture(testSettings);
        }
        
        
        
        public void Dispose()
        {
            _driverFIxture.Driver.Quit();
        }

        [Fact]
        public void Test1()

        {
            
            _driverFIxture.Driver.FindElement(By.LinkText("Product")).Click();

            _driverFIxture.Driver.FindElement(By.LinkText("Create")).Click();


            
        }
    }
}