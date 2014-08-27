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

        [Then(@"I should see tab contents with one active at any time")]
        public void ThenIShouldSeeTabContentsWithOneActiveAtAnyTime()
        {
            Assert.IsTrue(homepage.isTabOptionsDisplayed());
        }

        [Then(@"I shoud see error message being displayed")]
        public void ThenIShoudSeeErrorMessageBeingDisplayed()
        {
            string message = "Your username and password combination were not correct, please check both and try again";
            Assert.AreEqual(message, onlineshop.getInvaliErrorMessage());
        }

        [Then(@"I should see relevent pages ""(.*)""")]
        public void ThenIShouldSeeReleventPages(string p0)
        {
            if (p0 == "Make a donation")
            {
                Assert.AreEqual("Make a donation", donatepage.getDonationText());
            }
            else
                Assert.AreEqual("Make a one-off donation",donatepage.getDonationText());
        }




       

    }
}
