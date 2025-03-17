using OpenQA.Selenium;

namespace PageObject.Pages
{
    public class PaymentConfirmationPage : BasePage
    {
        public PaymentConfirmationPage(IWebDriver driver) : base(driver)
        {
        }
        public string DisplayMessage()
        {
            var textDisplay = Driver.FindElement(By.XPath("//div[@class='col-sm-9 col-sm-offset-1']/p")).Text;
            return textDisplay;
        }


    }
}
