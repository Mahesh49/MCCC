using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Internal;

namespace MarieCurieTests
{
   // [Binding]
    public static class GetDriver
    {
        public static IWebDriver driver;

        //[BeforeScenario]
        public static IWebDriver LoadBrowser()
        {
            //var browserType = "firefox";
            var browserType = ConfigurationManager.AppSettings["Browser"];
            
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
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            return driver;
        }

        //is Image visible
        public static bool IsImageVisible(this IWebElement image)
        {
            var driver = ((IWrapsDriver)image).WrappedDriver;
            var script = ConfigurationManager.AppSettings["Browser"] == "firefox"
                       ? "return arguments[0].complete"
                       : "return (typeof arguments[0].naturalWidth!=\"undefined\"" +
                       " && arguments[0].naturalWidth>0)";
            return (bool)((IJavaScriptExecutor)driver).ExecuteScript(script, image);
        }

    }
}
