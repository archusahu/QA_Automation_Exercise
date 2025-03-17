using AutomationExerciseTests;

using PageObject.Pages;

using TechTalk.SpecFlow;

namespace AutomationExercise.Steps.When
{
    [Binding]
    public class WhenSteps
    {
        private Context _context;


        public WhenSteps(Context context)
        {
            _context = context;
        }

        [Given(@"user enters '([^']*)' and '([^']*)' in loginPage")]
        [When(@"user enters '([^']*)' and '([^']*)' in loginPage")]
        public void WhenUserEntersAndInLoginPage(string username, string password)
        {
            _context.HomePage = _context.LoginAndSignUpPage.UserLogin(username, password);

        }

        [When(@"user clicks on Logout from the menu")]
        public void WhenUserClicksOnLogoutFromTheMenu()
        {
            _context.LoginAndSignUpPage = _context.HomePage.ClickOnLogout();
        }

        [When(@"click Proceed to Checkout on cart page")]
        public void WhenClickProceedToCheckoutOnCartPage()
        {
            _context.CartPage.ClickOnProceedToCheckout();
        }

        [When(@"click on Place Order on checkout page")]
        public void WhenClickOnPlaceOrderOnCheckoutPage()
        {
            _context.CheckoutPage.ClickOnPlaceOrder();
        }

        [When(@"enter card details and click Pay and Confirm Order on payment page")]
        public void WhenEnterCardDetailsAndClickPayAndConfirmOrderOnPaymentPage()
        {
            _context.PaymentPage.ClickOnPayAndConfirmOrder();


        }

    }
}







