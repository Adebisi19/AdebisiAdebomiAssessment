using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Giftreteproject.Common.Utilities;

namespace Giftreteproject.Hook
{
    [Binding]
    public sealed class BaseTest
    {

        static ScreenShots _screenShots;
        private static string[] featureTags;



        public BaseTest()
        {
            _screenShots = new ScreenShots();

        }

        public static IWebDriver driver;



        [BeforeFeature]
        public static void BeforeFeature()
        {
            try
            {
                featureTags = FeatureContext.Current.FeatureInfo.Tags;

                BrowserProcesses.Kill("chrome");

            }
            catch
            {
                System.Console.WriteLine("No browser to close");
            }

            OpenBrowser("Chrome");


        }

        private static void OpenBrowser(string browser)
        {
            ChromeOptions options = new ChromeOptions();
            //options.AddArguments("--headless");
            // options.AddArgument("--start-maximized");


            options.AddArguments("--disable-extensions");

            options.AddExcludedArgument("--ignore-certifcate-errors");

            options.AddArgument("--test-type");

            options.AddArgument("--incognito");


            driver = new ChromeDriver(options);

            // driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(300);
            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(300);
        }
        //
        [BeforeScenario]
        public static void BeforeScenario()
        {

            var scenarioTag = ScenarioContext.Current.ScenarioInfo.Tags;
            if ((featureTags.Contains("Login") || scenarioTag.Contains("Login")) && driver.Url.Contains("http"))
            {
                driver.Quit();
                BrowserProcesses.Kill("chrome");

                OpenBrowser("Chrome");

            }

            else
            {

                if (driver == null)
                {
                    OpenBrowser("Chrome");

                }
            }

        }



        [AfterScenario]
        public static void AfterScenario()
        {
            try
            {
                if (ScenarioContext.Current.TestError != null)
                {
                    _screenShots.TakeTestScreenShot();
                }


            }
            catch (Exception)
            {

            }

        }


        [AfterFeature]
        public static void AfterFeature()
        {
            driver.Quit();
            BrowserProcesses.Kill("chrome");


        }

    }
}















