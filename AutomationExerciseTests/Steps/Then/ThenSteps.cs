using AutomationExerciseTests;

using FluentAssertions;

using NUnit.Framework;


using TechTalk.SpecFlow;

namespace AutomationExercise.Steps.Then
{
    [Binding]
    public class ThenSteps
    {
        private Context _context;

        public ThenSteps(Context context)
        {
            _context = context;
        }

        [Then(@"dashboard page is display with '([^']*)'")]
        public void ThenDashboardPageIsDisplayWith(string expectedMessage)
        {
            var actualMessage = _context.HomePage.UserMessage();
            Console.WriteLine($"Expected: '{expectedMessage}', Actual: '{actualMessage}'");

            actualMessage.Should().Contain(expectedMessage);
        }

        [Then(@"login page shows error message '([^']*)' is visible")]
        public void ThenLoginPageShowsErrorMessageIsVisible(string expectedErrorMessage)
        {
            var actualErrorLogin = _context.LoginAndSignUpPage.LoginErrorMessage();
            Console.WriteLine($"Expected: '{expectedErrorMessage}', Actual: '{actualErrorLogin}'");
            actualErrorLogin.Should().Contain(expectedErrorMessage);
        }

        [Then(@"login page shows error message '([^']*)'")]
        public void ThenLoginPageShowsErrorMessage(string expectedValidation)
        {
            string actualValidationMessage = _context.LoginAndSignUpPage.GetValidationMessage("login-email");
            Console.WriteLine($"Actual Email Validation Message: {actualValidationMessage}");
            actualValidationMessage.Should().Contain(expectedValidation);
        }

        [Then(@"user should be redirected to the '([^']*)' page\.")]
        public void ThenUserShouldBeRedirectedToThePage_(string expectedTitle)
        {
            var actualTitle = _context.LoginAndSignUpPage.Title;
            Console.WriteLine($"Expected: '{expectedTitle}', Actual: '{actualTitle}'");
            actualTitle.Should().Contain(expectedTitle);
        }

        [Then(@"'([^']*)' message is displayed in payment confirmation page")]
        public void ThenMessageIsDisplayedInPaymentConfirmationPage(string expextedMessage)
        {
            var actualMessage = _context.PaymentConfirmationPage.DisplayMessage();
            actualMessage.Should().Be(expextedMessage);
        }

    }
}

