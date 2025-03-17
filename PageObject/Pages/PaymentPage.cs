

using OpenQA.Selenium;

namespace PageObject.Pages
{
    public class PaymentPage : BasePage
    {
        public PaymentPage(IWebDriver driver) : base(driver)
        {
        }

        public PaymentConfirmationPage ClickOnPayAndConfirmOrder()
        {
            Driver.FindElement(By.TagName("button")).Click();
            return new PaymentConfirmationPage(Driver);
        }
    }
}
