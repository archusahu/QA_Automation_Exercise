using AutomationExerciseTests;

using FluentAssertions;

using PageObject.Pages;

using TechTalk.SpecFlow;

namespace AutomationExercise.Steps.Given
{
    [Binding]
    public class GivenSteps
    {
        private Context _context;


        public GivenSteps(Context context)
        {
            _context = context;
        }

        [Given(@"user is on Signup/Login page")]
        public void GivenUserIsOnSignupLoginPage()
        {
            _context.Driver.Navigate().GoToUrl("https://www.automationexercise.com/");
            _context.HomePage = new HomePage(_context.Driver);
            _context.LoginAndSignUpPage = _context.HomePage.ClickOnLogin();
        }

        [Given(@"select Blue Top item to view product details on HomePage")]
        public void GivenSelectBlueTopItemToViewProductDetailsOnHomePage()
        {
            var itemName = _context.HomePage.ClickOnViewProduct();
        }


        [Given(@"click on Add to cart on product details page and selects view cart from the popup")]
        public void GivenClickOnAddToCartOnProductDetailsPageAndSelectsViewCartFromThePopup()
        {
            _context.ProdutDetailsPage.ClickOnAddToCart();
        }




    }
}
