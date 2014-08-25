using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace MarieCurieTests.Pages
{
    public class HomePage
    {

        static IWebDriver driver;

       
        public void getHomePage()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.mariecurie.org.uk/");
        }

        public string getHomePageTitle()
        {
            return driver.Title;
        }


       [AfterScenario]
        public void close()
        {
            driver.Quit();
        }

    }
}
