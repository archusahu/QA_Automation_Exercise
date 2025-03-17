using OpenQA.Selenium;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject.Pages
{
    public class CheckoutPage : BasePage
    {
        public CheckoutPage(IWebDriver driver) : base(driver)
        {
        }
        public PaymentPage ClickOnPlaceOrder()
        {
            Driver.FindElement(By.CssSelector("a.btn.btn-default.check_out")).Click();
            return new PaymentPage(Driver);
        }
    }
}
