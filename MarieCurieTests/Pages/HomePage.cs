using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using MarieCurieTests.CommonPages;

namespace MarieCurieTests.Pages
{
    public class HomePage:BasePage
    {
        public HomePage(IWebDriver driver) : base(driver) { }

              
       
        
        public string getHomePageTitle()
        {
            //driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_LoginStatus_LoggedInStatus_LoginLink']/img")).Click();
            //NavigateToHomePage();
            return driver.Title;
        }


       

    }
}
