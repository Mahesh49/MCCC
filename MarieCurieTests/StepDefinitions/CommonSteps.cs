using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using MarieCurieTests.Pages;
using MarieCurieTests.CommonPages;
using System.Diagnostics;

namespace MarieCurieTests.StepDefinitions
{
    public class CommonSteps
    {
        public static IWebDriver driver;

        public static HomePage homepage;
        public static BasePage basepage;
        public static DonatePage donatepage;
        public static OnlineShop onlineshop;

        public CommonSteps()
        {
            if (driver == null)
            {
                driver = GetDriver.LoadBrowser();
                driver.Navigate().GoToUrl("http://www.mariecurie.org.uk/"); 
                basepage = new BasePage(driver);
                homepage = new HomePage(driver);
                donatepage = new DonatePage(driver);
                onlineshop = new OnlineShop(driver);
                Debug.WriteLine("1");
           }
        }


    }
}
