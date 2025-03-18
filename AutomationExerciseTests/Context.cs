using ApiClient;

using OpenQA.Selenium;

using PageObject.Pages;

using RestSharp;

namespace AutomationExerciseTests
{
    public class Context
    {
        public Context()
        {
            Console.WriteLine("I am in context constructor");
        }
        public IWebDriver Driver { get; set; } // Stores WebDriver instance

        public HomePage HomePage { get; set; }

        public PaymentPage PaymentPage { get; set; }

        public CartPage CartPage { get; set; }

        public CheckoutPage CheckoutPage { get; set; }

        public LoginAndSignUpPage LoginAndSignUpPage { get; set; }

        public ProdutDetailsPage ProdutDetailsPage { get; set; }

        public PaymentConfirmationPage PaymentConfirmationPage { get; set; }
        public Client ApiClient { get; set; }
        public RestResponse ApiResponse { get; internal set; }
    }
}
