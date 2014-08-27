using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

    }
}
