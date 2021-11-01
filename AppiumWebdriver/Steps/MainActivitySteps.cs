using TechTalk.SpecFlow;
using AppiumWebdriver.Activities;

namespace AppiumWebdriver.Steps
{
    [Binding]
    public class MainActivitySteps
    {
        // Given I am on the main activity
        [Given(@"I am on the main activity")]
        public void GivenIAmOnTheMainActivity()
        {
            MainActivity.Open();
        }

        // When I send a message saying '<message>'
        [When(@"I send a message saying '(.*)'")]
        public void WhenISendAMessageSaying(string message)
        {
            MainActivity.SendMessage(message);
        }
    }
}
