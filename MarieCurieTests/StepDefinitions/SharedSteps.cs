using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing.Imaging;
using System.IO;

namespace MarieCurieTests.StepDefinitions
{
    [Binding]
    public class SharedSteps : CommonSteps
    {


        [AfterTestRun]
        public static void CloseBrowser()
        {
            //driver = null;
            driver.Quit();
            driver = null;
            
        }
        
        [BeforeScenario]
        public static void clearCookies()
        {
            if (driver != null)
            {
                driver.Manage().Cookies.DeleteAllCookies();
                driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(60));



                

            }
        }

        public static int i = 1;
        [AfterScenario]
        public static void TakeScreenShot()
        {
            
            //Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();

            //string startupPath = System.IO.Path.GetFullPath(".\\");
            //string startupPath1 = Environment.CurrentDirectory;
            //Debug.WriteLine(startupPath1);
            
            //string saveloc = @"C:\Users\Mahesh\Documents\Visual Studio 2010\Projects\MarieCurieTests\MarieCurieTests\Screeshots\";
            //Use it as you want now
            //string screenshot = ss.AsBase64EncodedString;
            //byte[] screenshotAsByteArray = ss.AsByteArray;
            //ss.SaveAsFile(saveloc+i+".Jpeg", ImageFormat.Jpeg); //use any of the built in image formating
            //i++;
            // ss.ToString();//same as string screenshot = ss.AsBase64EncodedString;

            TakeScreenshot(driver);
        }


        private static void TakeScreenshot(IWebDriver driver)
        {
            try
            {
                string fileNameBase = string.Format("error_{0}_{1}_{2}",
                                                    FeatureContext.Current.FeatureInfo.Title.ToString(),
                                                    ScenarioContext.Current.ScenarioInfo.Title.ToString(),
                                                    DateTime.Now.ToString("yyyyMMdd_HHmmss"));

                var artifactDirectory = Path.Combine(Directory.GetCurrentDirectory(), "testresults");
                if (!Directory.Exists(artifactDirectory))
                    Directory.CreateDirectory(artifactDirectory);

                string pageSource = driver.PageSource;
                string sourceFilePath = Path.Combine(artifactDirectory, fileNameBase + "_source.html");
                File.WriteAllText(sourceFilePath, pageSource, Encoding.UTF8);
                Console.WriteLine("Page source: {0}", new Uri(sourceFilePath));

                ITakesScreenshot takesScreenshot = driver as ITakesScreenshot;

                if (takesScreenshot != null)
                {
                    var screenshot = takesScreenshot.GetScreenshot();

                    string screenshotFilePath = Path.Combine(artifactDirectory, fileNameBase + "_screenshot.png");

                    screenshot.SaveAsFile(screenshotFilePath, ImageFormat.Png);

                    Console.WriteLine("Screenshot: {0}", new Uri(screenshotFilePath));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while taking screenshot: {0}", ex);
            }
        }

    }
}
