
using OpenQA.Selenium;
using System;
using System.IO;

namespace SeleniumWebdriver
{
    public static class TestData
    {
        public static string baseUrl = Environment.GetEnvironmentVariable("TEST_BASE_URL") ?? ReadFromEnvFile("TEST_BASE_URL");
        public static string testUser = Environment.GetEnvironmentVariable("TEST_USER") ?? ReadFromEnvFile("TEST_USER");
        public static string testPass = Environment.GetEnvironmentVariable("TEST_PASS") ?? ReadFromEnvFile("TEST_PASS");

        public static IWebDriver driver = null;

        private static string ReadFromEnvFile(string key)
        {
            string value = null;
            string root = Directory.GetCurrentDirectory();
            string dotenv = Path.Combine(root, ".env");
            foreach (string line in File.ReadAllLines(dotenv))
            {
                string[] parts = line.Split('=', StringSplitOptions.RemoveEmptyEntries);
                if (parts[0] == key)
                {
                    value = parts[1];
                }
            }
            return value;
        }
    }
}
