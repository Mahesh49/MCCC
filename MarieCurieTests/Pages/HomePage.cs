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
            return driver.Title;
        }

        public bool isTabOptionsDisplayed()
        {
            bool b=false;
            IList<IWebElement> tablist = driver.FindElements(By.ClassName("tabs"));

            foreach (IWebElement ele in tablist)
            {
                if (ele.Enabled)
                    b = true;
                else
                    b = false;
            }
            return b;


        }


       

    }
}
