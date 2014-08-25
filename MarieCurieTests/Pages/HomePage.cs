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
        public BasePage basepage;
        public IWebDriver driver;

        public HomePage()
        {
            driver = WebBrowser.Current;
            basepage = new BasePage();

        }

       
        
        public string getHomePageTitle()
        {
            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_LoginStatus_LoggedInStatus_LoginLink']/img")).Click();
            basepage.NavigateToHomePage();
            return driver.Title;
        }


       

    }
}
