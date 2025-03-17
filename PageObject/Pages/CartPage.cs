using OpenQA.Selenium;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject.Pages
{
    public class CartPage : BasePage
    {
        public CartPage(IWebDriver driver) : base(driver)
        {
        }

        public CheckoutPage ClickOnProceedToCheckout()
        {
            Driver.FindElement(By.CssSelector("a.btn.btn-default.check_out")).Click();
            return new CheckoutPage(Driver);
        }
    }
}
