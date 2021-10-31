using TechTalk.SpecFlow;
using SeleniumWebdriver.Pages;

namespace SeleniumWebdriver.Steps
{
    [Binding]
    public class LoginSteps
    {
        // Given I am on the login page
        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            LoginPage.Open();
        }

        // When I login with '<username>' and '<password>'
        [When(@"I login with '(.*)' and '(.*)'")]
        public void WhenILoginWithAnd(string username, string password)
        {
            LoginPage.Login(username, password);
        }
    }
}
