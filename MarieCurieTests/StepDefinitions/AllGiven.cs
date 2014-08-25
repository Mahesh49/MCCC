using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using MarieCurieTests.Pages;
using OpenQA.Selenium;

namespace MarieCurieTests.StepDefinitions
{
    [Binding]
    public class AllGiven
    {

        public HomePage homepage;
        public IWebDriver driver;
        public BasePage basepage;


        public AllGiven()
        {
            homepage = new HomePage();
            basepage = new BasePage();
        }

        [Given(@"I enter homepage url")]
        public void GivenIEnterHomepageUrl()
        {
            
            basepage.getHomePage();
        }

        

    }
}
