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

namespace MarieCurieTests
{
   // [Binding]
    public class GetDriver
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
    }
}
