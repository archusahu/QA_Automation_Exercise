

using OpenQA.Selenium;

namespace PageObject.Pages
{
    public abstract class BasePage
    {
        public IWebDriver Driver { get; set; }

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }


    }
}
