using Altom.AltUnityDriver;
using OpenQA.Selenium;
using System.Diagnostics;

namespace AltUnityWebdriver
{
    public static class TestData
    {
        public static AltUnityDriver altUnityDriver = null;
        public static IWebDriver driver = null;
        public static Process server = null;
    }
}
