using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using MarieCurieTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using MarieCurieTests.CommonPages;

namespace MarieCurieTests.StepDefinitions
{
    [Binding]
    public class AllThen : CommonSteps
    {

       

        [Then(@"I should see Homepage")]
        public void ThenIShouldSeeHomepage()
        {
           
            Assert.AreEqual("Marie Curie Cancer Care", homepage.getHomePageTitle());
           
        }



       

    }
}
