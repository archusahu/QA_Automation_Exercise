

using OpenQA.Selenium;

namespace PageObject.Pages
{
    public abstract class BasePage
    {
        public string Title => Driver.Title;
        public IWebDriver Driver { get; set; }

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }


    }
}
