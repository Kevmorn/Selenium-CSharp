using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using EaFramework.Driver;

namespace EaApplicationTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
                var driver = new DriverFIxture(BrowserType.Chrome);

            driver.Driver.FindElement(By.LinkText("Product")).Click();

            driver.Driver.FindElement(By.LinkText("Create")).Click();


            
        }
    }
}