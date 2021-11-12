using TechTalk.SpecFlow;
using AltUnityWebdriver.Scenes;
using Altom.AltUnityDriver;

namespace AltUnityWebdriver.Steps
{
    [Binding]
    public class MainSceneSteps
    {
        // When I start running and pause
        [When(@"I start running and pause")]
        public void WhenIStartRunningAndPause()
        {
            MainScene.StartRunThenPause();
        }

        // Then I should see the Pause Menu
        [Then(@"I should see the Pause Menu")]
        public void ThenIShouldSeeThePauseMenu()
        {
            AltUnityObject panelElement = TestData.altUnityDriver.WaitForObject(By.NAME, "Exit");
            //assert panelElement.enabled
        }
    }
}
