using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using MarieCurieTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace MarieCurieTests.StepDefinitions
{
    [Binding]
    public class AllThen
    {

        public HomePage homepage;
        public IWebDriver driver;
        public BasePage basepage;
        public AllThen()
        {
            homepage = new HomePage();
            basepage = new BasePage();
            driver = WebBrowser.Current;

        }

        [Then(@"I should see Homepage")]
        public void ThenIShouldSeeHomepage()
        {
            Assert.AreEqual("Marie Curie Cancer Care", homepage.getHomePageTitle());
            //basepage.GetOnlineShop();
            //driver.Navigate().Back();
            //basepage.GetDonationPage();
        }



       

    }
}
