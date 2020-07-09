using System;
using OpenQA.Selenium;
using System.IO;
using System.Linq;
using Giftreteproject.Hook;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using System.Collections.Generic;
using System.Text;

namespace Giftreteproject.Common.Utilities
{
    class ScreenShots
    {
        FileLocation _fileLocation;

        public ScreenShots()
        {
            _fileLocation = new FileLocation();
        }
        public void TakeTestScreenShot()
        {
            string screenShotImagesFolder = _fileLocation.GetFolderLocation("ScreenShotImages");

            try
            {
                string fileNameBase =
                     $"{DateTime.Now:yyyyMMdd_HHmmss}_error_FEATURE_{FeatureContext.Current.FeatureInfo.Title}_SCENARIO_{ScenarioContext.Current.ScenarioInfo.Title}";

                foreach (char c in System.IO.Path.GetInvalidFileNameChars())
                {
                    fileNameBase = fileNameBase.Replace(c, '_');
                }

                fileNameBase = fileNameBase.Replace(" ", "_");
                fileNameBase = fileNameBase.Replace(" ", "_");
                fileNameBase = fileNameBase.Replace("-", "_");

                if (fileNameBase.Length > 100)
                    fileNameBase = fileNameBase.Substring(0, 100);

                string screenshotFilePath = Path.Combine(screenShotImagesFolder + fileNameBase + "_screenshot.png");
                Console.WriteLine("ERROR LOG:Filename: {0}", fileNameBase);


                if (BaseTest.driver is ITakesScreenshot takesScreenshot)
                {
                    var screenshot = takesScreenshot.GetScreenshot();
                    screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);
                    //Console.WriteLine("ERROR LOG: Screenshot: {0}", new Uri(screenshotFilePath));
                    Console.WriteLine("ERROR LOG:Click here to view Screenshot on server: {0}", new Uri(screenshotFilePath));

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while taking screenshot: {0}", ex);
            }


        }


    }
}
