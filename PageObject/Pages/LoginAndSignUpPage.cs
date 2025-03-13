

using OpenQA.Selenium;

namespace PageObject.Pages
{
    public class LoginAndSignUpPage : BasePage
    {
        public LoginAndSignUpPage(IWebDriver driver) : base(driver)
        {
        }

        public HomePage UserLogin(string userId, string pwd)
        {
            Driver.FindElement(By.CssSelector("input[data-qa='login-email']")).SendKeys(userId);
            Driver.FindElement(By.CssSelector("input[data-qa='login-password']")).SendKeys(pwd);
            Driver.FindElement(By.CssSelector("button[data-qa='login-button']")).Click();
            Thread.Sleep(1000);
            return new HomePage(Driver);
        }

        public string LoginErrorMessage()
        {
            var loginError = Driver.FindElement(By.XPath("//form[@action='/login']/p")).Text;
            return loginError;
        }


        public string GetValidationMessage(string fieldId)
        {           
              
                IWebElement inputField = Driver.FindElement(By.CssSelector($"input[data-qa='{fieldId}']"));
                // Get the browser-generated validation message
                string message = inputField.GetAttribute("validationMessage");
                // Return the validation message
                return message;          
        }
    }
}

   

