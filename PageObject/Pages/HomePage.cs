

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PageObject.Pages
{
    public class HomePage : BasePage
    {

        public HomePage(IWebDriver driver) : base(driver)
        {
        }


        public void GetHomePageTitle()
        {
            String pageTitle = Driver.Title;
            Console.WriteLine("Home Page Title: " + pageTitle);
        }

        public LoginAndSignUpPage ClickOnLogin()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            IWebElement acceptButton = Driver.FindElement(By.XPath("//button[@class='fc-button fc-cta-consent fc-primary-button']/p"));
            acceptButton.Click();

            Driver.FindElement(By.PartialLinkText("Signup / Login")).Click();
            Thread.Sleep(1000);
            return new LoginAndSignUpPage(Driver);

        }
        public string UserMessage()
        {
            var pageTitle = Driver.FindElement(By.XPath("//ul[@class='nav navbar-nav']/li[contains(.,'Logged in as')]")).Text;
            return pageTitle;
        }



    }
}
