using System.Threading;
using Altom.AltUnityDriver;

namespace AltUnityWebdriver.Scenes
{
    class MainScene
    {
        /// <summay> The "Run!" `button`.</summay>
        public static AltUnityObject BtnRun()
        {
            return TestData.altUnityDriver.FindObject(By.NAME, "StartButton");
        }

        /// <summay> The "||" (Pause) `button`.</summay>
        public static AltUnityObject BtnPause()
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

        public static void StartRunThenPause()
        {
            Thread.Sleep(5000);
            BtnRun().Tap();
            Thread.Sleep(10000);
            BtnPause().Tap();
        }
    }
}
