

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PageObject.Pages
{
    public class ProdutDetailsPage : BasePage
    {
        public ProdutDetailsPage(IWebDriver driver) : base(driver)
        {
        }

        public CartPage ClickOnAddToCart()
        {
            Driver.FindElement(By.CssSelector("button[type='button']")).Click();

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            IWebElement viewCartButton = wait.Until(drv => drv.FindElement(By.XPath("//p[@class='text-center']//u")));
            viewCartButton.Click();
            return new CartPage(Driver);

        }
    }
}
