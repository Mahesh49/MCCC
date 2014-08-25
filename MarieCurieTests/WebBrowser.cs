using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MarieCurieTests
{

    [Binding]
    public static class WebBrowser
    {
        /// <summary>
        /// Gets the current.
        /// </summary>
        public static IWebDriver Current
        {
            get
            {
                if (!ScenarioContext.Current.ContainsKey("browser"))
                {
                    IWebDriver browser = LoadBrowser();

                    browser.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 10));

                    //((IJavaScriptExecutor)browser).ExecuteScript("window.resizeTo(1024, 768);");

                    ScenarioContext.Current["browser"] = browser;
                }

                return ScenarioContext.Current["browser"] as IWebDriver;
            }
        }

        /// <summary>
        /// Loads the browser.
        /// </summary>
        /// <returns></returns>
        private static IWebDriver LoadBrowser()
        {
            IWebDriver driver;

            var browserType = "firefox";

            // run local browser
            switch (browserType.ToLower())
            {
                case "firefox":
                    driver = new FirefoxDriver();
                    break;
                case "ie":
                    driver = new InternetExplorerDriver();
                    break;
                case "chrome":
                    driver = new ChromeDriver();
                    break;

                default:
                    driver = new ChromeDriver();
                    break;
            }

            return driver;
        }


        /// <summary>
        /// Closes the browser.
        /// </summary>
        /// 
        [AfterScenario]
        public static void CloseBrowser()
        {

            Current.Close();
            // ScenarioContext.Current.Remove("browser");
        }

    }
}

