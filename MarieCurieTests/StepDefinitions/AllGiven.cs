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

        public AllGiven()
        {
            homepage = new HomePage();
        }

        [Given(@"I enter homepage url")]
        public void GivenIEnterHomepageUrl()
        {
            homepage.getHomePage();
        }

        

    }
}
