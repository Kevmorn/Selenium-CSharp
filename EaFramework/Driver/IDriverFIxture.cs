using OpenQA.Selenium;

namespace EaFramework.Driver
{
    public interface IDriverFIxture
    {
        IWebDriver Driver { get; }
    }
}