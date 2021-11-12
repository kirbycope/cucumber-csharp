using System.Threading;
using Altom.AltUnityDriver;

namespace AltUnityWebdriver.Scenes
{
    class MainScene
    {
        // The "Run!" `button`.
        public static AltUnityObject btnRun()
        {
            return TestData.altUnityDriver.FindObject(By.NAME, "StartButton");
        }

        // The "||" (Pause) `button`.
        public static AltUnityObject btnPause()
        {
            return TestData.altUnityDriver.FindObject(By.NAME, "pauseButton");
        }

        /// <summary>
        /// Opens `this` scene.
        /// </summary>
        public static void Open()
        {
            TestData.altUnityDriver.LoadScene("Main");
        }

        /// <summary>
        /// Start a 10 second run, then pauses.
        /// </summary>
        public static void StartRunThenPause()
        {
            Thread.Sleep(2000);
            btnRun().Tap();
            Thread.Sleep(10000);
            btnPause().Tap();
        }
    }
}
